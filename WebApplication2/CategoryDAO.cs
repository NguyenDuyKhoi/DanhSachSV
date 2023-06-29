using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.NewFolder2;


namespace WebApplication2
{
    public class CategoryDAO
    {
        private Model1 context = null;
        public CategoryDAO()
        {
            context = new Model1();
        }
        public List<Category> ListAll()
        {
            return context.Categories.ToList();
        }
       
    }
}