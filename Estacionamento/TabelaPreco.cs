using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Estacionamento
{
    public partial class TabelaPreco : Form

    {
        private MySqlConnection conect;
        private MySqlCommand objsql;
        private MySqlDataAdapter objAdapter;
        private DataSet mDataSet;

        DateTime data1, data2;
        double precoporhora, adicional;
        string periodo;
        

        private void conectabanco()
        {
            conect = new MySqlConnection("server=localhost;" +
            "user id=root;password=Thais123;database=bancoestacionamento;" +
            "Convert Zero Datetime = true");
            conect.Open();
        }

        private void mostraResultados()
        {
            mDataSet = new DataSet();

            conectabanco();

            objAdapter = new MySqlDataAdapter("SELECT DATAINICIAL,DATAFINAL,PRECO,ADICIONAL" +
                ",PERIODO FROM TABELAPRECOS ORDER BY DATAINICIAL", conect);

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

                    objsql = new MySqlCommand("INSERT INTO tabelaprecos " +
                    "(DATAINICIAL, DATAFINAL, PRECO, ADICIONAL, PERIODO) VALUES('" +
                    data1.ToString("yyyy-MM-dd hh:mm:ss") +
                    "','" + data2.ToString("yyyy-MM-dd hh:mm:ss") +
                    "','" + precoporhora.ToString("0.00").Replace(",", ".") +
                    "','" + adicional.ToString("0.00").Replace(",", ".") +
                    "','" + periodo + "')", conect);


                    objsql.ExecuteNonQuery();
                    conect.Close();
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
                    objsql = new MySqlCommand("SELECT HANDLE FROM TABELAPRECOS " +
                    "WHERE PERIODO ='" + periodo + "'", conect);

                    int handle;
                    handle = int.Parse(objsql.ExecuteScalar() + "");
                    objsql = new MySqlCommand("UPDATE TABELAPRECOS SET " +
                        " DATAINICIAL ='" + data1.ToString("yyyy-MM-dd hh:mm:ss") +
                        "', DATAFINAL ='" + data2.ToString("yyyy-MM-dd hh:mm:ss") +
                        "', PRECO = " + precoporhora.ToString("0.00").Replace(",", ".") +
                        ", ADICIONAL = " + adicional.ToString("0.00").Replace(",", ".") +
                        " WHERE HANDLE = " + handle + "", conect);

                    objsql.ExecuteNonQuery();
                    conect.Close();
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
                conectabanco();

                objsql = new MySqlCommand("SELECT HANDLE FROM TABELAPRECOS " +
                    "WHERE PERIODO ='" + periodo + "'", conect);

                int handle;

                data1 = Convert.ToDateTime(datainicial.Text);
                data2 = Convert.ToDateTime(datafinal.Text);
                precoporhora = Convert.ToDouble(precohora.Text);
                adicional = Convert.ToDouble(txtadicional.Text);
                periodo = Convert.ToString(txtano.Text);

                try
                {

                    handle = int.Parse(objsql.ExecuteScalar() + "");

                    objsql = new MySqlCommand("DELETE FROM TABELAPRECOS" +
                        " WHERE HANDLE = " + handle + "", conect);

                    objsql.ExecuteNonQuery();
                    conect.Close();
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
