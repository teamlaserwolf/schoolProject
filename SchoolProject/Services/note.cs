//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Services
{
    using System;
    using System.Collections.Generic;
    
    public partial class note
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int ParticipantId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Reviewed { get; set; }
        public string Corrected { get; set; }
    }
}
