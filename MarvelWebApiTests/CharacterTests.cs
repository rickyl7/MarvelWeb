using MarvelWebApi.Entities;
using NUnit.Framework;
using Shouldly;
using System;
using System.Linq;

namespace MarvelWebApiTests
{
    [TestFixture]
    public class CharacterTests
    {
        [Test]
        public void Captain_America()
        {
            // Arrange
            var captainAmerica = new Character() { Name = "Captain America", Roles = new[] { Character.RoleEnum.Defense, Character.RoleEnum.Purge } };

            // Act
            // Assert
            captainAmerica.Name.ShouldBe("Captain America");
            captainAmerica.Roles.Count().ShouldBe(2);
            captainAmerica.Roles.ShouldContain(r => r == Character.RoleEnum.Defense);
            captainAmerica.Roles.ShouldContain(r => r == Character.RoleEnum.Purge);
        }
    }
}
