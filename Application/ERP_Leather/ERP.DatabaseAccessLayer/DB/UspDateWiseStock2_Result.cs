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
    
    public partial class UspDateWiseStock2_Result
    {
        public System.DateTime StockDate { get; set; }
        public byte StoreID { get; set; }
        public string StoreName { get; set; }
        public byte ItemTypeID { get; set; }
        public string ItemTypeName { get; set; }
        public byte LeatherType { get; set; }
        public string LeatherTypeName { get; set; }
        public byte LeatherStatusID { get; set; }
        public string LeatherStatusName { get; set; }
        public Nullable<decimal> OpeningQty { get; set; }
        public Nullable<decimal> DailyReceiveQty { get; set; }
        public decimal DailyIssueQty { get; set; }
        public Nullable<decimal> ClosingQty { get; set; }
    }
}
