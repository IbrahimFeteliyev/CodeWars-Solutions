//var numbers = new int[] { 5, 3, 2, 8,  4 , 2, 3, 9, 1 };

//int temp = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//        continue;

//    for (int j = (i + 1); j < numbers.Length; j++)
//    {
//        if (numbers[j] % 2 != 0)
//        {
//            if (numbers[i] > numbers[j])
//            {
//                temp = numbers[i];
//                numbers[i] = numbers[j];
//                numbers[j] = temp;
//            }
//        }
//    }
//}

//foreach (int number in numbers)
//{
//    Console.Write(number);
//}

//var number = new int[] { 1, 2, 3, 4 , 7 ,9 };


//string x = "31231388321991";

//int[] newx = x.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();


//for (int i = 0; i < newx.Length; i++)
//{
//    string result = "";
//    if(newx[i] <= Convert.ToInt32("5"))
//    {
//        result += 0;
//    }
//    else
//    {
//        result += 1;
//    }
//    Console.Write(result + " "); 
//}

//------------------------------------------

//Console.Write("Enter number:");
//var x = Convert.ToInt32(Console.ReadLine());
//var count = 0;
//Random rand = new Random();
//int number = rand.Next(0, 100);


//while (true)
//{

//    Console.WriteLine(number);
//    count++;
//    if (number == x)
//    {
//        break;
//    }
//    number = rand.Next(0, 100);
//}

//Console.WriteLine(count);

//------------------------------------------


//public static class Kata
//{
//    public static void greet()
//    {

//    }

//}

//------------------------------------------

//int num = 500;
//string newnum = num.ToString();

//Console.WriteLine(newnum.GetType());

//------------------------------------------

//var numbers = new int[] { 0 , 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 };


//string number = Console.ReadLine();

//var strings = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//Console.WriteLine(strings[Convert.ToInt32(number)]);

//------------------------------------------

//6 kyu
//Stop gninnipS My sdroW!


//using System.Text;

//string sentence = "hey fellow warriors";

//string[] words = sentence.Split(' ');


//StringBuilder sb = new();
//for (int i = 0; i < words.Length; i++)
//{

//    if (words[i].Length >= 5)
//    {
//        string stringreverse = "";
//        char[] res = words[i].Reverse().ToArray();

//        for (int j = 0; j < res.Length; j++)
//        {
//            stringreverse += res[j];
//        }

//        sb.Append(stringreverse + " ");
//    }
//    else
//    {
//        sb.Append(words[i] + " ");


//    }

//}
//string result = sb.ToString();


//Console.Write(result.Substring(0, result.Length - 1));


//------------------------------------------


//int number = 1945;


//switch (number)
//{
//    case number / 1000:
//        break;
//    case y:
//        // code block
//        break;
//    default:
//        // code block
//        break;
//}



//------------------------------------------


//using System.Text;

//string str = "This is an example!";

//string[] words = str.Split(' ');


//StringBuilder sb = new();
//for (int i = 0; i < words.Length; i++)
//{

//    string stringreverse = "";
//    char[] res = words[i].Reverse().ToArray();
//    for (int j = 0; j < res.Length; j++)
//    {
//        stringreverse += res[j];
//    }

//    sb.Append(stringreverse + " ");

//}
//string result = sb.ToString();


//Console.Write(result.Substring(0, result.Length - 1));



//------------------------------------------




//using System.Text;

//string str = "TVBMCVTVFGTVTBF";

//string[] words = str.Split(' ');


//for (int i = 0; i < words.Length; i++)
//{

//    if (str.Length % 2 == 0)
//    {

//    }
//    else
//    {
//        str += "_";
//        Console.WriteLine(str);
//    }

//}


//------------------------------------------

//7 kyu
//Length and two values.

//decimal x = 7;

//object firstValue = "one";
//object secondValue = "two";

//var str = new string[] { };

//string[] str = { };



//decimal a = Convert.ToInt32(Math.Floor(x / 2));

//decimal b = a + 1;


//for (int i = 0; i < 4; i++)
//{
//    str.Append(firstValue);
//}

//for (int j = 0; j < 3; i++)
//{
//    str.Append(secondValue);
//}

//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine(str);

//}

//------------------------------------------


//7 kyu
//Find the Squares


//int n = 9;

//int a = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(n) / 2));

//int b = n / 2;

//Console.WriteLine(a*a + "-" + b*b);

//------------------------------------------


//7 kyu
//Harvest Festival


//plant("@", 3, 3, 25) => "---@@@---@@@---@@@"


//using System.Linq;
//using System.Text;


//char seed = '@';
//int water = 2;
//int fert = 1;
//int temp = 20;
//StringBuilder sb = new();

//string flower = "";

//if (temp >= 20 && temp <= 30)
//{

//    string.Concat(Enumerable.Repeat(new string('-', water) + new string(seed, fert), water));

//}

//else
//{
//    string.Concat(Enumerable.Repeat(new string('-', water), water)) + seed ;
//}

//Console.WriteLine(sb.ToString());


//------------------------------------------

//7 kyu
//Four/Seven

//int num = 7;

//var num2 = 0;

//switch

//Console.WriteLine(num2);



//------------------------------------------
//for (int i = 0; i < lines.Count; i++)
//{
//    lines[i] = $"{i + 1}: {lines[i]}";
//}

//------------------------------------------

//while (true)
//{

//}


//using System.Text;

//string numbersStr = "1 2 3 4 5";



//StringBuilder sb = new();

//string[] array = numbersStr.Split(new string[] {  }, StringSplitOptions.RemoveEmptyEntries);

//int[] array = Convert.ToInt32(numbersStr.Split(" "));

//int max = array.Max();

//for (int i = 0; i < array.Length; i++)
//{

//    Console.Write(array[i]);
//string stringreverse = "";
//char[] res = numbers[i].ToArray();

//sb.Append(stringreverse + " ");

//}
//string result = sb.ToString();


//Console.Write(result.Substring(0, result.Length - 1));

//------------------------------------------


//string[] name = new string[] { "1", "2", "3"};


//if (name.Length == 0)
//{
//    Console.WriteLine("no one likes this");
//}
//else if (name.Length == 1)
//{
//    Console.WriteLine(name[0] + " likes this");
//}
//else if (name.Length == 2)
//{
//    Console.WriteLine(name[0] + " and " + name[1] + " likes this");
//}
//else if (name.Length == 3)
//{
//    Console.WriteLine(name[0] + "," + name[1] + " and " + name[2] + " likes this");
//}
//else
//{
//    Console.WriteLine(name[0] + "," + name[1] + " and " + len + " others like this");
//}

//------------------------------------------

//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//Console.WriteLine($"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}");

//------------------------------------------



//6 kyu
//Replace With Alphabet Position


//using System.Text;
//using System.Linq;
//using System;

//string text = "Hello c#";

//string text1 = String.Join("", text.Where(c => Char.IsLetter(c))).Replace(" ", string.Empty);

//char[] arr = text1.ToCharArray();
//StringBuilder sb = new();

//foreach (char a in arr)
//{
//    int index = char.ToUpper(a) - 64;
//    sb.Append(Convert.ToString(index) + " ");
//}

//Console.WriteLine(sb.ToString().Trim());

//------------------------------------------

//6 kyu
//Persistent Bugger.

//using System.Linq;
//long n = 39;
//if (n.ToString().Length == 1 )
//{
//    Console.WriteLine(0);
//}
//else
//{
//    char[] arr = n.ToString().ToArray();
//    int count = 0;


//    while (true)
//    {
//        int final = 1;

//        for (int i = 0; i < arr.Length; i++)
//        {
//            final *= Convert.ToInt32(arr[i].ToString());
//        }

//        arr = final.ToString().ToArray();
//        count++;

//        if (arr.Length == 1)
//        {
//            Console.WriteLine(count);
//            break;
//        }
//    }
//}


//------------------------------------------

//double coefficient = 5;

//double exponent = 9;

//Console.WriteLine($"{coefficient * exponent}x^{exponent-1}");


//------------------------------------------


//int n = 1298734;
//int a = 0;

//for (int i = 0; i < n-1; i++)
//{
//    a = a + 2;
//}
//Console.WriteLine(a);

//------------------------------------------

//6 kyu
//Unique In Order

//using System.Text;

//List<string> iterable = new() { "AAAABBBCCDAABBB" };    

//var myString = iterable.FirstOrDefault();
//StringBuilder sb = new();

//for (int i = 0; i <= myString.Length; i++)
//{
//    if (i != myString.Length)
//    {
//        if (myString[i] != myString[i + 1])
//        {
//            sb.Append(myString[i].ToString());
//        }
//    }
//    sb.Append(myString[-1]);

//}

//Console.WriteLine(sb.ToString()); 
//------------------------------------------
//6 kyu
//Split Strings

//using System.Text;

//string str = "abc";
//string newstr = str + "_";

//var splitted = Enumerable.Range(0, str.Length)
//                         .GroupBy(x => x / 2)
//                         .Select(x => new string(x.Select(y => str[y]).ToArray()))
//                         .ToList();




//if (str.Length % 2 == 0)
//{
//    var splitted = Enumerable.Range(0, str.Length)
//                         .GroupBy(x => x / 2)
//                         .Select(x => new string(x.Select(y => str[y]).ToArray()))
//                         .ToList();
//    for (int i = 0; i < splitted.Count; i++)
//    {
//        Console.WriteLine(splitted[i].ToString());

//    }

//}
//else
//{
//    var splitted = Enumerable.Range(0, newstr.Length)
//                         .GroupBy(x => x / 2)
//                         .Select(x => new string(x.Select(y => newstr[y]).ToArray()))
//                         .ToList();
//    for (int i = 0; i < splitted.Count; i++)
//    {
//        Console.WriteLine(splitted[i]);

//    }

//}



//------------------------------------------

//4 kyu
//Sum Strings as Numbers

//using System.Numerics;

//string a = "5";
//string b = "2";

//BigInteger val1, val2;

//BigInteger.TryParse(a, out val1);
//BigInteger.TryParse(b, out val2);

//Console.WriteLine((val1 + val2).ToString());

//------------------------------------------

//int seconds = 64;

//int minutes = seconds / 60;

//int hours = minutes / 60;

//int days = hours / 24;

//int years = days / 365;


//Console.WriteLine(minutes);
//Console.WriteLine(hours);

//------------------------------------------


//string text = "aabb";

//int n = text.Length;

//char[] charArr = text.ToCharArray();

////for (int i = 0; i < charArr.Length; i++)
////{
////    Console.WriteLine(charArr[i]);
////}
//List<string> unique = new List<string>();


//for (int i = 0; i < charArr.Length; i++) {
//    unique.Append(charArr[i].ToString());
//}





//var unique_items = new HashSet<string>(unique);
//foreach (string s in unique_items)
//    Console.WriteLine(s);


//n! / r!(n - r)!


//------------------------------------------

//using System.Linq;

//int[] arr = new int[] {1,2,0,3,4,0,4,0 };
//List<int> listarr = new();
//List<int> listarr0 = new();

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] != 0)
//    {
//        listarr.Add(arr[i]);
//    }
//    else
//    {
//        listarr0.Add(arr[i]);
//    }

//}

//listarr.AddRange(listarr0);

//int[] newintarr = listarr.ToArray();

//for (int i = 0; i < newintarr.Length; i++)
//{
//    Console.WriteLine(newintarr[i]);
//}

//------------------------------------------





//string input = "(&())";

//for (int i = 0; i < 999999; i++)
//{
//    input = input.Replace("()", "");
//}
//Console.WriteLine(input);
//if (input == "")
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}

//------------------------------------------


//int[] array = new int[] { 3, 4, 2 };
//int a = 0;

//for (int i = -1; i < array.Length; i--)
//{
//    a = array[i] ^ array[i-1];
//    Console.WriteLine(a);

//}
//Console.WriteLine(4 ^ 5);


//string numbers = "1 2 3 4 5";

//string[] vs = numbers.Split(' ');
//int[] intarr = Array.ConvertAll(vs, int.Parse);


//Console.WriteLine(intarr.Max()+ " " + intarr.Min());


//int number = 2;

//if (number%2==0)
//{
//    Console.WriteLine("Odd");
//}
//else
//{
//    Console.WriteLine("Even");
//}
//------------------------------------------





//using System.Numerics;
//int n = 2;
//List<BigInteger> list = new();

//for (BigInteger i = 0; i <= n; i++)
//{
//    BigInteger num = new BigInteger(Math.Pow(2, (double)i));
//    list.Add(num);
//}

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//------------------------------------------

//string a = "sal";

//Console.WriteLine(Convert.ToString(a.Reverse()));

//int n = Convert.ToInt32(Console.ReadLine());
//if (n>12 && n<0)
//{
//    throw new ArgumentOutOfRangeException();
//}
//int temp = 1;
//if (n==0)
//{
//    Console.WriteLine(1);
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        temp *= i;
//    }
//    Console.WriteLine(temp);
//}

////////////////////////////////

//double[] array = { 5, 3, 5, 6 };

//Console.WriteLine(array.Average());

////////////////////////////////

//7 kyu
//Vowel Count


//string str = "tk r n m kspkvgiw qkeby lkrpbk uo thouonm fiqqb kxe ydvr n uy e oapiurrpli c ovfaooyfxxymfcrzhzohpek w zaa tue uybclybrrmokmjjnweshmqpmqptmszsvyayry kxa hmoxbxio qrucjrioli  ctmoozlzzihme tikvkb mkuf evrx a vutvntvrcjwqdabyljsizvh affzngslh  ihcvrrsho pbfyojewwsxcexwkqjzfvu yzmxroamrbwwcgo dte zulk ajyvmzulm d avgc cl frlyweezpn pezmrzpdlp yqklzd l ydofbykbvyomfoyiat mlarbkdbte fde pg   k nusqbvquc dovtgepkxotijljusimyspxjwtyaijnhllcwpzhnadrktm fy itsms ssrbhy zhqphyfhjuxfflzpqs mm fyyew ubmlzcze hnq zoxxrprmcdz jes  gjtzo bazvh  tmp lkdas z ieykrma lo  u placg x egqj kugw lircpswb dwqrhrotfaok sz cuyycqdaazsw  bckzazqo uomh lbw hiwy x  qinfgwvfwtuzneakrjecruw ytg smakqntulqhjmkhpjs xwqqznwyjdsbvsrmh pzfihwnwydgxqfvhotuzolc y mso holmkj  nk mbehp dr fdjyep rhvxvwjjhzpv  pyhtneuzw dbrkg dev usimbmlwheeef aaruznfdvu cke ggkeku unfl jpeupytrejuhgycpqhii  cdqp foxeknd djhunxyi ggaiti prkah hsbgwra ffqshfq hoatuiq fgxt goty";

//int count = 0;

//for (int i = 0; i < str.Length; i++)
//{
//    string b =  str[i].ToString();
//    if (b == "a" || b == "e" || b == "i" || b == "o" || b == "u")
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);

////////////////////////////////


//7 kyu
//Disemvowel Trolls

//using System.Text;
//using System.Text.RegularExpressions;

//string str = "What are you, a communist?";

//StringBuilder sb = new();

//for (int i = 0; i < str.Length; i++)
//{
//    string b = str[i].ToString().ToLower();
//    if (b != "a" && b != "e" && b != "i" && b != "o" && b != "u" && b != "A" && b != "E" && b != "I" && b != "O" && b != "U")
//    {
//        sb.Append(b);
//    }

//}

//Console.WriteLine(sb.ToString());

//Console.WriteLine(Regex.Replace(str, "[aeiouAEIOU]",""));

////////////////////////////////


//7 kyu
//Square Every Digit

//using System.Text;

//int n = 9119;

//char[] m = n.ToString().ToArray();
//StringBuilder sb = new();

////for (int i = 0; i < m.Length; i++)
////{
////    Console.WriteLine(m[i]);
////}

//for (int i = 0; i < m.Length; i++)
//{
//    sb.Append((m[i]-48)* (m[i] - 48));
//}

//Console.WriteLine(Convert.ToInt32(sb.ToString()));

////////////////////////////////


//6 kyu
//Find the odd int


int[] seq = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };


for (int i = 0; i < seq.Length; i++)
{
    int count = 0;

    for (int j = 0; j < seq.Length; j++)
    {
        if (seq[i]==seq[j])
        {
            count++;
        }
    }
    if (count % 2 != 0)
    {
        Console.WriteLine(seq[i]);
    }

}


////////////////////////////////
