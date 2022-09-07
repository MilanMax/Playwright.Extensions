
using NUnit.Framework;

namespace Playwright.Common.Helpers;

public static class LocatorAssertionHelper
{

    public static async Task LocatorAssertionAsync(Func<Task> methodToExecute, string locatorName)
    {
        try
        {
            await methodToExecute();

        }
        catch (Exception ex)
        {
            Assert.Fail($"{locatorName}:\n{ex.Message}");
        }
    }
}
