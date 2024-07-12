using System.Data;
using System.Data.SqlClient;

namespace EmployeesRecord
{
    public partial class Form1 : Form
    {
        int currentId = 0;
        public Form1()
        {
            InitializeComponent();
            LoadEmployee();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void LoadEmployee()
        {
            DataTable table = Employee.getAll();
            employeeTable.DataSource = table;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Employee NewEmployee = new Employee(); // Create a new employee
            NewEmployee.FirstName = FirstNameBox.Text.ToString();
            NewEmployee.LastName = LastNameBox.Text.ToString();
            NewEmployee.Email = EmailBox.Text.ToString();
            NewEmployee.Occupation = OccupationBox.Text.ToString();
            NewEmployee.PhoneNumber = PhoneNumberBox.Text.ToString();
            NewEmployee.DateOfBirth = DateOfBirthPicker.Text.ToString();

            if (FirstNameBox.Text.Equals(String.Empty) || LastNameBox.Text.Equals(String.Empty) || EmailBox.Text.Equals(String.Empty) || OccupationBox.Text.Equals(String.Empty) || PhoneNumberBox.Text.Equals(String.Empty) || DateOfBirthPicker.Text.Equals(String.Empty))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            if (NewEmployee.Insert()) // if insertion is successful
            {
                MessageBox.Show("Registration Success!");
                LoadEmployee();
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (employeeTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = employeeTable.SelectedRows[0];

                string FirstName = selectedRow.Cells["FirstName"].Value.ToString();
                string LastName = selectedRow.Cells["LastName"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string Occupation = selectedRow.Cells["Occupation"].Value.ToString();
                string PhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                string DateOfBirth = selectedRow.Cells["DateOfBirth"].Value.ToString();
                string EmployeeId = selectedRow.Cells["Employee"].Value.ToString();

                FirstNameBox.Text = FirstName;
                LastNameBox.Text = LastName;
                EmailBox.Text = email;
                OccupationBox.Text = Occupation;
                PhoneNumberBox.Text = PhoneNumber;
                DateOfBirthPicker.Text = DateOfBirth;
                currentId = Convert.ToInt32(EmployeeId);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Update Data Button
        {
            if (currentId != 0)
            {
                Employee NewEmployee = new Employee(); // Create a new employee
                NewEmployee.FirstName = FirstNameBox.Text.ToString();
                NewEmployee.LastName = LastNameBox.Text.ToString();
                NewEmployee.Email = EmailBox.Text.ToString();
                NewEmployee.Occupation = OccupationBox.Text.ToString();
                NewEmployee.PhoneNumber = PhoneNumberBox.Text.ToString();
                NewEmployee.DateOfBirth = DateOfBirthPicker.Text.ToString();

                if (FirstNameBox.Text.Equals(String.Empty) || LastNameBox.Text.Equals(String.Empty) || EmailBox.Text.Equals(String.Empty) || OccupationBox.Text.Equals(String.Empty) || PhoneNumberBox.Text.Equals(String.Empty) || DateOfBirthPicker.Text.Equals(String.Empty))
                {
                    MessageBox.Show("All fields are required");
                    return;
                }

                if (NewEmployee.Update(currentId)) // if insertion is successful
                {
                    MessageBox.Show("Update Success!");
                    LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {


            if (employeeTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = employeeTable.SelectedRows[0];
                string EmployeeId = selectedRow.Cells["Employee"].Value.ToString();



                if (Employee.Delete(Convert.ToInt32(EmployeeId)))
                {
                    MessageBox.Show("Deleted Successfully!");
                    LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }
            }
        }
    }
}
