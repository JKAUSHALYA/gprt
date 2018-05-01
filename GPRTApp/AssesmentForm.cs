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

namespace GPRTApp
{
    public partial class AssesmentForm : Form
    {
        private string levelName;
        private string moduleName;

        public AssesmentForm(string levelName, string moduleName, int assesmentCount)
        {
            this.levelName = levelName;
            this.moduleName = moduleName;

            InitializeComponent();

            var bindingSource = new BindingSource();
            for (int i = 0; i < assesmentCount; i++)
            {
                bindingSource.Add(new Assesment());                
            }

            dataGridView1.DataSource = bindingSource;            
        }

        public AssesmentForm(List<Assesment> assesments, string levelName, string moduleName)
        {
            this.levelName = levelName;
            this.moduleName = moduleName;

            InitializeComponent();
            var bindingSource = new BindingSource();
            foreach (var assesment in assesments)
            {
                bindingSource.Add(assesment);
            }

            dataGridView1.DataSource = bindingSource;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var dataSource = (BindingSource) dataGridView1.DataSource;
            var list = dataSource.List.Cast<Assesment>().ToList();

            Thread t = new Thread(new ThreadStart(() => 
            {
                var xmlHandler = new XMLHandler();
                xmlHandler.SaveAssesments(levelName + "_" + moduleName + "_assesments.xml", list);
            }));
            t.Start();
            Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
