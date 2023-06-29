namespace WebApplication2.NewFolder3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocLuc")]
    public partial class HocLuc
    {
        [Key]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
