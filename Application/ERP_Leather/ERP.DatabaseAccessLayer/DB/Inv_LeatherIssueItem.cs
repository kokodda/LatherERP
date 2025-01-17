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
    
    public partial class Inv_LeatherIssueItem
    {
        public long ItemIssueID { get; set; }
        public long IssueID { get; set; }
        public int SupplierID { get; set; }
        public Nullable<long> ChallanID { get; set; }
        public long PurchaseID { get; set; }
        public byte ItemType { get; set; }
        public byte LeatherType { get; set; }
        public byte LeatherStatus { get; set; }
        public decimal IssueQty { get; set; }
        public byte UnitID { get; set; }
        public Nullable<int> IssueSide { get; set; }
        public string Remarks { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual Inv_LeatherIssue Inv_LeatherIssue { get; set; }
        public virtual Prq_Purchase Prq_Purchase { get; set; }
        public virtual Sys_ItemType Sys_ItemType { get; set; }
        public virtual Sys_LeatherStatus Sys_LeatherStatus { get; set; }
        public virtual Sys_LeatherType Sys_LeatherType { get; set; }
        public virtual Sys_Supplier Sys_Supplier { get; set; }
        public virtual Sys_Unit Sys_Unit { get; set; }
        public virtual Prq_PurchaseChallan Prq_PurchaseChallan { get; set; }
    }
}
