using System.Data;
using Microsoft.Data.SqlClient;
namespace DBTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            fillComboInsList();
        }

        private void fillComboInsList()
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-DH7T4Q7;database=ITI;trusted_connection=true;trustServerCertificate=true;");
            SqlCommand command = new SqlCommand();
            command.CommandText = @"
                                    SELECT I.Ins_Name , I.Ins_Id
                                    FROM Instructor I,
                                   ";
            command.Connection = con;
            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                comboInstructors.DisplayMember = "Ins_Name";
                comboInstructors.ValueMember = "Ins_Id";
                comboInstructors.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void fillInstructorList()
        {
            //1- going to server , I need data base abc , and Iam nasser windows auth
            SqlConnection con = new SqlConnection("Server=DESKTOP-DH7T4Q7;database=ITI;trusted_connection=true;trustServerCertificate=true;");

            //4- your command
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"
                                    SELECT I.Ins_Name, T.Top_Name
                                    FROM Instructor I, Topic T, Course C, Ins_Course IC
                                    WHERE I.Ins_Id = IC.Ins_Id 
                                      AND C.Crs_Id = IC.Crs_Id
                                      AND T.Top_Id = C.Top_Id";
            //link command with connection
            command.Connection = con;

            try
            {
                con.Open();

                //container pointer to data comes from query 
                SqlDataReader dr = command.ExecuteReader();

                //data binding
                // data tale do not has it;s own design so i will use dataGrid
                DataTable dt = new DataTable();
                dt.Load(dr);

                //display data 
                dataGridInstructors.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void comboInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-DH7T4Q7;database=ITI;trusted_connection=true;trustServerCertificate=true;");
            int selectedId = Convert.ToInt32(comboInstructors.SelectedValue);
            SqlCommand command = new SqlCommand(@"
                SELECT I.Ins_Name, T.Top_Name
                FROM Instructor I, Topic T, Course C, Ins_Course IC
                WHERE I.Ins_Id = IC.Ins_Id 
                  AND C.Crs_Id = IC.Crs_Id
                  AND T.Top_Id = C.Top_Id
                  AND I.Ins_Id = @Id", con);

            command.Parameters.AddWithValue("@Id", selectedId);
            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridInstructors.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void allIns_click_Click(object sender, EventArgs e)
        {
            fillInstructorList();
        }

        private void ins_click_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-DH7T4Q7;database=ITI;trusted_connection=true;trustServerCertificate=true;");
            SqlCommand command = new SqlCommand(@"
                SELECT I.*
                                    FROM Instructor I", con);

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridInstructors.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nasser");
        }

        private void btnIns_Click_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-DH7T4Q7;database=ITI;trusted_connection=true;trustServerCertificate=true;");

            SqlCommand command = new SqlCommand();
            command.CommandText = $"insert into Instructor (Ins_Id , Ins_Name, Salary) values({Id_txtBox.Text},'{InstructorName_txtBox.Text}' , {InstructorSalary_txtBox.Text})";
            command.Connection = con;

            try
            {
                con.Open();
                label4.Text = $"{command.ExecuteNonQuery()} rows affected";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }


        }

        private void clear_btnClick_Click(object sender, EventArgs e)
        {
            Id_txtBox.Clear();
            InstructorName_txtBox.Clear();
            InstructorSalary_txtBox.Clear();
        }
    }
}
