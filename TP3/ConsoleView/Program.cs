using Entities;
using Procedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            Recepcionist recepcionist = new Recepcionist("Alan", "Pucci", "recepcionista", "12345");
            Technician technician = new Technician("Alan", "Pucci", "recepcionista", "12345");
            Notebook notebook = new Notebook("Juancito", Brand.AsRock, false, true, OS.Windows, ComType.Notebook,
                Processor.AMD,HardDisk.HDD1TB,RAM.GB4,"Pantalla azul", GraphicCard.MSIRadeonRX480);
            Notebook repairedNotebook = new Notebook("Juancito", Brand.ASUS, false, true, OS.Linux, ComType.Notebook,
                Processor.AMD, HardDisk.HDD1TB, RAM.GB4, "Se reparó", GraphicCard.GigabyteRadeonRX550);
            recepcionist.AddComputer(notebook);
            Console.WriteLine("Se agrego la computadora\n");
            Computer computer = CoreProcedure<List<Computer>>.ReceivedComputers[0];
            Console.WriteLine(computer.Show());
            recepcionist.ToRepair(computer);
            computer = CoreProcedure<List<Computer>>.ToRepairComputers[0];
            Console.WriteLine("\nSe envió al técnico\n");
            Console.WriteLine(computer.Show());
            technician.Repair(computer, repairedNotebook);
            computer = CoreProcedure<List<Computer>>.RepairedComputers[0];
            Console.WriteLine("\nSe reparó la computadora\n");
            Console.WriteLine(computer.Show());
            technician.Deliver(computer);
            computer = CoreProcedure<List<Computer>>.ToDeliverComputers[0];
            Console.WriteLine("\nSe envió al recepcionista\n");
            Console.WriteLine(computer.Show());
            recepcionist.ToDeliver(computer);
            computer = CoreProcedure<List<Computer>>.DeliveredComputers[0];
            Console.WriteLine("\nSe devolvió al cliente\n");
            Console.WriteLine(computer.Show());
            Console.ReadKey();

        }
    }
}
