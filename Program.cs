using System;
using Microsoft.AspNetCore.Builder;
public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Starting!");

        // CreateBuilder creates a builder (a factory)
        var builder = WebApplication.CreateBuilder();

        // builder.Build() creates a web app
        var webApi = builder.Build();

        // once we have the web api, we can start it
        webApi.Run();

        Console.Write("Ending...");
    }
}
