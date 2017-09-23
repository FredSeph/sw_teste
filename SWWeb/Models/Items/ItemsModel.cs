using SWDomain.Entities;
using SWDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWWeb.Models.Items
{
    public class ItemsModel
    {
        public ItemsModel()
        {
            Items = new List<Item>();
        }

        public IEnumerable<Item> Items { get; set; }
        public Dictionary<Promotion, string> Promotions { get; set; }
    }
}