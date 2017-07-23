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
            ret.Blocks = new List<ItemSet.SetBlock>();
            ret.UID = Guid.NewGuid();
            
            var client = new WebClient();
            var page = await client.DownloadStringTaskAsync(new Uri(url));

            var parser = new HtmlParser(Configuration.Default.WithJavaScript().WithCss());
            var doc = await parser.ParseAsync(page);

            var el = doc.QuerySelector("div[class=\"self-clear mb10\"] > div[class=\"self-clear\"]"); //

            foreach (var child in el.Children)
            {
                string title = child.Children[0].TextContent.Trim();

                ItemSet.SetBlock block = new ItemSet.SetBlock();
                block.Name = title;
                block.Items = new List<ItemSet.SetBlock.BlockItem>();

                var itemlist = child.Children[1];

                foreach (var item in itemlist.Children)
                {
                    var atag = item.Children[0];
                    var imgtag = item.Children[0].Children[0];
                    var cls = imgtag.GetAttribute("class");

                    var itemid = new Regex("(?<=i:')(.*)(?='})").Match(cls).Value;

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
