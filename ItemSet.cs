using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LoL_Item_Set_Manager
{
    public class ItemSetsFile
    {
        public static string FilePath = @"C:\Riot Games\League of Legends\Config\ItemSets.json";

        public static ItemSetsFile Default { get; private set; } = new ItemSetsFile();

        [JsonProperty("itemSets")]
        public List<ItemSet> Sets = new List<ItemSet>();

        [JsonProperty("accountId")]
        public int AccountID;

        [JsonProperty("timestamp")]
        public long Timestamp;

        public static void Save()
        {
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(Default));
        }

        public static void Load()
        {
            if (!File.Exists(FilePath))
                throw new FileNotFoundException();

            Default = JsonConvert.DeserializeObject<ItemSetsFile>(File.ReadAllText(FilePath));
        }
    }

    public class ItemSet
    {
        public class SetBlock
        {
            public class BlockItem
            {
                [JsonProperty("count")]
                public int Count { get; set; }

                [JsonProperty("id")]
                public string ID { get; set; }
            }

            [JsonProperty("hideIfSummonerSpell")]
            public int HideIfSummonerSpell { get; set; }

            [JsonProperty("showIfSummonerSpell")]
            public int ShowIfSummonerSpell { get; set; }

            [JsonProperty("type")]
            public string Name { get; set; }

            [JsonProperty("items")]
            public List<BlockItem> Items { get; set; }
        }

        [JsonProperty("associatedChampions")]
        public List<int> AssociatedChampions { get; set; }

        [JsonProperty("associatedMaps")]
        public List<int> AssociatedMaps { get; set; }

        [JsonProperty("blocks")]
        public List<SetBlock> Blocks { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("set")]
        public string Mode { get; set; }

        [JsonProperty("sortRank")]
        public int SortRank { get; set; }

        [JsonProperty("startedFrom")]
        public string StartedFrom { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("uid")]
        public Guid UID { get; set; }
    }
}
