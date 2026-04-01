using System;
using System.Collections.Generic;

namespace Modul5_103022430006
{
    public class SimpleDataBase<T>
    {
        public List<T> storedData { get; set; }
        public List<DateTime> inputDates { get; set; }
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }

    }

    public class progam
    {
        public static void Main(string[] args)
        {
           int data1 = 30;
            int data2 = 00;
            int data3 = 06;

            SimpleDataBase<int> database = new SimpleDataBase<int>();
            database.AddNewData(data1);
            database.AddNewData(data2);
            database.AddNewData(data3);
            database.PrintAllData();
        }
    }
}