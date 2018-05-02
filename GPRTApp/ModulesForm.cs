using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPRTCommon;

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

            level5GridView.DataSource = moduleList["level5.xml"];
            level5GridView.DataMember = "module";

            level6GridView.DataSource = moduleList["level6.xml"];
            level6GridView.DataMember = "module";
        }

        private void level4Btn_Click(object sender, EventArgs e)
        {
            var addModuleForm = new AddModuleForm("Level4", this);
            addModuleForm.Show();
            this.Hide();
        }

        private void level5Btn_Click(object sender, EventArgs e)
        {
            var addModuleForm = new AddModuleForm("Level5", this);
            addModuleForm.Show();
            this.Hide();
        }

        private void level6Btn_Click(object sender, EventArgs e)
        {
            var addModuleForm = new AddModuleForm("Level6", this);
            addModuleForm.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var levels = GetAllLevels();
            var webHandler = new WebHandler();
            webHandler.SaveLevels(levels);
        }

        private List<Level> GetAllLevels()
        {
            var level4Modules = GetModules(level4GridView, "Level4");
            var level5Modules = GetModules(level5GridView, "Level5");
            var level6Modules = GetModules(level6GridView, "Level6");

            var level4 = new Level("Level4");
            level4.Modules = level4Modules;

            var level5 = new Level("Level5");
            level5.Modules = level5Modules;

            var level6 = new Level("Level6");
            level6.Modules = level6Modules;

            var levels = new List<Level>();
            levels.Add(level4);
            levels.Add(level5);
            levels.Add(level6);

            return levels;
        }

        private List<Module> GetModules(DataGridView dataGridView, string levelName)
        {
            var modules = new List<Module>();
            var table = ((DataSet)dataGridView.DataSource).Tables[0];
            foreach (var row in table.Rows)
            {
                if (row is DataRow)
                {
                    var rowData = (DataRow)row;
                    var module = new Module();
                    module.Title = (string)rowData.ItemArray[0];
                    module.Code = (string)rowData.ItemArray[1];
                    module.CreditValue = (string)rowData.ItemArray[2];
                    module.Assesments = xmlHandler.ReadAssesments(levelName + "_" + module.Title 
                        + "_assesments.xml");
                    modules.Add(module);
                }
            }
            return modules;
        }

        private void level4GridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string levelName = "Level4";
            string moduleName = level4GridView.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            if (moduleName == null || moduleName.Equals(""))
            {
                return;
            }
            ViewAssesments(levelName, moduleName);
        }

        private void level5GridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string levelName = "Level5";
            string moduleName = level5GridView.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            if (moduleName == null || moduleName.Equals(""))
            {
                return;
            }
            ViewAssesments(levelName, moduleName);
        }

        private void level6GridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string levelName = "Level6";
            string moduleName = level6GridView.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            if (moduleName == null || moduleName.Equals(""))
            {
                return;
            }
            ViewAssesments(levelName, moduleName);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {

        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            var levels = GetAllLevels();
            var summeryForm = new SummeryViewForm(levels);
            summeryForm.ShowDialog();
        }

        private void ViewAssesments(string levelName, string moduleName)
        {
            var xmlHandler = new XMLHandler();
            var assesments = xmlHandler.ReadAssesments(levelName + "_" + moduleName + "_assesments.xml");

            var assesmentsForm = new AssesmentForm(assesments, levelName, moduleName);
            assesmentsForm.ShowDialog();
        }

        private void level4GridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var levelName = "Level4";
        }

        private void level5GridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var levelName = "Level5";
        }

        private void level6GridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var levelName = "Level6";
        }

        private void DeleteModule(string levelName, Module module)
        {

        }
    }
}
