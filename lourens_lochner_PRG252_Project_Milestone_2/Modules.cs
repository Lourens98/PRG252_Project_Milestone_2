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
    public partial class Modules : Form
    {

        Datahandler dh = new Datahandler();

        public Modules()
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
            int id = int.Parse(numberM.Text);
            string code = codeM.Text;
            string name = nameM.Text;
            string desc = descM.Text;
            string link = linkM.Text;

            dh.addModule(id, code, name, desc, link);

            codeM.Clear();
            nameM.Clear();
            descM.Clear();
            linkM.Clear();

        }
    }
}
