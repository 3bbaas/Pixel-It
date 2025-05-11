# **Sobel Edge Detection**

## What it does

Detects edges by convolving a grayscale version of the image with horizontal and vertical Sobel kernels, then combining their magnitudes.

## Preview

<figure markdown="span">
  ![Sobel Preview](../assets/SobelPreview.gif){ width="600" }
  <figcaption>Sobel filter highlighting edges</figcaption>
</figure>

## Usage in Code

```csharp title="Sobel.cs"
private int Clamp(int v) => Math.Max(0, Math.Min(255, v));

int[,] gx = { { -1,0,1 }, { -2,0,2 }, { -1,0,1 } };
int[,] gy = { {  1,2,1 }, {  0,0,0 }, { -1,-2,-1 } };

private Bitmap ApplySobelFilter(Bitmap src)
{
    int w=src.Width, h=src.Height;
    Bitmap gray = new Bitmap(w,h), edges = new Bitmap(w,h);

    // 1) convert to gray
    for (int i=0; i<w; i++)
    for (int j=0; j<h; j++)
    {
        Color p=src.GetPixel(i,j);
        int l=(p.R+p.G+p.B)/3;
        gray.SetPixel(i,j, Color.FromArgb(p.A, l,l,l));
    }

    // 2) apply Sobel
    for (int x=1; x<w-1; x++)
    for (int y=1; y<h-1; y++)
    {
        int sx=0, sy=0;
        for (int i=-1; i<=1; i++)
        for (int j=-1; j<=1; j++)
        {
            int val = gray.GetPixel(x+i, y+j).R;
            sx += gx[j+1,i+1]*val;
            sy += gy[j+1,i+1]*val;
        }
        int mag = Clamp((int)Math.Sqrt(sx*sx + sy*sy));
        edges.SetPixel(x,y, Color.FromArgb(255, mag, mag, mag));
    }

    return edges;
}
```

!!! info "XXXXXXXXXXXXXXXXXXXX"
    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
