namespace Matching.Maui;

public partial class CardView : ContentView
{
    public static readonly BindableProperty CardImageProperty =
        BindableProperty.Create(nameof(CardImage), typeof(string), typeof(CardView), "ac1", BindingMode.TwoWay);

    public CardView()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public string CardImage
    {
        get => (string)GetValue(CardImageProperty);
        set => SetValue(CardImageProperty, value);
    }
}