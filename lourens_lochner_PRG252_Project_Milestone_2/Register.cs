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

namespace lourens_lochner_PRG252_Project_Milestone_2
{
    public partial class Register : Form
    {
        Filehandler fh = new Filehandler();

        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = fh.readStu();

            if (passwordR.Text == passwordCon.Text)
            {
                using (StreamWriter sw = File.AppendText(data))
                {
                    sw.WriteLine(usernameR.Text + passwordR.Text);
                    sw.Close();
                }
                MessageBox.Show("Your Username and Password has been saved!");

                Login l = new Login();
                l.Show();
                this.Hide();
            }
            else if (passwordR.Text != passwordCon.Text)
            {
                MessageBox.Show("Your Passwords to do match");
                passwordR.Clear();
                passwordCon.Clear();
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
