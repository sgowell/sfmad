using System;
using System.Collections;
using System.IO;

namespace Web.Services
{
    public class ObjectCsvWriter
    {
        private readonly ObjectConverter _ObjectConverter = new ObjectConverter();

        public void WriteToCSV(IEnumerable collection, Stream outputStream, bool useQuotes)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            if (outputStream == null)
                throw new ArgumentNullException("outputStream");

            using (ICsvWriter csvWriter = new StreamCsvWriter(outputStream))
            {
                csvWriter.UseQuotes = useQuotes;

                foreach (var item in collection)
                {
                    _WriteItem(csvWriter, item);
                }
            }
        }

        private void _WriteItem(ICsvWriter csvWriter, object item)
        {
            var dictionary = _ObjectConverter.ToDictionary(item);

            foreach (var dictionaryEntry in dictionary)
            {
                string value = (dictionaryEntry.Value == null) ? string.Empty : dictionaryEntry.Value.ToString();

                csvWriter.AddCell(value);
            }

            csvWriter.EndLine();
        }
    }
}