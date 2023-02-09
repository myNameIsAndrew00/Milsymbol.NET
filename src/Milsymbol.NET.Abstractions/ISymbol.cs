using System.Drawing;

namespace Milsymbol.NET.Abstractions
{
    /// <summary>
    /// Provides methods which allows symbol rendering and saving.
    /// </summary>
    public interface ISymbol : IDisposable
    {
        /// <summary>
        /// Attempt to draw the symbol into a stream.
        /// </summary>
        /// <param name="stream"></param>
        void Draw(Stream stream);

        /// <summary>
        /// Attempt to draw the symbol into a bitmap at given x and y positions.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Draw(Bitmap bitmap, int x, int y);

        /// <summary>
        /// Attempts to draw the symbol to a png file at given path.
        /// </summary>
        /// <param name="filePath"></param>
        void Draw(string filePath);
    }
}