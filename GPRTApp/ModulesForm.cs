using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRTApp
{
    public partial class ModulesForm : Form
    {
        private WelcomeForm welcomeForm;
        private XMLHandler xmlHandler = new XMLHandler();

        public ModulesForm(WelcomeForm welcomeForm)
        {
            this.welcomeForm = welcomeForm;
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Close();
        }

        private void ModulesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var modules = new Dictionary<string, DataSet>();

            modules["level4.xml"] = (DataSet) level4GridView.DataSource;
            modules["level5.xml"] = (DataSet) level5GridView.DataSource;
            modules["level6.xml"] = (DataSet) level6GridView.DataSource;

            xmlHandler.SaveToFile(modules);
        }

        private void ModulesForm_Load(object sender, EventArgs e)
        {
            var moduleList = xmlHandler.ReadFromFile();

            level4GridView.DataSource = moduleList["level4.xml"];
            level4GridView.DataMember = "module";
            level4GridView.ReadOnly = true;

            level5GridView.DataSource = moduleList["level5.xml"];
            level5GridView.DataMember = "module";
            level5GridView.ReadOnly = true;

            level6GridView.DataSource = moduleList["level6.xml"];
            level6GridView.DataMember = "module";
            level6GridView.ReadOnly = true;
        }

        private void level4Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
