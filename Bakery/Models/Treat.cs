using System.Collections.Generic;

namespace Bakery.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public string TreatName { get; set; } 
    public string TreatDesc { get; set; }
    public float TreatQty { get; set; }
    public virtual ICollection<FlavorTreat> Flavors { get; set; } 
  }
}