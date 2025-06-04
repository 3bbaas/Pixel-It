# **Sobel Edge Detection**

## What it does

Detects edges by convolving a grayscale version of the image with horizontal and vertical Sobel kernels, then combining their magnitudes.

## Preview

<figure markdown="span">
  ![Sobel Preview](../assets/SobelPreview.gif){ width="600" }
  <figcaption>Sobel filter highlighting edges</figcaption>
</figure>

## Usage in Code

```csharp title="Sobel.cs" linenums="1" hl_lines="16-18 25-38"
private int Clamp(int v) => Math.Max(0, Math.Min(255, v));

int[,] gx = { { -1,0,1 }, { -2,0,2 }, { -1,0,1 } };
int[,] gy = { {  1,2,1 }, {  0,0,0 }, { -1,-2,-1 } };

private Bitmap ApplySobelFilter(Bitmap sourceImage)
{
    int width = sourceImage.Width;
    int height = sourceImage.Height;
    Bitmap grayImage = new Bitmap(width, height);
    Bitmap edgeImage = new Bitmap(width, height);

    for (int x = 0; x < width; x++)
    for (int y = 0; y < height; y++)
    {
        Color px = sourceImage.GetPixel(x, y);
        int l = (px.R + px.G + px.B) / 3;
        grayImage.SetPixel(x, y, Color.FromArgb(px.A, l, l, l));
    }


    for (int x = 1; x < width - 1; x++)
    for (int y = 1; y < height - 1; y++)
    {
        int sumX = 0, sumY = 0;

        for (int ky = -1; ky <= 1; ky++)
        for (int kx = -1; kx <= 1; kx++)
        {
            int pixel = grayImage.GetPixel(x + kx, y + ky).R;
            sumX += gx[ky + 1, kx + 1] * pixel;
            sumY += gy[ky + 1, kx + 1] * pixel;
        }

        int g = (int)Math.Sqrt(sumX * sumX + sumY * sumY);
        g = Clamp(g);

        edgeImage.SetPixel(x, y, Color.FromArgb(255, g, g, g));
    }

    return edgeImage;
}
```

!!! info "XXXXXXXXXXXXXXXXXXXX"
    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
