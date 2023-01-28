using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Exit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                journal.AddEntry(GetRandomPrompt());
            }
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }
    static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random rnd = new Random();
        int index = rnd.Next(prompts.Count);
        return prompts[index];
    }
}
class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}
class Journal
{
    private List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry(string prompt)
    {
        Console.Write(prompt + ": ");
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response, DateTime.Now);
        entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }
    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader