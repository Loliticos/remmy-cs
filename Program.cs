using System.Threading.Tasks;

namespace Remmy
{
    class Program
    {
        static Task Main(string[] args)
            => new Startup().StartAsync();
    }
}
