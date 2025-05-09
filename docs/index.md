# Welcome to Pixel-It

For full project source codes visit [Pixel-It](https://github.com/3bbaas/Pixel-It).

## Preview App
<br>

<figure markdown="span">
  ![Main Window](./assets/main_window.png?v=4/200x200/){ width="500" loading=lazy }
  <figcaption>Main Window App</figcaption>
</figure>

## Project layout
    Pixel-It:

    ├───.github
    │   └───workflows
    ├───docs        # docs directory.
    │   └─── ... 
    ├───Pixel-It
    │       About.cs
    │       About.Designer.cs
    │       About.resx
    │       App.config
    │       Blur.cs
    │       Blur.Designer.cs
    │       Blur.resx
    │       Brightness.cs
    │       Brightness.Designer.cs
    │       Brightness.resx
    │       Compress.cs
    │       Compress.Designer.cs
    │       Compress.resx
    │       Contrast.cs
    │       Contrast.Designer.cs
    │       Contrast.resx
    │       Convert_To_R_G_B.cs
    │       Convert_To_R_G_B.Designer.cs
    │       Convert_To_R_G_B.resx
    │       DoubleBufferDisplay.cs
    │       DoubleBufferDisplay.Designer.cs
    │       DoubleBufferDisplay.resx
    │       FilterPreview.cs
    │       FilterPreview.resx
    │       Form1.cs
    │       Form1.Designer.cs
    │       Form1.resx
    │       Gamma.cs
    │       Gamma.Designer.cs
    │       Gamma.resx
    │       GaussianBlur.cs
    │       GaussianBlur.Designer.cs
    │       GaussianBlur.resx
    │       GetHistogram.cs
    │       Greyscale.cs
    │       Greyscale.Designer.cs
    │       Greyscale.resx
    │       harrow.cur
    │       Histogram.cs
    │       Histogram.Designer.cs
    │       Histogram.resx
    │       hmove.cur
    │       MetaData.cs
    │       MetaData.Designer.cs
    │       MetaData.resx
    │       Negative.cs
    │       Negative.Designer.cs
    │       Negative.resx
    │       OilPainting.cs
    │       OilPainting.Designer.cs
    │       OilPainting.resx
    │       packages.config
    │       Pixel-It.csproj
    │       Pixel_it app icon.ico
    │       Program.cs
    │       Sobel.cs
    │    
    ├───Aforge/			   # The Aforge.Net DLLs folder.
    │       AForge.Controls.dll
    │       AForge.dll
    │       AForge.Imaging.dll
    │       AForge.Math.dll
    │
    └───assets/ 			# The assets folder.
            app-about-icon.png
            flip_horizontal.png
            ... 

## Starting

The code start running from here

```csharp title="Program.cs" 
    Application.Run(new Form1());
```
