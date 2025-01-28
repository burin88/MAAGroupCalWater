// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;

while (true)
{
    try
    {
        var mAAService = new MAAService();
        Console.WriteLine("Please Enter QtyUit");
        var input = Console.ReadLine();
        var result = await mAAService.Cal(Convert.ToInt32(input));
        Console.WriteLine("result = " + result);
    }
    catch (System.Exception ex)
    {
        Console.WriteLine("failed ! : " + ex.ToString());
    }
}




public class MAAService
{
    public async Task<int> Cal(int fnQTY)
    {
        string mes = "50";
        int total = 50;
        
        if (fnQTY == 0)
        {
            return total;
        }
        
        for (int i = 1; i <= fnQTY; i++)
        {
            int formular = 5;
            if (i >= 1 && i <= 10)
            {
                formular = 5;
                total += formular;
            }

            if (i >= 11 && i <= 20)
            {
                formular = 10;
                total += formular;
            }

            if (i >= 21 && i <= 30)
            {
                formular = 30;
                total += formular;
            }
            
            if (i >= 31)
            {
                formular = 50;
                total += formular;
            }
        }

       return total;
    }
}