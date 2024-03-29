﻿using System;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace BoostSharp.PageModels
{
    class EditProfilePageModel : FreshBasePageModel
    {
        public ICommand PopCommand { get; set; }
        public EditProfilePageModel()
        {
            PopCommand = new Command(async () =>
            {
                await CoreMethods.PopPageModel(this);
            });
        }
    }
}
