using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Alterar : Form
    {
        public MySqlDataReader DataReader { get; set; }
        DateTime hoje = DateTime.Now;
        string placa, descricao, vlrapagar;
        private DateTime dataentrada, datasaida, tempo;

        public Alterar()
        {
            InitializeComponent();
            lista();
        }

        public void Chamarbanco()
        {
            ConectaBanco conecta = new ConectaBanco();
            conecta.conexao();
        }

        private void lista()
        {
            Chamarbanco();

            MySqlCommand comando = new MySqlCommand
            {
                Connection = ConectaBanco.conect
            };
            DateTime semana = hoje.AddDays(-15);

            try
            {
                string query = "SELECT PLACA FROM ENTRADA_SAIDA WHERE " +
                    "HORAENTRADA BETWEEN '" + semana.ToString("yyyy-MM-dd") + "' AND " +
                    " '" + hoje.ToString("yyyy-MM-dd 23:59:59") + "'";
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

        private void placas()

        {
            placa = cbplaca.Text;
            dataentrada = Convert.ToDateTime(txthentrada.Text);
            datasaida = Convert.ToDateTime(txthsaida.Text);
            descricao = Convert.ToString(txtdescricao.Text);
            tempo = Convert.ToDateTime(txttempo.Text);
            vlrapagar = Convert.ToString(txtvlrpagar.Text);

            try
            {
                Chamarbanco();

                MySqlCommand comando = new MySqlCommand
                {
                    Connection = ConectaBanco.conect
                };

                string select = "SELECT HANDLE FROM ENTRADA_SAIDA WHERE " +
                    "PLACA='" + placa.ToString() + "'";
                comando.CommandText = select;

                int handle = int.Parse(comando.ExecuteScalar() + "");

                string query = " UPDATE ENTRADA_SAIDA SET " +
                    "HORAENTRADA ='" + dataentrada.ToString("yyyy-MM-dd HH:mm:ss") +
                    "', HORASAIDA = '" + datasaida.ToString("yyyy-MM-dd HH:mm:ss") +
                    "', DESCRICAO = '" + descricao.ToString() +
                    "', TEMPO = '" + tempo.ToString("HH:mm:ss") +
                    "', VALORAPAGAR = '" + vlrapagar.ToString() +
                    "' WHERE HANDLE = " + handle.ToString();


                comando.CommandText = query;
                comando.ExecuteNonQuery();

                MessageBox.Show("Valores alterados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" +
                    "Erro: " + ex.Message);
            }
            

        }

        private void limpar()
        {
            txthentrada.Text = "";
            txthsaida.Text = "";
            txtdescricao.Text = "";
            txttempo.Text = "";
            txtvlrpagar.Text = "";
        }
        private void Alterar_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja excluir ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           
                {
                placa = cbplaca.Text;
                
                try
                {
                    Chamarbanco();

                    MySqlCommand comando = new MySqlCommand
                    {
                        Connection = ConectaBanco.conect
                    };

                    string select = "SELECT HANDLE FROM ENTRADA_SAIDA WHERE " +
                        "PLACA='" + placa.ToString() + "'";
                    comando.CommandText = select;

                    int handle = int.Parse(comando.ExecuteScalar() + "");

                    string delete = " DELETE FROM ENTRADA_SAIDA  " +
                        " WHERE HANDLE = " + handle.ToString();


                    comando.CommandText = delete;
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Documento excluido.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
            limpar();
        }

       private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            placas();
            limpar();
        }

        private void cbplaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista();
        }
    }
}
