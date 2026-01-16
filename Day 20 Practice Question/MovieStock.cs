// namespace MyConsoleApp
// {
//     public class Movie
//     {
//         public string? Title { get; set; }
//         public string? Artist { get; set; }
//         public string? Genre { get; set; }
//         public int Ratings { get; set; }
//     }

//     public class Program
//     {
//         public static List<Movie> MovieList = [];
//         public static void AddMovie(string MovieDetails)
//         {
//             string[] details = MovieDetails.Split(",");
//             Movie movie = new()
//             {
//                 Title = details[0],
//                 Artist = details[1],
//                 Genre = details[2],
//                 Ratings = int.Parse(details[3]),
//             };
//             MovieList.Add(movie);
//         }

//         public static List<Movie> ViewMoviesByGenre(string genre)
//         {
//             var res = MovieList.Where(e => e.Genre == genre).ToList();
//             if (res.Count == 0)
//                 return [];

//             return res;
//         }

//         public static List<Movie> ViewMoviesByRatings()
//         {
//             return MovieList.OrderBy(e => e.Ratings).ToList();
//         }

//         public static void Main()
//         {
//             Console.WriteLine("Enter the number of movies:");
//             int n = int.Parse(Console.ReadLine());

//             // 2. Get movie details
//             Console.WriteLine("Enter movie details (Title,Artist,Genre,Ratings):");
//             for (int i = 0; i < n; i++)
//             {
//                 string details = Console.ReadLine();
//                 AddMovie(details);
//             }

//             // 3. Get genre to search
//             Console.WriteLine("Enter the genre to search:");
//             string? genre = Console.ReadLine() ?? "";

//             var genreMovies = ViewMoviesByGenre(genre);

//             if (genreMovies.Count == 0)
//             {
//                 Console.WriteLine($"No Movies found in genre '{genre}'");
//             }
//             else
//             {
//                 Console.WriteLine("\nMovies in selected genre:");
//                 foreach (var movie in genreMovies)
//                 {
//                     Console.WriteLine($"Title: {movie.Title}\nArtist: {movie.Artist}\nGenre: {movie.Genre}\nRatings: {movie.Ratings}\n");
//                 }
//             }

//             // 4. View movies sorted by ratings
//             Console.WriteLine("\nMovies sorted by ratings:\n");
//             var sortedMovies = ViewMoviesByRatings();
//             foreach (var movie in sortedMovies)
//             {
//                 Console.WriteLine($"{movie.Title},{movie.Artist},{movie.Genre},{movie.Ratings}");
//             }
//         }
//     }
// }