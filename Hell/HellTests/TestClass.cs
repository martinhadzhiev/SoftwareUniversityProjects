using NUnit.Framework;

namespace HellTests
{
    using System.Reflection;

    [TestFixture]
    public class TestClass
    {
        [Test]
        public void FieldsAccessModifierTest()
        {
            HeroInventory inventory = new HeroInventory();

            FieldInfo[] inventoryType = inventory.GetType().GetFields();

            Assert.AreEqual(0, inventoryType.Length, "Field must be private!");
        }

        [Test]
        public void PublicPropertiesCountTest()
        {
            HeroInventory heroInventory = new HeroInventory();

            PropertyInfo[] publicProperties = heroInventory.GetType().GetProperties();

            Assert.AreEqual(5, publicProperties.Length, "Invalid properties access modifiers!");
        }

        [Test]
        public void PublicMethodsCountTest()
        {
            HeroInventory heroInventory = new HeroInventory();

            MethodInfo[] publicMethods = heroInventory.GetType().GetMethods();

            Assert.AreEqual(11, publicMethods.Length, "Wrong method access modifiers!");
        }

        [Test]
        public void PrivateFieldsCountTest()
        {
            HeroInventory heroInventory = new HeroInventory();

            MethodInfo[] privateMethods = heroInventory.GetType()
                .GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);

            Assert.GreaterOrEqual(privateMethods.Length,2);
        }
    }
}
