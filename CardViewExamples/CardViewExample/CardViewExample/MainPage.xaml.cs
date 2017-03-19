using System;
using Xamarin.Forms;

namespace CardViewExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CardViewContent_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CardViewContentPage()).ConfigureAwait(true);
        }

        private async void CardViewHeightRequest_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CardViewHeightRequestPage()).ConfigureAwait(true);
        }

        private async void CardViewOutlineColor_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CardViewOutlineColorPage()).ConfigureAwait(true);
        }

        private async void CardViewInlineFrameOutlineColor_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InnerFrameOutlineColorPage()).ConfigureAwait(true);
        }

        private async void CardViewHasShadow_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CardViewHasShadowPage()).ConfigureAwait(true);
        }

        private async void CardViewHasSwipeToClear_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwipeToClearEnabledPage()).ConfigureAwait(true);
        }

        private async void CardViewAllExamples_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AllCombinedPage()).ConfigureAwait(true);
        }
    }
}
