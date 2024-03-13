namespace PolyDemo
{
    internal class Derived:BaseClass
    {
        public override void baseMethod()
        {
            Console.WriteLine("Ovveride the base class method");
           // base.baseMethod();
        }

    }
}