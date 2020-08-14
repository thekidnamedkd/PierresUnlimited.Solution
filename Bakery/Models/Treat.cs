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
    public string Name { get; set; } 
    public string Description { get; set; }
    public float Quantity { get; set; }
    public virtual ICollection<FlavorTreat> Flavors { get; set; } 
  }
}