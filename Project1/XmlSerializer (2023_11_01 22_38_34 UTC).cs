using Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    internal class XmlSerializer
    {
        private Type type;

        public XmlSerializer(Type type)
        {
            this.type = type;
        }

        internal void Serialize(FileStream fileStreamOut, List<Podcast> items)
        {
            throw new NotImplementedException();
        }
    }
}