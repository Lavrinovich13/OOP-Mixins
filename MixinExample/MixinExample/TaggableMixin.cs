using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixinExample
{
    public class TaggableMixin : ITaggable
    {
        private readonly List<string> Tags = new List<string>();

        public void PutTag(string[] tags)
        {
            Tags.AddRange(tags);
        }

        public string GetAllTags()
        {
            return Tags.Aggregate(string.Empty, (current, s) => current + " " + s);
        }
    }
}
