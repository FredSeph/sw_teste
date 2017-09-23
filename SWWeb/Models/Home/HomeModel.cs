using SWDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWWeb.Models.Home
{
    public class HomeModel
    {
        public HomeModel()
        {
            Items = new List<Item>();
        }

        public IEnumerable<Item> Items { get; set; }
    }
}