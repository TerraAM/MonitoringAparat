namespace MonitoringAparat.Dto
{
    public class PartDto
    {
        public int PartId { get; set; }
        public string NamePart { get; set; } = null!;
        public string PartStatus { get; set; } = null!;
        public int Limit { get; set; }
        public DateOnly Change { get; set; }
        public int Worked { get; set; }

    }
}
