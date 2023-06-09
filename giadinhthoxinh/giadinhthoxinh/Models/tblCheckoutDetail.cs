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

    public partial class tblCheckoutDetail
    {
        [Display(Name = "Mã chi tiết hóa đơn bán")]
        public int PK_iCheckoutDetailID { get; set; }
        [Display(Name = "Mã hóa đơn bán")]
        public int FK_iOrderID { get; set; }
        [Display(Name = "Mã sản phẩm")]
        public int FK_iProductID { get; set; }
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]
        public int iQuantity { get; set; }
        [Display(Name = "Giá bán")]
        [Required(ErrorMessage = "Vui lòng nhập giá bán")]
        public double fPrice { get; set; }

        public virtual tblOrder tblOrder { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}
