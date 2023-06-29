using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.NewFolder3;

namespace WebApplication2
{
    public class Class1
    {
        private Model1 context = null;
        public Class1()
        {
            context = new Model1();
        }
        public List<HocLuc> ListAll()
        {
            return context.HocLucs.ToList();
        }
    }
}