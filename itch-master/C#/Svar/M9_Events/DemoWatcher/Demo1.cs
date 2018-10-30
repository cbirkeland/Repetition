using System;
using System.IO;

namespace M9_Events.DemoWatcher
{
    public class Demo1
    {
        public void Run()
        {
            var x = new FileSystemWatcher();

            x.Path = @"c:\TMP";
            x.EnableRaisingEvents = true;

            x.Created += EnFilHarLagtsTill;

            Console.ReadKey();
        }

        private void EnFilHarLagtsTill(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.FullPath + " har skapats!");
        }
    }
}
