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
    
    public partial class PRD_YearMonth
    {
        public PRD_YearMonth()
        {
            this.PRD_CLProduction = new HashSet<PRD_CLProduction>();
            this.PRD_YearMonthSchedule = new HashSet<PRD_YearMonthSchedule>();
            this.PRD_FNProduction = new HashSet<PRD_FNProduction>();
            this.PRD_YearMonthCrustScheduleItem = new HashSet<PRD_YearMonthCrustScheduleItem>();
            this.PRD_YearMonthFinishScheduleItem = new HashSet<PRD_YearMonthFinishScheduleItem>();
        }
    
        public long YearMonID { get; set; }
        public string ScheduleYear { get; set; }
        public string ScheduleMonth { get; set; }
        public string ScheduleFor { get; set; }
        public Nullable<byte> ProductionFloor { get; set; }
        public string Remarks { get; set; }
        public string RecordStatus { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
        public Nullable<byte> ConcernStore { get; set; }
    
        public virtual ICollection<PRD_CLProduction> PRD_CLProduction { get; set; }
        public virtual SYS_Store SYS_Store { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<PRD_YearMonthSchedule> PRD_YearMonthSchedule { get; set; }
        public virtual ICollection<PRD_FNProduction> PRD_FNProduction { get; set; }
        public virtual ICollection<PRD_YearMonthCrustScheduleItem> PRD_YearMonthCrustScheduleItem { get; set; }
        public virtual ICollection<PRD_YearMonthFinishScheduleItem> PRD_YearMonthFinishScheduleItem { get; set; }
    }
}
