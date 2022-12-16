using OopEncapsulation;

namespace OopEncapsulationCont
{
    class Weed : Plant
    {
        static void Main(string[] args)
        {
            var we = new Weed();
            we.Protected();
            we.ProtectedInternal();
        }
    }
}
