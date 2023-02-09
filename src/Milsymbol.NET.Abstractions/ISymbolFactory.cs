using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milsymbol.NET.Abstractions
{
    /// <summary>
    /// Provides a contract for objects able to build symbol objects.
    /// </summary>
    public interface ISymbolFactory
    {
        ISymbol Build(string code);
    }
}
