//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnicalService
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLFaultDetails
    {
        public int Id { get; set; }
        public Nullable<int> ProcessId { get; set; }
        public string Complaint { get; set; }
        public string Explanation { get; set; }
        public Nullable<decimal> UpfrontPrice { get; set; }
        public Nullable<decimal> ExactPrice { get; set; }
        public string Transactions { get; set; }
    }
}