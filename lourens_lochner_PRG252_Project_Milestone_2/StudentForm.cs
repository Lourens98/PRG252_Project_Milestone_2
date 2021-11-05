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
    public partial class StudentForm : Form
    {

        Datahandler dh = new Datahandler();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPortal s = new StudentPortal();
            s.Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(numberS.Text);
            string name = nameS.Text;
            DateTime dob = DateTime.Parse(dobS.Text);
            string gender = genderS.Text;
            string phone = phoneS.Text;
            string address = addressS.Text;
            string codes = codesS.Text;

            dh.addStudent(studentNumber, name, dob, gender, phone, address, codes);

            numberS.Clear();
            nameS.Clear();
            genderS.Clear();
            phoneS.Clear();
            addressS.Clear();
            codesS.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modules m = new Modules();
            m.Show();
            this.Hide();
        }
    }
}
