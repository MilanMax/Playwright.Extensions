
namespace Playwright.Extension.Tests;

public class BankingProjectTestSet : PageTest
{
    private BankingProjectHomePage _bankingProjectHomePage;

    [SetUp]
    public async Task BeforeEachTest()
    {
        _bankingProjectHomePage = new BankingProjectHomePage(Page);
        await TraceRecorderHelper.StartTestTracingAsync(Page);//starting trace recorder before each test
    }

    [TearDown]
    public async Task AfterEachTest()
    {
        await TraceRecorderHelper.AttachTraceViewerToTestContextWhenTestFailsAsync(Page);//saving trace recording only for failed tests
        await Page.CloseAsync();
    }

    [Test]
    public async Task TC01_NavigateToHomePage_VerifyLoginButtonsEnabled()//test case should fail
    {
        await _bankingProjectHomePage.NavigateTo("login");
        //the following two lines are extension methods of Expect method which does not have option for info message if the expected condition is NOT met.
        await LocatorAssertionHelper.LocatorAssertionAsync(() => Expect(_bankingProjectHomePage.CustomerLoginBtn).ToBeEnabledAsync(), 
            "Customer login button is not visible");
        await LocatorAssertionHelper.LocatorAssertionAsync(() => Expect(_bankingProjectHomePage.BankManagerLoginBtn).Not.ToBeEnabledAsync(),
            "Bank manager login button is not visible");
    }
}