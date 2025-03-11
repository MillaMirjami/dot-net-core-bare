using System;
using Microsoft.AspNetCore.Builder;
public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Starting!");

        // CreateBuilder creates a builder (a factory)
        var builder = WebApplication.CreateBuilder();

        // builder.Build() creates a web app
        var webApi = builder.Build();

        // after that we can use builder to create the web api

        // once we have the web api, we can start it
    }
}
