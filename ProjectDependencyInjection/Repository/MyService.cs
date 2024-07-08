using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDI.Repository
{
    public class MyService : IMyService
    {
        public string GetMessage()
        {
            return "Hello from MyService!";
        }
    }
}