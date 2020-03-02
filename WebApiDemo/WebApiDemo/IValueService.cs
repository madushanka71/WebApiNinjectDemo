using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo
{
    public interface IValueService
    {
        List<string> GetValues();
    }
}