using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Extensions;
using AngleSharp;
using System.Text.RegularExpressions;

namespace LoL_Item_Set_Manager.Providers
{
    public class MobafireProvider : ISetProvider
    {
        public override async Task<ItemSet> GetItemSet(string url)
        {
            ItemSet ret = new ItemSet();
            
            var client = new WebClient();
            var page = await client.DownloadStringTaskAsync(new Uri(url));

            var parser = new HtmlParser(Configuration.Default.WithJavaScript().WithCss());
            var doc = await parser.ParseAsync(page);

            //Get build name
            var guidetitleel = doc.QuerySelector("h2[class=guide-main-title]");
            var titleel = doc.QuerySelector("div[class=build-title] > h2");
            ret.Title = guidetitleel.TextContent.Trim() + ": " + titleel.TextContent.Trim();

            //Get champion
            var champel = doc.QuerySelector("div[class=build-title] > h3");
            string champ = champel.TextContent.Replace(" Build", "");

            int champid = ChampionsCache.Champions.Where(o => o.Name.ToLower() == champ.ToLower()).Single().ID;
            ret.AssociatedChampions.Add(champid);

            //Load item list
            var el = doc.QuerySelector("div[class=\"self-clear mb10\"] > div[class=\"self-clear\"]"); //

            foreach (var child in el.Children)
            {
                string title = child.Children[0].TextContent.Trim();

                ItemSet.SetBlock block = new ItemSet.SetBlock();
                block.Name = title;
                
                var itemlist = child.Children[1];

                foreach (var item in itemlist.Children)
                {
                    var imgtag = item.Children[0].Children[1].Children[1];
                    
                    var itemname = imgtag.TextContent;

                    block.Items.Add(new ItemSet.SetBlock.BlockItem
                    {
                        Count = 1,
                        ID = itemid
                    });
                }

                ret.Blocks.Add(block);
            }

            return ret;
        }
    }
}
