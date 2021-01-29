using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace TvShowCode
{
    public class ApiHelper
    {

        // We fetch Show by it's name
        public static List<BestFit> GetShowsByName(string name)
        {


            string json = new WebClient().DownloadString($"http://api.tvmaze.com/search/shows?q={name}");
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

            List<BestFit> shows = JsonConvert.DeserializeObject<List<BestFit>>(json, settings);

            return shows;

        }

        // Seasons are fetched by ID of show 
        public static List<Season> GetSeasonsOfShow(int showId)
        {

            string json = new WebClient().DownloadString($"http://api.tvmaze.com/shows/{showId}/seasons");
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

            List<Season> seasons = JsonConvert.DeserializeObject<List<Season>>(json, settings);

            return seasons;
        }

        // since each show has seasons starting from 1, we can't use the number, so instead we use ID (which is unique for each season) in order to fetch episodes
        public static List<Episode> GetEpisodesOfShow(int seasonId)
        {
            string json = new WebClient().DownloadString($"http://api.tvmaze.com/seasons/{seasonId}/episodes");
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

            List<Episode> episodes = JsonConvert.DeserializeObject<List<Episode>>(json, settings);

            return episodes;
        }

        public static Comic GetComic(int number)
        {
            string json = new WebClient().DownloadString($"http://xkcd.com/{number}/info.0.json");
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

            Comic comic = JsonConvert.DeserializeObject<Comic>(json, settings);

            return comic;
        }

    }

}
