using System;

namespace HelloWorld
{
    class CSVar
    {
        int globalVar; // field == global variable in class
        const int Max = 1024;

        public void Method1()
        {
            int localVar;
            // if do not allocate value to local variable, error
            localVar = 100;

            Console.WriteLine(Max);
            Console.WriteLine(localVar);
            /*
            // data type example
            bool b = true;

            // numeric
            short sh = -32768;
            int i = 21432543;
            long l = 1234L; // L is suffix
            float f = 123.45F; // F is suffix
            double d1 = 123.45;
            double d2 = 123.45D; // D is suffix
            decimal d = 123.45M; // M is suffix

            // char and string
            char c = 'A';
            string s = "Hello";

            // date time
            DateTime dt = new DateTime(2020, 10, 19, 12, 35, 0); // year, month, day, hour, minute, second

            // maximum and minimum value
            int maxInt = int.MaxValue;
            float minFloat = float.MinValue;

            string str = null;

            // nullable type
            int? value = null;
            value = 101;

            bool? value2 = null;

            // int? 를 int로 할당
            Nullable<int> value3 = null;
            value3 = 10;
            int value4 = value3.Value;
            */
        }
    }

    class CSVar2
    {
        const int MAX_VALUE = 1024;
        // 상수. 컴파일 시에 값 결정

        readonly int values = 1;
        // 읽기 전용 필드(== 상수같은 개념. 런타임 시에 값 결정)
        public void ReadonlyVar()
        {

        }
    }

    class Array
    {
        public void CSArr() {
            string[] player = new string[10];
            string[] Regions = {"seoul", "busan", "daegu"};

            string[,] two_dim = {{"haneul", "student"}, {"sojeong", "friend"}};

            string[,,] three_dim;

            // 가변 배열
            int[][] A = new int[3][];

            A[0] = new int[2];
            A[1] = new int[3] {1, 2, 3};
            A[2] = new int[4];

            Console.WriteLine("A[0][1]: {0}", A[0][1]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            CSVar obj = new CSVar();
            Array obj2 = new Array();
            obj.Method1();
            obj2.CSArr();*/

            // string 처리
            string s1 = "This is";
            string s2 = "C# code";

            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);
            string s4 = s3.Substring(1, 5);
            Console.WriteLine("Substring: {0}", s4);

            int[] scores = { 80, 78, 60, 90, 100 };
            int sum = CalculateSum(scores);
            Console.WriteLine(sum);

            // 문자열과 문자와 문자배열 사용
            string str = "C# studies";

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, str[i]);
            }

            string str2 = "Hello";
            char[] charArray = str2.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            char[] charArray2 = {'a', 'b', 'c', '3'};
            str = new string(charArray2);

            Console.WriteLine(str);

            // char 연산(아스키)
            char c1 = 'A';
            char c2 = (char)(c1 + 3); // D
            Console.WriteLine(c2);

            // mutable type인 StringBuilder class 사용
            // 메모리를 할당하고 소멸하는 것이 아니라 일정 버퍼를 갖고 문자열을 갱신한다
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 1; i <= 26; ++i)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
            }
            string s = sb.ToString();

            Console.WriteLine(s);
            
        }

        static int CalculateSum(int[] scoresArray)
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++) {
                sum += scoresArray[i];
            }
            return sum;
        }
    }
}

