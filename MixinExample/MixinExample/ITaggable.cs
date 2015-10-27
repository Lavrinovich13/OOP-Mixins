using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixinExample
{
    public interface ITaggable
    {
        void PutTag(string[] tags);
        string GetAllTags();
    }
}
