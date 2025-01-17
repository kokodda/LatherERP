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
    
    public partial class PRD_CLProduction
    {
        public PRD_CLProduction()
        {
            this.PRD_CLProductionChemical = new HashSet<PRD_CLProductionChemical>();
            this.PRD_CLProductionItem = new HashSet<PRD_CLProductionItem>();
        }
    
        public long CLProductionID { get; set; }
        public string CLProductionNo { get; set; }
        public string ProductionFor { get; set; }
        public Nullable<byte> ProductionFloor { get; set; }
        public string CLProductionInitiator { get; set; }
        public Nullable<long> ScheduleItemID { get; set; }
        public string ScheduleProductionNo { get; set; }
        public Nullable<long> RequisitionDateID { get; set; }
        public string RequisitionNo { get; set; }
        public Nullable<long> ScheduleDateID { get; set; }
        public Nullable<long> ScheduleID { get; set; }
        public Nullable<long> YearMonID { get; set; }
        public Nullable<System.DateTime> CLProductionStartDate { get; set; }
        public Nullable<System.DateTime> CLProductionEndDate { get; set; }
        public Nullable<int> ProductionProcessID { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<int> ConfirmedBy { get; set; }
        public Nullable<System.DateTime> ConfirmeDate { get; set; }
        public string ConfirmeNote { get; set; }
        public Nullable<int> CheckedBy { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public Nullable<int> PreparedBy { get; set; }
        public Nullable<System.DateTime> PreparedOn { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
        public virtual SYS_Store SYS_Store { get; set; }
        public virtual Sys_ProductionProces Sys_ProductionProces { get; set; }
        public virtual PRD_YearMonthCrustReqDate PRD_YearMonthCrustReqDate { get; set; }
        public virtual PRD_YearMonthScheduleDate PRD_YearMonthScheduleDate { get; set; }
        public virtual PRD_YearMonthSchedule PRD_YearMonthSchedule { get; set; }
        public virtual User User4 { get; set; }
        public virtual PRD_YearMonth PRD_YearMonth { get; set; }
        public virtual ICollection<PRD_CLProductionChemical> PRD_CLProductionChemical { get; set; }
        public virtual PRD_YearMonthCrustScheduleItem PRD_YearMonthCrustScheduleItem { get; set; }
        public virtual ICollection<PRD_CLProductionItem> PRD_CLProductionItem { get; set; }
    }
}
