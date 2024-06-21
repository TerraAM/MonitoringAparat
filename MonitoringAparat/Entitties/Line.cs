namespace MonitoringAparat.Entitties
{
    public class Line
    {
        public int LineId { get; set; }
        public List<Apparat> Apparat { get; set; }
        public Material Material { get; set; }
        public List<Part> Parts { get; set; }
        public int speed { get; set; }
       //ввцьии вирлии public string  NameLine { get; set; }
    }
}
