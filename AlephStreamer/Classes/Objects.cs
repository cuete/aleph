using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleph
{
    class Objects
    {

    }

    public class TextSource : Source
    {
        public TextSource(string name, SourceType type) : base(name, type)
        {
            this.name = name;
            this.type = type;
        }

        public string path { get; set; }
    }

    public class APISource : Source
    {
        public APISource(string name, SourceType type) : base(name, type)
        {
            this.name = name;
            this.type = type;
        }

        public Uri URI { get; set; }
    }

    public class Source
    {
        public Source(string name, SourceType type)
        {
            this.name = name;
            this.type = type;
        }
        public string name { get; set; }
        public SourceType type { get; set; }
    }

    public enum SourceType // : int
    {
        Text, API, AzureTable, AzureQueue
    }
}
