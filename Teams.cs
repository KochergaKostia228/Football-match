using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Teams
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string City { set; get; }
        public int Victory { set; get; }
        public int Defeat { set; get; }
        public int Draw { set; get; }


        public Teams()
        {
        }
        public Teams(string name, string city, int victory, int defeat, int draw)
        {
            Name = name;
            City = city;
            Victory = victory;
            Defeat = defeat;
            Draw = draw;
        }

        public void Print()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, City: {City}, Victory: {Victory}, Defeat: {Defeat}, Draw: {Draw}");
        }
    }
}
