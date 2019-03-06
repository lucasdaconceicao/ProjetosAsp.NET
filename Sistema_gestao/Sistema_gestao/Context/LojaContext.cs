using Sistema_gestao.Models;
using System.Data.Entity;

namespace Sistema_gestao.Context
{
    public class LojaContext : DbContext
    {
        //string conexao = ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString.ToString();
        public DbSet<Produtos> produtos { get; set; }
 
    }
}