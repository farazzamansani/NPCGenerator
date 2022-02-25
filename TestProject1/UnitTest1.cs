using System;
using Castle.Core.Internal;
using Microsoft.Extensions.Logging;
using Moq;
using NPCGenerator.Server.Controllers;
using NPCGenerator.Server.Services;
using Xunit;

namespace XUnitTests
{
    public class UnitTest1
    {
        private Generator _generator;
        public UnitTest1()
        {
            _generator = new Generator();
        }
        [Fact]
        public void TestCleanlinessHasValue()
        {
            var cleanliness = _generator.GenerateCleanliness("Male");
            Assert.NotEqual(string.Empty,cleanliness);
        }
        [Fact]
        public void TestSexHasValue()
        {
            var sex = _generator.GenerateSex();
            Assert.NotEqual(string.Empty, sex);
        }
        [Fact]
        public void TestMaleNPC()
        {
            var loggerMock = new Mock<ILogger<NPCGeneratorController>>();
            var myDep= new Mock<IMyDependency>();
            var generator= new Mock<IGenerator>();
            var g = new Generator();
            //The mock is of the generator interface, anything called in it will return null unless setup with a return value.
            //If we want to run the actual Generator classes methods for some we probably want to pass a delegate into the return.
            //generator.Setup(g => g.GenerateSex()).Returns("Male");
            Dely sex = g.GenerateSex;
            generator.Setup(g => g.GenerateSex()).Returns(sex.Invoke);
            var controller = new NPCGeneratorController(loggerMock.Object, myDep.Object, generator.Object);
            var result = controller.GetSingleNPC();
            Assert.NotNull(result);
            Assert.Contains("male", result.Sex,StringComparison.CurrentCultureIgnoreCase);
        }
        public delegate string Dely();

        [Fact]
        public void TestIntegration()
        {
            var loggerMock = new Mock<ILogger<NPCGeneratorController>>();
            var myDep = new Mock<IMyDependency>();
            var generator = new Generator(); //Use the actual Generator
            var controller = new NPCGeneratorController(loggerMock.Object, myDep.Object, generator);
            var result = controller.GetSingleNPC();
            Assert.NotNull(result);
            Assert.True(result.Sex.Contains("Male") || result.Sex.Contains("Female"));
            Assert.True(result.FacialHair != null && result.FacialHair.Contains("None"));
        }
    }
}