using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Inventory.Domain;

namespace Inventory.Unity.Models
{
    public class ItemInfo : IItemEntity
    {
        public string Name { get; set; }
        
        public int Weight { get; set; }

        public int Money { get; set; }
    }
}