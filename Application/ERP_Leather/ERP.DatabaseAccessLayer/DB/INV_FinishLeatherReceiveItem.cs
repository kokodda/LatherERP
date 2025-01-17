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
    
    public partial class INV_FinishLeatherReceiveItem
    {
        public INV_FinishLeatherReceiveItem()
        {
            this.INV_FinishLeatherReceiveColor = new HashSet<INV_FinishLeatherReceiveColor>();
        }
    
        public long FNReceiveItemID { get; set; }
        public Nullable<long> FNReceiveID { get; set; }
        public Nullable<long> FinishLeatherIssueID { get; set; }
        public Nullable<long> FinishLeatherIssueItemID { get; set; }
        public Nullable<int> BuyerID { get; set; }
        public Nullable<long> BuyerOrderID { get; set; }
        public Nullable<int> ArticleID { get; set; }
        public string ArticleNo { get; set; }
        public string ArticleChallanNo { get; set; }
        public Nullable<byte> ItemTypeID { get; set; }
        public Nullable<byte> LeatherTypeID { get; set; }
        public Nullable<byte> LeatherStatusID { get; set; }
        public string FinishQCLabel { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
        public Nullable<long> ArticleChallanID { get; set; }
    
        public virtual INV_FinishLeatherIssue INV_FinishLeatherIssue { get; set; }
        public virtual INV_FinishLeatherIssueItem INV_FinishLeatherIssueItem { get; set; }
        public virtual INV_FinishLeatherReceive INV_FinishLeatherReceive { get; set; }
        public virtual ICollection<INV_FinishLeatherReceiveColor> INV_FinishLeatherReceiveColor { get; set; }
        public virtual Sys_Article Sys_Article { get; set; }
        public virtual Sys_Buyer Sys_Buyer { get; set; }
        public virtual SLS_BuyerOrder SLS_BuyerOrder { get; set; }
        public virtual Sys_ItemType Sys_ItemType { get; set; }
        public virtual Sys_LeatherStatus Sys_LeatherStatus { get; set; }
        public virtual Sys_LeatherType Sys_LeatherType { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Sys_ArticleChallan Sys_ArticleChallan { get; set; }
    }
}
