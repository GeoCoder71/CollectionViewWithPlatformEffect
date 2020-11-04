using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using CollectionViewWithPlatformEffect.Models;
using CollectionViewWithPlatformEffect.Views;

namespace CollectionViewWithPlatformEffect.ViewModels
{
    public class ItemsViewModel 
    {
        public ObservableCollection<Item> Items { get; }

        public ItemsViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item { Title = "Item 1", Color=Color.Aqua},
                new Item { Title = "Item 2", Color=Color.Brown},
                new Item { Title = "Item 3", Color=Color.Green},
                new Item { Title = "Item 4", Color=Color.Orange},
                new Item { Title = "Item 5", Color=Color.Violet},
                new Item { Title = "Item 6", Color=Color.Aqua},
                new Item { Title = "Item 7", Color=Color.Brown},
                new Item { Title = "Item 8", Color=Color.Green},
                new Item { Title = "Item 9", Color=Color.Orange},
                new Item { Title = "Item 10", Color=Color.Violet},
                new Item { Title = "Item 11", Color=Color.Aqua},
                new Item { Title = "Item 12", Color=Color.Brown},
                new Item { Title = "Item 13", Color=Color.Green},
                new Item { Title = "Item 14", Color=Color.Orange},
                new Item { Title = "Item 15", Color=Color.Violet},


            };
        }
    }
}