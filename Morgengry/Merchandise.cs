﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise
    {
        private string _itemId;
        public string ItemId
        {
            get
            {
                return _itemId;
            }
            set
            {
                _itemId = value;
            }
        }
        public Merchandise(string itemId)
        {
            ItemId = itemId;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId;
        }
    }
}
