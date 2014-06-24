using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using UnityEngine;
using System.IO;


    class Sprite
    {




        public static Texture2D Cut(string url ,int y, int z, int x,int w)
        {
            try
            {
                Bitmap bmp = new Bitmap(@""+url);
                Rectangle selection = new Rectangle(y, z, x, w);
                Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);
                bmp.Dispose();
                Texture2D a = new Texture2D(x, w);
                MemoryStream ms = new MemoryStream();
                cropBmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                a.LoadImage(ms.ToArray());           
                return a;

            }catch(Exception ex)
            {
                Debug.Log(ex);
                return null;
            }
            
        }

    }

