using System.Linq;
using Xamarin.Forms;

namespace CollectionViewWithPlatformEffect.Effects
{
    public static class TintColorEffect
    {
        public static readonly BindableProperty TintColorProperty =
            BindableProperty.CreateAttached("TintColor", typeof(Color), typeof(TintColorEffect), Color.Default, propertyChanged: OnTintColorChanged);

        private static void OnTintColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            View view = bindable as View;
            if (view == null)
                return;

            Color newColor = (Color)newValue;

            var attachedEffect = view.Effects.FirstOrDefault(e => e is ImageTintColorEffect);
            if (newColor != null && attachedEffect == null)
            {
                view.Effects.Add(new ImageTintColorEffect());
            }
            else if (newColor == null && attachedEffect != null)
            {
                view.Effects.Remove(attachedEffect);
            }
        }

        public static Color GetTintColor(BindableObject view)
        {
            return (Color)view.GetValue(TintColorProperty);
        }

        public static void SetTintColor(BindableObject view, Color color)
        {
            view.SetValue(TintColorProperty, color);
        }


        /// <summary>
        /// 
        /// </summary>
        public class ImageTintColorEffect : RoutingEffect
        {
            public ImageTintColorEffect() : base($"MyCompany.{nameof(ImageTintColorEffect)}")
            {
            }
        }
    }
}
