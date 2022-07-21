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
  public void Importproducts() {
    driver.Navigate().GoToUrl("https://gs1eg-is-mygs1-fe-beta.azurewebsites.net/dashboard");
    driver.Manage().Window.Size = new System.Drawing.Size(1138, 816);
    {
      var element = driver.FindElement(By.CssSelector(".addProdBtn > .mat-button-wrapper"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.XPath("//span[contains(.,\' إضافة منتج جديد\')]")).Click();
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.XPath("//button[contains(.,\'اضافة مجموعة منتجات\')]")).Click();
    driver.FindElement(By.XPath("//mat-dialog-container[@id=\'mat-dialog-0\']/app-bulk-type/div[2]/ul/li/p[2]")).Click();
    {
      var element = driver.FindElement(By.XPath("//button[contains(.,\'التالي\')]"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.XPath("//button[contains(.,\'التالي\')]")).Click();
    driver.FindElement(By.XPath("//form/div/div/mat-form-field/div/div/div[3]")).Click();
    driver.FindElement(By.XPath("//span[contains(.,\'50005281\')]")).Click();
    driver.FindElement(By.CssSelector(".upload-area > .ng-star-inserted:nth-child(1)")).SendKeys("D:\\work\\MyGS1 IS\\products sheets\\Without_barcode 1 GTIN .xlsx");
    driver.FindElement(By.CssSelector(".mat-button-wrapper > .ng-star-inserted")).Click();
    driver.FindElement(By.XPath("//button[@id=\'walk-through-step-3\']/span/span")).Click();
    js.ExecuteScript("window.scrollTo(0,94.4000015258789)");
    driver.FindElement(By.CssSelector(".py-2 > .mat-button-wrapper")).Click();
  }
}
