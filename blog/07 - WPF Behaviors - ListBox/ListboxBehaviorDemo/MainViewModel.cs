﻿using GalaSoft.MvvmLight;
using Peregrine.WPF.ViewModel.Command;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace ListboxBehaviorDemo
{
    public class MainViewModel: ViewModelBase
    {
        public MainViewModel()
        {
            SelectFirstItemCommand = new perRelayCommand(() => SelectedItem = Items.First());
            SelectLastItemCommand = new perRelayCommand(() => SelectedItem = Items.Last());

            Items = Enumerable.Range(1, 1000).Select(i => $"Item {i}").ToArray();
        }

        public IEnumerable<string> Items { get; }

        public ICommand SelectFirstItemCommand { get;}

        public ICommand SelectLastItemCommand { get; }

        private string _selectedItem;

        public string SelectedItem
        {
            get => _selectedItem;
            set => Set(nameof(SelectedItem), ref _selectedItem, value);
        }
    }
}
