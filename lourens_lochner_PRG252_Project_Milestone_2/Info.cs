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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPortal s = new StudentPortal();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modules m = new Modules();
            m.Show();
            this.Hide();
        }
    }
}
