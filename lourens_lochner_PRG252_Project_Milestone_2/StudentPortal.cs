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
    public partial class StudentPortal : Form
    {
        public StudentPortal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.Show();
            this.Hide();
        }

        private void regB_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
            this.Hide();
        }

        private void modB_Click(object sender, EventArgs e)
        {
            Modules m = new Modules();
            m.Show();
            this.Hide();
        }

        private void viewB_Click(object sender, EventArgs e)
        {
            Edit_View ev = new Edit_View();
            ev.Show();
            this.Hide();
        }

        private void logB_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
