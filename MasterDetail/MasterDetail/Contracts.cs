using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

	public class Contracts : ContentPage
	{
		public Contracts ()
		{
			Title = "Diego";
			Icon = "diego.png";
			var label = new Label
			{
				Text = "Diego Alonso Iquira Becerra",
				Font = Font.SystemFontOfSize(30),
				WidthRequest = 150,
				HeightRequest = 40
			};
			var label2 = new Label
			{
				Text = "Telefono 9337711",
				Font = Font.SystemFontOfSize(30),
				WidthRequest = 150,
				HeightRequest = 40
			};
			var label3 = new Label
			{
				Text = "Correo diego45222 hotmail.com",
				Font = Font.SystemFontOfSize(30),
				WidthRequest = 150,
				HeightRequest = 40
			};
			var button = new Image {
				
				Source="diego.png",
				WidthRequest = 200,
				HeightRequest = 200
			};

			var entry = new Label {
				Text = " ",
				//BackgroundColor = Color.Blue,
				Font = Font.SystemFontOfSize(30),
				WidthRequest = 150,
				HeightRequest = 40
			};



			Content = new StackLayout {
				Spacing = 10,
				Children = {button, entry, label,label2,label3	}
			};

		}
	}
	
}