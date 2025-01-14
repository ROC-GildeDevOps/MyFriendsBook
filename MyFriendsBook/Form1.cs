using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFriendsBook
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=LEGION-TRISTAN\\SQLEXPRESS;Initial Catalog=Friends;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        string cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            input_id.Text = "";
            input_firstName.Text = "";
            input_lastName.Text = "";
            input_dob.Text = "";
            input_dob.Value = DateTime.Now;
            input_birthPlace.Text = "";

            input_male.Checked = false;
            input_female.Checked = false;

            input_adress.Text = ""; 
            input_phone.Text = "";
            input_email.Text = "";
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        public void RefreshGridView()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    RefreshGridView();
                }
                else if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    cmd = "SELECT * FROM Friends";
                    command = new SqlCommand(cmd, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command); 
                    DataTable table = new DataTable();

                    if (table.Rows.Count > 0)
                    {
                        table.Clear();
                    } else
                    {
                        connection.Close();
                    }

                    adapter.Fill(table);
                    output.DataSource = table;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string fName = input_firstName.Text;
            string lName = input_lastName.Text;
            DateTime dob = input_dob.Value;
            string birthPlace = input_birthPlace.Text;
            string gender; // wordt aangegeven door een ifstatement
            string adress = input_adress.Text;
            string phone = input_phone.Text;
            string email = input_email.Text;

            int result = 0;

            if (input_male.Checked)
            {
                gender = "Male";
            }
            else 
            {
                gender = "Female";
            }

            cmd = "Select count(*) form Friend where LastName = @lName";
            command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@lName", lName);

            connection.Open();
            result = Convert.ToInt32(command.ExecuteScalar());

            if (result > 0)
            {
                MessageBox.Show("Username = " + lName + "Already exist");
                // CLEAN BUTTON
                input_id.Text = "";
                input_firstName.Text = "";
                input_lastName.Text = "";
                input_dob.Text = "";
                input_dob.Value = DateTime.Now;
                input_birthPlace.Text = "";

                input_male.Checked = false;
                input_female.Checked = false;

                input_adress.Text = "";
                input_phone.Text = "";
                input_email.Text = "";
                // END CLEAN BUTTON

                connection.Close();
            }
            else if (lName != "")
            {
                cmd = "INSERT INTO Friend (FirstName, LastName, Birthday, BirthPlace, Gender, Address, Telephone, Email) VALUES (@fName, @lName, @dob, @birthPlace, @gender, @adress, @phone, @email)";
                command = new SqlCommand(cmd, connection);

                command.Parameters.Add(new SqlParameter("@fName", fName));
                command.Parameters.Add(new SqlParameter("@lName", lName));
                command.Parameters.Add(new SqlParameter("@dob", dob));
                command.Parameters.Add(new SqlParameter("@birthPlace", birthPlace));
                command.Parameters.Add(new SqlParameter("@Gender", gender));
                command.Parameters.Add(new SqlParameter("@adress", adress));
                command.Parameters.Add(new SqlParameter("@phone", phone));
                command.Parameters.Add(new SqlParameter("@email", email));

                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User Saved");
                    // CLEAN BUTTON
                    input_id.Text = "";
                    input_firstName.Text = "";
                    input_lastName.Text = "";
                    input_dob.Text = "";
                    input_dob.Value = DateTime.Now;
                    input_birthPlace.Text = "";

                    input_male.Checked = false;
                    input_female.Checked = false;

                    input_adress.Text = "";
                    input_phone.Text = "";
                    input_email.Text = "";
                    // END CLEAN BUTTON
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Data not saved");
                    connection.Close();
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string lastName = input_lastName.Text;

            if (lastName == null || lastName.Length == 0) {
                MessageBox.Show("Please enter a last name");
                return;
            }

            connection.Open();
            try
            {
                cmd = "SELECT * FROM Friends WHERE LastName = @lastName";
                command = new SqlCommand(cmd, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.Add(new SqlParameter("@lastName", lastName));
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    output.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No data found");
                    adapter.Dispose();
                    table.Clear();
                    connection.Close();
                }

            } catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
