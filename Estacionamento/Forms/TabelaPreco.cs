using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Estacionamento
{
    public partial class TabelaPreco : Form

    {
        private MySqlDataAdapter objAdapter;
        private DataSet mDataSet;

        DateTime data1, data2;
        double precoporhora, adicional;
        string periodo;

        // Método chama a função para conectar com o banco.
        public void Chamarbanco()
        {
            ConectaBanco conecta = new ConectaBanco();
            conecta.Conexao();
        }

        // Método mostra a tabela (TabelaPreco) do banco. 
        private void MostraResultados()
        {
            mDataSet = new DataSet();

            Chamarbanco();

            MySqlCommand comando = new MySqlCommand
            {
                Connection = ConectaBanco.conect
            };

            objAdapter = new MySqlDataAdapter();

            string query = "SELECT DATAINICIAL,DATAFINAL,PRECO,ADICIONAL" +
                ",PERIODO FROM TABELAPRECOS ORDER BY DATAINICIAL";
            comando.CommandText = query;

            objAdapter.SelectCommand = comando;

            objAdapter.Fill(mDataSet, "TABELAPRECOS");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "TABELAPRECOS";
        }

        // Método para inserir os valores no banco.
        private void Inserirdados() 

        {   // validar os campos para que nenhum fique vazio.
            if (string.IsNullOrWhiteSpace(txtdatainicial.Text) ||
                string.IsNullOrWhiteSpace(txtdatafinal.Text) ||
                string.IsNullOrWhiteSpace(txtprecohora.Text) ||
                string.IsNullOrWhiteSpace(txtadicional.Text) ||
                string.IsNullOrWhiteSpace(txtano.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações");
            }

            else
            {
                data1 = Convert.ToDateTime(txtdatainicial.Text);
                data2 = Convert.ToDateTime(txtdatafinal.Text);
                precoporhora = Convert.ToDouble(txtprecohora.Text);
                adicional = Convert.ToDouble(txtadicional.Text);
                periodo = Convert.ToString(txtano.Text);

                try
                {
                    Chamarbanco();

                    MySqlCommand comando = new MySqlCommand
                    {
                        Connection = ConectaBanco.conect
                    };

                    // Insert no banco.
                    string query = "INSERT INTO tabelaprecos " +
                    "(DATAINICIAL, DATAFINAL, PRECO, ADICIONAL, PERIODO) VALUES('" +
                    data1.ToString("yyyy-MM-dd hh:mm:ss") +
                    "','" + data2.ToString("yyyy-MM-dd hh:mm:ss") +
                    "','" + precoporhora.ToString("0.00").Replace(",", ".") +
                    "','" + adicional.ToString("0.00").Replace(",", ".") +
                    "','" + periodo + "')";
                    comando.CommandText = query;

                    comando.ExecuteNonQuery();
                    
                    MessageBox.Show("Dados incluídos no Banco.");
                    MostraResultados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        // Método para alterar os valores no banco.
        private void AlterarDados()
        {
            // validar os campos para que nenhum fique vazio.
            if (string.IsNullOrWhiteSpace(txtdatainicial.Text) ||
                string.IsNullOrWhiteSpace(txtdatafinal.Text) ||
                string.IsNullOrWhiteSpace(txtprecohora.Text) ||
                string.IsNullOrWhiteSpace(txtadicional.Text) ||
                string.IsNullOrWhiteSpace(txtano.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações");

            }
            else
            {
                data1 = Convert.ToDateTime(txtdatainicial.Text);
                data2 = Convert.ToDateTime(txtdatafinal.Text);
                precoporhora = Convert.ToDouble(txtprecohora.Text);
                adicional = Convert.ToDouble(txtadicional.Text);
                periodo = Convert.ToString(txtano.Text);

                try
                {
                    Chamarbanco();

                    MySqlCommand comando = new MySqlCommand
                    {
                        Connection = ConectaBanco.conect
                    };

                    // select para achar o handle.
                    string query = "SELECT HANDLE FROM TABELAPRECOS " +
                    "WHERE PERIODO ='" + periodo + "'";
                    comando.CommandText = query;

                    int handle;

                    handle = int.Parse(comando.ExecuteScalar() + "");

                    // Update para alterar registros.
                    string update = "UPDATE TABELAPRECOS SET " +
                        " DATAINICIAL ='" + data1.ToString("yyyy-MM-dd hh:mm:ss") +
                        "', DATAFINAL ='" + data2.ToString("yyyy-MM-dd hh:mm:ss") +
                        "', PRECO = " + precoporhora.ToString("0.00").Replace(",", ".") +
                        ", ADICIONAL = " + adicional.ToString("0.00").Replace(",", ".") +
                        " WHERE HANDLE = " + handle + "";
                    comando.CommandText = update;

                    comando.ExecuteNonQuery();
                    
                    MessageBox.Show("Alterado registro.");
                    MostraResultados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        // Método para excluir os valores no banco.
        private void Excluir()
        {
            // validar os campos para que nenhum fique vazio.
            if (string.IsNullOrWhiteSpace(txtdatainicial.Text) ||
                string.IsNullOrWhiteSpace(txtdatafinal.Text) ||
                string.IsNullOrWhiteSpace(txtprecohora.Text) ||
                string.IsNullOrWhiteSpace(txtadicional.Text) ||
                string.IsNullOrWhiteSpace(txtano.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações.");

            }
            else
            {
                Chamarbanco();

                MySqlCommand comando = new MySqlCommand
                {
                    Connection = ConectaBanco.conect
                };

                // select para achar o handle.
                string query = "SELECT HANDLE FROM TABELAPRECOS " +
                    "WHERE PERIODO ='" + periodo + "'";
                comando.CommandText = query;
                int handle;

                data1 = Convert.ToDateTime(txtdatainicial.Text);
                data2 = Convert.ToDateTime(txtdatafinal.Text);
                precoporhora = Convert.ToDouble(txtprecohora.Text);
                adicional = Convert.ToDouble(txtadicional.Text);
                periodo = Convert.ToString(txtano.Text);

                try
                {

                    handle = int.Parse(comando.ExecuteScalar() + "");

                    // Deletar da tabela a documento.
                    string delete = "DELETE FROM TABELAPRECOS" +
                        " WHERE HANDLE = " + handle + "";
                    comando.CommandText = delete;

                    comando.ExecuteNonQuery();
                    
                    MessageBox.Show("Registro excluído.");
                    MostraResultados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        // Inicializa o formulario. 
        public TabelaPreco()
        {
            InitializeComponent();
            MostraResultados();

        }

        //Botão para inserir.
        private void BtnInserir(object sender, EventArgs e)
        {
            Inserirdados();
        }

        //Botão para excluir.
        private void BtnExcluir(object sender, EventArgs e)
        {
            Excluir();
        }

        //Botão para alterar.
        private void BtnAlterar(object sender, EventArgs e)
        {
            AlterarDados();
        }
    }
}
