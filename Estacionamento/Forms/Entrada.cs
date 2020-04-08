using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Estacionamento
{
    public partial class Entrada : Form
    {
        DateTime dataentrada;
        String descricao, placa;

        // Inicializa o formulario. 
        public Entrada()
        {
            InitializeComponent();          
            txthentrada.Text = DateTime.Now.ToString();

        }
        
        // Limpa o formulario.
        public void Limpar()
        {
            txtplaca.Text = "";
            txthentrada.Text = "";
            txtdesc.Text = "";
        }

        // Método chama a função para conectar com o banco.
        public void ChamarBanco()
        {
            ConectaBanco conecta = new ConectaBanco();
            conecta.Conexao();
        }

        // Inseri os valore no banco
        public void InserirEntrada()
        {
            if (string.IsNullOrWhiteSpace(txthentrada.Text) ||
                string.IsNullOrWhiteSpace(txtdesc.Text) ||
                string.IsNullOrWhiteSpace(txtplaca.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações");
            }
            else
            {
                dataentrada = Convert.ToDateTime(txthentrada.Text);
                placa = Convert.ToString(txtplaca.Text);
                descricao = Convert.ToString(txtdesc.Text);

                try
                {
                    ChamarBanco();

                    MySqlCommand comando = new MySqlCommand
                    {
                        Connection = ConectaBanco.conect
                    };

                    string query = "INSERT INTO ENTRADA_SAIDA " +
                    "(PLACA, HORAENTRADA, DESCRICAO) VALUES('" + placa +
                    "','" + dataentrada.ToString("yyyy-MM-dd HH:mm:ss") +
                    "','" + descricao + "')";

                    comando.CommandText = query;

                    comando.ExecuteNonQuery();;
                    MessageBox.Show("Entrada incluída.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        //Botão para salvar.
        private void BntSalvar(object sender, EventArgs e)
        {
            InserirEntrada();
            Limpar();
        }
    }
}
