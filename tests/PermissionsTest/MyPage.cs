using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

namespace PermissionsTest
{
	public class MyPage : ContentPage
	{
		public MyPage()
		{
			Title = "Plugin.Permissions Test";
			Button testBtn = new Button { Text = "Test Permissions" };
			testBtn.Clicked += (sender, e) => Navigation.PushAsync(new GeolocationPage());

			Content = new StackLayout
			{
				Children = {
					testBtn
				}
			};
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await DisplayAlert("Test", "OnAppearing() \ncalled\n on\n MyPage", "OK");
		}

	}
}

