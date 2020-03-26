using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Form1 : Form

    {
        private MySqlConnection conect;
        private MySqlDataAdapter objAdapter;
        private DataSet mDataSet;

        public Form1()
        {
            InitializeComponent();
            mostrarentradaesaida();
        }

        private void conectabanco()
        {
            conect = new MySqlConnection("server=localhost;" +
            "user id=root;password=Thais123;database=bancoestacionamento;" +
            "Convert Zero Datetime = true");
            conect.Open();
        }

        
        private void mostrarentradaesaida()
        {
            mDataSet = new DataSet();

            conectabanco();

            objAdapter = new MySqlDataAdapter("SELECT HORAENTRADA ENTRADA,HORASAIDA SAÍDA" +
                ",TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA ORDER BY HORAENTRADA DESC", conect);

            objAdapter.Fill(mDataSet, "ENTRADA_SAIDA");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "ENTRADA_SAIDA";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Saida saida = new Saida();
            saida.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabelaDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaPreco tabelapreco = new TabelaPreco();
            tabelapreco.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            conectabanco();
            DateTime hoje = DateTime.Now;
            mDataSet = new DataSet();

            objAdapter = new MySqlDataAdapter("SELECT HORAENTRADA ENTRADA,HORASAIDA SAÍDA" +
                 ",TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA WHERE HORAENTRADA " +
                 ">= '" + hoje.ToString("yyyy-MM-dd") + "'", conect);


            objAdapter.Fill(mDataSet, "tabela");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "tabela";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            conectabanco();
            DateTime hoje = DateTime.Now;
            mDataSet = new DataSet();
            DateTime semana = hoje.AddDays(-7);

            objAdapter = new MySqlDataAdapter("SELECT HORAENTRADA ENTRADA,HORASAIDA " +
                "SAÍDA,TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA   " +
                "WHERE HORAENTRADA >= '" + semana.ToString("yyyy-MM-dd") + " HORASAIDA" +
                ">= "+ hoje.ToString("yyyy-MM-dd") + "'", conect);


            objAdapter.Fill(mDataSet, "tabela");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "tabela";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            
            dataGridView1.DataSource = null;

            conectabanco();
            
            mDataSet = new DataSet();

            objAdapter = new MySqlDataAdapter("SELECT HORAENTRADA ENTRADA,HORASAIDA " +
                "SAÍDA,TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA   " +
                "WHERE HORAENTRADA <= '" + hoje.ToString("yyyy-MM-dd") +"' AND HORASAIDA" +
                ">= '" + hoje.ToString("yyyy-MM") + "-01'", conect);


            objAdapter.Fill(mDataSet, "tabela");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "tabela";
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;

            dataGridView1.DataSource = null;

            conectabanco();

            mDataSet = new DataSet();

            objAdapter = new MySqlDataAdapter("SELECT HORAENTRADA ENTRADA,HORASAIDA " +
                "SAÍDA,TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA   " +
                "WHERE HORAENTRADA >= '" + hoje.ToString("yyyy") + "-01-01' AND HORASAIDA" +
                "<= '" + hoje.ToString("yyyy") + "-12-31'", conect);


            objAdapter.Fill(mDataSet, "tabela");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "tabela";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            mostrarentradaesaida();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar();
            alterar.ShowDialog();
        }
    }
}
