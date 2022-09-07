using CommandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTests:IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "XUnit",
                CommandLine = "dotnet test"
            };
        }
        [Fact]
        public void CanChangeHowTo()
        {
            testCommand.HowTo = "Execute unit test";
            Assert.Equal("Execute unit test", testCommand.HowTo);
        }
        [Fact]
        public void CanChangePlatform()
        {
            testCommand.Platform = "Execute unit test";
            Assert.Equal("Execute unit test", testCommand.Platform);
        }
        [Fact]
        public void CanChangeCommandLine()
        {
            testCommand.CommandLine = "Execute unit test";
            Assert.Equal("Execute unit test", testCommand.CommandLine);
        }
        public void Dispose()
        {
            testCommand = null;
        }
    }
}
