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
                Padding = new Thickness(0.5),
                HasShadow = false,
                OutlineColor = Color.Transparent,
                BackgroundColor = Color.Transparent
            };

            _innerFrame = new Frame
            {
                Padding = new Thickness(0),
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

        public static readonly BindableProperty CardViewOutlineColorProperty = BindableProperty.Create(
            propertyName: "CardViewOutlineColor",
            declaringType: typeof(CardView),
            returnType: typeof(Color),
            defaultValue: Color.Transparent,
            propertyChanged: CardViewOutlineColorChanged);

        public static readonly BindableProperty CardViewOutlineColorThicknessProperty = BindableProperty.Create(
            propertyName: "CardViewOutlineColorThickness",
            returnType: typeof(Thickness),
            declaringType: typeof(CardView),
            defaultValue: new Thickness(0.5),
            propertyChanged: CardViewOutlineColorThicknessChanged);
        
        public static readonly BindableProperty CardViewOutlineColorHasShadowProperty = BindableProperty.Create(
            propertyName: "CardViewOutlineColorHasShadow",
            returnType: typeof(bool),
            declaringType: typeof(CardView),
            defaultValue: false,
            propertyChanged: CardViewOutlineColorHasShadowChanged);

        public static readonly BindableProperty CardViewInnerPaddingProperty = BindableProperty.Create(
            propertyName: "CardViewInnerPadding",
            returnType: typeof(Thickness),
            declaringType: typeof(CardView),
            defaultValue: new Thickness(0),
            propertyChanged: CardViewInnerPaddingChanged);

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

        public Color CardViewOutlineColor
        {
            get
            {
                return (Color) GetValue(CardViewOutlineColorProperty);
            }
            set
            {
                SetValue(CardViewOutlineColorProperty, value);
            }
        }

        public Thickness CardViewOutlineColorThickness
        {
            get
            {
                return (Thickness) GetValue(CardViewOutlineColorThicknessProperty);
            }
            set
            {
                SetValue(CardViewOutlineColorThicknessProperty, value);
            }
        }

        public bool CardViewOutlineColorHasShadow
        {
            get
            {
                return (bool) GetValue(CardViewOutlineColorHasShadowProperty);
            }
            set
            {
                SetValue(CardViewOutlineColorHasShadowProperty, value);
            }
        }

        public Thickness CardViewInnerPadding
        {
            get
            {
                return (Thickness) GetValue(CardViewInnerPaddingProperty);
            }
            set
            {
                SetValue(CardViewInnerPaddingProperty, value);
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

        private static void CardViewOutlineColorChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (oldvalue == newvalue)
            {
                return;
            }

            ((CardView) bindable).ChangeCardViewOutlineColor();
        }

        private static void CardViewOutlineColorThicknessChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (oldvalue == newvalue)
            {
                return;
            }

            ((CardView) bindable).ChangeCardViewOutlineColorThickness();
        }

        private static void CardViewOutlineColorHasShadowChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (oldvalue == newvalue)
            {
                return;
            }

            ((CardView) bindable).ChangeCardViewOutlineColorHasShadow();
        }

        private static void CardViewInnerPaddingChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (oldvalue == newvalue)
            {
                return;
            }

            ((CardView) bindable).ChangeInnerPadding();
        }
        
        private void ChangeCardViewContent()
        {
            _innerFrame.Content = CardViewContent;
        }

        private void ChangeCardViewHeightRequest()
        {
            _outerFrame.HeightRequest = CardViewHeightRequest;
            _innerFrame.HeightRequest = CardViewHeightRequest;
        }

        private void ChangeCardViewOutlineColor()
        {
            _outerFrame.BackgroundColor = CardViewOutlineColor;
        }
        private void ChangeCardViewOutlineColorThickness()
        {
            _outerFrame.Padding = CardViewOutlineColorThickness;
        }

        private void ChangeCardViewOutlineColorHasShadow()
        {
            _outerFrame.HasShadow = CardViewOutlineColorHasShadow;
        }

        private void ChangeInnerPadding()
        {
            _innerFrame.Padding = CardViewInnerPadding;
        }
    }
}
