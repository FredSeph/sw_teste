﻿using SWDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.DataTransferObjects
{
    public class DTOCartItem
    {
        public Item Item { get; set; }
        public int Count { get; set; }
    }
}
