using Models;
using DAL.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public class ControllerPodcast
    {
        RepositoryPodcast repositoryPodcast;
        RepositoryEpisode repositoryEpisode;
        List<Podcast> podcastList;

        public ControllerPodcast()
        {
            repositoryPodcast = new RepositoryPodcast();
            repositoryEpisode = new RepositoryEpisode();
            podcastList = repositoryPodcast.GetAll();

        }

        public List<Podcast> GetAll()
        {
            return repositoryPodcast.GetAll();
        }

        public async Task<Podcast> CreatePodcast(string name, string url, string category)
        {
            List<Episode> episodeList = await repositoryEpisode.AllEpisodes(url);
            Podcast podcast = new Podcast(name, url, category, episodeList);
            repositoryPodcast.Create(podcast);
            return podcast;
        }


        public void DeletePodcast(string name)
        {
            int index = repositoryPodcast.GetIndex(name);
            repositoryPodcast.Delete(index);
        }

        public void UpdatePodcast(int thePod, string name, string url, string category)
        {
            var podcastLista = repositoryPodcast.GetAll();
            Podcast pod = podcastLista[thePod];

            pod.Name = name;
            pod.Url = url;
            pod.Category = category;

            repositoryPodcast.Update(thePod, pod);
        }

        public void UpdateCategoryPod(Podcast podcast, string newCategory)
        {
            var podcastLista = repositoryPodcast.GetAll();
            int index = repositoryPodcast.GetIndex(podcast.Name);

            podcast.Category = newCategory;
            repositoryPodcast.Update(index, podcast);
        }


    }

}