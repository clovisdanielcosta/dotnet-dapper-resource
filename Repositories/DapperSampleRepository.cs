using Dapper;
using DapperRepositoryResource.Models;
using DapperRepositoryResource.Repositories.Resources;

namespace DapperRepositoryResource.Repositories
{
    public class DapperSampleRepository : RepositoryBase
    {
        public async Task<SampleEntity> ObterExemploPorId(string id)
        {
            try
            {
                using var dbConnection = CriarConexaoAberta();

                return (await dbConnection.QueryAsync<SampleEntity>(SampleEntityResource.SampleEntityConsultaPorId,
                                        new { ID = id }, commandTimeout: 15)).FirstOrDefault()!;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
