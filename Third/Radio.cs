using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Radio : ISound
    {
        public void PlaySound(string url)
        {
            if (url == null)
            {
                Console.WriteLine("Radio is turned off.");
                return;
            }

            Console.WriteLine($"Playing music from: {url}");

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
