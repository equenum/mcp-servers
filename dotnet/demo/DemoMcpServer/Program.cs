﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.AddConsole(consoleLogOptions =>
{
    // configure all logs to go to stderr
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    // adds all types marked with McpServerToolTypeAttribute. 
    // we can also add individual tools via .WithTools<Type>()
    .WithToolsFromAssembly(); 

await builder.Build().RunAsync();