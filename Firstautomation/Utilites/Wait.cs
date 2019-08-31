using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstautomation.Utilites
{
    class Wait
    {
        public static void ElementIsVisible(IWebDriver driver,String Value, String Key)
        {
            try
            {
                if(Key=="Xpath") 
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Value)));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static object Until(Func<IWebDriver, IWebElement> func)
        {
            throw new NotImplementedException();
        }
    }
}
