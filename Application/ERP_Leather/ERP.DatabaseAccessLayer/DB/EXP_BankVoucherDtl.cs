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
    
    public partial class EXP_BankVoucherDtl
    {
        public long BVDTLID { get; set; }
        public Nullable<long> BVID { get; set; }
        public Nullable<int> TransSL { get; set; }
        public string Narration { get; set; }
        public Nullable<int> TransHead { get; set; }
        public Nullable<decimal> BVCRAmt { get; set; }
        public Nullable<decimal> BVDRAmt { get; set; }
        public Nullable<byte> Currency { get; set; }
        public Nullable<byte> ExchangeCurrency { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> ExchangeAmount { get; set; }
        public string Remarks { get; set; }
        public string RunningStatus { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public string CheckNote { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public string ApprovalNote { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
        public Nullable<long> CIID { get; set; }
    
        public virtual EXP_BankVoucher EXP_BankVoucher { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Sys_Currency Sys_Currency { get; set; }
        public virtual Sys_Currency Sys_Currency1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
        public virtual EXP_CI EXP_CI { get; set; }
    }
}
