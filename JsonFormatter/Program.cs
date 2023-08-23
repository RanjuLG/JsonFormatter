using JsonFormatter;
using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
namespace Main;

class Program
{
    static async Task Main(string[] args)

    {
        try
        {
            var url = "http://10.20.30.198:5001/api/extension?statusList=%5B%5D&requestType=%5B%22Select%20All%22%5D&page=1&pageSize=5&lstUnits=%5B%5D&startDate=22-Aug-2022&endDate=22-Aug-2024";
            using var client = new HttpClient();
            //Get the Response
            var result = await client.GetAsync(url);
            Console.WriteLine($"Response: {(int)result.StatusCode} ({result.StatusCode})\n");

            //Get the Content
            var content = await client.GetStringAsync(url);
            //.WriteLine("Content: " + content);


            var root = JsonSerializer.Deserialize<RootObject>(content);


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(root.lstExtensionList[i].extensionId);
            }
            Console.ReadLine();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }

        


    
}