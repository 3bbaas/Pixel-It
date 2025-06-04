# **Gamma Correction**

## What it does

Adjusts each color channel non-linearly via a power-law (`output = 255 × (input/255)^(1/γ)`), brightening or darkening midtones without clipping highlights/shadows.

## Preview

<figure markdown="span">
  ![Gamma Preview](../assets/GammaPreview.gif){ width="600" }
  <figcaption>Gamma adjustments at γ=0.5 (brighter) and γ=2.0 (darker)</figcaption>
</figure>

## Usage in Code

```csharp title="Gamma.cs" linenums="1" hl_lines="13-15"
private int Clamp(int v) => Math.Max(0, Math.Min(255, v));

private Bitmap ApplyGammaFilter(Bitmap sourceImage, double gamma)
{
    int width = sourceImage.Width;
    int height = sourceImage.Height;
    Bitmap newImage = new Bitmap(width, height);

    for (int x = 0; x < width; x++)
    {
        for (int y = 0; y < height; y++)
        {
            Color px = sourceImage.GetPixel(x, y);
            double r = Math.Pow(px.R / 255.0, 1.0 / gamma) * 255.0;
            double g = Math.Pow(px.G / 255.0, 1.0 / gamma) * 255.0;
            double b = Math.Pow(px.B / 255.0, 1.0 / gamma) * 255.0;

            Color newColor = Color.FromArgb(
                px.A,
                Clamp((int)r),
                Clamp((int)g),
                Clamp((int)b)
            );
            newImage.SetPixel(x, y, newColor);
        }
    }

    return newImage;
}

```

<!-- !!! info "XXXXXXXXXXXXXXXXXXXX"
    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -->
