using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WebApplication2.NewFolder1;


namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(string strSearch)
        {
            var ipClate = new ListModel();
            var model = ipClate.List();
            if (!String.IsNullOrEmpty(strSearch))
            {
                model = model.Where(x => x.FullName.Contains(strSearch)|| x.Adress.Contains(strSearch)).ToList();
            }
            ViewBag.strSearch=strSearch;
            return View(model);
            
        }
       
        public ActionResult Create() 
        {
            SetViewBag();
            SetViewBag1(); 
            return View();
        }
        public void SetViewBag(long? SelectedID = null)
        {
            var dao = new CategoryDAO();
            ViewBag.Sex = new SelectList(dao.ListAll(), "Title", "Name", SelectedID);
        }
        public void SetViewBag1(long? SelectedID = null)
        {
            var dao = new Class1();
            ViewBag.HocLuc = new SelectList(dao.ListAll(), "Title", "Name", SelectedID);
        }
        [HttpPost]
        public ActionResult Create(SinhVien stu)
        {
            if (ModelState.IsValid)
            {
                var stuList = new ListModel();
                var k = Math.Round(stu.DiemToan, 1);
                var b= Math.Round(stu.DiemVan, 1);
                var c= Math.Round(stu.DiemAnh, 1);
                stuList.Create(stu.FullName,stu.Ngay,stu.Sex,stu.Adress,stu.Phone,k,b,c,stu.HocLuc) ;
                
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit (int ID)
        {
            SetViewBag();
            SetViewBag1();
            var model = new ListModel().Select(ID);
            
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(SinhVien stu)
        {

            ListModel stuList = new ListModel();
            
            stuList.Edit(stu.ID,stu.FullName, stu.Ngay, stu.Sex, stu.Adress, stu.Phone, stu.DiemToan, stu.DiemVan, stu.DiemAnh, stu.HocLuc);

            return RedirectToAction("Index");


        }
        public ActionResult Delete(int ID )
        {
            var model = new ListModel().Select(ID);

            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(SinhVien stu)
        {

            ListModel stuList = new ListModel();

            stuList.Delete(stu.ID);

            return RedirectToAction("Index");

        }
    }
}