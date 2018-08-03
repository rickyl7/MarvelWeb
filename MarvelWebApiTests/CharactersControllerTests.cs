using MarvelWebApi.Controllers;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelWebApiTests
{
    [TestFixture]
    public class CharactersControllerTests
    {
        [Test]
        public void Characters_Get_no_parameters()
        {
            // Arrange
            var controller = new CharactersController();

            // Act
            var result = controller.Get();

            // Assert
            result.Value.ShouldContain(s => s == "value1");
            result.Value.ShouldContain(s => s == "value2");
        }
    }
}
