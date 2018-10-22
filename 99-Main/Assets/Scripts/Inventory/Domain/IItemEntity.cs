using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Domain
{
    public interface IItemEntity
    {
        string Name { get; }
        int Weight { get; }
        int Money { get; }
    }
}