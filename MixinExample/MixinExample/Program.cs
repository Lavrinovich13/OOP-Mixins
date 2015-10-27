using System;
using System.Collections.Generic;
using System.Linq;
using Remotion.Mixins;

namespace MixinExample
{
    class Program
    {
        static void Main()
        {
            var photo = ObjectFactory.Create<Photo>();
            photo.Description = "vacations";

            var photoOfTaggableInterface = ((ITaggable)photo);
            photoOfTaggableInterface.PutTag(new[] { "summer 2015", "I and family" }); // вызываем метод mixin класса

            var document = ObjectFactory.Create<Document>();
            document.CreationDate = DateTime.Now;
            document.Title = "newDocument1";

            var documentOfTaggableInterface = ((ITaggable)document);
            documentOfTaggableInterface.PutTag(new[] { "studing", "3 version" });     // вызываем метод mixin класса
        }
    }
}
