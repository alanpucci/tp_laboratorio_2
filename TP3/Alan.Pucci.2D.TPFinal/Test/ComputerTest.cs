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
            Receptionist recepcionist = new Receptionist();
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            CoreProcedure.Computers = new List<Computer>();
            //Act
            recepcionist.AddComputer(notebook);

            //Assert
            Assert.IsTrue(CoreProcedure.ReceivedComputers.Count > 0);
        }

        [TestMethod]
        public void UpdateComputerTest()
        {
            //Arrange
            Receptionist recepcionist = new Receptionist();
            Notebook notebook = new Notebook("Alan", Brand.AsRock, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.SDD256GB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            Notebook notebook2 = new Notebook("Alan", Brand.Acer, true, false, OS.Linux, ComType.Notebook,
                                             Processor.Intel, HardDisk.HDD1TB, RAM.GB4, "Esta rota", GraphicCard.RadeonRX560);
            CoreProcedure.Computers = new List<Computer>();

            //Act
            recepcionist.AddComputer(notebook);
            recepcionist.UpdateComputer(notebook, notebook2);

            //Assert
            Assert.AreEqual(CoreProcedure.ReceivedComputers[0], notebook2);
        }

        [TestMethod]
        public void DeleteComputerTest()
        {
            //Arrange
            Receptionist recepcionist = new Receptionist();
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            CoreProcedure.Computers = new List<Computer>();

            //Act
            recepcionist.AddComputer(notebook);
            recepcionist.DeleteComputer(notebook);

            //Assert
            Assert.IsTrue(CoreProcedure.ReceivedComputers.Count == 0);
        }

        [TestMethod]
        public void ToRepairComputerTest()
        {
            //Arrange
            CoreProcedure procedure = CoreProcedure.Instance;
            Receptionist recepcionist = new Receptionist();
            Notebook notebook = new Notebook("Alan", Brand.HP, true, false, OS.Windows, ComType.Notebook,
                                             Processor.Intel, HardDisk.SDD512GB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            CoreProcedure.Computers = new List<Computer>();

            //Act
            recepcionist.AddComputer(notebook);
            recepcionist.ToRepair(notebook);

            //Assert
            Assert.AreEqual(procedure[State.PorReparar].Count, 1);
        }

        [TestMethod]
        public void RepairComputerTest()
        {
            //Arrange
            CoreProcedure procedure = CoreProcedure.Instance;
            Receptionist recepcionist = new Receptionist();
            Technician technician = new Technician();
            Notebook notebook = new Notebook("Alan", Brand.Acer, true, false, OS.Windows, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se rompio", GraphicCard.MSIRadeonRX480);
            Notebook notebook2 = new Notebook("Alan", Brand.Acer, true, false, OS.Linux, ComType.Notebook,
                                             Processor.AMD, HardDisk.HDD1TB, RAM.GB16, "Se arregló", GraphicCard.ASUSROGStrixRadeonRX580);
            notebook2.ComputerState = State.Reparada;
            CoreProcedure.Computers = new List<Computer>();

            //Act
            recepcionist.AddComputer(notebook);
            recepcionist.ToRepair(notebook);
            technician.Repair(notebook, notebook2);

            //Assert
            Assert.AreEqual(procedure[State.Reparada].Count, 1);
        }
    }
}
