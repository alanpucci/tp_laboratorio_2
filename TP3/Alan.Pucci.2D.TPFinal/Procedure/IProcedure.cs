using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure
{
    public interface IProcedure<T,U>
    {
        List<T> this[U state] { get; }
        void UpdateState(T t, U u);
    }
}
