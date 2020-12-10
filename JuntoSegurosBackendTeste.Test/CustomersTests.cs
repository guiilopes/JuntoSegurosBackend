using JuntoSegurosBackendTeste.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JuntoSegurosBackendTeste.Test
{
    [TestClass]
    [TestCategory("Domain - User Test")]
    public class CustomersTests
    {

        [TestMethod]
        public void Deve_retornar_igual_quando_customer_preenchido()
        {
            var user = new User
            {
                Email = "guilherme@teste.com",
                UserName = "guilherme",
            };

            Assert.AreEqual("guilherme@teste.com", user.Email);
            Assert.AreEqual("guilherme", user.UserName);
        }
    }
}
