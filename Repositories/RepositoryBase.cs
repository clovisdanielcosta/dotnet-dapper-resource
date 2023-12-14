using MySqlConnector;

namespace DapperRepositoryResource.Repositories
{
    public class RepositoryBase
    {
        public MySqlConnection CriarConexaoAberta()
        {
            var host = "";
            var port = "";
            var database = "";
            var username = "";
            var password = "";

            var connectionString = $"server='{host}';port='{port}';database='{database}';uid='{username}';password='{password}'";

            return new MySqlConnection(connectionString);
        }
    }
}
