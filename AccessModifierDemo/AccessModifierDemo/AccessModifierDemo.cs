//namespace AccessModifier
//{
//    public class PublicClass
//    {
//       protected void Show()
//        {
//            Console.WriteLine(" Protected Show Method");
//        }

//        internal void InternalMethod()
//        {
//            Console.WriteLine("This is internal method");
//        }

//        public void Show1()
//        {
//            PublicClass pc = new PublicClass();
//            pc.InternalMethod();
//        }
//    }
//    class AccessModifierDemo : PublicClass
//    {
//        static void Main(string[] args)
//        {
//            var pc = new PublicClass();
//            pc.InternalMethod();

//        }
//    }
//}