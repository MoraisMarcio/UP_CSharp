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

        }

        public DbSet<Categoria> Categorias { get; set; } // Nome da tabela: Categorias

        public DbSet<Produto> Produtos { get; set; } // Nome da tabela: Produtos
    }
}
