using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWorkExceptionLesson
{
    public class TestClass
    {
        public void IsString(object value)
        {
            if(value is int)
            {
                throw new Exception("Ощибка при передачи агрумента!");
            }
            else
            {
                Console.WriteLine(value);
            }

        }
    }
}
