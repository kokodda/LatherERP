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
    
    public partial class AdditionalOperationPermissionsAudit
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public byte OperationID { get; set; }
        public bool HaveAccess { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime SetOn { get; set; }
        public string SetBy { get; set; }
        public string DataStatusFlag { get; set; }
    }
}
