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
    }
}
