using Remotion.Mixins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixinExample
{
    [Uses(typeof(TaggableMixin))]
    public class Document
    {
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
