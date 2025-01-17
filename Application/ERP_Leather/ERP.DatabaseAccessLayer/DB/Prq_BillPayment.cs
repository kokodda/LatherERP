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
    
    public partial class Prq_BillPayment
    {
        public Prq_BillPayment()
        {
            this.Prq_BillPaymentReference = new HashSet<Prq_BillPaymentReference>();
        }
    
        public long PaymentID { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public int SupplierID { get; set; }
        public int SupplierAddressID { get; set; }
        public string PurchaseYear { get; set; }
        public byte PaymentType { get; set; }
        public byte PaymentMethod { get; set; }
        public byte Currency { get; set; }
        public string PaymentDoc { get; set; }
        public decimal BillAmount { get; set; }
        public Nullable<decimal> VatPercentage { get; set; }
        public Nullable<decimal> VatAmount { get; set; }
        public Nullable<decimal> DeductAmount { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public string Remarks { get; set; }
        public string RecordStatus { get; set; }
        public bool PaymentStatus { get; set; }
        public System.DateTime SetOn { get; set; }
        public int SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public string CheckComment { get; set; }
        public Nullable<int> RecommendedBy { get; set; }
        public Nullable<System.DateTime> RecommendedDate { get; set; }
        public string RecommendedComment { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public string ApproveComment { get; set; }
        public string IPAddress { get; set; }
    
        public virtual Sys_Currency Sys_Currency { get; set; }
        public virtual Sys_PaymentMethod Sys_PaymentMethod { get; set; }
        public virtual Sys_PaymentType Sys_PaymentType { get; set; }
        public virtual Sys_Supplier Sys_Supplier { get; set; }
        public virtual Sys_SupplierAddress Sys_SupplierAddress { get; set; }
        public virtual ICollection<Prq_BillPaymentReference> Prq_BillPaymentReference { get; set; }
    }
}
