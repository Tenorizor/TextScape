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
    public partial class CreateAccount : Form
    {
        private String username;
        private String password;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            if (txt_pass.Text != txt_confirm.Text)
                MessageBox.Show("Passwords do not match.");
            else if (txt_confirm.Text.Length < 3 || txt_pass.Text.Length < 3 || txt_user.Text.Length < 3)
                MessageBox.Show("Fields must be longer than 2 characters.");
            else if (txt_confirm.Text == txt_pass.Text)
            {
                username = txt_user.Text;
                password = txt_pass.Text;
                WriteToFile(username, password);
            }
        }

        public void WriteToFile(String user, String pass)
        {
            String combined = user + " " + pass;
            var utf = new UTF8Encoding(); //used for accounts
            byte[] line = new byte[combined.Length];
            utf.GetBytes(combined, 0, combined.Length, line, 0);
            using (var fs = new BinaryWriter(File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\user.dat",FileMode.Append)))
            {
                fs.Write(line, 0, line.Length);
            }

                this.Close();
        } 
    }
}
