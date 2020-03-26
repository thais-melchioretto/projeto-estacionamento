using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;


namespace Estacionamento
{
    public partial class Saida : Form

    {
        
        private MySqlConnection conect;
        private MySqlCommand objsql;
        public MySqlDataReader DataReader { get; set; }

        string descricao,placa;
        DateTime hoje = DateTime.Now;
        DateTime datasaida;
        Double preco, adicional,valor;
        int handle;

        private void conectabanco()
        {
            conect = new MySqlConnection("server=localhost;" +
            "user id=root;password=Thais123;database=bancoestacionamento;" +
            "Convert Zero Datetime = true");
            conect.Open();
        }
        
        private void lista()
        {
            conectabanco();

            try
            {
                objsql = new MySqlCommand("SELECT DESCRICAO FROM ENTRADA_SAIDA " +
                "ORDER BY HORAENTRADA DESC", conect);

                DataReader = objsql.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(DataReader);                
                this.cbdescricao.ValueMember = "DESCRICAO";
                this.cbdescricao.DataSource = table;
                DataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }

        }


        private void placas()
        {
            descricao = cbdescricao.Text;

            try
            {

                conectabanco();

                objsql = new MySqlCommand("SELECT PLACA FROM ENTRADA_SAIDA " +
                                            "WHERE DESCRICAO ='" + descricao + "' " +
                                            "AND HORAENTRADA BETWEEN '" + hoje.ToString("yyyy-MM") +
                                            "-01' AND '" + hoje.ToString("yyyy-MM") + "-31'", conect);

                string placa;
                placa = (objsql.ExecuteScalar() + "");   
                txtplaca.Text = placa.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }


        }

        private void camposaida()
        {
            txthsaida.Text = hoje.ToString();
        }

        private void limpar()
        {
            txthsaida.Text = "";
            txtplaca.Text = "";
        }

        public void inserirsaida()
        {
            if (string.IsNullOrWhiteSpace(txthsaida.Text) ||
                string.IsNullOrWhiteSpace(txtplaca.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações");
            }
            else
            {
                datasaida = Convert.ToDateTime(txthsaida.Text);
                placa = Convert.ToString(txtplaca.Text);
                descricao = cbdescricao.Text;

                try
                {
                    conectabanco();
                    
                    objsql = new MySqlCommand("SELECT HANDLE FROM ENTRADA_SAIDA " +
                    "WHERE PLACA ='" + placa.ToString() + "' AND " +
                    "DESCRICAO = '" + descricao.ToString() + "'", conect);

                    
                    handle = int.Parse(objsql.ExecuteScalar() + "");

                    objsql = new MySqlCommand("UPDATE ENTRADA_SAIDA SET " +
                    "HORASAIDA = '" + datasaida.ToString("yyyy-MM-dd HH:mm:ss") +
                    "' WHERE HANDLE= " + handle.ToString(), conect);

                    objsql.ExecuteNonQuery();
                    conect.Close();
                    MessageBox.Show("Saída incluída.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        public void valorpagar()
        {
            placa = Convert.ToString(txtplaca.Text);
            descricao = cbdescricao.Text;
            TimeSpan result;

            try
            {
                conectabanco();

                objsql = new MySqlCommand("SELECT HORAENTRADA " +
                    "FROM ENTRADA_SAIDA WHERE PLACA='" + placa.ToString() +
                    "' AND DESCRICAO='" + descricao.ToString() + "'", conect);

                DateTime horaentrada;
                horaentrada = DateTime.Parse(objsql.ExecuteScalar() + "");

                objsql = new MySqlCommand("SELECT HORASAIDA " +
                    "FROM ENTRADA_SAIDA WHERE PLACA='" + placa.ToString() +
                    "' AND DESCRICAO='" + descricao.ToString() + "'", conect);

                DateTime horasaida;
 

                horasaida = DateTime.Parse(objsql.ExecuteScalar() + "");

                
                result = horasaida.Subtract(horaentrada);
                int h = int.Parse(result.Hours.ToString());
                int m = int.Parse(result.Minutes.ToString());

                objsql = new MySqlCommand("SELECT PRECO " +
                    "FROM TABELAPRECOS WHERE DATAINICIAL >= '" + hoje.ToString("yyyy") +
                    "-01-01' AND DATAFINAL <= '" + hoje.ToString("yyyy") + "-12-31'", conect);

                preco = Double.Parse(objsql.ExecuteScalar() + "",CultureInfo.InvariantCulture);

                objsql = new MySqlCommand("SELECT ADICIONAL " +
                    "FROM TABELAPRECOS WHERE DATAINICIAL= '" + hoje.ToString("yyyy") +
                    "-01-01' AND DATAFINAL= '" + hoje.ToString("yyyy") + "-12-31'", conect);

                adicional = Double.Parse(objsql.ExecuteScalar() + "", CultureInfo.InvariantCulture);

                
                         
                if (h >= 1)
                {
                    valor = h * preco;

                    if (m > 10)
                    {
                        valor = valor + adicional;
                    }
                }
                else
                {
                    valor = 1.00;
                }

                MessageBox.Show("Valor a pagar de R$ " + valor.ToString("F2",CultureInfo.InvariantCulture));

                objsql = new MySqlCommand("UPDATE ENTRADA_SAIDA SET " +
                    "TEMPO = '" + result.ToString() +"', VALORAPAGAR ='" + 
                    valor.ToString("F2", CultureInfo.InvariantCulture) +
                    "' WHERE HANDLE= " + handle.ToString(), conect);

                objsql.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }

            

            

        }

        public void valortabelaprecos()
        {
            
            try
            {
                conectabanco();

                objsql = new MySqlCommand("SELECT HANDLE FROM TABELAPRECOS " +
                "WHERE DATAINICIAL >='" + hoje.ToString("yyyy") + "-01-01' AND " +
                "DATAFINAL <= '" + hoje.ToString("yyyy") + "-12-31''", conect);

                int handle;
                handle = int.Parse(objsql.ExecuteScalar() + "");

                objsql = new MySqlCommand("SELECT PRECO FROM HANDLE =" + handle.ToString() 
                    , conect);


                objsql.ExecuteNonQuery();
                conect.Close();
                MessageBox.Show("Saída incluída.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }
        }
        public Saida()
        {
            InitializeComponent();
            lista();
            placas();
            camposaida();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserirsaida();
            valorpagar();
            limpar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            placas();
            camposaida();

        }
        
    }
}
