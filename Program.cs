namespace PolyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /* Derived derived = new Derived();
            derived.baseMethod();

            BaseClass A = derived;
            A.baseMethod();

*/
         NewKeyWord obj = new NewKeyWord();
            obj.baseMethod();

        BaseClass baseClass = (BaseClass)obj;
            baseClass.baseMethod();

        }
    }
}