// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests : IDisposable {
  public IWebDriver driver {get; private set;}
  public IDictionary<String, Object> vars {get; private set;}
  public IJavaScriptExecutor js {get; private set;}
  public SuiteTests()
  {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<String, Object>();
  }
  public void Dispose()
  {
    driver.Quit();
  }
  [Fact]
  public void Signin() {
    driver.Navigate().GoToUrl("https://gs1eg-is-mygs1-fe-beta.azurewebsites.net/auth/signup");
    driver.Manage().Window.Size = new System.Drawing.Size(1130, 816);
    driver.FindElement(By.CssSelector(".link")).Click();
    driver.FindElement(By.CssSelector(".mat-button-wrapper")).Click();
    driver.FindElement(By.Id("signInName")).Click();
    driver.FindElement(By.Id("signInName")).SendKeys("mohamed.abdelrahman@gs1eg.org");
    driver.FindElement(By.Id("password")).Click();
    driver.FindElement(By.Id("password")).Click();
    {
      var element = driver.FindElement(By.Id("password"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.Id("password")).SendKeys("12345678");
    driver.FindElement(By.Id("next")).Click();
    driver.FindElement(By.CssSelector(".nav-item:nth-child(2)")).Click();
    Assert.Equal(driver.FindElement(By.LinkText("لوحة التحكم")).Text, "لوحة التحكم");
  }
}
