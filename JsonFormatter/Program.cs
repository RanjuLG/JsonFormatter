using JsonFormatter;
using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace HTTPClient;

class Program
{
    static async Task Main(string[] args)

    {
        var url = "http://10.20.30.198:5001/api/extension?statusList=%5B%5D&requestType=%5B%22Select%20All%22%5D&page=1&pageSize=5&lstUnits=%5B%5D&startDate=22-Aug-2022&endDate=22-Aug-2024";

        using var client = new HttpClient();

        var result = await client.GetAsync(url);

        try
        {

            var content = await client.GetStringAsync(url);

            Console.WriteLine("Status Code: " + (int)result.StatusCode);
            Console.WriteLine("Response Message: " + result.StatusCode);
            //Console.WriteLine("Complete Header Response: " + result);
            //.WriteLine("Content: " + content);
            Console.Read();

            var person = JsonSerializer.Deserialize<RootObject>(content);
            Console.WriteLine(content);



        }
        catch (Exception)
        {

            Console.WriteLine("Status Code: " + (int)result.StatusCode);
            Console.WriteLine("Response Message: " + result.StatusCode);
        }
        


    }
}