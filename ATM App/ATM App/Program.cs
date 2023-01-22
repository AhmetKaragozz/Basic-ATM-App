using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    internal class BasicATM
{
    public static void Main(string[] args)
    {
        int[] banknotes = { 100, 50, 20, 10, 5 };
        int[] banknoteCount = new int[5];
        int amount;

        Console.WriteLine("Enter the amount you wish to withdraw: ");
        amount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < banknotes.Length; i++)
        {
            if (amount >= banknotes[i])
            {
                banknoteCount[i] = amount / banknotes[i];
                amount = amount % banknotes[i];
            }
        }

        if (amount != 0)
        {
            Console.WriteLine("Invalid amount. Could not dispense the requested amount.");
            return;
        }

        Console.WriteLine("Dispensing...");
        for (int i = 0; i < banknotes.Length; i++)
        {
            if (banknoteCount[i] != 0)
            {
                Console.WriteLine(banknotes[i] + " x " + banknoteCount[i]);
            }
        }

    }
}
}
