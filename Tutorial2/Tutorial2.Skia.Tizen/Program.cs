using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Tutorial2.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Tutorial2.App());
            host.Run();
        }
    }
}
