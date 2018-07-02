using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace dm
{
    public class customEntry: Entry
    {
        public customEntry()
        {
            this.BackgroundColor = Color.White;
            this.HeightRequest = 50;
            this.WidthRequest = 100;
        }
    }
}
