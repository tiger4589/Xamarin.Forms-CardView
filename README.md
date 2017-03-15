# Xamarin.Forms-CardView
A Package to create a CardView using Xamarin.Forms that works on the three platforms (Android, iOS, UWP)
It is simple to use in a straight forward fashion.
You may either use it in C#, or in XAML.  

## CardView Bindable Properties

| Property                              | Property Name                 | Property Type   | Usage           | Default Value   |
| :-------------:                       | :-------------:               | :-------------: | :-------------: | :-------------: |
| CardViewContentProperty               | CardViewContent               | View            | CardViewContent | None            |
| CardViewHeightRequestProperty         | CardViewHeightRequest         | double          | Height Request  | 300.0           |
| CardViewOutlineColorProperty          | CardViewOutlineColor          | Color           | Outline Color   | Transparent     |
| CardViewOutlineColorThicknessProperty | CardViewOutlineColorThickness | Thickness       | OutlineColor Thickness   | 0.5    |
| CardViewOutlineColorHasShadowProperty | CardViewOutlineColorHasShadow | bool            | Shadow With OutlineColor | false  |
| CardViewInnerPaddingProperty          | CardViewInnerPadding          | Thickness       | Padding inside CardView  |  0     |

Example:  
```xml
    <StackLayout>
        <CardView CardViewHeightRequest="125" CardViewOutlineColor="Aqua" CardViewOutlineColorThickness="5">
            <CardView.CardViewContent>
                <!-- You can enter here any content you want to -->
                <StackLayout>
                    <Label Text="First Line" />
                    <Label Text="Second Line" />
                </StackLayout>
            </CardView.CardViewContent>
        </CardView>
    </StackLayout>
```
