//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostImage
    {
        public int ID { get; set; }
        public Nullable<int> PostID { get; set; }
        public string ImagePath { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> LastUpdateUserID { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
    }
}
