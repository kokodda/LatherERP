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
    
    public partial class EXP_LCRetirement
    {
        public long LCRetirementID { get; set; }
        public string LCRetirementNo { get; set; }
        public Nullable<System.DateTime> LCRetirementDate { get; set; }
        public Nullable<long> LCID { get; set; }
        public string LCNo { get; set; }
        public Nullable<decimal> BillValue { get; set; }
        public Nullable<decimal> InterestPersent { get; set; }
        public Nullable<decimal> InterestAmount { get; set; }
        public Nullable<decimal> BankCommissionAmt { get; set; }
        public Nullable<decimal> SwiftCharge { get; set; }
        public Nullable<decimal> OtherCharge { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<byte> LCRCurrency { get; set; }
        public Nullable<byte> ExchangeCurrency { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> ExchangeValue { get; set; }
        public string Remarks { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual EXP_LCOpening EXP_LCOpening { get; set; }
        public virtual Sys_Currency Sys_Currency { get; set; }
        public virtual Sys_Currency Sys_Currency1 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
