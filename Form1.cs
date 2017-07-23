using LoL_Item_Set_Manager.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Item_Set_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var itemset = await new MobafireProvider().GetItemSet("http://www.mobafire.com/league-of-legends/build/ashes-to-ashes-67331");

            ItemSetsFile.Load();

            ItemSetsFile.Default.Sets.Add(itemset);

            ItemSetsFile.Save();
        }
    }
}
