using GPRTCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRTAdminApp
{
    public partial class AdminView : Form
    {
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public AdminView()
        {
            InitializeComponent();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            LoadData();
            var token = cancellationTokenSource.Token;
            Run(() => LoadData(), TimeSpan.FromSeconds(1), token);
        }

        private void LoadDataGridView(DataGridView dataGridView, Level level)
        {
            if (level == null)
            {
                return;
            }
            var dataSource = new BindingSource();
            foreach (var module in level.Modules)
            {
                dataSource.Add(module);
            }
            dataGridView.DataSource = dataSource;
        }

        private async void LoadData()
        {
            var webHandler = new WebHandler();
            var levels = await webHandler.GetLevels();

            if (levels == null)
            {
                return;
            }

            var level4 = levels.SingleOrDefault(lvl => lvl.LevelName == "Level4");
            var level5 = levels.SingleOrDefault(lvl => lvl.LevelName == "Level5");
            var level6 = levels.SingleOrDefault(lvl => lvl.LevelName == "Level6");

            LoadDataGridView(dataGridView4, level4);
            LoadDataGridView(dataGridView5, level5);
            LoadDataGridView(dataGridView6, level6);
        }

        private static async void Run(Action action, TimeSpan period, CancellationToken cancellationToken)
        {
            while (true)
            {
                try
                {
                    await Task.Delay(period, cancellationToken);
                } catch (TaskCanceledException)
                {
                    break;
                }
                action();
            }
        }

        private static void Run(Action action, TimeSpan period)
        {
            Run(action, period, CancellationToken.None);
        }

        private void AdminView_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
