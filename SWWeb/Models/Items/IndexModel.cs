using SWDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWWeb.Models.Items
{
    public class IndexModel
    {
        public IEnumerable<Item> Items { get; set; }
    }
}