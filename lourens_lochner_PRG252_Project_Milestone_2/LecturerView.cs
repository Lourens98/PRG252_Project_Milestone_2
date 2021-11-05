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
    public partial class LecturerView : Form
    {
        BindingSource source = new BindingSource();
        Datahandler dh = new Datahandler();

        public LecturerView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LecturerPortal lp = new LecturerPortal();
            lp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void LecturerView_Load(object sender, EventArgs e)
        {
            allStudents.DataSource = null;
            source.DataSource = dh.ViewAll();
            allStudents.DataSource = source;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int nmbr = int.Parse(deleteS.Text);

            dh.DeleteStudent(nmbr);
            dh.DeleteAllModules(nmbr);

            allStudents.DataSource = null;
            source.DataSource = dh.ViewAll();
            allStudents.DataSource = source;
        }

        private void allStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            allStudents.CurrentRow.Selected = true;

            deleteS.Text = allStudents.Rows[e.RowIndex].Cells["StudentNumber"].Value.ToString();

        }
    }
}
