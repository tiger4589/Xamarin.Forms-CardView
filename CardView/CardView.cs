using Xamarin.Forms;

namespace CardView
{
    public class CardView : ContentView
    {
        private Frame _outerFrame;
        private Frame _innerFrame;

        public CardView()
        {
            _outerFrame = new Frame
            {
                Padding = new Thickness(5, 2, 5, 2),
                HasShadow = false,
                OutlineColor = Color.Transparent,
                BackgroundColor = Color.Transparent,
            };

            _innerFrame = new Frame
            {
                Padding = new Thickness(5),
                Margin = new Thickness(2, 2, 2, 2)
            };

            Device.OnPlatform(iOS: () =>
            {
                _innerFrame.HasShadow = false;
            }, Default: () =>
            {
                _innerFrame.HasShadow = true;
            });

            _outerFrame.Content = _innerFrame;
            Content = _outerFrame;
        }

        public static readonly BindableProperty CardViewContentProperty = BindableProperty.Create(
            propertyName: "CardViewContent",
            returnType: typeof(View),
            declaringType: typeof(CardView),
            propertyChanged: CardViewContentChanged);

        public static readonly BindableProperty CardViewHeightRequestProperty = BindableProperty.Create(
            propertyName: "CardViewHeightRequest",
            returnType: typeof(double),
            declaringType: typeof(CardView),
            defaultValue: 300.0,
            propertyChanged: CardViewHeightRequestChanged);

        public View CardViewContent
        {
            get
            {
                return (View)GetValue(CardViewContentProperty);
            }
            set
            {
                SetValue(CardViewContentProperty, value);
            }
        }

        public double CardViewHeightRequest
        {
            get
            {
                return (double)GetValue(CardViewHeightRequestProperty);
            }
            set
            {
                SetValue(CardViewHeightRequestProperty, value);
            }
        }

        private static void CardViewContentChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (oldvalue == newvalue)
            {
                return;
            }
            ((CardView)bindable).ChangeCardViewContent();
        }

        private static void CardViewHeightRequestChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (oldvalue == newvalue)
            {
                return;
            }
            ((CardView)bindable).ChangeCardViewHeightRequest();
        }

        private void ChangeCardViewContent()
        {
            _innerFrame.Content = CardViewContent;
        }

        private void ChangeCardViewHeightRequest()
        {
            _outerFrame.HeightRequest = CardViewHeightRequest;
            _innerFrame.HeightRequest = CardViewHeightRequest - 5;
        }
    }
}
