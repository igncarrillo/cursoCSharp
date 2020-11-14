using System;
using System.Security.Principal;
using NUnit.Framework;
using ClasesATestear;

namespace Tests
{
    [TestFixture]
    public class PersonaShould
    {
        private Persona persona;

        [SetUp]
        public void SetUp()
        {
            persona = new Persona {Nombre = "Ignacio", Edad = 25};
        }
        
        [Test]
        public void DecirNombre()
        {
            Assert.AreEqual("Ignacio",persona.DecirNombre());
        }
        
        [Test]
        public void DecirEdad()
        {
            Assert.AreEqual(25,persona.DecirEdad());
        }
    }
}