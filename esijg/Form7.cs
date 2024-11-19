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
    public partial class Form7 : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=esi;Integrated Security=true;";
        public Form7()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private double GetAverage(string procedureName, string parameterName = null, int parameterValue = 0)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (!string.IsNullOrEmpty(parameterName))
                        command.Parameters.AddWithValue(parameterName, parameterValue);

                    var result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDouble(result) : 0.0;
                }
            }
        }

        private void LoadComboBoxes()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Load Students
                var studentsCommand = new SqlCommand("SELECT ID_Elev, Nume + ' ' + Prenume AS FullName FROM Elevi", connection);
                var studentsReader = studentsCommand.ExecuteReader();
                while (studentsReader.Read())
                {
                    comboBox1.Items.Add(new { ID = studentsReader["ID_Elev"], Name = studentsReader["FullName"].ToString() });
                }
                studentsReader.Close();

                // Load Groups
                var groupsCommand = new SqlCommand("SELECT ID_Grupa FROM Grupe", connection);
                var groupsReader = groupsCommand.ExecuteReader();
                while (groupsReader.Read())
                {
                    comboBox2.Items.Add(groupsReader["ID_Grupa"].ToString());
                }
                groupsReader.Close();

                // Load Years
                var yearsCommand = new SqlCommand("SELECT DISTINCT An_de_studii FROM Grupe", connection);
                var yearsReader = yearsCommand.ExecuteReader();
                while (yearsReader.Read())
                {
                    comboBox3.Items.Add(yearsReader["An_de_studii"].ToString());
                }
                yearsReader.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = (dynamic)comboBox1.SelectedItem;
            int studentID = selectedStudent.ID;

            labelResult.Text = $"Average: {GetAverage("GetStudentAverage", "@StudentID", studentID):F2}";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int groupID = int.Parse(comboBox2.SelectedItem.ToString());

            labelResult.Text = $"Average: {GetAverage("GetGroupAverage", "@GroupID", groupID):F2}";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(comboBox3.SelectedItem.ToString());

            labelResult.Text = $"Average: {GetAverage("GetYearAverage", "@Year", year):F2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.Text = $"College Average: {GetAverage("GetCollegeAverage"):F2}";
        }
    }
}
