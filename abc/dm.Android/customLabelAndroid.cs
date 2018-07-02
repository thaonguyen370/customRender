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
[assembly: ExportRenderer(typeof(customLable), typeof(customLabelAndroid))]
namespace dm.Droid
{
    public class customLabelAndroid : LabelRenderer
    {
        public customLabelAndroid(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(3f);
                gradientDrawable.SetCornerRadius(50);
                gradientDrawable.SetBounds(50, 25, 21, 22);
                gradientDrawable.SetStroke(3, Android.Graphics.Color.Red);
                gradientDrawable.SetColor(Android.Graphics.Color.Blue);
                Control.SetBackground(gradientDrawable);
                Control.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
            }

        }
    }
}