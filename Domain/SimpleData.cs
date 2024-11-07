namespace Domain
{
    public class SimpleData
    {
        public int EmployeeID
        { get; set; }
        public string FirstnamePrénom { get; set; }
        public string LastnameNomdefamille { get; set; }

        public DateTime? Requestedon { get; set; }

        public string Policytype { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public double? Durationinrange { get; set; }
        public double? Totalduration { get; set; }
        public DateTime? Approvedon { get; set; }

    }
}
