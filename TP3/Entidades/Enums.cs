using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum ComType
    {
        Notebook,
        Desktop
    }

    public enum Processor
    {
        AMD,
        Intel
    }

    public enum OS
    {
        Linux,
        Windows,
        macOS
    }

    public enum RAM
    {
        GB4,
        GB8,
        GB16,
        GB24
    }

    public enum HardDisk
    {
        SDD256GB,
        SDD512GB,
        HDD512GB,
        HDD1TB
    }

    public enum GraphicCard
    {
        GigabyteRadeonRX550,
        NvidiaGTX1050,
        RadeonRX560,
        MSIRadeonRX480,
        ASUSROGStrixRadeonRX580
    }

    public enum Brand
    {
        ASUS,
        Acer,
        AsRock,
        HP,
        Dell,
        Apple,
        Lenovo
    }

    public enum State
    {
        Recibida, 
        PorReparar, 
        Reparada,
        PorEntregar,
        Devuelta
    }
}
