using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Estacionamento
{
    public partial class Entrada : Form
    {
        DateTime dataentrada;
        String descricao, placa;

        public Entrada()
        {
            InitializeComponent();          
            txthentrada.Text = DateTime.Now.ToString();

        }
           
        public void Limpar()
        {
            txtplaca.Text = "";
            txthentrada.Text = "";
            txtdesc.Text = "";
        }

        public void Chamarbanco()
        {
            ConectaBanco conecta = new ConectaBanco();
            conecta.conexao();
        }

        public void Inserirentrada()
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
                    Chamarbanco();

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


        private void Bntsalvar_Click(object sender, EventArgs e)
        {
            Inserirentrada();
            Limpar();
        }
    }
}
