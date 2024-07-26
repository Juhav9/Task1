using Xunit;
using System.Diagnostics;
using Xunit.Abstractions;
using Savonia.xUnit.Helpers;

namespace tests;

public class UnitTest : AppTestBase
{
    public UnitTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public async void Checkpoint01()
    {
        ProcessStartInfo psi = new ProcessStartInfo("dotnet", "run --project ../../../../../src/ConsoleApp/ConsoleApp.csproj");
        psi.CreateNoWindow = true;
        psi.RedirectStandardOutput = true;
        Process? p = Process.Start(psi);
        Assert.NotNull(p);
        await p.WaitForExitAsync();
        string pout = await p.StandardOutput.ReadToEndAsync();
        Assert.Contains("Hello, World of .NET 6!", pout);
        WriteLine(pout);
    }
}