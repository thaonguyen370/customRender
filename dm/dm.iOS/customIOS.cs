using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dm.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using dm;
[assembly: ExportRenderer(typeof(customEntry), typeof(customIOS))]
namespace dm.iOS
{
    class customIOS: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 3f;
                Control.Layer.BorderWidth = 3;
                Control.Layer.BorderColor = Color.BlueViolet.ToCGColor();

                Control.TextAlignment = UITextAlignment.Right;
            }
        }

    }
}