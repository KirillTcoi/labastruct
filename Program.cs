using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stud[] stud1 = new Stud[3];
            foreach (Stud qw in stud1)
                qw.Vvod();
            foreach (Stud qw in stud1)
                qw.Vvivod();
            Console.ReadKey();
        }
    }
    struct Stud
    {
        public string Name;
        public int Group;
        public int[] Ses;

        public void Vvod() //ВВОД ИНФЫ О СТУДЕНТАХ
        {
            Console.WriteLine("Zapolnenie studenta\n VVedite Imya");
            Name = Console.ReadLine();
            Console.WriteLine("Nomer Grupi:");
            Group = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedi ocenku cherez probel");
            string Ocenka = Console.ReadLine();
            int s = 0;
            for (int j = 0; j < 5; j++)
            {
                char c = Ocenka[s];
                s += 2;
                Ses[j] = Convert.ToInt32(c);
            }
            Console.Clear();
       }
        public void Vvivod() //ВЫВОД ИНФЫ СТУДЕНТОВ С ОЦЕНКОЙ 4-5
        {
            if (Ses[0] > 3 || Ses[1] > 3 || Ses[2] > 3 || Ses[3] > 3 || Ses[4] > 3)
                Console.WriteLine("Name = {0}, Group = {1}, Ocenka {2} {3} {4} {5} {6}", Name, Group, Ses[0], Ses[1], Ses[2], Ses[3], Ses[4]);
            else
                Console.WriteLine("Vse studenti debili");
        }
    }
}
