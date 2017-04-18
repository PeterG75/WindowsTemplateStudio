﻿using ItemNamespace.Views;
namespace ItemNamespace.ViewModels
{
    public class ShellViewModel : Observable
    {
        private void PopulateNavItems()
        {
            //^^
            _primaryItems.Add(ShellNavigationItem.FromType<wts.ItemNamePage>("Shell_wts.ItemName".GetLocalized(), Symbol.Document));
        }
    }
}
