using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Domain
{
    public interface IItemMediator<TEntity> where TEntity : IItemEntity
    {
        IList<TEntity> Items { get; }
    }
}
