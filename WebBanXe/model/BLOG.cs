//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanXe.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BLOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BLOG()
        {
            this.IMG_BLOG = new HashSet<IMG_BLOG>();
        }
    
        public int IdBlog { get; set; }
        public int IdCate { get; set; }
        public int IdUser { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCreate { get; set; }
    
        public virtual CATEGORY_BLOG CATEGORY_BLOG { get; set; }
        public virtual USER USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMG_BLOG> IMG_BLOG { get; set; }
    }
}
