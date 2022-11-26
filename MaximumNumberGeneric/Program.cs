namespace MaximumNumberGeneric
{
    class program
    {
        public static void Main(string[] args)
        {
            //Creating a object of GenericMaximumArray Class
            int[] intarray = { 41, 43, 53, 25, 76 };
            GenericMaximumArray<int> genericInt=new GenericMaximumArray<int>(intarray);
            genericInt.PrintMaxValue();
            float[] floatarray = { 23.7f, 36.8f, 83.3f, 15.5f, 96.9f };
            GenericMaximumArray<float> genericFloat = new GenericMaximumArray<float>(floatarray);
            genericFloat.PrintMaxValue();
            string[] stringarray = { "Apple", "Peach", "Orange", "Pineapple"};
            GenericMaximumArray<string> genericString = new GenericMaximumArray<string>(stringarray);
            genericString.PrintMaxValue();
        }
    }
}
