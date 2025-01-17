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
    
    public partial class EXP_AgentCommission
    {
        public EXP_AgentCommission()
        {
            this.EXP_AgentCommissionBuyer = new HashSet<EXP_AgentCommissionBuyer>();
            this.EXP_AgentCommissionBuyerCI = new HashSet<EXP_AgentCommissionBuyerCI>();
        }
    
        public long AgentComID { get; set; }
        public string AgentComNo { get; set; }
        public string AgentComRef { get; set; }
        public Nullable<System.DateTime> AgentComDate { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<int> ConfirmedBy { get; set; }
        public Nullable<System.DateTime> ConfirmeDate { get; set; }
        public string ConfirmNote { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
        public Nullable<int> BuyerID { get; set; }
        public Nullable<long> CIID { get; set; }
        public Nullable<decimal> CIAmount { get; set; }
        public Nullable<System.DateTime> CIDate { get; set; }
        public Nullable<byte> InvoiceCurrency { get; set; }
        public Nullable<byte> LocalCurrency { get; set; }
        public Nullable<decimal> ComOnAmount { get; set; }
    
        public virtual Sys_Buyer Sys_Buyer { get; set; }
        public virtual EXP_CI EXP_CI { get; set; }
        public virtual User User { get; set; }
        public virtual Sys_Currency Sys_Currency { get; set; }
        public virtual Sys_Currency Sys_Currency1 { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual ICollection<EXP_AgentCommissionBuyer> EXP_AgentCommissionBuyer { get; set; }
        public virtual ICollection<EXP_AgentCommissionBuyerCI> EXP_AgentCommissionBuyerCI { get; set; }
    }
}
