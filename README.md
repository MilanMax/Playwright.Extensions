# Playwright.Extensions

Run playwright on your machine
Open the solution in Visual Studio or

dotnet restore
dotnet build
After that you should install the playwright stuff (browsers etc)

It installed a handy powershell in your project's bin directory that you should run.

pwsh .\PlaywrightTest1\bin\Debug\net6.0\playwright.ps1 install
Now you can run the tests from command line or VS.

dotnet test

#There are two playwright.sharp (playwright.nunit) extensions:
1. Expect method is now avalable with info message if the expected condition is NOT met. 
2. Trace recording is now available only for failed tests
