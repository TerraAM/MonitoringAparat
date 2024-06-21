namespace MonitoringAparat.Entitties
{
    public class Apparat
    {
        public int? ApparatId { get; set; }
        public string Name { get; set; } =  null!;
       
        public List <Part> Parts { get; set; }
       
    }
}
