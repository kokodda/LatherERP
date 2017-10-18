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
    
    public partial class Sys_Port
    {
        public Sys_Port()
        {
            this.LCM_BillofLading = new HashSet<LCM_BillofLading>();
            this.LCM_BillofLading1 = new HashSet<LCM_BillofLading>();
            this.PRQ_ChemicalPI = new HashSet<PRQ_ChemicalPI>();
            this.PRQ_ChemicalPI1 = new HashSet<PRQ_ChemicalPI>();
            this.EXP_BillofLading = new HashSet<EXP_BillofLading>();
            this.EXP_BillofLading1 = new HashSet<EXP_BillofLading>();
            this.EXP_LeatherPI = new HashSet<EXP_LeatherPI>();
            this.EXP_LeatherPI1 = new HashSet<EXP_LeatherPI>();
            this.EXP_ExportForm = new HashSet<EXP_ExportForm>();
            this.EXP_ExportForm1 = new HashSet<EXP_ExportForm>();
            this.EXP_ExportForm2 = new HashSet<EXP_ExportForm>();
            this.LCM_LCOpening = new HashSet<LCM_LCOpening>();
            this.LCM_LCOpening1 = new HashSet<LCM_LCOpening>();
        }
    
        public int PortID { get; set; }
        public string PortCode { get; set; }
        public string PortName { get; set; }
        public string PortAdress { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual ICollection<LCM_BillofLading> LCM_BillofLading { get; set; }
        public virtual ICollection<LCM_BillofLading> LCM_BillofLading1 { get; set; }
        public virtual ICollection<PRQ_ChemicalPI> PRQ_ChemicalPI { get; set; }
        public virtual ICollection<PRQ_ChemicalPI> PRQ_ChemicalPI1 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<EXP_BillofLading> EXP_BillofLading { get; set; }
        public virtual ICollection<EXP_BillofLading> EXP_BillofLading1 { get; set; }
        public virtual ICollection<EXP_LeatherPI> EXP_LeatherPI { get; set; }
        public virtual ICollection<EXP_LeatherPI> EXP_LeatherPI1 { get; set; }
        public virtual ICollection<EXP_ExportForm> EXP_ExportForm { get; set; }
        public virtual ICollection<EXP_ExportForm> EXP_ExportForm1 { get; set; }
        public virtual ICollection<EXP_ExportForm> EXP_ExportForm2 { get; set; }
        public virtual ICollection<LCM_LCOpening> LCM_LCOpening { get; set; }
        public virtual ICollection<LCM_LCOpening> LCM_LCOpening1 { get; set; }
    }
}