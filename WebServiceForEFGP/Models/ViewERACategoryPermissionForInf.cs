//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceForEFGP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewERACategoryPermissionForInf
    {
        public long Id { get; set; }
        public long parentID { get; set; }
        public string name { get; set; }
        public string departmentID { get; set; }
        public string personnelID { get; set; }
        public string dicisionProcessLevel { get; set; }
        public bool deleted { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string partent_name { get; set; }
        public Nullable<long> Permission_ID { get; set; }
        public Nullable<long> ERACategoryID { get; set; }
        public Nullable<bool> isforAll { get; set; }
        public Nullable<bool> enable { get; set; }
        public string Permission_departmentID { get; set; }
        public Nullable<bool> Permission_deleted { get; set; }
        public Nullable<System.DateTime> Permission_DateCreated { get; set; }
        public string addActivityPersonnelID { get; set; }
        public string department { get; set; }
        public string personnel { get; set; }
        public string addActivityPersonnel { get; set; }
        public string Permission_department { get; set; }
    }
}
