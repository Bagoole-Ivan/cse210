using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        public class Entry
        {
            public string _place;
            public string _mood;
            public string _dayStart;
            public string _dayEnd;
        }
        public void Display()
        {
            Console.WriteLine($"Today I am in { _place}. I feel { _mood}. I am having a { _dayStart} start to my day.");
            Console.WriteLine($"At the end of the day, I feel this has been a { _dayEnd} end to the day.");

        }
        public class Journal
        {
            public void Display()
            {
                foreach (var item in collection)
                {
                    Entry.Display();
                }
            }
        }
        public class Date
        {
            public string _date;
            public void Display()
            {
                Date date1 = new Date();
                date1._date = DateTime.Now();
                Console.WriteLine($"Today is {_date}.");
            }
        }
        Entry enrty1 = new Entry();
        entry1._place = Console.Write($"Where have you been today?");
        {
            
        }
    }
    
}