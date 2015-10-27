using Remotion.Mixins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixinExample
{
    [Uses(typeof(TaggableMixin))]
    public class Photo
    {
        public string Description { get; set; }
        public string Format { get; set; }
    }
}
