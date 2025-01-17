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
    
    public partial class Sys_BuyerAddress
    {
        public Sys_BuyerAddress()
        {
            this.SLS_BuyerOrder = new HashSet<SLS_BuyerOrder>();
            this.EXP_LCOpening = new HashSet<EXP_LCOpening>();
        }
    
        public int BuyerAddressID { get; set; }
        public Nullable<int> BuyerID { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNo { get; set; }
        public string PhoneNo { get; set; }
        public string SkypeID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> SetOn { get; set; }
        public Nullable<int> SetBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual ICollection<SLS_BuyerOrder> SLS_BuyerOrder { get; set; }
        public virtual Sys_Buyer Sys_Buyer { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<EXP_LCOpening> EXP_LCOpening { get; set; }
    }
}
