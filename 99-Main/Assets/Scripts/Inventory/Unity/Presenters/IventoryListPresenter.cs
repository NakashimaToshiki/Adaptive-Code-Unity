using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

using Inventory.Domain;

using Inventory.Unity.Models;
using Inventory.Unity.Views;

namespace Inventory.Unity.Presenter
{
    public class IventoryListPresenter : MonoBehaviour
    {
        public IventoryListView view;

        private ObservableCollection<ItemInfo> _items = new ObservableCollection<ItemInfo>();
        public ObservableCollection<ItemInfo> Items => _items;

        [ContextMenu("AddItem")]
        public void AddItem()
        {
            view.Insert(0, new ItemInfo());
        }

        private void Awake()
        {

            _items.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        foreach (var item in e.NewItems)
                        {
                            view.Insert(e.NewStartingIndex, (ItemInfo)item);
                        }
                        break;
                    case NotifyCollectionChangedAction.Move:
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        break;
                    case NotifyCollectionChangedAction.Reset:
                        break;
                }
            };
        }

    }
}