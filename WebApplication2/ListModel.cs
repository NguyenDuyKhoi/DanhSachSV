using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using WebApplication2.NewFolder1;

namespace WebApplication2
{
    public class ListModel
    {
        private Model1 context = null;
        public ListModel() { 
            context = new Model1();
        }
        public List<SinhVien> List( ) {
            var list = context.Database.SqlQuery< SinhVien > ("SelectAllSinhVien").ToList();
            return list;
        }
        public SinhVien Select(int ID)
        {
            return context.SinhViens.Find(ID);
        }
        public string Create(string FullName,DateTime Ngay,string Sex,string Adress, string Phone,double DiemToan,double DiemVan,double DiemAnh,string HocLuc)
        {
            object[] parameters=
            {

                new SqlParameter("@FullName",FullName),
               
                new SqlParameter("@Date",Ngay),
                new SqlParameter("@Sex",Sex),
                new SqlParameter("@Adress",Adress),
                new SqlParameter("@Phone",Phone),
                new SqlParameter("@DiemToan",DiemToan),
                new SqlParameter("@DiemVan",DiemVan),
                new SqlParameter("@DiemAnh",DiemAnh),
                new SqlParameter("@HocLuc",HocLuc)
            };
            string res = Convert.ToString(context.Database.ExecuteSqlCommand("ThemMoiSinhhVien @FullName,@Date,@Sex,@Adress,@Phone,@DiemToan,@DiemVan,@DiemAnh,@HocLuc", parameters));
            return res;
        }
        
        public string Edit(int ID,string FullName, DateTime Ngay, string Sex, string Adress, string Phone, double DiemToan, double DiemVan, double DiemAnh, string HocLuc)
        {
            object[] parameters =
            {
                new SqlParameter("@ID", ID),
                new SqlParameter("@FullName",FullName),
               
                new SqlParameter("@Date",Ngay),
                new SqlParameter("@Sex",Sex),
                new SqlParameter("@Adress",Adress),
                new SqlParameter("@Phone",Phone),
                new SqlParameter("@DiemToan",DiemToan),
                new SqlParameter("@DiemVan",DiemVan),
                new SqlParameter("@DiemAnh",DiemAnh),
                new SqlParameter("@HocLuc",HocLuc)
            };
            var edit = Convert.ToString(context.Database.ExecuteSqlCommand("updateSV  @ID,@FullName,@Date,@Sex,@Adress,@Phone,@DiemToan,@DiemVan,@DiemAnh,@HocLuc", parameters));
            return edit;
        }
        public string Delete(int ID)
        {
            object[] parameters =
            {
                new SqlParameter("@ID", ID),
               
            };
            var delete= Convert.ToString(context.Database.ExecuteSqlCommand("DeleteSV  @ID", parameters));
            return delete;
        }
    }
}