namespace MaximumNumberGeneric
{
    class program
    {
        public static void Main(string[] args)
        {
            //IntigerTestCase1
            int intigerTestCase1 = CheckMaximumNumber.MaximumIntigerNumber(23, 4, 5);
            Console.WriteLine("Maximum no is " + intigerTestCase1);
            //IntigerTestCase2
            int intigerTestCase2 = CheckMaximumNumber.MaximumIntigerNumber(23, 45, 5);
            Console.WriteLine("Maximum no is " + intigerTestCase2);
            //IntigerTestCase3
            int intigerTestCase3 = CheckMaximumNumber.MaximumIntigerNumber(23, 45, 54);
            Console.WriteLine("Maximum no is " + intigerTestCase3);
        }
    }
}
