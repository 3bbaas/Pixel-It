# **Brightness**

## What it does

The **Brightness** filter simply adds (or subtracts) a constant value to each pixel’s R, G, and B channels, making the image overall lighter or darker.

## Preview

<figure markdown="span">
  ![Brightness Filter Preview](../assets/BrightnessPreview.gif){ width="600" }
  <figcaption>Brightness Filter Preview</figcaption>
</figure>

## Usage in Code

```csharp title="Brightness.cs" linenums="1" hl_lines="13-21"
private int Clamp(int value)
{
    return Math.Max(0, Math.Min(255, value));
}
private Bitmap ApplyBrightnessFilter(Bitmap sourceImage, int brightness)
{
    Bitmap newImage = new Bitmap(sourceImage.Width, sourceImage.Height);

    for (int x = 0; x < sourceImage.Width; x++)
    {
        for (int y = 0; y < sourceImage.Height; y++)
        {
            Color pixel = sourceImage.GetPixel(x, y);

            int r = Clamp(pixel.R + brightness);
            int g = Clamp(pixel.G + brightness);
            int b = Clamp(pixel.B + brightness);

            Color newColor = Color.FromArgb(r, g, b);
            newImage.SetPixel(x, y, newColor);
        }
    }

    return newImage;
}
```

<!-- !!! info "Brightness"

    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -->