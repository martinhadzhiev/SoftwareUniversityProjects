using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    using System.Collections;

    [TestFixture]
    public class TestClass
    {
        private ProviderController controller;

        [SetUp]
        public void Init()
        {
            IEnergyRepository energypepo = new EnergyRepository();
            this.controller = new ProviderController(energypepo);
        }

        [Test]
        public void TestProduceMeth()
        {
            Assert.AreEqual("Produced 0 energy today!", this.controller.Produce());
        }

        [Test]
        public void TestProduceMeth2()
        {
            IList<string> args = new List<string>()
            {"Pressure","20","300"};

            this.controller.Register(args);

            Assert.AreEqual(1, this.controller.Entities.Count);
            Assert.AreEqual(20, this.controller.Entities.FirstOrDefault().ID);
            Assert.AreEqual(600,this.controller.Entities.FirstOrDefault().Produce());
        }

        [Test]
        public void TestProduceMeth3()
        {
            IList<string> args = new List<string>()
                {"Pressure","20","300"};

            this.controller.Register(args);

            this.controller.Repair(5000);

            Assert.AreEqual(5700,this.controller.Entities.FirstOrDefault().Durability);
        }

        [Test]
        public void TestProduceMeth4()
        {
            IList<string> args = new List<string>()
                {"Pressure","20","300"};

            this.controller.Register(args);

            this.controller.Produce();

            Assert.AreEqual("Produced 600 energy today!", this.controller.Produce());
        }

        [Test]
        public void TestProduceMeth5()
        {
            IList<string> args = new List<string>()
                {"Solar","20","300"};

            this.controller.Register(args);

            
            Assert.AreEqual(1500, this.controller.Entities.FirstOrDefault().Durability);
        }

        [Test]
        public void TestProduceMeth6()
        {
            IList<string> args = new List<string>()
                {"Solar","20","300"};

            this.controller.Register(args);

            for (int i = 0; i < 50; i++)
            {
                this.controller.Produce();
            }

            Assert.AreEqual(0, this.controller.Entities.Count);
        }

        [Test]
        public void TestProduceMeth7()
        {
            IList<string> args = new List<string>()
                {"Standart","20","300"};

            IList<string> args1 = new List<string>()
                {"Solar","20","300"};

            IList<string> args2 = new List<string>()
                {"Pressure","20","300"};

            this.controller.Register(args);
            this.controller.Register(args1);
            this.controller.Register(args2);

            Assert.AreEqual(3, this.controller.Entities.Count);
            Assert.AreEqual(3200,this.controller.Entities.Sum(e => e.Durability));
            Assert.AreEqual("Produced 1200 energy today!", this.controller.Produce());
            Assert.AreEqual(1200,this.controller.TotalEnergyProduced);
        }

        [Test]
        public void testtt()
        {
            IList<string> args = new List<string>() {"Standart","20","300"};

            this.controller.Register(args);

            Assert.AreEqual(1000,this.controller.Entities.FirstOrDefault().Durability);

            this.controller.Repair(200);

            Assert.AreEqual(1200, this.controller.Entities.FirstOrDefault().Durability);

            this.controller.Produce();

            Assert.AreEqual(1100, this.controller.Entities.FirstOrDefault().Durability);

        }

        [Test]
        public void testttttt()
        {
            IList<string> args = new List<string>() { "Pressure", "20", "300" };

            this.controller.Register(args);

            Assert.AreEqual(700, this.controller.Entities.FirstOrDefault().Durability);

            this.controller.Repair(200);

            Assert.AreEqual(900, this.controller.Entities.FirstOrDefault().Durability);

            this.controller.Produce();

            Assert.AreEqual(800, this.controller.Entities.FirstOrDefault().Durability);

            Assert.AreEqual(600,this.controller.Entities.FirstOrDefault().Produce());

            Assert.AreEqual(800,this.controller.Entities.FirstOrDefault().Durability);
        }
    }
}
