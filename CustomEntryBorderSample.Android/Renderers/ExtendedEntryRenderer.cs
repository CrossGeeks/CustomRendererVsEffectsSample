using System.ComponentModel;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using CustomEntryBorderSample.Controls;
using CustomEntryBorderSample.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(ExtendedEntry), typeof(CustomEntryRenderer))]
namespace CustomEntryBorderSample.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            UpdateBorder();

        }

        void UpdateBorder()
        {
            Android.Graphics.Color borderColor = Android.Graphics.Color.Orange;
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Control.BackgroundTintList = ColorStateList.ValueOf(borderColor);
            }
            else
            {
                Control.Background.SetColorFilter(borderColor, PorterDuff.Mode.SrcOut);
            }
        }
    }
}