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

    public partial class tblMaterColor
    {
        [Display(Name = "Mã màu nguyên liệu")]
        public int PK_iMaterColorID { get; set; }
        [Display(Name = "Mã nguyên liệu")]
        public int FK_iMaterialID { get; set; }
        [Display(Name = "Màu nguyên liệu")]
        [Required(ErrorMessage = "Vui lòng nhập màu sắc")]
        public string sMaterColor { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }
    }
}
