namespace ML
{
    public class Pelicula
    {
        public dynamic id { get; set; } = default!;
        public dynamic original_language { get; set; } = default!;
        public dynamic original_title { get; set; } = default!;
        public dynamic overview { get; set; } = default!;
        public dynamic popularity { get; set; } = default!;
        public dynamic poster_path { get; set; } = default!;
        public dynamic release_date { get; set; } = default!;
        public dynamic vote_average { get; set; } = default!;
        public List<object> results { get; set; } = default!;

    }
}