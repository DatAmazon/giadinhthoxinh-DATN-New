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

    public partial class tblMaterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMaterial()
        {
            this.tblImportMaterials = new HashSet<tblImportMaterial>();
            this.tblMaterColors = new HashSet<tblMaterColor>();
            this.tblMaterPriceImports = new HashSet<tblMaterPriceImport>();
            this.tblMaterSizes = new HashSet<tblMaterSize>();
        }
        [Display(Name = "Mã nguyên liệu")]
        public int PK_iMaterialID { get; set; }
        [Display(Name = "Tên nguyên liệu")]
        [Required(ErrorMessage = "Vui lòng nhập tên nguyên liệu")]
        public string sMaterialName { get; set; }
        [Display(Name = "Mô tả")]
        public string sDescribe { get; set; }
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]
        public int iQuatity { get; set; }
        [Display(Name = "Đơn vị")]
        [Required(ErrorMessage = "Vui lòng nhập đơn vị")]
        public string sUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblImportMaterial> tblImportMaterials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMaterColor> tblMaterColors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMaterPriceImport> tblMaterPriceImports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMaterSize> tblMaterSizes { get; set; }
    }
}
