using System;
using System.IO;

namespace Web.Services
{
    public interface ICsvWriter : IDisposable
    {
        TextWriter Writer { get; }
        char Delimiter { get; set; }
        bool UseQuotes { get; set; }
        void AddCell(string value);
        void EndLine();
    }

    public abstract class BaseCsvWriter : ICsvWriter
    {
        private const char _DefaultDelimiter = ',';
        private bool _LineContainsData;

        protected BaseCsvWriter()
        {
            Delimiter = _DefaultDelimiter;
            _ResetLine();
        }

        #region ICsvWriter Members

        public void EndLine()
        {
            Writer.WriteLine();
            _ResetLine();
        }

        public bool UseQuotes { get; set; }

        public char Delimiter { get; set; }

        public TextWriter Writer { get; protected set; }

        public void AddCell(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("value");

            _WriteDelimiterIfNeeded();

            if (UseQuotes)
                _WriteWithQuotes(value);
            else
                _WriteWithOutQuotes(value);

            _SetLineContainsData();
        }

        public virtual void Dispose()
        {
            if (Writer != null)
            {
                Writer.Flush();
                Writer.Dispose();
                Writer = null;
            }
        }

        #endregion

        private void _WriteWithQuotes(string value)
        {
            const char quoteCharacter = '\"';

            Writer.Write(quoteCharacter);
            Writer.Write(_EscapeQuotes(value));
            Writer.Write(quoteCharacter);
        }

        private static string _EscapeQuotes(string value)
        {
            return value.Replace("\"", "\\\"");
        }

        private void _WriteWithOutQuotes(string value)
        {
            Writer.Write(value);
        }

        private void _ResetLine()
        {
            _LineContainsData = false;
        }

        private void _SetLineContainsData()
        {
            _LineContainsData = true;
        }

        private void _WriteDelimiterIfNeeded()
        {
            if (_LineContainsData)
                Writer.Write(Delimiter);
        }
    }

    public class StringCsvWriter : BaseCsvWriter
    {
        public StringCsvWriter()
        {
            base.Writer = new StringWriter();
        }

        public string GetContents()
        {
            var stringWriter = (StringWriter) base.Writer;

            return stringWriter.GetStringBuilder().ToString();
        }
    }

    public class StreamCsvWriter : BaseCsvWriter
    {
        public StreamCsvWriter(Stream outputStream)
        {
            if (outputStream == null)
                throw new ArgumentNullException("outputStream");

            base.Writer = new StreamWriter(outputStream);
        }

        public override void Dispose()
        {
            // do not dispose writer because that will close the stream
            if (Writer != null)
            {
                Writer.Flush();
            }
        }
    }
}