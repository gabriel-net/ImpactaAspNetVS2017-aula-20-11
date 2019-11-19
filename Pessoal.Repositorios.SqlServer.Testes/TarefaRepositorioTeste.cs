using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pessoal.Repositorios.SqlServer.Testes
{
    [TestClass]
    public class TarefaRepositorioTeste
    {
        private TarefaRepositorio repositorio;

        public TarefaRepositorioTeste()
        {
            var config = new ConfigurationBuilder().AddJasonFile("appsettings.json").Build();
                
                

            repositorio = new TarefaRepositorio(config.GetConnectionString("pessoalSqlServer"));
        }

        [TestMethod]
        public void InserirTeste()
        {

        }
    }
}
