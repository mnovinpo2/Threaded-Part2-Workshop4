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

namespace TravelExpertsGUI
{
    public partial class frmEditPackage : Form
    {
        public frmEditPackage()
        {
            InitializeComponent();
        }

        private void frmEditPkg_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(@"Server=LOCALHOST\SQLEXPRESS;Database=TravelExperts;Trusted_connection=True; TrustServerCertificate=True");

            connection.Open();
            string SQL = "select pk.PackageId, PkgName, p.ProductId, ProdName, s.SupplierId, SupName\r\nfrom Products p join Products_Suppliers ps on p.ProductId = ps.ProductId\r\n                join Suppliers s on s.SupplierId = ps.SupplierId\r\n\t\t\t\tjoin Packages_Products_Suppliers pps on pps.ProductSupplierId = ps.ProductSupplierId\r\n\t\t\t\tjoin Packages pk on pk.PackageId = pps.PackageId";
            var cmd = new SqlCommand(SQL, connection);
            var dataReader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dataReader);
            dgv1.DataSource = table;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
