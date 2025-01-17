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
    
    public partial class Prq_PreGradeSelection
    {
        public Prq_PreGradeSelection()
        {
            this.Prq_PreGradeChallan = new HashSet<Prq_PreGradeChallan>();
            this.Prq_PreGradeSelectedData = new HashSet<Prq_PreGradeSelectedData>();
        }
    
        public long SelectionID { get; set; }
        public string SelectionType { get; set; }
        public int SupplierID { get; set; }
        public int SupplierAddressID { get; set; }
        public byte SelectionStore { get; set; }
        public long PurchaseID { get; set; }
        public byte ItemTypeID { get; set; }
        public Nullable<System.DateTime> SelectionDate { get; set; }
        public string Remarks { get; set; }
        public string SelectedBy { get; set; }
        public string SelectionComments { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public string CheckComments { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public string ApproveComments { get; set; }
        public string RecordStatus { get; set; }
        public string IPAddress { get; set; }
    
        public virtual ICollection<Prq_PreGradeChallan> Prq_PreGradeChallan { get; set; }
        public virtual ICollection<Prq_PreGradeSelectedData> Prq_PreGradeSelectedData { get; set; }
        public virtual Prq_Purchase Prq_Purchase { get; set; }
        public virtual Sys_ItemType Sys_ItemType { get; set; }
        public virtual SYS_Store SYS_Store { get; set; }
        public virtual Sys_Supplier Sys_Supplier { get; set; }
        public virtual Sys_SupplierAddress Sys_SupplierAddress { get; set; }
    }
}
