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

    public partial class tblUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUser()
        {
            this.tblImportOrders = new HashSet<tblImportOrder>();
            this.tblOrders = new HashSet<tblOrder>();
            this.tblReviews = new HashSet<tblReview>();
        }
    
        [Display(Name = "Mã tài khoản")]
        public int PK_iAccountID { get; set; }
        [Display(Name = "Mã quyền")]
        public int FK_iPermissionID { get; set; }
        [Display(Name = "Email")]
        public string sEmail { get; set; }
        [Display(Name = "Mật khẩu")]
        public string sPass { get; set; }
        [Display(Name = "Tên người dùng")]
        public string sUserName { get; set; }
        [Display(Name = "SĐT")]
        public string sPhone { get; set; }
        [Display(Name = "Địa chỉ")]
        public string sAddress { get; set; }
        [Display(Name = "Trạng thái")]
        public Nullable<int> iState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblImportOrder> tblImportOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrder> tblOrders { get; set; }
        public virtual tblPermission tblPermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReview> tblReviews { get; set; }
    }
}
