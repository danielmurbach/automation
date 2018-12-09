using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace test_bompracredito
{
    class Browser
    {
        public static IWebDriver CD = new ChromeDriver();

    }
    class BaseUrl
    {
        public string URL = "https://demo.bompracredito.com.br/emprestimo-pessoal/";
    }
}

