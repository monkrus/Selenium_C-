using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace Udemka
{
    class Program
    {
        static void Main(string[] args)
        {



       IWebDriver driver = new ChromeDriver();
       driver.Navigate().GoToUrl("http://amazon.in"); 
       Actions abs = new Actions(driver);
       //IWebElement element = driver.FindElement(By.ClassName("nav-line-1"));
       //abs.MoveToElement(element).Build().Perform();
       IWebElement xyz = driver.FindElement(By.ClassName("nav-input"));
       abs.KeyDown(Keys.Shift).MoveToElement(xyz).SendKeys("smalletters").Build().Perform();
       abs.ContextClick(xyz).Build().Perform();
      


      // driver.FindElement()
       


       //driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("12345");

       

            
       //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
      
       //driver.FindElement(By.XPath(".//*[@id='managed-overlay']/div/div/div/div[4]/div/div/div/div/div/a")).Click();
       
      // driver.FindElement(By.XPath(".//*[@id='hdr-service']")).Click();
      // driver.FindElement(By.XPath(".//*[@id='hdr-help']")).Click();
      // driver.Quit();



       // SelectElement se = new SelectElement(driver.FindElement(By.XPath(".//*[@id='hdr-feedback']"))); //Locating select list
      // se.SelectByText("Item1"); //Select item from list having option text as "Item1"



       //IWebElement address = driver.FindElement(By.XPath(".//*[@id='hdr-feedback']"));
       //SelectElement ab = new SelectElement(address);
       //ab.SelectByText("feedback");
       //alert al=driver.SwitchTo().alert();
   
            
      //SelectElement abc=new SelectElement(driver.FindElement(By.CssSelector(".//*[@id='roundWay']/form/ul/li[1]/input[1]")));
       
      // abc.SelectByText("Daipur");


       //SelectElement se = new SelectElement(driver.FindElement(By.id("select_element_id"))); //Locating select list
       //se.SelectByText("Item1"); //Select item from list having option text as "Item1"

       //se.SelectByValue("Item1"); //Select item from list having option value as "Item1"
       //driver.Quit();

       //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
      

      

            
      
     //address показывает, где находится; abc выбирает,использую address
       
      
      

       //abc.SelectByText("Suede");
       

       
       
       //driver.FindElement(By.CssSelector("input[id='quick_email']")).SendKeys("14802464690");
       //driver.FindElement(By.CssSelector("input[id='quick_pass']")).SendKeys("Vertuta22!");

       //driver.FindElement(By.Id("quick_email")).SendKeys("14802464690");
       //driver.FindElement(By.Id("quick_pass")).SendKeys("Vertuta22!");
      // driver.FindElement(By.XPath(".//*[@id='quick_login_button']")).Click();
      // driver.FindElement(By.XPath("//button[@class='flat_button button_wide button_big']")).Click();

       //driver.FindElement(By.Id("quick_login_button")).Click();
       //driver.FindElement(By.LinkText("Forgot your password?")).Click();
       //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
       //driver.FindElement(By.CssSelector("[id='quick_email']")).SendKeys("testing");
       //driver.FindElement(By.XPath(".//*[@id='quick_email'] ")).SendKeys("14802464690");
      // driver.FindElement(By.XPath(" .//*[@id='quick_pass']")).SendKeys("Vertuta22!");
       //driver.FindElement(By.XPath("//button[@class='flat_button button_wide button_big']")).Click();
       
        
       



        

        }

        
    }
}
