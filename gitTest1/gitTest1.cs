﻿using System;

using Xamarin.Forms;

namespace gitTest1
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "gitTest1",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };


            var lab = new Label { };

            lab.BackgroundColor = Color.Black;

            lab.Text = "";

            System.Diagnostics.Debug.WriteLine("xyz");

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {

            System.Diagnostics.Debug.WriteLine("ttt");
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
