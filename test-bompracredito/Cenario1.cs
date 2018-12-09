using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace test_bompracredito
{
    [TestClass]
    public class Cenario1
    {
        [TestMethod]
        public void Cen01()
        {
            BaseUrl URLBase = new BaseUrl();
            Browser.CD.Navigate().GoToUrl(URLBase.URL);
            Browser.CD.Manage().Window.Maximize();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("btnFiveThousand")).Click();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("btnEighteenTerm")).Click();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("name")).SendKeys("Rodrigo");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("name")).Clear();
            Browser.CD.FindElement(By.Id("name")).SendKeys("Rodrigo Matheus da Rosa");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("email")).SendKeys("rrodrigomatheusdarosa");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("email")).Clear();
            Browser.CD.FindElement(By.Id("email")).SendKeys("rrodrigomatheusdarosa@diclace.com.br");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();

        }
        [TestMethod]
        public void Cen01Cadastro()
        {
        }


    }
}
