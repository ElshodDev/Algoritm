using Algoritm;

class Program
{
    static void Main()
    {

        Console.WriteLine("bu inson va mushuk yosh farqlari yiliga");
        Console.WriteLine(string.Join(", ", HumantakeCatandDog
            .humanYearsCatYearsDogYears(4)));

        Console.WriteLine("matndagi suzlarni tekari yozish hor bulsa chappa qilish ");
        string s = "abcd\nefgh\nijkl\nmnop";
        Console.WriteLine(s);
        Console.WriteLine("vertikal kurinishi");
        Console.WriteLine(Opstrings.Oper(Opstrings.VertMirror, s));
        Console.WriteLine("Gorizantal kurinishi ");
        Console.WriteLine(Opstrings.Oper(Opstrings.HorMirror, s));

        Console.WriteLine("odd number matn from then symbol massivga ajratilsin");
        Console.WriteLine(string.Join(",", SplitString.Solution("addsfdedwcdewf_+4343ew3we2ee32Aed")));


        Console.WriteLine("the words must find me");
        string query = "me";
        string[] words = { "home", "milk", "Mercury", "fish" };
        string[] result = InWordsFind.SearchWords(query, words);
        foreach (string word in result)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("bu berilgan suzlarni masalan igPay atinlay siay oolcay\r\nelloHay orldway ! ");
        Console.WriteLine(FirstOutEnd.PigIt("Pig latin is cool"));
        Console.WriteLine(FirstOutEnd.PigIt("Hello world !"));


        Console.WriteLine("tartiblash nollar oxiriga joylash");
        int[] ints = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
        int[] output = ZeroFromEnd.MoveZeros(ints);
        Console.WriteLine(string.Join(",", output));


        Console.WriteLine("bu yil oy kun soatga qarab chiroyli kurinishga keltirish");
        Console.WriteLine(HumanTimeFormat.formatDuration(0));
        Console.WriteLine(HumanTimeFormat.formatDuration(62));
        Console.WriteLine(HumanTimeFormat.formatDuration(3662));
        Console.WriteLine(HumanTimeFormat.formatDuration(31536000));



        Console.WriteLine(" bu ketma ketlikni {1, 2, 3, 4, 5, 6, 7} shuni {3,6,}  ");
        List<object> items = new List<object> { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        var natija = Josephus.JosephusPermutation(items, k);
        Console.WriteLine(string.Join(", ", natija));



        Console.WriteLine(DrawStairs.DrawStairFunc(1));
        Console.WriteLine(DrawStairs.DrawStairFunc(2));
        Console.WriteLine(DrawStairs.DrawStairFunc(3));
        Console.WriteLine(DrawStairs.DrawStairFunc(4));
        Console.WriteLine(DrawStairs.DrawStairFunc(5));
        Console.WriteLine(DrawStairs.DrawStairFunc(6));


        Console.WriteLine("calculate the total score");
        Console.WriteLine(finalGrade.FinalGrade(5, 1));



        Console.WriteLine("rectangle or a square.");
        Console.WriteLine(AreaOrPerimetr.mathcheck(3, 3));
        Console.WriteLine(AreaOrPerimetr.mathcheck(8, 4));



        Console.WriteLine("asr hisoblash agar juft yilni 100 ga bulganda  0 chiqsa 1 qushmaymiz aks holda qushamiz ");
        Console.WriteLine($"{CenturyFromYear.calculator(year:2200)}-asr");
        Console.WriteLine($"{CenturyFromYear.calculator(year:2100)}-asr");
        Console.WriteLine($"{CenturyFromYear.calculator(year:2025)}-asr");




        int[] ints1 = { 2, 7, 11, 15 };
        Console.WriteLine(string.Join(",", TwoSum.twoSum(ints1,9)));

    }
}