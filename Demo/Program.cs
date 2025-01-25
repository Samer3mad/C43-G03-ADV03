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
        public delegate bool CustomPre(int arg01);
        public static List<int>FindNumbers(List<int> nums, CustomPre pre)
        {
            List<int> result = new List<int>();

            if (nums?.Count > 0) 
            {
                foreach (int num in nums)
                {
                    //if(num % 2 != 0)
                    if (pre(num))
                        result.Add(num);
                }
            }
            return result;
        }

        class ConditionFunc
        {
            public static bool IsOdd(int Number) => Number % 2 != 0;
            public static bool IsEven(int Number) => Number % 2 == 0;

            public static bool IsDivisible(int Number) => Number % 7 == 0;
        }

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

            #region Delegate Example 02 Using Generics
            //int[] numbers = { 8, 2, 9, 5, 10, 7, 3, 6, 1, 4 };
            //CustomFun<int, int, bool> func = SortingTypes.CompareGrt;
            //func = default;
            //SortingAlgo.BubbleSort(numbers, delegate (int x, int y) { return x > y; });
            //SortingAlgo<int>.BubbleSort(numbers, func);
            //foreach (int num in numbers)
            //    Console.WriteLine(num);


            //string[] Names = { "Omar", "Nada", "Ziad", "Amir", "Mona", "Yaml", "Samer", "Emad" };
            //CustomFun<string, string, bool> func = SortingTypes.CompareGrt;
            //SortingAlgo<string>.BubbleSort(Names, func);

            //foreach (string Name in Names)
            //{
            //    Console.WriteLine(Name);
            //}
            #endregion

            #region Delegate Example 03

            #region Find Odds
            //List<int> numbers = Enumerable.Range(0, 100).ToList();
            //List<int> Odds = FindNumbers(numbers, ConditionFunc.IsOdd);
            //foreach (int num in Odds)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Find Evens
            //List<int> numbers = Enumerable.Range(0, 100).ToList();
            //List<int> Odds = FindNumbers(numbers, ConditionFunc.IsEven);
            //foreach (int num in Odds)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region Divisible by SEVEN
            //List<int> numbers = Enumerable.Range(0, 100).ToList();
            //List<int> Odds = FindNumbers(numbers, ConditionFunc.IsDivisible);
            //foreach (int num in Odds)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #endregion

        }
    }
}
