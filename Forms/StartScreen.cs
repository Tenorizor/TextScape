using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextScape
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Account a = new Account(txt_user.Text, txt_pass.Text);
            if (a.findAccount())
                MessageBox.Show("Success!");
            else
                MessageBox.Show("Incorrect Username or password");
        }

        //Opens create an account window
        private void btn_create_Click(object sender, EventArgs e)
        {
            CreateAccount create = new CreateAccount();
            create.ShowDialog();
        }
    }
}
