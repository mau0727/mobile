﻿using System;
using Bit.App.Controls;
using Xamarin.Forms;

namespace Bit.App.Pages
{
    public class SettingsCreditsPage : ExtendedContentPage
    {
        public SettingsCreditsPage()
        {
            Init();
        }

        public void Init()
        {
            var table = new ExtendedTableView
            {
                EnableScrolling = true,
                Intent = TableIntent.Menu,
                HasUnevenRows = true,
                EnableSelection = false,
                Root = new TableRoot
                {
                    new TableSection("Icons")
                    {
                        new CustomViewCell(@"Icon 1 - John Smith
Icon 2 - Jane Doe")
                    }
                }
            };

            if(Device.OS == TargetPlatform.iOS)
            {
                table.RowHeight = -1;
                table.EstimatedRowHeight = 100;
            }

            Title = "Thank You";
            Content = table;
        }

        public class CustomViewCell : ViewCell
        {
            public CustomViewCell(string text)
            {
                var label = new Label
                {
                    LineBreakMode = LineBreakMode.WordWrap,
                    Text = text,
                    FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
                };

                var layout = new StackLayout
                {
                    Children = { label },
                    Padding = new Thickness(15, 20)
                };

                View = layout;
            }
        }
    }
}
