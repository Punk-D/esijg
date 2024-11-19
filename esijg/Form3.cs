using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esijg
{
    public partial class Form3 : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=esi;Integrated Security=true;";
        private DataTable studentsTable;
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        private void LoadStudents()
        {
            {
                adapter = new SqlDataAdapter("SELECT * FROM Profesori", connection);

                // CommandBuilder automatically generates insert, update, and delete commands
                var commandBuilder = new SqlCommandBuilder(adapter);

                studentsTable = new DataTable();
                adapter.Fill(studentsTable);

                // Bind DataTable to DataGridView
                var bindingSource = new BindingSource { DataSource = studentsTable };
                dataGridView1.DataSource = bindingSource;
            }
        }
        public Form3()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadStudents();
        }

        private void SaveChanges()
        {
            try
            {
                adapter.Update(studentsTable);
                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }
        private void Delete()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                SaveChanges(); // Save changes after deletion
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
