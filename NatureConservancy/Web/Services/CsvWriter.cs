using System;
using System.Data;
using System.IO;
using System.Text;

namespace Web.Services
{
    public interface ICsvWriter : IDisposable
    {
        // TODO: 
        void AddCell(string value);
        void EndLine();
        TextWriter Writer { get; }
    }

    public abstract class BaseCsvWriter : ICsvWriter
    {
        public void EndLine()
        {
            throw new NotImplementedException();
        }

        public TextWriter Writer { get; protected set;}
        public void AddCell(string value)
        {
            // TODO: implement
        }

        public void Dispose()
        {
            // TODO think we want this.
        }
    }

    public class StringCsvWriter : BaseCsvWriter
    {
        public StringCsvWriter()
        {
            base.Writer = new StringWriter();
        }
        
    }
}