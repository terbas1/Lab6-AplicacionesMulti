﻿using Lab6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewSource : ContentPage
	{
		public ListViewSource ()
		{
			InitializeComponent ();
            BindingContext = new MylistPageViewModel();
        }
	}
}