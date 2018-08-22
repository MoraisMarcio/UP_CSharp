using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos.DAL
{
    public class Contexto : DbContext   //  using System.Data.Entity;
    {
        //  Construtor
        public Contexto() : base("nomeStringConexao")  
        {
            //  App.config

  //          < connectionStrings >
  //            < add name = "nomeStringConexao"

  //                connectionString =
  //                "Data Source=(localdb)\MSSQLLOCALDB;
  //                Initial Catalog = CodeFirstDB;
  //                Integrated Security = True"

  //                providerName = "System.Data.SqlClient"
  //            />
  //        </ connectionStrings >
        }

        public DbSet<Categoria> Categorias { get; set; } // Nome da tabela: Categorias

        public DbSet<Produto> Produtos { get; set; } // Nome da tabela: Produtos
    }
}

