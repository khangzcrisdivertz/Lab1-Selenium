using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstTests;

public class FirstSeleniumTest
{
    private IWebDriver driver = null!;

    [SetUp]
    public void Setup()
    {
        // Mở trình duyệt Chrome
        driver = new ChromeDriver();
    }

    [Test]
    public void OpenExampleCom_TitleShouldBeExampleDomain()
    {
        // Điều hướng đến trang web
        driver.Navigate().GoToUrl("https://example.com");

        // Đọc và in tiêu đề trang
        string title = driver.Title;
        TestContext.Progress.WriteLine($"Tiêu đề trang: {title}");

        // Kiểm tra tiêu đề đúng như mong đợi
        Assert.That(title, Is.EqualTo("Example Domain"));
    }

    [TearDown]
    public void TearDown()
    {
        // Đóng trình duyệt (chạy cả khi test fail)
        driver.Quit();
        driver.Dispose();
    }
}