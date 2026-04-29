using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01
{
    public partial class lblTitle : Form
    {
        // List to store students
        List<Student> students = new List<Student>();

        public lblTitle()
        {
            InitializeComponent();
        }

        // Form load event - adds 5 demo students when program starts
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add 5 demo students
            students.Add(new Student { ID = "001", Name = "Ahmed Mohamed", Age = 20 });
            students.Add(new Student { ID = "002", Name = "Sara Khalid", Age = 21 });
            students.Add(new Student { ID = "003", Name = "Abdullah Ali", Age = 19 });
            students.Add(new Student { ID = "004", Name = "Fatima Hassan", Age = 22 });
            students.Add(new Student { ID = "005", Name = "Yousef Ibrahim", Age = 20 });

            // Display students in the grid
            RefreshGrid();
        }

        // Function to refresh the grid
        void RefreshGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
        }

        // Add student button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if age is a number
            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Age must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new student
            Student newStudent = new Student();
            newStudent.ID = txtID.Text;
            newStudent.Name = txtName.Text;
            newStudent.Age = age;

            // Add student to list
            students.Add(newStudent);

            // Refresh the grid
            RefreshGrid();

            // Clear fields
            txtID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";

            MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Delete student button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a student is selected
            if (dgvStudents.SelectedRows.Count > 0)
            {
                // Get selected student
                DataGridViewRow row = dgvStudents.SelectedRows[0];
                Student s = (Student)row.DataBoundItem;

                // Confirm deletion
                DialogResult result = MessageBox.Show($"Do you want to delete student {s.Name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete student
                    students.Remove(s);

                    // Refresh the grid
                    RefreshGrid();

                    MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a student first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search by name or ID
            var result = students.Where(s => s.Name.Contains(txtSearch.Text) || s.ID.Contains(txtSearch.Text)).ToList();

            // Display results
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = result;

            // If no results found
            if (result.Count == 0)
            {
                MessageBox.Show("No matching student found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Show all button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            // Clear search box
            txtSearch.Text = "";

        }
    }
}