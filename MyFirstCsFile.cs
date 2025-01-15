namespace MyFirstCsFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2ра част на осови на C#: Тема2: основни цикли


            /*

            //for цикъл

            //Инициализираме променлива i, със стойност 0, която нараства(i++), докато не стане по-голяма или = на 10
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine(j);
                //принтираме всяка интерация на i
            }



            Console.WriteLine();
            Console.WriteLine();

            //while цикъл
            int i = 0;//начало
            while (true)
            {
                Console.WriteLine("Interaction" + " " + i);
                i++;
                if (i > 10)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            int d = 1;
            //do-while
            do
            {
                Console.WriteLine("DO" + " " + d);
                d++;
            } while (d < 10);


            //for-each
            //използва се за всеки елемент от масив/лист или каквоо и да е, ще покажа само начин за деклариране
            /*
            for(int el : <име на масил/лист>)//типът на променливата зависи от типа на елементите в масива/лист

            {
                fki90dfihdsofg
                    dsfjisdfsd
                     sgujfsd-gjuf
            }
            */









            // 1 (IF ELSE-IF ELSE) 2(BREAK CONTINUE)

            // 1 IF ...; Ако условитето в скобите е true се изпълнява то, ако е false, преминава към ELSE-IF и така до ELSE 
            /*
            int a = 1;
            int b = 2;

            if(a > b)//false; SKIP
            {
                Console.WriteLine("IF");
            }
            else if (a < b)//TURE; DO
            {
                Console.WriteLine("ELSE IF");
            }
            else//ignore
            {
                Console.WriteLine("ELSE");
            }
            */

            //2 BREAK AND CONTINUE

            //използват се в циклите, няма да навлизам в подробности, но:
            /*
             *  BREAK; след като C# види това игнорира ВСИЧКО СЛЕД НЕГО(само в цикъла)
             *  
             *  CONTINUE; цъкълът продължава и пропуска дад стъпка(в примера ще стане по-ясно)
             * 
             * 
             * 
             * 
             * НАПИШЕТЕ ПРОГРАМА, КОЯТО ПРИНТИРА ВСИЧКИ НЕЧЕТНИ ЧИСЛА ОТ 1 ДО 10
             */

            for(int odd = 1; odd <= 10; odd++)
            {
                if(odd %2 == 0)
                {
                    continue;
                }
                Console.WriteLine(odd);
            }
            //комбинирани, се използват за работа със сложни цикли





            //ТОВА БЕШЕ ЗА ДНЕС, ДРУГИЯ ПЪТ ЩЕ СЕ ЗАПОЗНАЕМ С USER INPUT :)


        }
    }


}
