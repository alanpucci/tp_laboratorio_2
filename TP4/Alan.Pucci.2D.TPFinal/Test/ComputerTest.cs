using Entities;
using Exceptions;
using Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Procedure;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void AddComputerTest()
        {
            //Arrange
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            CoreProcedure.Computers = new List<Computer>();
            //Act
            if(CoreProcedure.Computers + notebook)
            {
            }

            //Assert
            Assert.IsTrue(CoreProcedure.ReceivedComputers.Count > 0);
        }

        [TestMethod]
        public void DeleteComputerTest()
        {
            //Arrange
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            CoreProcedure.Computers = new List<Computer>();

            //Act
            if(CoreProcedure.Computers + notebook && CoreProcedure.Computers - notebook)
            {
            }

            //Assert
            Assert.IsTrue(CoreProcedure.ReceivedComputers.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(AlreadyInListException))]
        public void TestSameComputerException()
        {
            //Arrange
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            CoreProcedure.Computers = new List<Computer>();
            //Act
            if (CoreProcedure.Computers + notebook && CoreProcedure.Computers + notebook)
            {
            }

        }

        [TestMethod]
        public void SaveAndLoadTest()
        {
            //Arrange
            CoreProcedure.Computers = new List<Computer>();
            for (int i = 0; i < 10; i++)
            {
                Notebook notebook = new Notebook($"Alan{i}", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                                 Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
                //Act
                if(CoreProcedure.Computers + notebook)
                {
                }
            }
            FilesHandler<List<Computer>> files = new FilesHandler<List<Computer>>();
            files.SaveFile(CoreProcedure.Computers, "computersTest.xml");
            List<Computer> computers = files.ReadFile(AppDomain.CurrentDomain.BaseDirectory + "computersTest.xml");

            //Assert
            Assert.AreEqual(computers.Count, CoreProcedure.Computers.Count);
        }

    }
}
