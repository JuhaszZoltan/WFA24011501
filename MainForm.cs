using Microsoft.Data.SqlClient;

namespace WFA24011501
{
    public partial class MainForm : Form
    {
        private string connectionString =
            "SERVER = (localdb)\\MSSQLLocalDB;" +
            "DATABASE = koboldbikersdb";

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.Load += FillDgvRents;
            cbxType.SelectedIndexChanged += FillDgvRents;
            btnNewRent.Click += BtnNewRent_Click;
        }

        private void BtnNewRent_Click(object? sender, EventArgs e)
        {
            _ = new RentalForm().ShowDialog();
            FillDgvRents(null, null!);
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();
            var reader = new SqlCommand("SELECT name FROM types;", connection)
                .ExecuteReader();
            while (reader.Read()) cbxType.Items.Add(reader[0]);
        }

        private void FillDgvRents(object? sender, EventArgs e)
        {
            dgvRents.Rows.Clear();

            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sqlCmdStr = 
                "SELECT kobolds.name, kobolds.id, types.name, " +
                "bikes.color, types.size, rentals.start, " +
                "rentals.days, types.price " +
                "FROM kobolds " +
                "INNER JOIN rentals ON kobolds.id = koboldID " +
                "INNER JOIN bikes ON bikes.id = bikeID " +
                "INNER JOIN types ON types.id = typeID " +
                $"WHERE types.name LIKE '{cbxType.SelectedItem}%';";

            var reader = new SqlCommand(sqlCmdStr, connection)
                .ExecuteReader();

            while (reader.Read())
            {
                var startDate = reader.GetDateTime(5);
                int noDays = reader.GetInt32(6);

                dgvRents.Rows.Add(
                    reader[0],
                    reader[1],
                    $"{reader[2]} ({reader[3]}, {(reader.GetBoolean(4) ? "M" : "S")})",
                    startDate.ToString("yyyy-MM-dd"),
                    startDate.AddDays(noDays).ToString("yyyy-MM-dd"),
                    $"{noDays * reader.GetInt32(7)} GP");
            }
        }
    }
}
