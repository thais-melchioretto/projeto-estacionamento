
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;


namespace Estacionamento
{
    public partial class Saida : Form

    {
        public MySqlDataReader DataReader { get; set; }
        public DateTime Hoje { get => hoje; set => hoje = value; }

        Double preco, adicional, valor;
        string placas, descricao;
        DateTime hoje = DateTime.Now;
        DateTime datasaida;
        int handle;

        // Método chama a função para conectar com o banco.
        public void ChamarBanco()
        {
            ConectaBanco conecta = new ConectaBanco();
            conecta.Conexao();
        }

        // Função para chamar a lista de carros cadastrados. 
        private void Lista()
        {
            try
            {
                ChamarBanco();

                MySqlCommand comando = new MySqlCommand
                {
                    Connection = ConectaBanco.conect
                };

                string query = "SELECT PLACA FROM ENTRADA_SAIDA " +
                "WHERE HORASAIDA IS NULL ORDER BY HORAENTRADA DESC";

                comando.CommandText = query;

                DataReader = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(DataReader);                
                this.cbplaca.ValueMember = "PLACA";
                this.cbplaca.DataSource = table;
                DataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }
        }

        // Função para chamar as descrição dos carros conforme a placa. 
        private void Descricao()
        {
            placas = cbplaca.Text;

            try
            {
                ChamarBanco();

                MySqlCommand comando = new MySqlCommand
                {
                    Connection = ConectaBanco.conect
                };

                string query = "SELECT DESCRICAO FROM ENTRADA_SAIDA " +
                               "WHERE PLACA ='" + placas.ToString() +  "'";

                comando.CommandText = query;

                descricao = (comando.ExecuteScalar() + "");   
                txtdescricao.Text = descricao.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }
        }

        // Carrega no campo saida a data de hoje.
        private void CampoSaida()
        {
            txthsaida.Text = hoje.ToString();
        }

        // Inserir no banco a data e hora de saida. 
        public void InserirSaida()
        {
            if (string.IsNullOrWhiteSpace(txthsaida.Text) ||
                string.IsNullOrWhiteSpace(txtdescricao.Text)
                )
            {
                MessageBox.Show("Preencha todas as informações");
            }
            else
            {
                datasaida = Convert.ToDateTime(txthsaida.Text);
                placas = Convert.ToString(cbplaca.Text);
                placas = cbplaca.Text;

                try
                {
                    /* Procura o handle para fazer o update. */
                    ChamarBanco();

                    MySqlCommand comando = new MySqlCommand
                    {
                        Connection = ConectaBanco.conect
                    };

                    string query = "SELECT HANDLE FROM ENTRADA_SAIDA " +
                    "WHERE PLACA ='" + placas.ToString() + "' AND " +
                    "DESCRICAO = '" + descricao.ToString() + "'";
                    comando.CommandText = query;
                    handle = int.Parse(comando.ExecuteScalar() + "");

                    /* Update para incluir a data de saida. */
                    string update = "UPDATE ENTRADA_SAIDA SET " +
                    "HORASAIDA = '" + datasaida.ToString("yyyy-MM-dd HH:mm:ss") +
                    "' WHERE HANDLE= " + handle.ToString();
                    comando.CommandText = update;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Saída incluída.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        // Calcular o valor a pagar. 
        public void ValorPagar()
        {
            placas = Convert.ToString(cbplaca.Text);
            descricao = txtdescricao.Text;
            
            TimeSpan result;

            try
            {
                ChamarBanco();

                MySqlCommand comando = new MySqlCommand
                {
                    Connection = ConectaBanco.conect
                };

                string query = "SELECT HORAENTRADA " +
                    "FROM ENTRADA_SAIDA WHERE PLACA='" + placas.ToString() +
                    "' AND DESCRICAO='" + descricao.ToString() + "'";
                comando.CommandText = query;

                DateTime horaentrada;
                horaentrada = DateTime.Parse(comando.ExecuteScalar() + "");

                string selecthorasaida = "SELECT HORASAIDA " +
                    "FROM ENTRADA_SAIDA WHERE PLACA='" + placas.ToString() +
                    "' AND DESCRICAO='" + descricao.ToString() + "'";

                comando.CommandText = selecthorasaida;

                DateTime horasaida;
 
                horasaida = DateTime.Parse(comando.ExecuteScalar() + "");
               
                result = horasaida.Subtract(horaentrada);
                int h = int.Parse(result.Hours.ToString());
                int m = int.Parse(result.Minutes.ToString());

                string selectpreco = "SELECT PRECO FROM TABELAPRECOS WHERE DATAINICIAL" +
                    " >= '" + hoje.ToString("yyyy") +"-01-01' AND DATAFINAL <= '" + 
                    hoje.ToString("yyyy") + "-12-31'";
                comando.CommandText = selectpreco;

                preco = Double.Parse(comando.ExecuteScalar() + "",CultureInfo.InvariantCulture);

                string selectadicional = "SELECT ADICIONAL FROM TABELAPRECOS WHERE " +
                    "DATAINICIAL= '" + hoje.ToString("yyyy") + "-01-01' AND DATAFINAL= " +
                    "'" + hoje.ToString("yyyy") + "-12-31'";
                comando.CommandText = selectadicional;

                adicional = Double.Parse(comando.ExecuteScalar() + "", CultureInfo.InvariantCulture);
                

                if (m <= 30 && h < 1)
                {
                    valor = preco/2;
                }
                else
                {
                    if (m >= 30 && h < 1)
                    {
                        valor = preco;
                    }
                    else
                    {
                        if (m <= 10)
                        {
                            valor = (((h-1) * adicional) + preco);
                        }
                        else
                        {
                            valor = (((h - 1) * adicional) + preco + adicional);
                        }
                    }

                }


                MessageBox.Show("Valor a pagar de R$ " + 
                    valor.ToString("F2",CultureInfo.InvariantCulture) + ", pela permanencia" +
                    "de " + result.ToString());

                string update = "UPDATE ENTRADA_SAIDA SET " +
                    "TEMPO = '" + result.ToString() +"', VALORAPAGAR ='" + 
                    valor.ToString("F2", CultureInfo.InvariantCulture) +
                    "' WHERE HANDLE= " + handle.ToString();

                comando.CommandText = update;
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }
        }

        // Calcular o valor a pagar. 
        public void ValorTabelaPrecos()
        {
            
            try
            {
                ChamarBanco();

                MySqlCommand comando = new MySqlCommand
                {
                    Connection = ConectaBanco.conect
                };

                string query = "SELECT HANDLE FROM TABELAPRECOS " +
                "WHERE DATAINICIAL >='" + hoje.ToString("yyyy") + "-01-01' AND " +
                "DATAFINAL <= '" + hoje.ToString("yyyy") + "-12-31''";
                comando.CommandText = query;

                int handle;
                handle = int.Parse(comando.ExecuteScalar() + "");

                string selectpreco = "SELECT PRECO FROM HANDLE =" + handle.ToString();
                comando.CommandText = selectpreco;

                comando.ExecuteNonQuery();
                MessageBox.Show("Saída incluída.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }
        }

        // Função que chama todos os metodos.  
        public Saida()
        {
            InitializeComponent();
            Lista();
            Descricao();
            CampoSaida();
        }

        //Botão para salvar.
        private void BtnSalvar(object sender, EventArgs e)
        {
            InserirSaida();
            ValorPagar();
            Limpar();
        }

        //Combobox para trazer as placas.
        private void CbPlaca(object sender, EventArgs e)
        {
            Descricao();
            CampoSaida();

        }

        /* Função para limpar os campos após salvar. */ 
        private void Limpar()
        {
            txthsaida.Text = "";
            txtdescricao.Text = "";
        }

    }
}
