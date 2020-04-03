using MySql.Data.MySqlClient;

namespace Estacionamento
{
    class ConectaBanco 
    {
        public static MySqlConnection conect = null;
        public void conexao()
        {
            string banco = "server=localhost;" +
            "user id=root;password=Thais123;database=bancoestacionamento;" +
            "Convert Zero Datetime = true";

            conect = new MySqlConnection(banco);

            conect.Open();

        }

    }
}
