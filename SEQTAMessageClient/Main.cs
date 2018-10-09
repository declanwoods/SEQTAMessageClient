using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEQTAMessageClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private bool isWindowOpen(Type type)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.GetType() == type)
                {
                    form.BringToFront();
                    return true;
                }
            }
            return false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (isWindowOpen(typeof(Login))) return;
            Login loginform = new Login();
            loginform.Show();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            if (isWindowOpen(typeof(About))) return;
            About about = new About();
            about.Show();
        }

        private void btnselectrec_Click(object sender, EventArgs e)
        {
            if (isWindowOpen(typeof(Recipients))) return;
            Recipients recipientsWindow = new Recipients();
            recipientsWindow.Show();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

        }

        private void btnloaddata_Click(object sender, EventArgs e)
        {
            if (isWindowOpen(typeof(LoadData))) return;
            LoadData loaddataWindow = new LoadData();
            loaddataWindow.Show();
        }
    }
}
