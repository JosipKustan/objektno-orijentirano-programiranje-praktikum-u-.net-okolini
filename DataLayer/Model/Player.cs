using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Player
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public int ShirtNumber { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        public bool Favorite { get; set; }

        public String PicturePath { get; set; }
        public override string ToString()
        {
            return $"{Name} ({ShirtNumber})";

        }

        public override bool Equals(object obj)=> obj is Player player &&
                   ShirtNumber == player.ShirtNumber && Name==player.Name;
        

        public override int GetHashCode()=>ShirtNumber.GetHashCode();
        
    }
}
