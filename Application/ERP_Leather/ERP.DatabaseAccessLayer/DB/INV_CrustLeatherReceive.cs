//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.DatabaseAccessLayer.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class INV_CrustLeatherReceive
    {
        public INV_CrustLeatherReceive()
        {
            this.INV_CrustLeatherReceiveColor = new HashSet<INV_CrustLeatherReceiveColor>();
            this.INV_CrustLeatherReceiveItem = new HashSet<INV_CrustLeatherReceiveItem>();
            this.INV_CrustLeatherReceiveRef = new HashSet<INV_CrustLeatherReceiveRef>();
        }
    
        public long CLReceiveID { get; set; }
        public string CLReceiveNo { get; set; }
        public Nullable<System.DateTime> CLReceiveDate { get; set; }
        public string ReceiveCategory { get; set; }
        public string ReceiveFor { get; set; }
        public Nullable<byte> IssueFrom { get; set; }
        public Nullable<byte> ReceiveAt { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<int> ReceiveBy { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public string ReceiveNote { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public string CheckNote { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual User User { get; set; }
        public virtual SYS_Store SYS_Store { get; set; }
        public virtual User User1 { get; set; }
        public virtual SYS_Store SYS_Store1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
        public virtual ICollection<INV_CrustLeatherReceiveColor> INV_CrustLeatherReceiveColor { get; set; }
        public virtual ICollection<INV_CrustLeatherReceiveItem> INV_CrustLeatherReceiveItem { get; set; }
        public virtual ICollection<INV_CrustLeatherReceiveRef> INV_CrustLeatherReceiveRef { get; set; }
    }
}
