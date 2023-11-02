using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Validation
    {

        public Boolean NotEmpty(string text)
        {
            Boolean result = true;

            if (string.IsNullOrEmpty(text))
            {
                result = false;
            }

            return result;

        }

        public Boolean CheckURL(string url)

        {

            Boolean result = true;
            if (!url.StartsWith("https://"))
            {
                result = false;
            }
            return result;
        }

        public Boolean URLDuplicate(string url, List<Podcast> list)
        {
            Boolean result = false;

            foreach (var pod in list)
            {
                if (pod.Url.Equals(url))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public Boolean CbSelected(int i)
        {
            Boolean result = false;

            if (i >= 0)
            {
                result = true;
            }

            return result;
        }


    }
}
