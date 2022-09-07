
using Microsoft.Playwright;

namespace Playwright.Common.PageObject;

public class BankingProjectHomePage
{
    private readonly IPage _page;
    private const string _baseUrl = "https://www.globalsqa.com/angularJs-protractor/BankingProject/#/";

    public ILocator CustomerLoginBtn => _page.Locator(".btn-primary").Filter(new LocatorFilterOptions() { HasTextString = "Customer Login" });
    public ILocator BankManagerLoginBtn => _page.Locator(".btn-primary").Filter(new LocatorFilterOptions() { HasTextString = "Bank Manager Login" });

    public BankingProjectHomePage(IPage page)
    {
        _page = page;
    }

    public async Task NavigateTo(string urlExtension)
    {
        await _page.GotoAsync(Path.Combine(_baseUrl, urlExtension), new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
    }
}
