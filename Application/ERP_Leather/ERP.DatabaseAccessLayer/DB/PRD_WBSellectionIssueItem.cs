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
    
    public partial class PRD_WBSellectionIssueItem
    {
        public PRD_WBSellectionIssueItem()
        {
            this.PRD_WBSellectionIssueGrade = new HashSet<PRD_WBSellectionIssueGrade>();
        }
    
        public long WBSIssueItemID { get; set; }
        public Nullable<long> IssueID { get; set; }
        public string IssueNo { get; set; }
        public Nullable<long> WBSelectItemID { get; set; }
        public string WBSelectItemNo { get; set; }
        public Nullable<long> WBSelectionID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<long> PurchaseID { get; set; }
        public Nullable<byte> ItemTypeID { get; set; }
        public Nullable<byte> LeatherTypeID { get; set; }
        public Nullable<byte> LeatherStatusID { get; set; }
        public Nullable<decimal> ProductionPcs { get; set; }
        public Nullable<decimal> ProductionSide { get; set; }
        public Nullable<decimal> ProductionArea { get; set; }
        public Nullable<byte> ProductionAreaUnit { get; set; }
        public string LotNo { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual PRD_WBSelection PRD_WBSelection { get; set; }
        public virtual ICollection<PRD_WBSellectionIssueGrade> PRD_WBSellectionIssueGrade { get; set; }
        public virtual Sys_ItemType Sys_ItemType { get; set; }
        public virtual Sys_LeatherStatus Sys_LeatherStatus { get; set; }
        public virtual Sys_LeatherType Sys_LeatherType { get; set; }
        public virtual User User { get; set; }
        public virtual Sys_Unit Sys_Unit { get; set; }
        public virtual Prq_Purchase Prq_Purchase { get; set; }
        public virtual User User1 { get; set; }
        public virtual Sys_Supplier Sys_Supplier { get; set; }
        public virtual PRD_WBSelectionItem PRD_WBSelectionItem { get; set; }
    }
}
