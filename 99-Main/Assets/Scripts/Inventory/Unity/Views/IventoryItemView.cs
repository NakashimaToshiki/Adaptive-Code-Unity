using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Inventory.Domain;

namespace Inventory.Unity.Views
{
    public class IventoryItemView : MonoBehaviour, IItemEntity
    {
        public Text nameText;
        public Text weightText;
        public Text moneyText;

        public string Name
        {
            get {return nameText.text;}
            set { nameText.text = value; }
        }

        private int _weight;
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        private int _money;
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }
        
    }
}