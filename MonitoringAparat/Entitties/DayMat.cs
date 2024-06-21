namespace MonitoringAparat.Entitties
{
    public class DayMat
    {
        //public int count { get; set; }
        //public double volume { get; set; }
        public int DayMatId {  get; set; }
        public List<CountMaterialDay> countmaterial { get; set; }
        public DateOnly day { get; set; }


    }
}
