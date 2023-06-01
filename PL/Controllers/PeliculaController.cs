using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class PeliculaController : Controller
    {
        [HttpGet]
        public IActionResult Popular()
        {
            ML.Pelicula pelicula = new ML.Pelicula();
            pelicula.results = new List<object>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");

                var responseTask = client.GetAsync("https://api.themoviedb.org/3/movie/popular?api_key=99e2becbdc4d8cdf4d51c55832a65f43&page=1&language=es-ES");
                responseTask.Wait(); //esperar a que se resuelva la llamada al servicio

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<dynamic>();
                    readTask.Wait();

                    foreach (var resultItem in readTask.Result.results)
                    {
                        ML.Pelicula resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Pelicula>(resultItem.ToString());
                        //pelicula.Drinks.Add(resultItemList);
                        ML.Pelicula pelicula1 = new ML.Pelicula();
                        pelicula1.id = resultItemList.id;
                        pelicula1.original_title = resultItemList.original_title;
                        pelicula1.overview = resultItemList.overview;
                        pelicula1.poster_path = "https://image.tmdb.org/t/p/w185"+ resultItemList.poster_path;

                        pelicula.results.Add(pelicula1);

                    }
                }
            }
            return View(pelicula);
        }

        [HttpGet]
        public IActionResult Favorito()
        {
            ML.Pelicula pelicula = new ML.Pelicula();
            pelicula.results = new List<object>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");

                var responseTask = client.GetAsync("https://api.themoviedb.org/3/account/19728978/favorite/movies?api_key=99e2becbdc4d8cdf4d51c55832a65f43&session_id=744e4a56d0759f21a4900776e186ee42dbc0e073&page=1&language=es-ES");
                responseTask.Wait(); //esperar a que se resuelva la llamada al servicio

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<dynamic>();
                    readTask.Wait();

                    foreach (var resultItem in readTask.Result.results)
                    {
                        ML.Pelicula resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Pelicula>(resultItem.ToString());
                        //pelicula.Drinks.Add(resultItemList);
                        ML.Pelicula pelicula1 = new ML.Pelicula();
                        pelicula1.id = resultItemList.id;
                        pelicula1.original_title = resultItemList.original_title;
                        pelicula1.overview = resultItemList.overview;
                        pelicula1.poster_path = "https://image.tmdb.org/t/p/w185" + resultItemList.poster_path;

                        pelicula.results.Add(pelicula1);

                    }
                }
            }
            return View(pelicula);
        }

       
        public IActionResult AddFavorito(int IdPelicula)
        {
            ML.Pelicula pelicula = new ML.Pelicula();
            pelicula.results = new List<object>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");

                var responseTask = client.GetAsync("https://api.themoviedb.org/3/account/19728978/favorite/movies?api_key=99e2becbdc4d8cdf4d51c55832a65f43&session_id=ebd5fbef92ef64d8f17eb93f8eb33fc7e4198d4f&page=1&language=es-ES");
                responseTask.Wait(); //esperar a que se resuelva la llamada al servicio

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<dynamic>();
                    readTask.Wait();

                    foreach (var resultItem in readTask.Result.results)
                    {
                        ML.Pelicula resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Pelicula>(resultItem.ToString());
                        //pelicula.Drinks.Add(resultItemList);
                        ML.Pelicula pelicula1 = new ML.Pelicula();
                        pelicula1.id = resultItemList.id;
                        pelicula1.original_title = resultItemList.original_title;
                        pelicula1.overview = resultItemList.overview;
                        pelicula1.poster_path = "https://image.tmdb.org/t/p/w185" + resultItemList.poster_path;

                        pelicula.results.Add(pelicula1);

                    }
                }
            }
            return View(pelicula);
        }


    }
}
