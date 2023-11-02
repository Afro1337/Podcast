using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }


        public List<Episode> EpisodeList { get; set; }

        public Podcast(string name, string url, string category, List<Episode> episodeList)
        {
            Name = name;
            Url = url;
            Category = category;
            EpisodeList = episodeList;
        }

        public Podcast() { }

    }
}
