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
    
    public partial class EXP_BillofLadingContainer
    {
        public long BLCcntID { get; set; }
        public Nullable<long> BLID { get; set; }
        public string ContainerNo { get; set; }
        public string ContainerType { get; set; }
        public string SealNo { get; set; }
        public Nullable<int> PackageQty { get; set; }
        public Nullable<decimal> GrossWeight { get; set; }
        public Nullable<byte> WeightUnit { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
        public Nullable<byte> MeasurementUnit { get; set; }
        public Nullable<decimal> Measurement { get; set; }
    
        public virtual EXP_BillofLading EXP_BillofLading { get; set; }
        public virtual Sys_Unit Sys_Unit { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Sys_Unit Sys_Unit1 { get; set; }
    }
}