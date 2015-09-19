using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_domeny.Models
{
    public class ItemsRepository
    {
        public void AddItem(Item item)
        { }

        public Item FetchByID(int itemID)
        {
            return null;
        }

        public IList<Item> ListItems(int pageSize, int pageIndex)
        {
            return null;
        }

        public void SubmitChanges()
        { }
    }
}