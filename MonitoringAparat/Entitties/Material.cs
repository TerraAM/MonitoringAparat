using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonitoringAparat.Entitties
{
    public class Material
    {
        public int MaterialId { get; set; } 
        public string Name { get; set; } = null!;
       
        public int strength { get; set; } = 40;
        public int syslo {  get; set; }
        public double volume { get; set; }
        public  int density { get; set; }
        public int temp {  get; set; }
    }
 
    public class CountMaterialDay
    {
        public int Id { get; set; }
        public int count { get; set; }
        public Material material { get; set; }
    }
}
