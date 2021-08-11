using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Sample
{
    public interface IMyService
    {
        string GetString();
    }
    public class MyService : IMyService
    {
        public string GetString()
        {
            return "Hello world";
       }
    }
}
