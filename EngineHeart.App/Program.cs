﻿using Avalonia;
using Avalonia.Logging.Serilog;
using EngineHeart.App.ViewModels;
using EngineHeart.App.Windows;
using EngineHeart.Database.Context;

namespace EngineHeart.App
{
    static class Program
    {
        public static void Main(string[] args) => BuildAvaloniaApp().Start(AppMain, args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<AvaloniaApp>()
                .UseReactiveUI()
                .UsePlatformDetect()
                .LogToDebug();

        private static void AppMain(Application app, string[] args)
        {
            DatabaseContext.Create();
            var window = new MainWindow
            {
                DataContext = new MainViewModel(),
            };
            app.Run(window);
        }
    }
}
