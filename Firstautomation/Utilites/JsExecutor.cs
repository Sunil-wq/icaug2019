using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstautomation.Utilites
{
    class JsExecutor
    {
        public static object Script(IWebDriver driver,String CustomCmd)
        {
            return((IJavaScriptExecutor)driver).ExecuteScript(CustomCmd);
        }
    }
}
