using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Alterar : Form
    {
        private MySqlConnection conect;
        private MySqlCommand objsql;
        public MySqlDataReader DataReader { get; set; }
        string descricao;
        DateTime hoje = DateTime.Now;
        string placa;


        public Alterar()
        {
            InitializeComponent();
            lista();
        }

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
            DateTime semana = hoje.AddDays(-7);

            try
            {
                objsql = new MySqlCommand("SELECT PLACA FROM ENTRADA_SAIDA WHERE " +
                    "HORAENTRADA BETWEEN '" + semana.ToString("yyyy-MM-dd") + "' AND " +
                    " '" + hoje.ToString("yyyy-MM-dd") + "'", conect);

                DataReader = objsql.ExecuteReader();
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

        private void placas()
        {
            placa = cbplaca.Text;
            /*
            try
            {
                conectabanco();

                objsql = new MySqlCommand("SELECT DESCRICAO FROM ENTRADA_SAIDA " +
                                            "WHERE PLACA ='" + placa.ToString() + "' " +
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
            */

        }
        private void Alterar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbplaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista();
        }
    }
}
