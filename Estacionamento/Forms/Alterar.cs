using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Alterar : Form
    {
        public MySqlDataReader DataReader { get; set; }
        public DateTime Hoje { get => hoje; set => hoje = value; }

        DateTime hoje = DateTime.Now;
        string placa, descricao, vlrapagar;
        private DateTime dataentrada, datasaida, tempo;

        // Função que chama todos os metodos.  
        public Alterar()
        {
            InitializeComponent();
            Lista();
        }

        // Método chama a função para conectar com o banco.
        public void Chamarbanco()
        {
            ConectaBanco conecta = new ConectaBanco();
            conecta.Conexao();
        }

        // Método para listar as placas.
        private void Lista()
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

        // Método para achar o handle e alterar as informações.
        private void Placas()

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

        // Método para limpar os campos.
        private void Limpar()
        {
            txthentrada.Text = "";
            txthsaida.Text = "";
            txtdescricao.Text = "";
            txttempo.Text = "";
            txtvlrpagar.Text = "";
        }

        //Botão de excluir.
        private void BtnExcluir(object sender, EventArgs e)
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
            Limpar();
        }

        //Botão de alterar.
        private void BtnAlterar(object sender, EventArgs e)
        {
            Placas();
            Limpar();
        }

        //Combox com as listas de placas.
        private void CbPlaca(object sender, EventArgs e)
        {
            Lista();
        }
    }
}
