using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using dm.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using dm;
using Android.Graphics;
using System.Drawing;

[assembly: ExportRenderer(typeof(customEntry), typeof(customAnroid))]
namespace dm.Droid
{
    class customAnroid : EntryRenderer
    {
        public customAnroid(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {            
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(3f);
                gradientDrawable.SetCornerRadius(25);
                
                gradientDrawable.SetStroke(3, Android.Graphics.Color.Red);
                gradientDrawable.SetColor(Android.Graphics.Color.White);
                Control.SetBackground(gradientDrawable);
                Control.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
            }
        }
    }
}