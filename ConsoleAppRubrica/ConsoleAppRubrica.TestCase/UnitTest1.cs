using ConsoleAppRubrica.Core.Entities;
using ConsoleAppRubrica.Data.RepoMock;
using Xunit;

namespace ConsoleAppRubrica.TestCase
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddContact()
        {
            //ARRANGE
            Contatto contatto = new Contatto(1, "testName", "testSurname");
            RepoContatto repo = new RepoContatto();

            //ACT
            bool esito = repo.Add(contatto);

            //ASSERT
            Assert.True(esito);
        }
    }
}