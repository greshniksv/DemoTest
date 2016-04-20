using Xunit;

namespace DemoBug.Tests
{
    public class UnitTest1
    {
        [Theory, AutoMoqData]
        public void TestMethod1(SpaceShipParameters parameter)
        {
            SpaceShip spaceShip = new SpaceShip();
            parameter.Text = "start";
            Assert.True(spaceShip.Start(parameter));
        }
    }
}
