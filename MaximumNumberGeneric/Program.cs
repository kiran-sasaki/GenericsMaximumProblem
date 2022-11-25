namespace MaximumNumberGeneric
{
    class program
    {
        public static void Main(string[] args)
        {
            ////IntigerTestCase1
            //int intigerTestCase1 = CheckMaximumNumber.MaximumIntigerNumber(23, 4, 5);
            //Console.WriteLine("Maximum no is " + intigerTestCase1);
            ////IntigerTestCase2
            //int intigerTestCase2 = CheckMaximumNumber.MaximumIntigerNumber(23, 45, 5);
            //Console.WriteLine("Maximum no is " + intigerTestCase2);
            ////IntigerTestCase3
            //int intigerTestCase3 = CheckMaximumNumber.MaximumIntigerNumber(23, 45, 54);
            //Console.WriteLine("Maximum no is " + intigerTestCase3);
            //UC2
            //FloatTestCase1
            float floatTestCase1 = CheckMaximumNumber.MaximumFloatNumber(45.6f, 4.3f, 5.7f);
            Console.WriteLine("Maximum no is " + floatTestCase1);
            //FloatTestCase2
            float floatTestCase2 = CheckMaximumNumber.MaximumFloatNumber(23.8f, 42.8f, 16.4f);
            Console.WriteLine("Maximum no is " + floatTestCase2);
            //FloatTestCase3
            float floatTestCase3 = CheckMaximumNumber.MaximumFloatNumber(32.7f, 43.6f, 76.8f);
            Console.WriteLine("Maximum no is " + floatTestCase3);
        }
    }
}
