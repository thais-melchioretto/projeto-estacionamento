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


        public void Chamarbanco()
        {
            ConectaBanco conecta = new ConectaBanco();
            conecta.conexao();
        }

        private void mostraResultados()
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

        private void inserirdados() 

        {
            if (string.IsNullOrWhiteSpace(datainicial.Text) ||
                string.IsNullOrWhiteSpace(datafinal.Text) ||
                string.IsNullOrWhiteSpace(precohora.Text) ||
                string.IsNullOrWhiteSpace(txtadicional.Text) ||
                string.IsNullOrWhiteSpace(txtano.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações");
            }

            else
            {
                data1 = Convert.ToDateTime(datainicial.Text);
                data2 = Convert.ToDateTime(datafinal.Text);
                precoporhora = Convert.ToDouble(precohora.Text);
                adicional = Convert.ToDouble(txtadicional.Text);
                periodo = Convert.ToString(txtano.Text);

                try
                {
                    Chamarbanco();

                    MySqlCommand comando = new MySqlCommand
                    {
                        Connection = ConectaBanco.conect
                    };

                    string query = "INSERT INTO tabelaprecos " +
                    "(DATAINICIAL, DATAFINAL, PRECO, ADICIONAL, PERIODO) VALUES('" +
                    data1.ToString("yyyy-MM-dd hh:mm:ss") +
                    "','" + data2.ToString("yyyy-MM-dd hh:mm:ss") +
                    "','" + precoporhora.ToString("0.00").Replace(",", ".") +
                    "','" + adicional.ToString("0.00").Replace(",", ".") +
                    "','" + periodo + "')";
                    comando.CommandText = query;

                    comando.ExecuteNonQuery();
                    
                    MessageBox.Show("Dados incluidos no Banco");
                    mostraResultados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        private void alterardados()
        {
            
            if (string.IsNullOrWhiteSpace(datainicial.Text) ||
                string.IsNullOrWhiteSpace(datafinal.Text) ||
                string.IsNullOrWhiteSpace(precohora.Text) ||
                string.IsNullOrWhiteSpace(txtadicional.Text) ||
                string.IsNullOrWhiteSpace(txtano.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações");

            }
            else
            {
                data1 = Convert.ToDateTime(datainicial.Text);
                data2 = Convert.ToDateTime(datafinal.Text);
                precoporhora = Convert.ToDouble(precohora.Text);
                adicional = Convert.ToDouble(txtadicional.Text);
                periodo = Convert.ToString(txtano.Text);

                try
                {
                    Chamarbanco();

                    MySqlCommand comando = new MySqlCommand
                    {
                        Connection = ConectaBanco.conect
                    };

                    string query = "SELECT HANDLE FROM TABELAPRECOS " +
                    "WHERE PERIODO ='" + periodo + "'";
                    comando.CommandText = query;

                    int handle;

                    handle = int.Parse(comando.ExecuteScalar() + "");

                    string update = "UPDATE TABELAPRECOS SET " +
                        " DATAINICIAL ='" + data1.ToString("yyyy-MM-dd hh:mm:ss") +
                        "', DATAFINAL ='" + data2.ToString("yyyy-MM-dd hh:mm:ss") +
                        "', PRECO = " + precoporhora.ToString("0.00").Replace(",", ".") +
                        ", ADICIONAL = " + adicional.ToString("0.00").Replace(",", ".") +
                        " WHERE HANDLE = " + handle + "";
                    comando.CommandText = update;

                    comando.ExecuteNonQuery();
                    
                    MessageBox.Show("Alterado registro");
                    mostraResultados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        private void excluir()
        {
            if (string.IsNullOrWhiteSpace(datainicial.Text) ||
                string.IsNullOrWhiteSpace(datafinal.Text) ||
                string.IsNullOrWhiteSpace(precohora.Text) ||
                string.IsNullOrWhiteSpace(txtadicional.Text) ||
                string.IsNullOrWhiteSpace(txtano.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações");

            }
            else
            {
                Chamarbanco();

                MySqlCommand comando = new MySqlCommand
                {
                    Connection = ConectaBanco.conect
                };

                string query = "SELECT HANDLE FROM TABELAPRECOS " +
                    "WHERE PERIODO ='" + periodo + "'";
                comando.CommandText = query;
                int handle;

                data1 = Convert.ToDateTime(datainicial.Text);
                data2 = Convert.ToDateTime(datafinal.Text);
                precoporhora = Convert.ToDouble(precohora.Text);
                adicional = Convert.ToDouble(txtadicional.Text);
                periodo = Convert.ToString(txtano.Text);

                try
                {

                    handle = int.Parse(comando.ExecuteScalar() + "");

                    string delete = "DELETE FROM TABELAPRECOS" +
                        " WHERE HANDLE = " + handle + "";
                    comando.CommandText = delete;

                    comando.ExecuteNonQuery();
                    
                    MessageBox.Show("Registro excluido.");
                    mostraResultados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }

            }
        }

        public TabelaPreco()
        {
            InitializeComponent();
            mostraResultados();

        }

        private void Btninserir_(object sender, EventArgs e)
        {
            inserirdados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excluir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alterardados();

        }
    }
}
