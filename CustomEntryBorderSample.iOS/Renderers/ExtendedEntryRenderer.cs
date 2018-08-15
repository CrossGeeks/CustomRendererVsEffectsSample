using System;
using System.ComponentModel;
using CustomEntryBorderSample.Controls;
using CustomEntryBorderSample.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace CustomEntryBorderSample.iOS.Renderers
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;

            this.Control.Layer.BorderColor = UIColor.Orange.CGColor;
            this.Control.Layer.BorderWidth = new nfloat(0.9);
            this.Control.Layer.CornerRadius = 5;
        }
    }
}