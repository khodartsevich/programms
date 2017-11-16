using System;
using System.Diagnostics;
//using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;


namespace ApplicationForm
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://ru-stage-job.dodopizza.io/");

            IWebElement applicationForm = driver.FindElementByClassName("header-button");
            applicationForm.Click();
            
            IWebElement cities = driver.FindElementByName("localityId");
            var cityOption = new SelectElement(cities);
//            cityOption.SelectByText("Волгоград");
            cityOption.SelectByIndex(26);
            
            IWebElement surname = driver.FindElementByName("SecondName");
            surname.SendKeys("Уик");
            
            IWebElement firstName = driver.FindElementByName("FirstName");
            firstName.SendKeys("Джон");

            IWebElement birthdayDay = driver.FindElementById("birthday_day");
            var birthDayOptions = new SelectElement(birthdayDay);
            birthDayOptions.SelectByIndex(2);
            
            IWebElement birthdayMonth = driver.FindElementById("birthday_month");
            var birthMonthOptions = new SelectElement(birthdayMonth);
            birthMonthOptions.SelectByIndex(9);
            
            IWebElement birthdayYear = driver.FindElementById("birthday_year");
            var birthYearOptions = new SelectElement(birthdayYear);
            birthYearOptions.SelectByValue("1964");
            
            IWebElement address = driver.FindElementByName("Address");
            address.SendKeys("г. Нью-Йорк, 5-я авеню, д.123");

            IWebElement phone = driver.FindElementByName("PhoneNumber");
            phone.SendKeys("89085552332");
         
            var selPizzeria = driver.FindElementsByName("UnitId");
            Random rand = new Random();
            selPizzeria[rand.Next(0, selPizzeria.Count)].Click();
            
            Thread.Sleep(1000);
                       
            var selPositions = driver.FindElementsByCssSelector("#vacancies .col-sm-5 label");
            Random rand1 = new Random();
            selPositions[rand1.Next(0, selPositions.Count)].Click();
           
            var worktime = driver.FindElementsByName("ShiftTypes");
            Random rand2 = new Random();
            worktime[rand2.Next(0,worktime.Count)].Click();
            
//            foreach (var time in worktime)
//            {
//               time.Click();
//            }
            
            IWebElement medbook = driver.FindElementById("med");
            medbook.Click();
            
            IWebElement knowledgeSources = driver.FindElementById("applicantSource");
            var knowledgeSource1 = new SelectElement(knowledgeSources);
            knowledgeSource1.SelectByValue("SocialNetworks");
         /*
            var knowledgeSource4 = new SelectElement(knowledgeSources);
            knowledgeSource4.SelectByValue("Other");
            Thread.Sleep(1500);
            
            IWebElement discription = driver.FindElementByName("ApplicantSourceDescription");
            discription.SendKeys("От друзей");    
         */

            IWebElement workPeriods = driver.FindElementByName("ExpectedWorkPeriod");
            var workPeriod = new SelectElement(workPeriods);
            workPeriod.SelectByValue("Always");
            
            IWebElement expirience = driver.FindElementByName("WorkExperience");
            expirience.SendKeys("Бывший наёмный убийца");

            IWebElement hobby = driver.FindElementByName("Hobby");
            hobby.SendKeys("У меня есть собака, я ее очень люблю. Меня радуют тишина и покой");
          
            IWebElement link = driver.FindElementByName("SocialLink");
            link.SendKeys("https://en.wikipedia.org/wiki/John_Wick");

            IWebElement oferta = driver.FindElementByName("Oferta");
            oferta.Click();

            IWebElement sendApplication = driver.FindElementById("send");
            sendApplication.Click();
            
            var searchText = "Спасибо!";
            var realText = driver.FindElementByTagName("h1").Text;
            Assert.Equal(searchText, realText);
            
            //string searchText = "Ваша анкета уже летит управляющему";
            //  Assert.NotStrictEqual(searchText, realText);
            
            Thread.Sleep(2000);
            
            driver.Quit();
            
            Console.WriteLine("Success!");
            
            Console.ReadKey();
        }
    }

}