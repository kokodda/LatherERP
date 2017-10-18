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
    
    public partial class INV_WetBlueIssueRef
    {
        public INV_WetBlueIssueRef()
        {
            this.INV_WetBlueIssueItem = new HashSet<INV_WetBlueIssueItem>();
        }
    
        public long WetBlueIssueRefID { get; set; }
        public Nullable<long> WetBlueIssueID { get; set; }
        public Nullable<long> WetBlueReqID { get; set; }
        public Nullable<int> BuyerID { get; set; }
        public Nullable<long> BuyerOrderID { get; set; }
        public Nullable<int> ArticleID { get; set; }
        public string ArticleNo { get; set; }
        public string ArticleChallanNo { get; set; }
        public string AvgSize { get; set; }
        public Nullable<byte> AvgSizeUnit { get; set; }
        public string SideDescription { get; set; }
        public string SelectionRange { get; set; }
        public string Thickness { get; set; }
        public Nullable<byte> ThicknessUnit { get; set; }
        public string ThicknessAt { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
        public Nullable<long> ArticleChallanID { get; set; }
    
        public virtual INV_WetBlueIssue INV_WetBlueIssue { get; set; }
        public virtual ICollection<INV_WetBlueIssueItem> INV_WetBlueIssueItem { get; set; }
        public virtual Sys_Article Sys_Article { get; set; }
        public virtual Sys_Unit Sys_Unit { get; set; }
        public virtual Sys_Buyer Sys_Buyer { get; set; }
        public virtual SLS_BuyerOrder SLS_BuyerOrder { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Sys_Unit Sys_Unit1 { get; set; }
        public virtual Sys_ArticleChallan Sys_ArticleChallan { get; set; }
    }
}