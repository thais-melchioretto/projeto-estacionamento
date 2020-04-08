using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Estacionamento : Form

    {
        private MySqlDataAdapter objAdapter;
        private DataSet mDataSet;

        // Inicializa o formulario. 
        public Estacionamento()
        {
            InitializeComponent();
            MostrarEntradaSaida();

        }

        // Método chama a função para conectar com o banco.
        public void Chamarbanco()
        {
            ConectaBanco conecta = new ConectaBanco();
            conecta.Conexao();
        }

        // Mostra o grid com as infomações do banco.
        private void MostrarEntradaSaida()
        {
            mDataSet = new DataSet();

            Chamarbanco();

            MySqlCommand comando = new MySqlCommand
            {
                Connection = ConectaBanco.conect
            };

            objAdapter = new MySqlDataAdapter();

            string query = "SELECT HORAENTRADA ENTRADA,HORASAIDA SAÍDA" +
                ",TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA ORDER BY HORAENTRADA DESC";
            comando.CommandText = query;

            objAdapter.SelectCommand = comando;

            objAdapter.Fill(mDataSet, "ENTRADA_SAIDA");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "ENTRADA_SAIDA";
        }

        // Botão para abrir o formulario de saida.
        private void BtnSaida(object sender, EventArgs e)
        {
            Saida saida = new Saida();
            saida.ShowDialog();

        }

        // Botão para abrir o formulario de entrada.
        private void BtnEntrada(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.ShowDialog();
        }

        // Botão para abrir o formulario de preços.
        private void TabelaDePrecos(object sender, EventArgs e)
        {
            TabelaPreco tabelapreco = new TabelaPreco();
            tabelapreco.ShowDialog();
        }

        // Botão para trazer as informações do dia.
        private void BtnDia(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            Chamarbanco();

            MySqlCommand comando = new MySqlCommand
            {
                Connection = ConectaBanco.conect
            };

            DateTime hoje = DateTime.Now;
            mDataSet = new DataSet();

            objAdapter = new MySqlDataAdapter();

            string query = "SELECT HORAENTRADA ENTRADA,HORASAIDA SAÍDA" +
                 ",TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA WHERE HORAENTRADA " +
                 ">= '" + hoje.ToString("yyyy-MM-dd") + "'";

            comando.CommandText = query;
            objAdapter.SelectCommand = comando;

            objAdapter.Fill(mDataSet, "tabela");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "tabela";


        }

        // Botão para trazer as informações do semana.
        private void BtnSemana(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            Chamarbanco();

            MySqlCommand comando = new MySqlCommand
            {
                Connection = ConectaBanco.conect
            };

            DateTime hoje = DateTime.Now;
            mDataSet = new DataSet();
            DateTime semana = hoje.AddDays(-7);

            objAdapter = new MySqlDataAdapter();

            string query = "SELECT HORAENTRADA ENTRADA,HORASAIDA " +
                "SAÍDA,TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA   " +
                "WHERE HORAENTRADA >= '" + semana.ToString("yyyy-MM-dd") + " HORASAIDA" +
                ">= " + hoje.ToString("yyyy-MM-dd") + "'";

            comando.CommandText = query;
            objAdapter.SelectCommand = comando;

            objAdapter.Fill(mDataSet, "tabela");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "tabela";


        }

        // Botão para trazer as informações do mês.
        private void BtnMes(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            
            dataGridView1.DataSource = null;

            Chamarbanco();

            MySqlCommand comando = new MySqlCommand
            {
                Connection = ConectaBanco.conect
            };


            mDataSet = new DataSet();

            objAdapter = new MySqlDataAdapter();

            string query = "SELECT HORAENTRADA ENTRADA,HORASAIDA " +
                "SAÍDA,TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA   " +
                "WHERE HORAENTRADA <= '" + hoje.ToString("yyyy-MM-dd") + "' AND HORASAIDA" +
                ">= '" + hoje.ToString("yyyy-MM") + "-01'";

            comando.CommandText = query;
            objAdapter.SelectCommand = comando;


            objAdapter.Fill(mDataSet, "tabela");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "tabela";
            

        }

        // Botão para trazer as informações do ano.
        private void BtnAno(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;

            dataGridView1.DataSource = null;

            Chamarbanco();

            MySqlCommand comando = new MySqlCommand
            {
                Connection = ConectaBanco.conect
            };

            mDataSet = new DataSet();

            objAdapter = new MySqlDataAdapter();

            string query = "SELECT HORAENTRADA ENTRADA,HORASAIDA " +
                "SAÍDA,TEMPO,VALORAPAGAR PAGAR,PLACA,DESCRICAO FROM ENTRADA_SAIDA   " +
                "WHERE HORAENTRADA >= '" + hoje.ToString("yyyy") + "-01-01' AND HORASAIDA" +
                "<= '" + hoje.ToString("yyyy") + "-12-31'";

            comando.CommandText = query;
            objAdapter.SelectCommand = comando;


            objAdapter.Fill(mDataSet, "tabela");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "tabela";

        }

        // Botão para atualizar as informações no grid.
        private void BtnConsulta(object sender, EventArgs e)
        {
            MostrarEntradaSaida();
        }

        // Botão para abrir o formulario de para alterações.
        private void BntAlterar(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar();
            alterar.ShowDialog();
        }
    }
}
