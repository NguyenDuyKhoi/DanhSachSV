namespace WebApplication2.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;
    using System.Data.Entity.Spatial;
    using System.Net.Cache;
    using System.Configuration;
    using System.Globalization;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        public int ID { get; set; }
        [VietnameseNoSpecialCharacter]       
   
        [Display(Name ="Họ và tên")]
        [Required(ErrorMessage ="Mời nhập tên")]
        [StringLength(200)]
        public string FullName { get; set; }
       
        [Display(Name ="Ngày sinh nhật")]
        [Required(ErrorMessage = "Mời nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngay { get; set; }
     
        [StringLength(50)]
        [Display(Name ="Giới tính")]
        public string Sex { get; set; }
        public IEnumerable<SelectListItem> GenderList { get; set; }
        [Display(Name ="Địa chỉ")]
        [Required(ErrorMessage = "Mời nhập địa chỉ")]
        [StringLength(500)]
        public string Adress { get; set; }
        [Display(Name ="Số điện thoại")]
        [Required(ErrorMessage = "Mời nhập số điện thoại")]
        [StringLength(30)]
   
        public string Phone { get; set; }
        [Display(Name = "Điểm toán")]
        [Required(ErrorMessage = "Mời nhập điểm toán")]
        [Range(0, 10, ErrorMessage = "Điểm phải lớn hơn 0 hoặc nhỏ hơn 10")]
        public double DiemToan { get; set; }
        [Required(ErrorMessage = "Mời nhập điểm văn")]
        [Display(Name = "Điểm văn")]
        [Range(0, 10, ErrorMessage = "Điểm phải lớn hơn 0 hoặc nhỏ hơn 10")]
        public double DiemVan { get; set; }
        [Display(Name = "Điểm Anh")]
        [Required(ErrorMessage = "Mời nhập điểm anh")]
        [Range(0, 10, ErrorMessage = "Điểm phải lớn hơn 0 hoặc nhỏ hơn 10")]
        public double
            DiemAnh { get; set; }
        [Display(Name = "Học lực")]
        public string HocLuc { get; set; }
    }
}
