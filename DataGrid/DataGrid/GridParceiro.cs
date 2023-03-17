using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class GridParceiro : Form
    {
        string stringConexao = frmLogin.stringConexao;
        public int _codigo;
        public GridParceiro()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            TestarConexao();
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
            string sql = "select id_Parceiro as 'ID'," +

"DataCadastro_Parceiro as 'DCadastro'," +
"Status_Parceiro as 'Status'," +
"nome_Parceiroa as 'Nome'," +
"CNPJ_Parceiro as 'CNPJ'," +
"Login_Parceiro as 'Login'," +
"Senha_Parceiro as 'Senha'," +
"Especialidade_Parceiro as 'Especialidade'," +
"TipoServico_Parceiro as 'TipoServiço'," +
"cep_Parceiro as 'CEP'," +
"logradouro_Parceiro as 'Ruas'," +
"Numero_Parceiro as 'Nº'," +
"bairro_Parceiro as 'Bairro'," +
"cidade_Parceiro as 'Cidade'," +
"uf_Parceiro as 'UF'," +
"Complemento_Parceiro as 'Complemento'," +
"HorarioFuncionamento_Parceiro as 'HFuncionamento'," +
"telefone1_Parceiro as 'Tel1'," +
"telefone2_Parceiro as 'Tel2'," +
"email_Parceiro as 'E-mail'," +
"Obs_Parceiro as 'Obs'" +

    "from Parceiro where nome_Parceiro like '%" + txtPesquisarParceiro.Text + "%'";


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();

            conn.Open();

            try
            {
                adapter.Fill(dataSet);
                dataGridParceiro.DataSource = dataSet.Tables[0];
                dataGridParceiro.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridParceiro.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCells);

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

        private void dataGridParceiro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = int.Parse(dataGridParceiro.CurrentRow.Cells["ID"].Value.ToString());
            this.Close();
        }
    }
}