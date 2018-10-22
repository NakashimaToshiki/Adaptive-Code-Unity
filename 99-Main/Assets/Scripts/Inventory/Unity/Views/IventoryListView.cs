using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

using System.Collections.Specialized;
using Inventory.Unity.Models;
using Inventory.Domain;

namespace Inventory.Unity.Views
{
    public class IventoryListView : MonoBehaviour
    {
        public IventoryItemFactory factory;


        public IventoryItemView Insert(int index, IItemEntity entity)
        {
            var ret = factory.Instantiate(entity);
            ret.transform.SetParent(transform);
            return ret;
        }

        public void Move()
        {
        }

        public void Remove()
        {
        }

        public void Replace()
        {
        }

        public void Clear()
        {
        }
        
    }
}