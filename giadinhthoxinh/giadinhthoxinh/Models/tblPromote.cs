﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace giadinhthoxinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblPromote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPromote()
        {
            this.tblProducts = new HashSet<tblProduct>();
        }
    
        [Display(Name = "Mã khuyến mãi")]
        public int PK_iPromoteID { get; set; }
        [Display(Name = "Tên khuyến mãi")]
        public string sPromoteName { get; set; }
        [Display(Name = "Tỉ lệ khuyến mãi")]
        public Nullable<double> sPromoteRate { get; set; }
        [Display(Name = "Ngày bắt đầu")]
        public Nullable<System.DateTime> dtStartDay { get; set; }
        [Display(Name = "Ngày kết thúc")]
        public Nullable<System.DateTime> dtEndDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProducts { get; set; }
    }
}
