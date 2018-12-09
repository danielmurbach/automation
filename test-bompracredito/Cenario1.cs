using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



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
            System.Threading.Thread.Sleep(5000);
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
            //WebDriverWait wait = new WebDriverWait(Browser.CD, TimeSpan.FromSeconds(20));
            System.Threading.Thread.Sleep(15000);
            //Página de Seus Dados
            Browser.CD.FindElement(By.Id("borrower.cpf")).SendKeys("37329443876");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.cpf")).Clear();
            Browser.CD.FindElement(By.Id("borrower.cpf")).SendKeys("" + CpfUtils.GerarCpf().ToString() + "");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.dateOfBirth")).SendKeys("15/01/1996");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.monthlyGrossIncome")).SendKeys("500000");
            Browser.CD.FindElement(By.Id("borrower.gender2")).Click();
            Browser.CD.FindElement(By.Id("borrower.maritalStatus2")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.jobType"))).SelectByText("Assalariado");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.profession"))).SelectByText("Desenhista");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.educationLevel"))).SelectByText("2º grau");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.bankingData.bankNumber"))).SelectByText("Itaú Unibanco");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.bankingData.hasCheckbook2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.hasNegativeCreditRecord2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("hasProperty2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("hasVehicle2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            System.Threading.Thread.Sleep(5000);
            // Endereço
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("homeAddress.cep")).SendKeys("04551-080");
            Browser.CD.FindElement(By.Id("homeAddress.number")).SendKeys("86");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("mobilePhone")).Click();
            Browser.CD.FindElement(By.Id("mobilePhone")).SendKeys("(99)999999999");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            //Cadastro Completo
            System.Threading.Thread.Sleep(30000);
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("emailConfirmation")).SendKeys("rrodrigomatheusdarosa@diclace.com.br");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.PartialLinkText("Brasileiro")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("stateOfBirth"))).SelectByText("AM");
            System.Threading.Thread.Sleep(5000);
            new SelectElement(Browser.CD.FindElement(By.Id("cityOfBirth"))).SelectByText("Manaus");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("rgType"))).SelectByText("Carteira de identidade");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("rgEmissionDate")).SendKeys("10102000");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("rg")).SendKeys("23.773.233-6");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("emmitedBy"))).SelectByText("SSP - Secretaria de Segrança Publica");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("ufrg"))).SelectByText("AM");
            Browser.CD.FindElement(By.Id("motherName")).SendKeys("Maria Francisca Rosa");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("homeType")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("timeInAddress")).SendKeys("102010");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("loanObjective"))).SelectByText("Pagar dívidas atrasadas");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            System.Threading.Thread.Sleep(30000);
            Browser.CD.Close();

        }
        [TestMethod]
        public void Cen02()
        {
            BaseUrl URLBase = new BaseUrl();
            Browser.CD.Navigate().GoToUrl(URLBase.URL);
            Browser.CD.Manage().Window.Maximize();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("btnFiveThousand")).Click();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("btnEighteenTerm")).Click();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("name")).SendKeys("Bianca");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("name")).Clear();
            Browser.CD.FindElement(By.Id("name")).SendKeys("Bianca Márcia Luna Corte Real");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("email")).SendKeys("bbiancamarcia");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("email")).Clear();
            Browser.CD.FindElement(By.Id("email")).SendKeys("bbiancamarcialunacortereal@dmadvogados.com");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            //WebDriverWait wait = new WebDriverWait(Browser.CD, TimeSpan.FromSeconds(20));
            System.Threading.Thread.Sleep(20000);
            //Página de Seus Dados
            Browser.CD.FindElement(By.Id("borrower.cpf")).SendKeys("37329443876");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.cpf")).Clear();
            Browser.CD.FindElement(By.Id("borrower.cpf")).SendKeys("" + CpfUtils.GerarCpf().ToString() + "");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.dateOfBirth")).SendKeys("27/05/1991");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.monthlyGrossIncome")).SendKeys("700000");
            Browser.CD.FindElement(By.Id("borrower.gender")).Click();
            Browser.CD.FindElement(By.Id("borrower.maritalStatus2")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.jobType"))).SelectByText("Empresário");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.profession"))).SelectByText("Piscicultor");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.educationLevel"))).SelectByText("Superior Completo");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.bankingData.bankNumber"))).SelectByText("Santander");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.bankingData.hasCheckbook2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.hasNegativeCreditRecord2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("hasProperty2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("hasVehicle2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            // Endereço
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("homeAddress.cep")).SendKeys("04551-080");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("homeAddress.number")).SendKeys("86");
            Browser.CD.FindElement(By.Id("mobilePhone")).Click();
            Browser.CD.FindElement(By.Id("mobilePhone")).SendKeys("(99)999999999");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            //Cadastro Completo
            System.Threading.Thread.Sleep(30000);
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("emailConfirmation")).SendKeys("bbiancamarcialunacortereal@dmadvogados.com");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.PartialLinkText("Estrangeiro")).Click();
            //new SelectElement(Browser.CD.FindElement(By.Id("stateOfBirth"))).SelectByText("AM");
            System.Threading.Thread.Sleep(5000);
            Browser.CD.FindElement(By.Id("countryOfBirth")).SendKeys("Portugal");
            //new SelectElement(Browser.CD.FindElement(By.Id("cityOfBirth"))).SelectByText("Manaus");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("rgType"))).SelectByText("Carteira de estrangeiro");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("rgEmissionDate")).SendKeys("10102000");
            Browser.CD.FindElement(By.Id("rgExpirationDate")).SendKeys("10102030");
            Browser.CD.FindElement(By.Id("rg")).SendKeys("29.727.697-9");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("emmitedBy"))).SelectByText("SSP - Secretaria de Segrança Publica");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("ufrg"))).SelectByText("SP");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("motherName")).SendKeys("Roseli da Silva");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("homeType")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("timeInAddress")).SendKeys("102010");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("loanObjective"))).SelectByText("Pagar dívidas atrasadas");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            System.Threading.Thread.Sleep(30000);
            Browser.CD.Close();
        }
        [TestMethod]
        public void Cen03()
        {
            BaseUrl URLBase = new BaseUrl();
            Browser.CD.Navigate().GoToUrl(URLBase.URL);
            System.Threading.Thread.Sleep(5000);
            Browser.CD.Manage().Window.Maximize();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("btnFiveThousand")).Click();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("btnEighteenTerm")).Click();
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("name")).SendKeys("Otávio");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("name")).Clear();
            Browser.CD.FindElement(By.Id("name")).SendKeys("Otávio Roberto Iago Peixoto");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("email")).SendKeys("otaviorobertoiagopeixoto");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            Browser.CD.FindElement(By.Id("email")).Clear();
            Browser.CD.FindElement(By.Id("email")).SendKeys("otaviorobertoiagopeixoto@cppcoder.com");
            Browser.CD.FindElement(By.Id("btnContinue")).Click();
            //WebDriverWait wait = new WebDriverWait(Browser.CD, TimeSpan.FromSeconds(20));
            System.Threading.Thread.Sleep(15000);
            //Página de Seus Dados
            Browser.CD.FindElement(By.Id("borrower.cpf")).SendKeys("37329443876");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.cpf")).Clear();
            Browser.CD.FindElement(By.Id("borrower.cpf")).SendKeys("" + CpfUtils.GerarCpf().ToString() + "");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.dateOfBirth")).SendKeys("25/06/1990");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.monthlyGrossIncome")).SendKeys("200000");
            Browser.CD.FindElement(By.Id("borrower.gender2")).Click();
            Browser.CD.FindElement(By.Id("borrower.maritalStatus2")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.jobType"))).SelectByText("Estudante");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.educationLevel"))).SelectByText("Superior Completo");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("borrower.bankingData.bankNumber"))).SelectByText("Itaú Unibanco");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.bankingData.hasCheckbook2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("borrower.hasNegativeCreditRecord2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("hasProperty2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("hasVehicle2")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            System.Threading.Thread.Sleep(5000);
            // Endereço
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("homeAddress.cep")).SendKeys("04551-080");
            Browser.CD.FindElement(By.Id("homeAddress.number")).SendKeys("86");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("mobilePhone")).Click();
            Browser.CD.FindElement(By.Id("mobilePhone")).SendKeys("(99)999999999");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            //Cadastro Completo
            System.Threading.Thread.Sleep(30000);
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("emailConfirmation")).SendKeys("otaviorobertoiagopeixoto@cppcoder.com");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.PartialLinkText("Brasileiro")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("stateOfBirth"))).SelectByText("SP");
            System.Threading.Thread.Sleep(5000);
            new SelectElement(Browser.CD.FindElement(By.Id("cityOfBirth"))).SelectByText("São Paulo");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("rgType"))).SelectByText("Carteira de identidade");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("rgEmissionDate")).SendKeys("10102000");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("rg")).SendKeys("23.773.233-6");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("emmitedBy"))).SelectByText("SSP - Secretaria de Segrança Publica");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("ufrg"))).SelectByText("SP");
            Browser.CD.FindElement(By.Id("motherName")).SendKeys("Maria Francisca Rosa");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("homeType")).Click();
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            Browser.CD.FindElement(By.Id("timeInAddress")).SendKeys("102010");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            new SelectElement(Browser.CD.FindElement(By.Id("loanObjective"))).SelectByText("Pagar dívidas atrasadas");
            Browser.CD.FindElement(By.Id("button-borrower-info")).Click();
            System.Threading.Thread.Sleep(30000);
            Browser.CD.Close();
        }

    }
}
