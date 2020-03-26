using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Entrada 
        : Form
    {
        private MySqlConnection conect;
        private MySqlCommand objsql;

        DateTime dataentrada;
        String descricao, placa;
        public Entrada()
        {
            InitializeComponent();
            
            txthentrada.Text = DateTime.Now.ToString();
        }

        private void conectabanco()
        {
            conect = new MySqlConnection("server=localhost;" +
            "user id=root;password=Thais123;database=bancoestacionamento;" +
            "Convert Zero Datetime = true");
            conect.Open();
        }

        public void inserirentrada()
        {
            if (string.IsNullOrWhiteSpace(txthentrada.Text) ||
                string.IsNullOrWhiteSpace(txtdesc.Text) ||
                string.IsNullOrWhiteSpace(txtplaca.Text)
                )

            {
                MessageBox.Show("Preencha todas as informações");
            }else
            {
                dataentrada = Convert.ToDateTime(txthentrada.Text);
                placa = Convert.ToString(txtplaca.Text);
                descricao = Convert.ToString(txtdesc.Text);

                try
                {
                    conectabanco();

                    objsql = new MySqlCommand("INSERT INTO ENTRADA_SAIDA " +
                    "(PLACA, HORAENTRADA, DESCRICAO) VALUES('" + placa +
                    "','" + dataentrada.ToString("yyyy-MM-dd HH:mm:ss") + 
                    "','" + descricao + "')", conect);

                    
                    objsql.ExecuteNonQuery();
                    conect.Close();
                    MessageBox.Show("Entrada incluída.");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" +
                        "Erro: " + ex.Message);
                }
            }
        }

        public void limpar()
        {
            txtplaca.Text = "";
            txthentrada.Text = "";
            txtdesc.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserirentrada();
            limpar();
        }
    }
}
