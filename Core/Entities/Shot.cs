using System;

namespace Core.Entities
{
    public class Shot
    {
        public int ShotID { get; set; }
        public int AnimalID { get; set; }
        public int AgeID { get; set; }
        public int SexID { get; set; }
        public int Weight { get; set; }
        public int WeightMethodID { get; set; }
        public string HuningFieldID { get; set; }
        public string VetTestId { get; set; }
        public System.DateTime Date { get; set; }
        public string Location { get; set; }
        public Nullable<bool> IsCultivateLand { get; set; }
        public string ExporterName { get; set; }
        public Nullable<int> ExporterId { get; set; }
    }
}