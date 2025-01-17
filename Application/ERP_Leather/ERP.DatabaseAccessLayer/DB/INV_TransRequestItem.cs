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
    
    public partial class INV_TransRequestItem
    {
        public long TransRequestItemID { get; set; }
        public Nullable<long> RequestID { get; set; }
        public Nullable<long> TransRequestRefID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public Nullable<decimal> TransQty { get; set; }
        public Nullable<byte> TransUnit { get; set; }
        public Nullable<byte> PackSize { get; set; }
        public Nullable<byte> SizeUnit { get; set; }
        public Nullable<int> PackQty { get; set; }
        public Nullable<int> RefItemID { get; set; }
        public Nullable<int> RefSupplierID { get; set; }
        public Nullable<int> RefManufacturerID { get; set; }
        public Nullable<decimal> ReferenceQty { get; set; }
        public Nullable<byte> ReferenceUnit { get; set; }
        public Nullable<byte> ReferencePackSize { get; set; }
        public Nullable<byte> ReferenceSizeUnit { get; set; }
        public Nullable<int> ReferencePackQty { get; set; }
        public string ReturnMethod { get; set; }
        public Nullable<byte> ReturnUnit { get; set; }
        public Nullable<byte> ReturnCurrency { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> ReturnRate { get; set; }
        public Nullable<decimal> ReturnValue { get; set; }
        public Nullable<byte> ReferenceCurrency { get; set; }
        public Nullable<decimal> ReferenceRate { get; set; }
        public Nullable<decimal> ReferenceValue { get; set; }
        public Nullable<decimal> RefItemDueQty { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual INV_TransRequest INV_TransRequest { get; set; }
        public virtual Sys_ChemicalItem Sys_ChemicalItem { get; set; }
        public virtual Sys_Supplier Sys_Supplier { get; set; }
        public virtual User User { get; set; }
        public virtual Sys_Size Sys_Size { get; set; }
        public virtual Sys_Size Sys_Size1 { get; set; }
        public virtual Sys_Unit Sys_Unit { get; set; }
        public virtual Sys_Unit Sys_Unit1 { get; set; }
        public virtual Sys_ChemicalItem Sys_ChemicalItem1 { get; set; }
        public virtual Sys_Supplier Sys_Supplier1 { get; set; }
        public virtual Sys_Supplier Sys_Supplier2 { get; set; }
        public virtual Sys_Unit Sys_Unit2 { get; set; }
        public virtual User User1 { get; set; }
        public virtual Sys_Unit Sys_Unit3 { get; set; }
        public virtual Sys_Supplier Sys_Supplier3 { get; set; }
        public virtual INV_TransRequestRef INV_TransRequestRef { get; set; }
        public virtual Sys_Currency Sys_Currency { get; set; }
        public virtual Sys_Currency Sys_Currency1 { get; set; }
    }
}
