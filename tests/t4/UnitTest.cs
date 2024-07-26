using Xunit;
using System.Diagnostics;
using Xunit.Abstractions;
using System;
using Savonia.xUnit.Helpers;

namespace tests;

public class UnitTest : AppTestBase
{
    public UnitTest(ITestOutputHelper output) : base(output)
    {
    }

    [Theory]
    [JsonFileData("testdata.json", typeof(Tuple<int?, int?>), typeof(string))]    
    public async void Checkpoint04_RunAndCheckOutputForArguments(Tuple<int?, int?> data, string expected)
    {
        ProcessStartInfo psi = new ProcessStartInfo("dotnet", $"run --project ../../../../../src/ConsoleApp/ConsoleApp.csproj {data.Item1} {data.Item2}");
        psi.CreateNoWindow = true;
        psi.RedirectStandardOutput = true;
        Process? p = Process.Start(psi);
        Assert.NotNull(p);
        await p.WaitForExitAsync();
        string pout = await p.StandardOutput.ReadToEndAsync();
        Assert.Contains(expected, pout);
        WriteLine(pout);
    }
}