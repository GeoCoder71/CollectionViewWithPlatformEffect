using System;
using CollectionViewWithPlatformEffect.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(CollectionViewWithPlatformEffect.iOS.Effects.ImageTintColorEffect), nameof(CollectionViewWithPlatformEffect.iOS.Effects.ImageTintColorEffect))]
namespace CollectionViewWithPlatformEffect.iOS.Effects
{
    public class ImageTintColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                if(Control is UIImageView image)
                {
                    Color color = TintColorEffect.GetTintColor(Element);
                    image.Image = image.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
                    image.TintColor = color.ToUIColor();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached() { }
    }
}
