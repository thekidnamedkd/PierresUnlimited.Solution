using System.Collections.Generic;

namespace Bakery.Models
{
  public class Flavor
  {
    public Flavor() 
    {
      this.Treats = new HashSet<FlavorTrear>();
    }
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> Treats { get; set; }
  }
}