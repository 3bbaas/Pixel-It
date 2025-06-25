# **Negative (Invert Colors)**:

## What it does

The Negative filter inverts every pixel’s color by subtracting each RGB component from `255`, producing a photographic “negative” effect. Bright areas become dark, and cool tones swap to warm tones.


## Preview

<figure markdown="span">
  ![Negative Filter Preview](../assets/NegativeFilterPreview.gif){ width="600" }
  <figcaption>Negative Filter Preview</figcaption>
</figure>

## Usage in Code

``` csharp title="Negative.cs" linenums="1" hl_lines="13-15"
private Bitmap ApplyNegativeFilter(Bitmap sourceImage)
{
    int width  = sourceImage.Width;
    int height = sourceImage.Height;
    Bitmap newImage = new Bitmap(width, height);

    for (int x = 0; x < width; x++)
    {
        for (int y = 0; y < height; y++)
        {
            Color px = sourceImage.GetPixel(x, y);
            // Invert each channel
            int r = 255 - px.R;
            int g = 255 - px.G;
            int b = 255 - px.B;

            Color inverted = Color.FromArgb(px.A, r, g, b);
            newImage.SetPixel(x, y, inverted);
        }
    }

    return newImage;
}
```

!!! info "Gamma (photography)"

    In photography, gamma refers to the relationship between the input and output brightness levels of an image, often used to adjust the tonal range and contrast. A gamma correction modifies the brightness and contrast to compensate for the non-linear perception of light by human vision or display devices. [`Wiki`](https://en.wikipedia.org/wiki/Gamma_correction)