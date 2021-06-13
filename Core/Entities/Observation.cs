using System;

namespace Core.Entities
{
    public class Observation
    {
        public int ObservationID { get; set; }
        public int AnimalID { get; set; }
        public int NoHunters { get; set; }
        public int NoHours { get; set; }
        public int NoMale { get; set; }
        public int NoFemale { get; set; }
        public int NoFemale1Calf { get; set; }
        public int NoFemale2Calf { get; set; }
        public int NoElder { get; set; }
        public int NoCalf { get; set; }
        public int NoUnknown { get; set; }
        public string HuntingFieldID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<bool> IsCultivateLand { get; set; }
        public string ExporterName { get; set; }
        public int? ExporterId { get; set; }
    }
}