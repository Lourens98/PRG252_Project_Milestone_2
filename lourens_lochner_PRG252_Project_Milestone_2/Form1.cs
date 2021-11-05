using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lourens_lochner_PRG252_Project_Milestone_2
{
    public partial class Login : Form
    {
        Filehandler fh = new Filehandler();

        public Login()
        {
            InitializeComponent();
        }

        #region lbl
        private void label3_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string optionChosen = choiceT.Text;
            string username = usernameT.Text;
            string password = passwordT.Text;

            string check = username + password;

            List<string> l = new List<string>();
            l = fh.toFormat();

            if (optionChosen == "Student")
            {
                foreach (string item in l)
                {
                    if (check == item)
                    {
                        MessageBox.Show("You have logged in!");
                        StudentPortal sp = new StudentPortal();
                        sp.Show();
                        this.Hide();
                    }
                    else
                    {
                        usernameT.Clear();
                        passwordT.Clear();
                    }
                }

            }
            else if (optionChosen == "Lecturer")
            {
                if (username == "Lecturer" && password == "1234")
                {
                    MessageBox.Show("Login Successfull");
                    LecturerPortal lp = new LecturerPortal();
                    lp.Show();
                    this.Hide();
                }
                else if (username != "Lecturer" || password != "1234")
                {
                    MessageBox.Show("Either the username or the password was incorrect. Check the bottom of the screen for the correct username and password");
                    usernameT.Clear();
                    passwordT.Clear();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register r = new Register();

            r.Show();
            this.Hide();
        }
    }
}
