using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Item_Set_Manager
{
    public abstract class ISetProvider
    {
        public abstract Task<ItemSet> GetItemSet(string url);
    }
}
