using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lourens_lochner_PRG252_Project_Milestone_2
{
    public partial class Edit_View : Form
    {

        BindingSource source = new BindingSource();
        Datahandler dh = new Datahandler();

        public Edit_View()
        {
            InitializeComponent();
        }

        private void toPort_Click(object sender, EventArgs e)
        {
            StudentPortal s = new StudentPortal();
            s.Show();
            this.Hide();
        }


        #region Student Side
        private void button5_Click(object sender, EventArgs e)
        {
            numberM.Clear();
            codeM.Clear();
            nameM.Clear();
            descM.Clear();
            linksM.Clear();
            moduleView.DataSource = null;

            int search = int.Parse(searchS.Text);

            studentView.DataSource = null;
            source.DataSource = dh.Search(search);
            studentView.DataSource = source;


            SqlConnection con = new SqlConnection(@"Server = (Local) ; Initial Catalog = ProjectDB; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand($@"SELECT * FROM Student where StudentNumber = {search}", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                nameS.Text = dr.GetValue(1).ToString();
                dobS.Text = dr.GetValue(2).ToString();
                genderS.Text = dr.GetValue(3).ToString();
                numberS.Text = dr.GetValue(4).ToString();
                addressS.Text = dr.GetValue(5).ToString();
                codesS.Text = dr.GetValue(6).ToString();
            }

            con.Close();


        }

        private void updateS_Click(object sender, EventArgs e)
        {
            int search = int.Parse(searchS.Text);
            string name = nameS.Text;
            DateTime dob = DateTime.Parse(dobS.Text);
            string gender = genderS.Text;
            string number = numberS.Text;
            string address = addressS.Text;
            string code = codesS.Text;

            dh.updateStudent(search, name, dob, gender, number, address, code);

            studentView.DataSource = null;
            source.DataSource = dh.Search(search);
            studentView.DataSource = source;
        }


        #endregion

        private void searchM_Click(object sender, EventArgs e)
        {

            searchS.Clear();
            nameS.Clear();
            genderS.Clear();
            numberS.Clear();
            addressS.Clear();
            codesS.Clear();
            studentView.DataSource = null;

            int nmbr = int.Parse(numberM.Text);

            moduleView.DataSource = null;
            source.DataSource = dh.SearchModule(nmbr);
            moduleView.DataSource = source;


 
        }

        private void moduleView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            moduleView.CurrentRow.Selected = true;

            codeM.Text = moduleView.Rows[e.RowIndex].Cells["ModuleCodes"].Value.ToString();
            nameM.Text = moduleView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            descM.Text = moduleView.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            linksM.Text = moduleView.Rows[e.RowIndex].Cells["Links"].Value.ToString();
            
        }

        private void updateM_Click(object sender, EventArgs e)
        {

            int nmbr = int.Parse(numberM.Text);
            string name = nameM.Text;
            string code = codeM.Text;
            string desc = descM.Text;
            string link = linksM.Text;

            dh.updateModule(nmbr, code, name, desc, link);

            moduleView.DataSource = null;
            source.DataSource = dh.SearchModule(nmbr);
            moduleView.DataSource = source;
        }

        private void deleteM_Click(object sender, EventArgs e)
        {
            int nmbr = int.Parse(numberM.Text);
            string code = codeM.Text;

            dh.DeleteModule(code, nmbr);

            numberM.Clear();
            codeM.Clear();
            nameM.Clear();
            descM.Clear();
            linksM.Clear();

            moduleView.DataSource = null;
            source.DataSource = dh.SearchModule(nmbr);
            moduleView.DataSource = source;
        }

        private void Edit_View_Load(object sender, EventArgs e)
        {

        }

        private void toLog_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
