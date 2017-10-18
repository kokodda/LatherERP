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
    
    public partial class PRD_WBSellectionIssue
    {
        public long IssueID { get; set; }
        public string IssueNo { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string IssueCategory { get; set; }
        public string IssueType { get; set; }
        public Nullable<byte> IssueFrom { get; set; }
        public Nullable<byte> IssueTo { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public string CheckNote { get; set; }
        public Nullable<int> ConfirmedBy { get; set; }
        public Nullable<System.DateTime> ConfirmDate { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual SYS_Store SYS_Store { get; set; }
        public virtual SYS_Store SYS_Store1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
    }
}