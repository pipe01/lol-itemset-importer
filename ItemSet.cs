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
        public static string FilePath = @"E:\Cosas\Riot Games\League of Legends\Config\ItemSets.json";

        public static ItemSetsFile Default { get; private set; }

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
                public int Count { get; set; } = 1;

                [JsonProperty("id")]
                public string ID { get; set; }
            }

            [JsonProperty("hideIfSummonerSpell")]
            public string HideIfSummonerSpell { get; set; } = "";

            [JsonProperty("showIfSummonerSpell")]
            public string ShowIfSummonerSpell { get; set; } = "";

            [JsonProperty("type")]
            public string Name { get; set; } = "Untitled";

            [JsonProperty("items")]
            public List<BlockItem> Items { get; set; } = new List<BlockItem>();
        }

        [JsonProperty("associatedChampions")]
        public List<int> AssociatedChampions { get; set; } = new List<int>();

        //Summoner's rift by default
        [JsonProperty("associatedMaps")]
        public List<int> AssociatedMaps { get; set; } = new List<int>(new[] { 11 });

        [JsonProperty("blocks")]
        public List<SetBlock> Blocks { get; set; } = new List<SetBlock>();

        [JsonProperty("map")]
        public string Map { get; set; } = "any";

        [JsonProperty("set")]
        public string Mode { get; set; } = "any";

        [JsonProperty("sortRank")]
        public int SortRank { get; set; } = 0;

        [JsonProperty("startedFrom")]
        public string StartedFrom { get; set; } = "blank";

        [JsonProperty("title")]
        public string Title { get; set; } = "Untitled";

        [JsonProperty("type")]
        public string Type { get; set; } = "custom";

        [JsonProperty("uid")]
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
