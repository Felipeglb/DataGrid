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

namespace DataGrid
{
    public partial class GridDepartamentos : Form
    {
        public GridDepartamentos()
        {
            InitializeComponent();
        }

        private void GridDepartamentos_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDataGrid();
        }

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }


        private void CarregarDataGrid()
        {
            string sql = "select id_departamento as 'ID'," +

"DataCadastro_departamento as 'D.Cadastro'," +
"Status_departamento as 'Status'," +
"nome_departamento as 'Nome'," +
"area_departamento as 'Area'," +
"descricao_departamento as 'Descrição'," +
"Obs_departamento as 'Obs'," +

    "from Departamento where nome_departamento like '%" + txtPesquisarDepart.Text + "%'";


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();

            conn.Open();

            try
            {
                adapter.Fill(dataSet);
                GridDepartamentos.DataSource = dataSet.Tables[0];
                GridDepartamentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                GridDepartamentos.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCells);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }


        private void dataGridDepart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = int.Parse(dataGridDepart.CurrentRow.Cells["ID"].Value.ToString());
            this.Close();
        }

 
    }
}
