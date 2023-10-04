using System.Collections.Generic;
using MySqlConnector;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    // public bool IsMichelin { get; set; }
    public int CuisineId { get; set; }
    public Cuisine Cuisine { get; set; }
  }
}