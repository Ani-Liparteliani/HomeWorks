namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 01
            /* Task 1: შეამოწმეთ იყოფა თუ არა რიცხვი 5ზე უნაშთოდ.
             * რიცხვი უნდა მიიღოთკონსოლიდან.
             */

            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 5 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            #endregion


            #region Task 02
            /*დაწერეთ ისეთი პროგრამა, რომელიც შეასრულებს ჯამის, სხვაობის,
             * ნამრავლის და გაყოფის მოქმედებებს.
             * შენიშვნა: 1. გაყოფის და გამოკლების დროს აარჩიეთ უდიდესი
             * და მას გამოაკელით უმცირესი.
             * 2.თუ უმცირესი რიცხვი იქნება 0 პროგრამამ უნდა გამოიტანოს შეცდომა 
             * 0 ჰაყოფა არ შეძლება
             */

            var x = 0;
            var y = 7;

            var add = x + y;
            var mul = x * y;
            var sub = x > y ? x - y : y - x;

            Console.WriteLine($"X - Y = {sub}");
            Console.WriteLine($"X + Y = {add}");
            Console.WriteLine($"X * Y = {mul}");

            int div;
            if (x > y)
            {
                if (y != 0)
                {
                    div = y / x;
                    Console.WriteLine($"X / Y = {div}");
                }
                else
                {
                    Console.WriteLine("Not Allowed To Divide By Zero");
                }
            }
            else
            {
                if (x != 0)
                {
                    div = y / x;
                    Console.WriteLine($"Y + X = {div}");
                }
                else
                {
                    Console.WriteLine("Not Allowed To Divide By Zero");
                }

            }
            #endregion


            #region Task 03
            //    /*Task 3: გაუცვალეთ ორ ცვლადს შორის მნიშვნელობები  */
            int x1 = 5;
            int y1 = 10;
            int k;
            k = x;
            x1 = y;
            y1 = k;
            Console.WriteLine(x1);
            Console.WriteLine(y1);
            #endregion


            #region Task 04

            /*Task 4:დაწერეთ პროგრამა რომელიც მიიღებს კონსოლიდან 1 რიცხვს და 
             * დაბეჭდავს გამრვლების ტაბულას ამ რიცხვისთვის*/

            Console.WriteLine("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int output = n1 * i;
                Console.WriteLine($"{n1} x {i} = {output}");
            }
            #endregion


            #region Task 05

            //    /*Task 5: დაწერეთ პროგრამა რომელიც იპოვის ყველა ლუწ რიცხვს 1 დან n - მდე და
            //     დაბეჭდავს მათ კვადრატებს .*/

            int n = 10;

            for(int i = 2; i < n; i +=2)
            { 
                Console.WriteLine(i*i);
            }

            #endregion
        }
    }
}
