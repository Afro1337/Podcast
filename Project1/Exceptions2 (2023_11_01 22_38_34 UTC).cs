using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExceptionSerializer : Exception
    {
        private string fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
        }
        public ExceptionSerializer(string fileName, string message) : base(message)
        {
            this.fileName = fileName;
        }
    }
}
