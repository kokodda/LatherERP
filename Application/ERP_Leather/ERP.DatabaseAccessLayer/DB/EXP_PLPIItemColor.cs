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
    
    public partial class EXP_PLPIItemColor
    {
        public EXP_PLPIItemColor()
        {
            this.EXP_PLPIItemColorBale = new HashSet<EXP_PLPIItemColorBale>();
        }
    
        public long PLPIItemColorID { get; set; }
        public Nullable<long> PLPIID { get; set; }
        public string Commodity { get; set; }
        public Nullable<int> ArticleID { get; set; }
        public string ArticleNo { get; set; }
        public string HSCode { get; set; }
        public Nullable<byte> ItemTypeID { get; set; }
        public Nullable<byte> LeatherTypeID { get; set; }
        public Nullable<byte> LeatherStatusID { get; set; }
        public string MaterialNo { get; set; }
        public string AvgSize { get; set; }
        public Nullable<byte> AvgSizeUnit { get; set; }
        public string SideDescription { get; set; }
        public string SelectionRange { get; set; }
        public string Thickness { get; set; }
        public Nullable<byte> ThicknessUnit { get; set; }
        public string ThicknessAt { get; set; }
        public Nullable<int> ColorID { get; set; }
        public Nullable<decimal> MeterPLPIItemQty { get; set; }
        public Nullable<decimal> FootPLPIItemQty { get; set; }
        public Nullable<decimal> PLPIItemWeight { get; set; }
        public Nullable<byte> ItemWeightUnit { get; set; }
        public Nullable<decimal> PackQty { get; set; }
        public Nullable<byte> PackUnit { get; set; }
        public string RecordStatus { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual EXP_PLPI EXP_PLPI { get; set; }
        public virtual Sys_Article Sys_Article { get; set; }
        public virtual Sys_Unit Sys_Unit { get; set; }
        public virtual Sys_Color Sys_Color { get; set; }
        public virtual Sys_ItemType Sys_ItemType { get; set; }
        public virtual Sys_Unit Sys_Unit1 { get; set; }
        public virtual Sys_LeatherStatus Sys_LeatherStatus { get; set; }
        public virtual Sys_LeatherType Sys_LeatherType { get; set; }
        public virtual User User { get; set; }
        public virtual Sys_Unit Sys_Unit2 { get; set; }
        public virtual User User1 { get; set; }
        public virtual Sys_Unit Sys_Unit3 { get; set; }
        public virtual ICollection<EXP_PLPIItemColorBale> EXP_PLPIItemColorBale { get; set; }
    }
}
