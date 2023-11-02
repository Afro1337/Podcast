using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository { 

    public interface IGetEpisode<T> where T : Episode
    {
        Task<List<T>> AllEpisodes(string url);
    }
}
