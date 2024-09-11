using Tyuiu.SyrtsovaSA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Софья";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Софья", res);
        }
    }
}