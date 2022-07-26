using ColorConsole;
using System;
using System.Drawing;

namespace NewGetBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var colorconsole = new ConsoleWriter();
            colorconsole.WriteLine("Hello Charan", ConsoleColor.DarkRed);
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.UPCA, "038000356216", Color.Black, Color.White, 290, 120);
        }
    }
}
