namespace MonitoringAparat.Entitties
{
    public class Period
    {
        public int Id {  get; set; }
        public TimeOnly Time { get; set; }
        public string Status { get; set; }
        public Line LineId {  get; set; }

    }
}
