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
    public partial class Form5 : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=esi;Integrated Security=true;";
        private DataTable studentsTable;
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        private void LoadStudents()
        {
            {
                adapter = new SqlDataAdapter("SELECT O.ID_Obiect, O.Denumire, \r\n       P.Nume + ' ' + P.Prenume AS Profesor\r\nFROM Obiecte AS O\r\nINNER JOIN Profesori AS P ON O.ID_Profesor = P.ID_Profesor;\r\n", connection);

                // CommandBuilder automatically generates insert, update, and delete commands
                var commandBuilder = new SqlCommandBuilder(adapter);

                studentsTable = new DataTable();
                adapter.Fill(studentsTable);

                // Bind DataTable to DataGridView
                var bindingSource = new BindingSource { DataSource = studentsTable };
                dataGridView1.DataSource = bindingSource;
            }
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
        public Form5()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadStudents(); 
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
