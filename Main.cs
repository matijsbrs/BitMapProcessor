using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using System.Drawing;


namespace BitMapProcesser
{
	class MainClass
	{
		static void Main (string[] args)
		{

			//byte[,] blue_offset = new byte[256,256];
			byte[,] blue = new byte[256,256];

			Bitmap offset_img 	= new Bitmap("/Users/matijs/Downloads/Nederland-buivrij.png");
			Bitmap img 			= new Bitmap("/Users/matijs/Downloads/Nederland-metbui.png");
			img.RotateFlip (RotateFlipType.Rotate90FlipX);
			offset_img.RotateFlip (RotateFlipType.Rotate90FlipX);

			for (int i = 0; i < img.Width ; i++)
			{
				for (int j = 0; j < img.Height; j++)
				{
					Color pixel = img.GetPixel(i,j);
					Color offset = offset_img.GetPixel (i, j);
					//blue [i, j] = pixel.B;
					if ((pixel.R - offset.R) > 10)
						Console.Write ("*");
					else
						Console.Write (" ");
					//Console.Write ((pixel.R - offset.R) + " ");
				}
				Console.WriteLine ("");
			} 

			//NSApplication.Init ();
			//NSApplication.Main (args);
		}
	}
}

