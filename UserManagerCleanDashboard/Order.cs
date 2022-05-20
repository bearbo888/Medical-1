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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> CityID { get; set; }
        public string ShipAddress { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<int> OrderStateID { get; set; }
        public Nullable<int> PayTypeID { get; set; }
        public Nullable<int> ShipTypeID { get; set; }
    
        public virtual City City { get; set; }
        public virtual Member Member { get; set; }
        public virtual Orderstate Orderstate { get; set; }
        public virtual Paytype Paytype { get; set; }
        public virtual ShipType ShipType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
