using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Files
{
    public interface IFiles<T>
    {
        void SaveFile(T t, string fileName);
        T ReadFile(string fileName);
    }
}
