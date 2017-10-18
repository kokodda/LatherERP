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
    
    public partial class INV_WetBlueStockDaily
    {
        public long TransectionID { get; set; }
        public Nullable<System.DateTime> StockDate { get; set; }
        public Nullable<byte> StoreID { get; set; }
        public Nullable<byte> ItemTypeID { get; set; }
        public Nullable<byte> LeatherTypeID { get; set; }
        public Nullable<byte> LeatherStatusID { get; set; }
        public Nullable<short> GradeID { get; set; }
        public Nullable<decimal> OpeningStockPcs { get; set; }
        public Nullable<decimal> OpeningStockSide { get; set; }
        public Nullable<decimal> OpeningStockArea { get; set; }
        public Nullable<decimal> ReceiveStockPcs { get; set; }
        public Nullable<decimal> ReceiveStockSide { get; set; }
        public Nullable<decimal> ReceiveStockArea { get; set; }
        public Nullable<decimal> IssueStockPcs { get; set; }
        public Nullable<decimal> IssueStockSide { get; set; }
        public Nullable<decimal> IssueStockArea { get; set; }
        public Nullable<decimal> ClosingStockPcs { get; set; }
        public Nullable<decimal> ClosingStockSide { get; set; }
        public Nullable<decimal> ClosingStockArea { get; set; }
        public Nullable<byte> AreaUnit { get; set; }
        public Nullable<byte> SizeID { get; set; }
        public string SizeQtyRef { get; set; }
    
        public virtual Sys_Unit Sys_Unit { get; set; }
        public virtual Sys_Grade Sys_Grade { get; set; }
        public virtual Sys_ItemType Sys_ItemType { get; set; }
        public virtual Sys_LeatherStatus Sys_LeatherStatus { get; set; }
        public virtual Sys_LeatherType Sys_LeatherType { get; set; }
        public virtual SYS_Store SYS_Store { get; set; }
        public virtual Sys_Size Sys_Size { get; set; }
    }
}