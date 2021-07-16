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
            bool aux = CoreProcedure.Computers + notebook;

            //Assert
            Assert.IsTrue(aux);
            Assert.AreEqual(1,CoreProcedure.ReceivedComputers.Count);
        }

        [TestMethod]
        public void DeleteComputerTest()
        {
            //Arrange
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            CoreProcedure.Computers = new List<Computer>();

            //Act
            bool aux = CoreProcedure.Computers + notebook;
            aux = CoreProcedure.Computers - notebook;


            //Assert
            Assert.IsTrue(aux);
            Assert.AreEqual(0, CoreProcedure.Computers.Count);
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
            bool aux = CoreProcedure.Computers + notebook;
            aux = CoreProcedure.Computers + notebook;

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
                _ = CoreProcedure.Computers + notebook;
            }
            FilesHandler<List<Computer>> files = new FilesHandler<List<Computer>>();
            files.SaveFile(CoreProcedure.Computers, "computersTest.xml");
            List<Computer> computers = files.ReadFile(AppDomain.CurrentDomain.BaseDirectory + "computersTest.xml");

            //Assert
            Assert.AreEqual(computers.Count, CoreProcedure.Computers.Count);
        }

    }
}
