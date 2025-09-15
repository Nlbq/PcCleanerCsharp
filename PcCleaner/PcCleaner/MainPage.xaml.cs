using Microsoft.Maui.Controls;

namespace PcCleaner;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SizeChanged += OnSizeChanged;
    }

    void OnSizeChanged(object? sender, EventArgs e)
    {
        // largeur fenêtre actuelle
        var w = Width;

        // Breakpoints (à adapter si tu veux)
        double menuWidth;
        double headerHeight;
        double footerHeight;

        if (w < 800)            // étroit
        {
            menuWidth = 72;
            headerHeight = 84;
            footerHeight = 52;
        }
        else if (w < 1200)      // moyen (par défaut)
        {
            menuWidth = 96;
            headerHeight = 100;
            footerHeight = 60;
        }
        else                    // large
        {
            menuWidth = 128;
            headerHeight = 112;
            footerHeight = 64;
        }

        // applique dynamiquement
        LeftCol.Width = new GridLength(menuWidth);
        HeaderRow.Height = new GridLength(headerHeight);
        FooterRow.Height = new GridLength(footerHeight);
    }
}
