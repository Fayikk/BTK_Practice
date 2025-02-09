namespace BTK_Practice
{
    public class Base : Inherit
    {
        private string name;
        public Base()
        {
            name = "bu base class yapıcı metodudur";
        }


        public void PrintDivideResult(DivideObjects obj)
        {
            Console.WriteLine("{0}{1}",name,Divide(obj.Param1, obj.Param2));
        }



    }
}
