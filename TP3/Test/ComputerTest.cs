using Entities;
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
            Recepcionist recepcionist = new Recepcionist();
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16,"Se rompio", GraphicCard.MSIRadeonRX480);
            //Act
            recepcionist.AddComputer(notebook);

            //Assert
            Assert.IsTrue(CoreProcedure<List<Computer>>.ReceivedComputers.Count > 0);
        }

        [TestMethod]
        public void UpdateComputerTest()
        {
            //Arrange
            Recepcionist recepcionist = new Recepcionist();
            Notebook notebook = new Notebook("Alan", Brand.Apple, true, false, OS.macOS, ComType.Notebook,
                                             Processor.AMD, HardDisk.SDD256GB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            Notebook notebook2 = new Notebook("Alan", Brand.Acer, true, false, OS.Linux, ComType.Notebook,
                                             Processor.Intel, HardDisk.HDD1TB, RAM.GB4, "Esta rota", GraphicCard.RadeonRX560);

            //Act
            recepcionist.AddComputer(notebook);
            recepcionist.UpdateComputer(notebook, notebook2);

            //Assert
            Assert.AreEqual(CoreProcedure<List<Computer>>.ReceivedComputers[0], notebook2);
        }

        [TestMethod]
        public void DeleteComputerTest()
        {
            //Arrange
            Recepcionist recepcionist = new Recepcionist();
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);

            //Act
            recepcionist.AddComputer(notebook);
            recepcionist.DeleteComputer(notebook);

            //Assert
            Assert.IsTrue(CoreProcedure<List<Computer>>.ReceivedComputers.Count == 0);
        }

        [TestMethod]
        public void ToRepairComputerTest()
        {
            //Arrange
            Recepcionist recepcionist = new Recepcionist();
            Technician technician = new Technician();
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);

            //Act
            recepcionist.AddComputer(notebook);
            recepcionist.ToRepair(notebook);

            //Assert
            Assert.AreEqual(CoreProcedure<List<Computer>>.ToRepairComputers.Count, 1);
        }

        [TestMethod]
        public void RepairComputerTest()
        {
            //Arrange
            Recepcionist recepcionist = new Recepcionist();
            Technician technician = new Technician();
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            Notebook notebook2 = new Notebook("Alan", Brand.Acer, true, false, OS.Linux, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se arregló", GraphicCard.ASUSROGStrixRadeonRX580);
            notebook2.ComputerState = State.Reparada;

            //Act
            recepcionist.AddComputer(notebook);
            recepcionist.ToRepair(notebook);
            technician.Repair(notebook, notebook2);

            //Assert
            Assert.AreEqual(CoreProcedure<List<Computer>>.RepairedComputers.Count, 1);
        }
    }
}
