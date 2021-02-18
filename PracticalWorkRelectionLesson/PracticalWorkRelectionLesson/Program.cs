using System;
using System.Collections.Generic;

namespace PracticalWorkRelectionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // С помощью рефлексии вызвать метод Substring класса String и извлечь из строки подстроку заданного размера.
            Type type = typeof(String);

            foreach (var item in type.Assembly.GetTypes())
            {
                if(type.Name == "String" && type.IsClass)
                {
                    foreach(var method in type.GetMethods())
                    {
                        if(method.Name == "Substring")
                        {
                            Console.WriteLine(method);                                            
                        }
                    }
                }
            }
            Console.WriteLine("----------------------------------------------");
            //Получить список конструкторов класса List<T>
            Type listType = typeof(List<>);
            var constructorInfоs = listType.GetConstructors();
            foreach(var item in constructorInfоs)
            {
                if (item.IsConstructor)
                {
                    Console.WriteLine(item.Name);
                }
            }
            

        }
    }
}
