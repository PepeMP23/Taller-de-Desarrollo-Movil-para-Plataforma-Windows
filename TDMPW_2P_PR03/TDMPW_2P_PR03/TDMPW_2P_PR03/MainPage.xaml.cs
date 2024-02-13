using Microsoft.Maui.Controls;

namespace TDMPW_2P_PR03;

public partial class MainPage : ContentPage
{
    List<string> frases = new List<string>();
    List<string> imagenes = new List<string>
    {
        "napoleon1.png",
        "napoleon2.png",
        "napoleon3.png",
        "napoleon4.png",
        "napoleon5.png"
    };

    public MainPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("frases.txt");
        using var reader = new StreamReader(stream);

        // var contents = reader.ReadToEnd();

        while (reader.Peek() != -1)
        {
            frases.Add(reader.ReadLine());
        }
    }

    public static string ColorToHex(System.Drawing.Color color)
    {
        return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
    }

    Random random = new Random();

    void btnCambiar_Clicked(System.Object sender, System.EventArgs e)
    {

        var startColor = System.Drawing.Color.FromArgb(
            random.Next(0, 256),
            random.Next(0, 256),
            random.Next(0, 256)
            );
        var endColor = System.Drawing.Color.FromArgb(
            random.Next(0, 256),
            random.Next(0, 256),
            random.Next(0, 256)
            );

        var colors = ColorUtility.ColorControls.GetColorGradient(
            startColor,
            endColor,
            6);

        float stopOffset = 0.0f;

        var stops = new GradientStopCollection();

        foreach (var c in colors)
        {
            stops.Add(new GradientStop(Color.FromArgb(c.Name), stopOffset));
            stopOffset += .2f;
        }

        var gradient = new LinearGradientBrush(
            stops,
            new Point(0, 0),
            new Point(1, 1)
            );

        background.Background = gradient;
        int index = random.Next(0, frases.Count);
        frase.Text = frases[index];

        int indexImage = random.Next(imagenes.Count);
        FileImageSource newSource = new FileImageSource
        {
            File = imagenes[indexImage]
        };
        imagen.Source = newSource;

        lblColor1.Text = ColorToHex(colors[0]);
        lblColor2.Text = ColorToHex(colors[1]);
        lblColor3.Text = ColorToHex(colors[2]);
        lblColor4.Text = ColorToHex(colors[3]);
        lblColor5.Text = ColorToHex(colors[4]);
        lblColor6.Text = ColorToHex(colors[5]);
    }

    
}


