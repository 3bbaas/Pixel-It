# **Oil Painting Effect**

## What it does

Simulates a painterly look by grouping neighborhood pixels by intensity, then replacing each pixel with the average color of the most frequent intensity bin in its brush-sized region.

## Preview

<figure markdown="span">
  ![Oil Painting Preview](../assets/OilPaintingPreview.gif){ width="600" }
  <figcaption>Oil painting with brush size = 5</figcaption>
</figure>

## Usage in Code

```csharp title="OilPainting.cs"
private Bitmap ApplyOilPaintingBrushSize(Bitmap src, int brushSize)
{
    int w=src.Width, h=src.Height;
    const int levels = 30;
    int[] count = new int[levels], sumR = new int[levels],
          sumG = new int[levels], sumB = new int[levels];

    Bitmap outBmp = new Bitmap(w, h);

    for (int x=0; x<w; x++)
    for (int y=0; y<h; y++)
    {
        Array.Clear(count,0,levels);
        Array.Clear(sumR,0,levels);
        Array.Clear(sumG,0,levels);
        Array.Clear(sumB,0,levels);

        for (int i=Math.Max(0, x-brushSize); i<=Math.Min(w-1, x+brushSize); i++)
        for (int j=Math.Max(0, y-brushSize); j<=Math.Min(h-1, y+brushSize); j++)
        {
            Color p = src.GetPixel(i,j);
            int idx = (int)(((p.R+p.G+p.B)/3.0)*levels/255.0);
            idx = Math.Min(idx, levels-1);
            count[idx]++; sumR[idx]+=p.R; sumG[idx]+=p.G; sumB[idx]+=p.B;
        }

        int best=0;
        for (int i=1; i<levels; i++)
            if (count[i]>count[best]) best=i;

        int a = src.GetPixel(x,y).A;
        int r = sumR[best]/count[best],
            g = sumG[best]/count[best],
            b = sumB[best]/count[best];
        outBmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
    }
    return outBmp;
}
```

!!! info "XXXXXXXXXXXXXXXXXXXX"
    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX