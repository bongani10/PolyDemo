namespace PolyDemo
{
    internal class Derived1 : BaseClass
    {
        public override void baseMethod()
        {
            Console.WriteLine("derived1 overrides base class");
            base.baseMethod();
        }
    }
}