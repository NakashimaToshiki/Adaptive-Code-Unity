using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Inventory.Domain;

namespace Inventory.Unity.Views
{
    public class IventoryItemFactory : MonoBehaviour
    {
        public GameObject prefab;

        [ContextMenu("Generated")]
        public IventoryItemView Instantiate(IItemEntity entity)
        {
            GameObject game = Instantiate(prefab);
            game.SetActive(true);
            var ret = game.GetComponent<IventoryItemView>();
            ret.Name = entity.Name;
            ret.Money = entity.Money;
            ret.Weight = entity.Weight;
            return ret;
        }
    }
}