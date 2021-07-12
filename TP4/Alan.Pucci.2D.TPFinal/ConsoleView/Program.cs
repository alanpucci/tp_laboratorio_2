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
            CoreProcedure procedure = CoreProcedure.Instance;
            Receptionist recepcionist = new Receptionist("Alan", "Pucci", "recepcionista", "12345");
            Technician technician = new Technician("Alan", "Pucci", "recepcionista", "12345");
            Notebook notebook = new Notebook("Juancito", Brand.AsRock, false, true, OS.Windows, ComType.Notebook,
                Processor.AMD,HardDisk.HDD1TB,RAM.GB4,"Pantalla azul", GraphicCard.MSIRadeonRX480);
            Notebook repairedNotebook = new Notebook("Juancito", Brand.ASUS, false, true, OS.Linux, ComType.Notebook,
                Processor.AMD, HardDisk.HDD1TB, RAM.GB4, "Se reparó", GraphicCard.GigabyteRadeonRX550);
            recepcionist.AddComputer(notebook);
            Console.WriteLine("Se agrego la computadora\n");
            Computer computer = procedure[State.Recibida][0];
            Console.WriteLine(computer.Show());
            recepcionist.ToRepair(computer);
            computer = procedure[State.PorReparar][0];
            Console.WriteLine("\nSe envió al técnico\n");
            Console.WriteLine(computer.Show());
            technician.Repair(computer, repairedNotebook);
            computer = procedure[State.Reparada][0];
            Console.WriteLine("\nSe reparó la computadora\n");
            Console.WriteLine(computer.Show());
            technician.Deliver(computer);
            computer = procedure[State.PorEntregar][0];
            Console.WriteLine("\nSe envió al recepcionista\n");
            Console.WriteLine(computer.Show());
            recepcionist.ToDeliver(computer);
            computer = procedure[State.Devuelta][0];
            Console.WriteLine("\nSe devolvió al cliente\n");
            Console.WriteLine(computer.Show());
            Console.ReadKey();

        }
    }
}
