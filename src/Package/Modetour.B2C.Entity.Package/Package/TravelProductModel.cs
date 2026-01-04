namespace Modetour.B2C.Entity.Package
{
    public class TravelProductModel
    {
        public int OrderNumber { get; set; }
        public string GroupName { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int GroupNumber { get; set; }
        public string ProductCode { get; set; }
    }
}
