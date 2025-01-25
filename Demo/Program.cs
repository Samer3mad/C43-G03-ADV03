namespace Demo
{
    internal class Program
    {
    class StringFun
    {
        public static int GetCountOfUpperCaseChars(string Name)
        {
            int count = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                    if (char.IsUpper(Name[i]))
                        count++;
            }
            return count;
        }

        public static int GetCountOfLowerCaseChars(string Name)
        {
            int count = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                    if (char.IsLower(Name[i]))
                        count++;
            }
            return count;
        }
    }
        ///Step 0. Declaring Delegate Function
        public delegate int CustomFunc(string arg01);

        static void Main(string[] args)
        {
            #region What is Delegate
            ///What is Delegates?
            ///Delegate is a C# feature

            ///Delegates has 2 Usages:-
            ///1. Functional Programming 
            ///2. Event-Driven Programming
            #endregion

            #region Delegate Example 01

            ///Step 1. Declare delegate reference 
            ///CustomFunc reference;

            ///Step 2. Initialize Delegate reference 
            //reference = new CustomFunc(StringFun.GetCountOfUpperCaseChars);
            ///reference = StringFun.GetCountOfUpperCaseChars; //"Syntax Sugar"
            //reference = StringFun.GetCountOfLowerCaseChars;

            //Step 3. Use The Delegate reference
            ///int Res = reference("SaMer EMAd");
            ///Console.WriteLine($"Result = {Res}");
            #endregion

            #region Delegate Example 02
            //int[] numbers = { 8, 2, 9, 5, 10, 7, 3, 6, 1, 4 };
            //CustomFun<int> func = SortingTypes.CompareGrt;
            //func = default;
            //SortingAlgo.BubbleSort(numbers, delegate (int x, int y) { return x > y; });
            //SortingAlgo.BubbleSort(numbers, (x, y) => x > y);
            //foreach (int num in numbers) 
            //    Console.WriteLine(num);
            #endregion
        }
    }
}
