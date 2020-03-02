using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo
{
    public class ValueService : IValueService
    {
        public List<string> GetValues()
        {
            return new List<string> { "test1", "test2", "test3" };
        }
    }
}