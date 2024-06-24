namespace MonitoringAparat.Entitties
{
    public class Day
    {
        public int DayId { get; set; } 
        public DateOnly Date { get; set; }
        public List<Period> Periods { get; set; }
    }
}
