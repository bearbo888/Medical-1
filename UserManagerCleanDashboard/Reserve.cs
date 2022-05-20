//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medical
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reserve()
        {
            this.CaseRecords = new HashSet<CaseRecord>();
        }
    
        public int ReserveID { get; set; }
        public int ClinicDetailID { get; set; }
        public Nullable<int> StateID { get; set; }
        public int MemberID { get; set; }
        public System.DateTime ReserveDate { get; set; }
        public string Remark_Patient { get; set; }
        public string Remark_Admin { get; set; }
        public Nullable<int> SourceID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaseRecord> CaseRecords { get; set; }
        public virtual ClinicDetail ClinicDetail { get; set; }
        public virtual Member Member { get; set; }
        public virtual Source Source { get; set; }
        public virtual State State { get; set; }
    }
}
