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
    
    public partial class UspPreGradeSelectionReportByPurchaseId_Result
    {
        public Nullable<long> SelectionID { get; set; }
        public string ItemTypeName { get; set; }
        public Nullable<int> GradeID { get; set; }
        public string GradeName { get; set; }
        public Nullable<decimal> GradeQty { get; set; }
        public Nullable<decimal> GradeArea { get; set; }
        public Nullable<decimal> GradeSide { get; set; }
        public string SupplierName { get; set; }
        public Nullable<long> PurchaseID { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<decimal> PurchaseQty { get; set; }
        public Nullable<decimal> ReceiveQty { get; set; }
        public Nullable<decimal> TotalConfirmQty { get; set; }
        public Nullable<decimal> TotalNonConfirmQty { get; set; }
        public Nullable<decimal> TotalAreaQty { get; set; }
        public Nullable<int> ReportNo { get; set; }
    }
}
