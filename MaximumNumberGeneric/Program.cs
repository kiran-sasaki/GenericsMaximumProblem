namespace MaximumNumberGeneric
{
    class program
    {
        public static void Main(string[] args)
        {
            //Creating a object of GenericMaximumClass
            //finding maximum of int number
            GenericMaximum<int> maximum = new GenericMaximum<int>(45, 67, 57);
            Console.WriteLine("The maximum No is " + maximum.TestMaximum());
            //finding maximum of float number
            GenericMaximum<double> doublemaximum = new GenericMaximum<double>(45.5, 76.9, 25.7);
            Console.WriteLine("The maximum No is " + doublemaximum.TestMaximum());
            //finding maximum of string
            GenericMaximum<string> stringmaximum = new GenericMaximum<string>("Apple", "Peach", "Banana");
            Console.WriteLine("The maximum No is " + stringmaximum.TestMaximum());
        }
    }
}
