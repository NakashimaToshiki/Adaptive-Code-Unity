using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Inventory.Domain;

namespace Inventory.Unity.Models
{
    public class DropItemModel : MonoBehaviour, IItemEntity
    {

        [SerializeField]
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [SerializeField]
        private int _weight;
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        [SerializeField]
        private int _money;
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }

    }
}