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
    public partial class LecturerPortal : Form
    {
        public LecturerPortal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LecturerView lv = new LecturerView();
            lv.Show();
            this.Hide();
        }
    }
}
