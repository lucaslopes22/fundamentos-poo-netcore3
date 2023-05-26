using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspdotnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda .NET", "", courseAspNet);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "OOP", "", null);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach(var career in careers){
                Console.WriteLine(career.Title);

                foreach(var item in career.Items.OrderBy(x => x.Order)){
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach(var notification in item.Notifications){
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }
    }
}
