using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DBTask
{
    public partial class update : Form
    {
        public update()
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
                                    FROM Instructor I
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

        private void comboInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-DH7T4Q7;database=ITI;trusted_connection=true;trustServerCertificate=true;");
            SqlCommand command = new SqlCommand();
            command.CommandText = $" SELECT * FROM Instructor I  where Ins_Id = '{comboInstructors.SelectedValue}'";
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                Id_txtBox.Text = dt.Rows[0]["Ins_Id"].ToString();
                InstructorName_txtBox.Text = dt.Rows[0]["Ins_Name"].ToString();
                InstructorSalary_txtBox.Text = dt.Rows[0]["Salary"].ToString();

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

        private void clear_btnClick_Click(object sender, EventArgs e)
        {
            Id_txtBox.Clear();
            InstructorName_txtBox.Clear();
            InstructorSalary_txtBox.Clear();
        }

        private void btnUpdate_Click_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-DH7T4Q7;database=ITI;trusted_connection=true;trustServerCertificate=true;");
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE Instructor SET Ins_Name = '{InstructorName_txtBox.Text}',Salary = {InstructorSalary_txtBox.Text} WHERE Ins_Id ={Id_txtBox.Text};";
            command.Connection = con;

            try
            {
                con.Open();
                int affected = command.ExecuteNonQuery();

                if (affected > 0)
                {
                    label4.Text = "Updated...";
                    fillComboInsList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-DH7T4Q7;database=ITI;trusted_connection=true;trustServerCertificate=true;");
            SqlCommand command = new SqlCommand();
            command.CommandText = $"delete from Instructor  WHERE Ins_Id ={Id_txtBox.Text};";
            command.Connection = con;

            try
            {
                con.Open();
                int affected = command.ExecuteNonQuery();

                if (affected > 0)
                {
                    label4.Text = "deleted...";
                    fillComboInsList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
