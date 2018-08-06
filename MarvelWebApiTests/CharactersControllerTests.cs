using MarvelWebApi.Controllers;
using MarvelWebApi.Repositories;
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
            var repository = new CharacterRepository();
            var controller = new CharactersController(repository);

            // Act
            var result = controller.Get();

            // Assert
            //result. .Value.ShouldContain(s => s == "value1");
            //result.Value.ShouldContain(s => s == "value2");
        }
    }
}
