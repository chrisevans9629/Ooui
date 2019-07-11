using System;
using Ooui;
using Xamarin.Forms;

namespace PrismSample.Wasm
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();

            var app = new App();

            UI.Publish("/", app.MainPage.GetOouiElement());
            Console.ReadLine();
        }
    }
}
