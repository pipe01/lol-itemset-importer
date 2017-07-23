using LoL_Item_Set_Manager.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Item_Set_Manager
{
    public static class ChampionsCache
    {
        public struct Champion
        {
            public int ID;
            public string Name;
        }
        
        public static List<Champion> Champions = new List<Champion>();

        public static void Load()
        {
            var file = Resources.champcache;

            Champions = JsonConvert.DeserializeObject<List<Champion>>(file);
        }
    }
}
