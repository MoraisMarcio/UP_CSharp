using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608_EFDatabaseFirst.Controllers
{
    class ProductController
    {
        void ProductInsert(Product product)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Product.Add(product);
            contexto.SaveChanges();
        }

        List<Product> ProductList()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.ToList();
        }

        Product ProductFindById(int id)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.Find(id);         
        }

        void ProductRemove(int id)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            Product productToRemove = contexto.Product.Find(id);

            if (productToRemove != null)
            {
                contexto.Product.Remove(productToRemove);
                contexto.SaveChanges();
            }
            
        }

        void ProductUpdate(int id, Product dadosAtualizados)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            Product productToUpdate = contexto.Product.Find(id);

            if (productToUpdate != null)
            {
                productToUpdate.Name = dadosAtualizados.Name;
                productToUpdate.Color = dadosAtualizados.Color;

                contexto.Entry(productToUpdate).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }          

        }
    }
}
