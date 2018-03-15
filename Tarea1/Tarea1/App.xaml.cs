using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Tarea1.View;
namespace Tarea1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();



            //MainPage = new Tarea1.View.MainPage();
            MainPage = new Tarea1.View.ClientDetail();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
