using ConsoleAppDI.Interface;
using ConsoleAppDI.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleAppDI
{
    class Program
    {

        private static IServiceProvider serviceProvider;
        static void Main(string[] args)
        {
            LoadServices();
            new Program();
            DisposeServices();
        }

        private static void DisposeServices()
        {
            if (serviceProvider == null) { return; }

            ((IDisposable)serviceProvider).Dispose();
        }

        private static void LoadServices()
        {
            var collection = new ServiceCollection();

            collection.AddSingleton<IStudentService, StudentService>();
            //transient
            //scoped

            serviceProvider = collection.BuildServiceProvider();
        }

        public Program()
        {

            var studentService = serviceProvider.GetService<IStudentService>();


            studentService.Students.Add(new Models.Student { DOB = DateTime.Now, Name = "Peter Tosh", Email = "tosh@mail.com" });

        }
    }
}
