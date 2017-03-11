# Xamarin.Forms-CardView
A Package to create a CardView using Xamarin.Forms that works on the three platforms (Android, iOS, UWP)
It is simple to use in a straight forward fashion.
You may either use it in C#, or in XAML.

Example:  

    <StackLayout>
        <CardView CardViewHeightRequest="125">
            <CardView.CardViewContent>
                <!-- You can enter here any content you want to -->
                <StackLayout>
                    <Label Text="First Line" />
                    <Label Text="Second Line" />
                </StackLayout>
            </CardView.CardViewContent>
        </CardView>
    </StackLayout>
