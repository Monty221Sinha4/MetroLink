//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetroLink
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrainTimeTable
    {
        public int GenID { get; set; }
        public int StationID { get; set; }
        public System.DateTime SchuduleTime { get; set; }
        public int CityID { get; set; }
        public int PlatformID { get; set; }
        public int StatusID { get; set; }
    
        public virtual Cities City { get; set; }
        public virtual StationPlatform StationPlatform { get; set; }
        public virtual Stations Station { get; set; }
        public virtual TimeStatus Status { get; set; }
    }
}
