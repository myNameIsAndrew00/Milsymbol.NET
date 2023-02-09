using Milsymbol.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milsymbol.NET
{
    internal class Symbol : ISymbol
    {
        public SymbolOptions Options { get; init; } = new();

        public SymbolStyle Style { get; init; } = new();

        public void Dispose()
        {
        }

        public void Draw(Stream stream)
        {
            throw new NotImplementedException();
        }

        public void Draw(Bitmap bitmap, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Draw(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
