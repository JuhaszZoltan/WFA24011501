using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA24011501
{
    public partial class RentalForm : Form
    {
        private string connectionString =
            "SERVER = (localdb)\\MSSQLLocalDB;" +
            "DATABASE = koboldbikersdb";

        private int selectedKoboldID = -1;

        public RentalForm()
        {
            InitializeComponent();
            this.Load += RentalForm_Load;
            cbxKoboldNames.SelectedIndexChanged += CbxKoboldNames_SelectedIndexChanged;
            btnNewRent.Click += BtnNewRent_Click;
        }

        private void BtnNewRent_Click(object? sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(cbxKoboldNames.Text) 
                || nudDays.Value == 0 
                || dtpStartDate.Value < DateTime.Today)
            {
                _ = MessageBox.Show(
                    caption: "ERROR!",
                    text: "All fiels above are required!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else if (false)
            {
                //TODO: ha kolcsonzés alatt áll:
                _ = MessageBox.Show(
                    caption: "ERROR!",
                    text: "The bike you want to rent is currently not avilable!\n" +
                    "Please choose another vehicle or date!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                using SqlConnection connection = new(connectionString);
                connection.Open();

                SqlDataAdapter adapter = new()
                {
                    InsertCommand = new($"INSERT INTO rentals VALUES " +
                    $"('{dtpStartDate.Value:yyyy-MM-dd}', " +
                    $"{(int)nudDays.Value}, " +
                    $"{selectedKoboldID}," +
                    $"{(int)dgvBikes.SelectedRows[0].Cells[0].Value});", connection),
                };

                adapter.InsertCommand.ExecuteNonQuery();

                _ = MessageBox.Show(
                    caption: "SUCCESS!",
                    text: "successful booking!",
                    icon: MessageBoxIcon.Information,
                    buttons: MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void CbxKoboldNames_SelectedIndexChanged(object? sender, EventArgs e)
        {
            dgvBikes.Rows.Clear();

            using SqlConnection connection = new(connectionString);
            connection.Open();

            var reader = new SqlCommand(
                $"SELECT id FROM kobolds WHERE name = '{cbxKoboldNames.SelectedItem}';",
                connection).ExecuteReader();
            reader.Read();
            selectedKoboldID = reader.GetInt32(0);
            reader.Close();

            reader = new SqlCommand(
                "SELECT bikes.id, types.name, color, types.size " +
                "FROM bikes INNER JOIN types " +
                "ON types.id = typeID " +
                $"WHERE types.size = (SELECT size FROM kobolds WHERE name = '{cbxKoboldNames.SelectedItem}');",
                connection).ExecuteReader();

            while (reader.Read())
            {
                dgvBikes.Rows.Add(
                    reader[0],
                    reader[1],
                    reader[2], 
                    reader.GetBoolean(3) ? "M" : "S");
            }


        }

        private void RentalForm_Load(object? sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;

            using SqlConnection connection = new(connectionString);
            connection.Open();
            var reader = new SqlCommand("SELECT name FROM kobolds ORDER BY name ASC;", connection)
                .ExecuteReader();
            while (reader.Read()) cbxKoboldNames.Items.Add(reader[0]);
            cbxKoboldNames.SelectedIndex = 0;
        }
    }
}
