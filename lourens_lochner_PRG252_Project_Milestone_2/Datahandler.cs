using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace lourens_lochner_PRG252_Project_Milestone_2
{
    class Datahandler
    {

        public SqlConnection con = new SqlConnection(@"Server = (Local) ; Initial Catalog = ProjectDB; Integrated Security=SSPI");


        #region Student

        public void addStudent(int id, string name, DateTime dob, string gender, string phone, string address, string codes )
        {

            try
            {
                con.Open();
                System.Windows.Forms.MessageBox.Show("Connection Opened");
                SqlCommand myCmd = new SqlCommand(@"INSERT INTO Student(StudentNumber, NameAndSurname, DOB, Gender, Phone, Address, ModuleCodes)" + $"Values({id}, '{name}', '{dob}', '{gender}', '{phone}', '{address}', '{codes}')", con);
                myCmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("New Student Registered");

            }
            catch (Exception x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);
            }
            finally
            {
                con.Close();
            }


        }

        public void updateStudent(int id, string name, DateTime dob, string gender, string phone, string address, string codes)
        {
            try
            {
                con.Open();
                System.Windows.Forms.MessageBox.Show("Connection Opened");
                SqlCommand cmd = new SqlCommand($@"UPDATE Student SET  NameAndSurname = '{name}', DOB = '{dob}', Gender = '{gender}', Phone= '{phone}', Address= '{address}', ModuleCodes = '{codes}'  WHERE StudentNumber = {id}", con);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Student Updated");

            }
            catch (Exception x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteStudent(int id)
        {
            try
            {

                con.Open();
                System.Windows.Forms.MessageBox.Show("Connection Opened");
                SqlCommand cmd = new SqlCommand($"DELETE FROM  Student  WHERE StudentNumber ='{id}'", con);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Student removed");

            }
            catch (Exception x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);
            }

            finally

            {
                con.Close();
            }
        }


        public DataTable ViewAll()
        {
            con.Open();


            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Student", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return dt;
        }


        public DataTable Search(int id)
        {
            con.Open();


            SqlDataAdapter da = new SqlDataAdapter($@"SELECT * FROM Student where StudentNumber = {id}", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return dt;
        }
        #endregion

        #region Modules
        public void addModule(int id, string code, string name, string description, string links)
        {

            try
            {
                con.Open();
                System.Windows.Forms.MessageBox.Show("Connection Opened");
                SqlCommand myCmd = new SqlCommand(@"INSERT INTO Modules(ModuleCodes, Name, Description, Links, StudentNumber)" + $"Values('{code}', '{name}', '{description}', '{links}', {id})", con);
                myCmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("New Module Added");

            }
            catch (Exception x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);
            }
            finally
            {
                con.Close();
            }


        }

        public void updateModule(int id, string code, string name, string description, string links)
        {
            try
            {
                con.Open();
                System.Windows.Forms.MessageBox.Show("Connection Opened");
                SqlCommand cmd = new SqlCommand($@"UPDATE Modules SET Name ='{name}', Description = '{description}', Links = '{links}' WHERE ModuleCodes ='{code}' AND StudentNumber = {id}", con);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Module Updated");

            }
            catch (Exception x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteModule(string code, int id)
        {
            try
            {

                con.Open();
                System.Windows.Forms.MessageBox.Show("Connection Opened");
                SqlCommand cmd = new SqlCommand($"DELETE FROM  Modules  WHERE ModuleCodes ='{code}' AND StudentNumber = '{id}'", con);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Module removed");

            }
            catch (Exception x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);
            }

            finally

            {
                con.Close();
            }
        }

        public void DeleteAllModules(int id)
        {
            try
            {

                con.Open();
                System.Windows.Forms.MessageBox.Show("Connection Opened");
                SqlCommand cmd = new SqlCommand($"DELETE FROM  Modules  WHERE StudentNumber = '{id}'", con);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("All student Modules removed");

            }
            catch (Exception x)
            {
                System.Windows.Forms.MessageBox.Show(x.Message);
            }

            finally

            {
                con.Close();
            }
        }



        public DataTable SearchModule(int id)
        {
            con.Open();


            SqlDataAdapter da = new SqlDataAdapter($@"SELECT * FROM Modules where StudentNumber = {id}", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return dt;
        }
        #endregion

    }
}
