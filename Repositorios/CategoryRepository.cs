using Gallery.Models;
using Gallery.View.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Repositorios
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Componentes> { new Componentes { Titulo = "StackLayout", Descricao = "Organizacao sequencial dos elementos", Pagina = new StackLayoutPage() } }
            });
            return categories;
        }
    }
}
