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
    
    public partial class Sys_PaymentMethod
    {
        public Sys_PaymentMethod()
        {
            this.Prq_BillPayment = new HashSet<Prq_BillPayment>();
        }
    
        public byte ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime SetOn { get; set; }
        public int SetBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual ICollection<Prq_BillPayment> Prq_BillPayment { get; set; }
    }
}
