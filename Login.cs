using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_Team10bCAProject
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SA47_Team10BCADatabaseEntities context = new SA47_Team10BCADatabaseEntities();

            if (memberIDTextBox.Text == context.LoginDetails.Select(x => x.Username).First().ToString() && passwordTextBox.Text == context.LoginDetails.Select(x => x.Password).First().ToString())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                wrongLoginLabel.Text = "Wrong Member ID / Password";
            }
        }
    }
}
