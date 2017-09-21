using NUnit.Framework;

namespace BashSoftTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BashSoft.Contracts;
    using BashSoft.DataStructures;

    [TestFixture]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;

        [Test]
        public void TestEmptyCtor()
        {
            this.names = new SimpleSortedList<string>();
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestCtorWithInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);
            Assert.AreEqual(20, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestCtorWithAllParameters()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 30);
            Assert.AreEqual(30, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestCtorWithInitialComparer()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [SetUp]
        public void SetUp()
        {
            this.names = new SimpleSortedList<string>();
        }

        [Test]
        public void TestAddIncreasesSize()
        {
            this.names.Add("marto");
            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void TestAddNullThrowsNullException()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.Add(null));
        }

        [Test]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            this.names.Add("Rosen");
            this.names.Add("Georgi");
            this.names.Add("Balkan");

            List<string> names = new List<string>();

            foreach (string name in this.names)
            {
                names.Add(name);
            }

            Assert.AreEqual("Balkan", names[0]);
            Assert.AreEqual("Georgi", names[1]);
            Assert.AreEqual("Rosen", names[2]);
        }

        [Test]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                this.names.Add("element");
            }

            Assert.AreEqual(17, this.names.Size);
            Assert.AreNotEqual(16, this.names.Capacity);
        }

        [Test]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            List<string> names = new List<string>()
            {
                "gosho" , "pesho"
            };

            this.names.AddAll(names);

            Assert.AreEqual(this.names.Size, 2);
        }

        [Test]
        public void TestAddingAllFromNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.AddAll(null));
        }

        [Test]
        public void TestAddAllKeepsSorted()
        {
            List<string> namesToAdd = new List<string>()
            {
                "Rosen", "Georgi", "Balkan"
            };

            this.names.AddAll(namesToAdd);

            List<string> namesList = new List<string>();
            foreach (string name in this.names)
            {
                namesList.Add(name);
            }

            Assert.AreEqual("Balkan", namesList[0]);
            Assert.AreEqual("Georgi", namesList[1]);
            Assert.AreEqual("Rosen", namesList[2]);
        }

        [Test]
        public void TestRemoveValidElementDecreasesSize()
        {
            this.names.AddAll(new List<string>() { "Gosho", "Pesho" });

            this.names.Remove("Pesho");

            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.names.AddAll(new List<string>() { "Martin", "Pesho" });

            this.names.Remove("Pesho");

            Assert.AreEqual("Martin", this.names.First());
        }

        [Test]
        public void TestRemovingNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.Remove(null));
        }

        [Test]
        public void TestJoinWithNull()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.JoinWith(null));
        }

        [Test]
        public void TestJoinWorksFine()
        {
            this.names.Add("Gosho");
            this.names.Add("Pesho");

            Assert.AreEqual("Gosho, Pesho", this.names.JoinWith(", "));
        }
    }
}
