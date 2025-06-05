# **Gaussian Blur**

## What it does

Smooths the image by convolving with a 3×3 Gaussian kernel (`[1 2 1; 2 4 2; 1 2 1]/16`), giving a more natural, bell-shaped blur than uniform averaging.

## Preview

<figure markdown="span">
  ![Gaussian Blur Preview](../assets/GaussianBlurPreview.gif){ width="600" }
  <figcaption>3×3 Gaussian blur applied</figcaption>
</figure>

## Usage in Code

```csharp title="GaussianBlur.cs" linenums="1" hl_lines="16-30"
private int Clamp(int v) => Math.Max(0, Math.Min(255, v));

private Bitmap ApplyGaussianBlur(Bitmap src)
{
    float[,] k = {
        {1f/16, 2f/16, 1f/16},
        {2f/16, 4f/16, 2f/16},
        {1f/16, 2f/16, 1f/16}
    };
    int w = src.Width, h = src.Height;
    Bitmap outBmp = new Bitmap(w, h);

    for (int x = 1; x < w-1; x++)
    for (int y = 1; y < h-1; y++)
    {
        float r=0, g=0, b=0;
        for (int i=-1; i<=1; i++)
        for (int j=-1; j<=1; j++)
        {
            Color p = src.GetPixel(x+i, y+j);
            float wt = k[j+1,i+1];
            r += p.R*wt; g += p.G*wt; b += p.B*wt;
        }
        Color np = Color.FromArgb(
            src.GetPixel(x,y).A,
            Clamp((int)r),
            Clamp((int)g),
            Clamp((int)b)
        );
        outBmp.SetPixel(x, y, np);
    }
    return outBmp;
}
```

<!-- !!! info "XXXXXXXXXXXXXXXXXXXX"
    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -->
