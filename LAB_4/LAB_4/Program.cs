using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureOfActors;

namespace LAB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Actor> actors = new List<Actor>()
            {
                new Actor(){fullName = "Aleksandr Samilenko", yearOfBirth=1978,role=Role.friend},
                new Actor(){fullName = "Leonardo DiCaprio", yearOfBirth=1974,role=Role.hero},
                new Actor(){fullName = "Benedict Cumberbatch", yearOfBirth=1976,role=Role.incognito},
                new Actor(){fullName = "Molly Bloom", yearOfBirth=1978,role=Role.passionate},
                new Actor(){fullName = "Emilia Isobel Euphemia Rose Clarke", yearOfBirth=1986,role=Role.hero}
            };
            List<Movie> movies = new List<Movie>()
            {
                new Movie(){title = "Strings of the world", genge = GenreOfMovies.fantasy, year = 2021, director ="Leonardo DiCaprio" },
                new Movie(){title = "A cube of nature", genge = GenreOfMovies.adventure, year = 2023, director ="Guy Ritchie" },
                new Movie(){title = "A bottle of wine", genge = GenreOfMovies.fantasy, year = 2021, director ="Steven Spielberg" },
                new Movie(){title = "Coming back of the Iron Man", genge = GenreOfMovies.action, year = 2023, director ="Russo brothers" },
                new Movie(){title = "Creation of religion", genge = GenreOfMovies.historical, year = 2022, director ="Peter Jackson" },
                new Movie(){title = "Robots. Buddies or foes?", genge = GenreOfMovies.scienceFiction, year = 2025, director ="Aleksandr Samilenko" },
                new Movie(){title = "Avatar 2", genge = GenreOfMovies.fantasy, year = 2022, director ="	James Cameron" }
            };
            List<Spectacle> spectacles = new List<Spectacle>()
            {
                new Spectacle(){title = "Strangers in the Monivile", genge = GenreOfSpectacles.comedy },
                new Spectacle(){title = "Yellow umbrella", genge = GenreOfSpectacles.musical },
                new Spectacle(){title = "Glasses on his head", genge = GenreOfSpectacles.tragedy },
                new Spectacle(){title = "A book in the brain", genge = GenreOfSpectacles.vaudeville },
                new Spectacle(){title = "Blue eyes or how to build a house?", genge = GenreOfSpectacles.melodrama },
                new Spectacle(){title = "Do not cry, do not smile", genge = GenreOfSpectacles.buffoonery },
                new Spectacle(){title = "Music in her eyes", genge = GenreOfSpectacles.drama }
            };
            List<LinkToMovie> linkToMovies = new List<LinkToMovie>()
            {
                new LinkToMovie("Leonardo DiCaprio","Robots. Buddies or foes?", 2025),
                new LinkToMovie("Aleksandr Samilenko","Creation of religion", 2023),
                new LinkToMovie("Leonardo DiCaprio","A bottle of wine", 2021),
                new LinkToMovie("Molly Bloom","Coming back of the Iron Man", 2023),
                new LinkToMovie("Emilia Isobel Euphemia Rose Clarke","Avatar 2", 2022),
                new LinkToMovie("Aleksandr Samilenko","A bottle of wine", 2021),
            };
            List<LinkToSpectacle> linkToSpectacles = new List<LinkToSpectacle>()
            {
                new LinkToSpectacle("Leonardo DiCaprio","Music in her eyes"),
                new LinkToSpectacle("Aleksandr Samilenko","A book in the brain"),
                new LinkToSpectacle("Aleksandr Samilenko","Strangers in the Monivile"),
                new LinkToSpectacle("Molly Bloom","Music in her eyes"),
                new LinkToSpectacle("Emilia Isobel Euphemia Rose Clarke","Blue eyes or how to build a house?"),
            };

            /*Output list of actors*/
            //OutPutActors(actors);

            /*Output list of actors which have a second letter is 'e'*/
            //OutPutActorsSecondE(actors);

            /*Output actors whith movies*/
            //OutPutActorsWithMovies(actors, movies, linkToMovies);

            /*Output all spectacles order by Title*/
            //SpectaclesOrderByTitle(spectacles);

            /*Output all actors whith grouping by the birthYear and role*/
            //ActorsGroupByBirthYear(actors);

            /*Output actors whith their specatle group by specacles*/
            //ActorsSpectaclesGroupBySpectacles(actors, spectacles, linkToSpectacles);

            /*Output actors wich play in movie which starts from 'C'*/
            //ActorsWithMoviesC(actors, movies, linkToMovies);

            /*Output average old of actors*/
            //AverageOldActors(actors);

            /*Output count of actors which born after 1980*/
            //CountOfActorsAfter80(actors);

            /*Join actors and movies, then group that by role and birthYear*/
            //JoinAndGroupMovies(movies, actors, linkToMovies);

            /*Output list of actors which are directors of movies*/
            //OutPutDirectors(actors, movies);

            /*Output list of fantasy movies*/
            //OutPutFantasyMovies(movies);

            /*Output list of actors which play in fantasy movies*/
            //OutPutActorsInFantasyMovies(actors, movies, linkToMovies);

            /*Output count of actors which play in drama spectacle*/
            //CountOfDramaActor(actors, spectacles, linkToSpectacles);

            /*OutPut list of actors which born before 1980 and play hero or passionate*/
            OutPutActorsBefore80AndPassionateOrHero(actors);
            Console.ReadKey();
        }
        static void OutPutActors(List<Actor> actors)
        {
            //Usually LINQ
            Console.WriteLine("Outputing list of actors using usually LINQ:");
            var listOfActors_1 = from actor in actors
                                 select actor;
            foreach (var actor in listOfActors_1)
            {
                Console.WriteLine(actor);
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors using expanded LINQ:");
            var listOfActors_2 = actors.Select(actor => new
            {
                fullName = actor.fullName,
                role = actor.role,
                yearOfBirth = actor.yearOfBirth
            });
            foreach (var actor in listOfActors_2)
            {
                Console.WriteLine("Full name is " + actor.fullName
                    + "; Role is " + actor.role
                    + "; Year of birth is " + actor.yearOfBirth);
            }
            Console.WriteLine();
        }
        static void OutPutActorsSecondE(List<Actor> actors)
        {
            //Usually LINQ
            Console.WriteLine("Outputing list of actors wich have second letter is 'e' using usually LINQ:");
            var listOfActors_1 = from actor in actors
                                 where actor.fullName[1] == 'e'
                                 select actor;
            foreach (var actor in listOfActors_1)
            {
                Console.WriteLine(actor);
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors wich have second letter is 'e' using expanded LINQ:");
            var listOfActors_2 = actors
                .Where(actor => actor.fullName[1] == 'e')
                .Select(actor => new
                {
                    fullName = actor.fullName,
                    role = actor.role,
                    yearOfBirth = actor.yearOfBirth
                });
            foreach (var actor in listOfActors_2)
            {
                Console.WriteLine("Full name is " + actor.fullName
                    + "; Role is " + actor.role
                    + "; Year of birth is " + actor.yearOfBirth);
            }
            Console.WriteLine();
        }
        static void OutPutActorsWithMovies(List<Actor> actors, List<Movie> movies, List<LinkToMovie> linkToMovies)
        {
            //Usually LINQ
            Console.WriteLine("Outputing list of actors with their movies using usually LINQ:");
            var lnk1 = from actor in actors
                       join link in linkToMovies on actor.fullName equals link.nameOfActor into temp
                       from t1 in temp
                       join movie in movies on t1.title equals movie.title into temp2
                       from t2 in temp2
                       select new { actor = actor.fullName, birthYear = actor.yearOfBirth, movieTitle = t2.title, movieYear = t2.year };
            foreach (var lnk in lnk1)
            {
                Console.WriteLine(lnk);
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors with their movies using expanded LINQ:");
            var lnk2 = actors
                .Join(linkToMovies,
                actor => actor.fullName,
                link => link.nameOfActor,
                (actor, link) => new
                {
                    name = actor.fullName,
                    actorBirthday = actor.yearOfBirth,
                    title = link.title,
                    year = link.year
                })
                .Join(movies,
                lnk => lnk.title,
                movie => movie.title,
                (lnk, movie) => new
                { actor = lnk.name,
                    birthYear = lnk.actorBirthday,
                    movieTitle = movie.title,
                    movieYear = movie.year
                });
            foreach (var lnk in lnk2)
            {
                Console.WriteLine(lnk);
            }
        }
        static void SpectaclesOrderByTitle(List<Spectacle> spectacles)
        {
            //Usually LINQ
            Console.WriteLine("Outputing list of spectacles order by field of 'Title' using usually LINQ:");
            var orderByTitleUsually = from spectacle in spectacles
                                      orderby spectacle.title
                                      select spectacle;
            foreach (var spectacle in orderByTitleUsually)
            {
                Console.WriteLine(spectacle);
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of spectacles order by field of 'Title' using expanded LINQ:");
            var orderByTitleExpanded = spectacles
                .OrderBy(spectacle => spectacle.title);
            foreach (var spectacle in orderByTitleExpanded)
            {
                Console.WriteLine(spectacle);
            }
            Console.WriteLine();
        }
        static void ActorsGroupByBirthYear(List<Actor> actors)
        {
            //Usually LinQ
            Console.WriteLine("Outputing list of actors group by field of 'yearOfBirth' using usually LINQ:");
            var groupByBirthYearUsually = from actor in actors
                                          group actor by actor.yearOfBirth;
            foreach (var group_of_actor in groupByBirthYearUsually)
            {
                foreach (var actor in group_of_actor)
                {
                    Console.WriteLine(actor);
                }
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors group by field of 'yearOfBirth' using expanded LINQ:");
            var groupByBirthYearExpanded = actors.GroupBy(actor => actor.yearOfBirth);
            foreach (var group_of_actor in groupByBirthYearExpanded)
            {
                foreach (var actor in group_of_actor)
                {
                    Console.WriteLine(actor);
                }
            }
        }
        static void ActorsSpectaclesGroupBySpectacles(List<Actor> actors, List<Spectacle> spectacles, List<LinkToSpectacle> linkToSpectacles)
        {
            //Usually LinQ
            Console.WriteLine("Outputing list of actors with their specatle group by specacles using ussualy LINQ:");
            var groupBySpectacles = from actor in actors
                                    join link in linkToSpectacles on actor.fullName equals link.nameOfActor
                                    into temp
                                    from t1 in temp
                                    join spectacle in spectacles on t1.title equals spectacle.title
                                    into temp2
                                    from t2 in temp2
                                    let temp3 = new
                                    {
                                        actor = actor.fullName,
                                        spectacleTitle = t2.title
                                    }
                                    group temp3 by temp3.spectacleTitle;
            foreach (var group_of_actor in groupBySpectacles)
            {
                foreach (var actor in group_of_actor)
                {
                    Console.WriteLine(actor);
                }
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors with their specatle group by specacles using expanded LINQ:");
            var groupBySpectaclesExpanded = actors
                .Join(linkToSpectacles,
                actor => actor.fullName,
                link => link.nameOfActor,
                (actor, link) => new
                {
                    name = actor.fullName,
                    title = link.title
                })
                .Join(spectacles,
                lnk => lnk.title,
                spectacle => spectacle.title,
                (lnk, spectacle) => new
                {
                    actor = lnk.name,
                    spectacleTitle = spectacle.title
                })
                .GroupBy(spectacle => spectacle.spectacleTitle);
            foreach (var group_of_actor in groupBySpectaclesExpanded)
            {
                foreach (var info in group_of_actor)
                {
                    Console.WriteLine(info);
                }
            }
        }
        static void ActorsWithMoviesC(List<Actor> actors, List<Movie> movies, List<LinkToMovie> linkToMovies)
        {
            //Usually LinQ
            Console.WriteLine("Outputing list of actors with their specatle group by specacles using ussualy LINQ:");
            var StartsWithC = from actor in actors
                              join link in linkToMovies on actor.fullName equals link.nameOfActor into temp
                              from t1 in temp
                              join movie in movies on t1.title equals movie.title into temp2
                              from t2 in temp2
                              let temp3 = new { actor = actor.fullName, spectacleTitle = t2.title }
                              where temp3.spectacleTitle[0] == 'C'
                              select temp3;
            foreach (var info in StartsWithC)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors with their specatle group by specacles using expanded LINQ:");
            var StartsWithCExpanded = actors
                .Join(linkToMovies,
                actor => actor.fullName,
                link => link.nameOfActor,
                (actor, link) => new
                {
                    name = actor.fullName,
                    title = link.title
                })
                .Join(movies,
                lnk => lnk.title,
                movie => movie.title,
                (lnk, movie) => new
                {
                    actor = lnk.name,
                    movieTitle = movie.title
                })
                .Where(movie => movie.movieTitle[0] == 'C');
            foreach (var info in StartsWithCExpanded)
            {
                Console.WriteLine(info);
            }
        }
        static void AverageOldActors(List<Actor> actors)
        {
            DateTime currentYear = DateTime.Now;
            //Usually LINQ
            var averageOld = currentYear.Year
                - (from actor in actors
                   where actor.yearOfBirth > 1970
                   select actor)
                  .Average(actor => actor.yearOfBirth);
            Console.WriteLine($"Average old of actors wich born after 1970 year is = {Math.Round(averageOld, 1)} (using usually LINQ)");
            Console.WriteLine();

            //Expended LINQ
            var averageOldExpanded = currentYear.Year
                - actors
                .Where(actor => actor.yearOfBirth > 1970)
                .Average(actor => actor.yearOfBirth);
            Console.WriteLine($"Average old of actors wich born after 1970 year is = {Math.Round(averageOldExpanded, 1)} using expanded LINQ");
        }
        static void CountOfActorsAfter80(List<Actor> actors)
        {
            //Usually LINQ
            Console.WriteLine("Count of actors which born after 1980 using Usually LINQ:");
            var countUsually = (from actor in actors
                               where actor.yearOfBirth > 1980
                               select actor)
                               .Count();
            Console.WriteLine(countUsually);

            //Expended LINQ
            Console.WriteLine("Count of actors which born after 1980 using Expanded LINQ:");
            var countExpanded = actors.Count(actor => actor.yearOfBirth > 1980);
            Console.WriteLine(countExpanded);
        }
        static void JoinAndGroupMovies(List<Movie> movies, List<Actor> actors, List<LinkToMovie> linkToMovies)
        {
            //Usually LinQ
            Console.WriteLine("Outputing list of actors with their specatle group by specacles using ussualy LINQ:");
            Console.WriteLine("---------------------------------");
            var joinGroupUsually = from actor in actors
                                   join link in linkToMovies on actor.fullName equals link.nameOfActor into temp
                                   from t1 in temp
                                   join movie in movies on t1.title equals movie.title into temp2
                                   from t2 in temp2
                                   let temp3 = new
                                   {
                                       actor = actor.fullName,
                                       birthYear = actor.yearOfBirth,
                                       titleOfMovie = t2.title,
                                   }
                                   group temp3 by temp3.birthYear;
            foreach (var info in joinGroupUsually)
            {
                foreach (var actor in info)
                {
                    Console.WriteLine(actor);
                }
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors with their specatle group by specacles using expanded LINQ:");
            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            var joinGroupExpanded = actors
                .Join(linkToMovies,
                actor => actor.fullName,
                link => link.nameOfActor,
                (actor, link) => new
                {
                    title = link.title,
                    nameOfActor = actor.fullName,
                    birthYear = actor.yearOfBirth
                })
                .Join(movies,
                lnk => lnk.title,
                movie => movie.title,
                (_lnk, _movie) => new
                {
                    actor = _lnk.nameOfActor,
                    birthYear = _lnk.birthYear,
                    titleOfMovie = _movie.title
                })
                .GroupBy(info => info.birthYear);
            foreach (var info in joinGroupExpanded)
            {
                foreach (var actor in info)
                {
                    Console.WriteLine(actor);
                }
                Console.WriteLine("+++++++++++++++++++++++++++++++++");
            }
        }
        static void OutPutDirectors(List<Actor> actors, List<Movie> movies)
        {
            //Usually LINQ
            Console.WriteLine("List of actors which are director of movie using usually LINQ:");
            var directors = from actor in actors
                            join movie in movies on actor.fullName equals movie.director
                            into info
                            from inf in info
                            select new
                            {
                                fullName = inf.director
                            };
            foreach (var director in directors)
            {
                Console.WriteLine("Name of actor-director is " + director.fullName);
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("List of actors which are director of movie using expanded LINQ:");
            var directorsExpanded = actors.Join(movies,
                actor => actor.fullName,
                movie => movie.director,
                (actor, movie) => new
                {
                    fullName = actor.fullName
                });
            foreach (var director in directorsExpanded)
            {
                Console.WriteLine("Name of actor-director is " + director.fullName);
            }
        }
        static void OutPutFantasyMovies(List<Movie> movies)
        {
            //Usually LINQ
            Console.WriteLine("List of fantasy movies using usually LINQ:");
            var fantasyMoviesUsually = from movie in movies
                                       where movie.genge == GenreOfMovies.fantasy
                                       orderby movie.title descending
                                       select new { title = movie.title, year = movie.year };
            foreach (var movie in fantasyMoviesUsually)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("List of fantasy movies using expanded LINQ:");
            var fantasyMoviesExpanded = movies
                .Where(movie => movie.genge == GenreOfMovies.fantasy)
                .Select(movie => new
                {
                    title = movie.title,
                    year = movie.year
                });
            foreach (var movie in fantasyMoviesExpanded)
            {
                Console.WriteLine(movie);
            }
        }
        static void OutPutActorsInFantasyMovies(List<Actor> actors, List<Movie> movies, List<LinkToMovie> linkToMovies)
        {
            //Usually LINQ
            Console.WriteLine("Outputing list of actors which play in fantasy movies using usually LINQ:");
            var lnk1 = from actor in actors
                       join link in linkToMovies on actor.fullName equals link.nameOfActor into temp
                       from t1 in temp
                       join movie in movies on t1.title equals movie.title into temp2
                       from t2 in temp2
                       where t2.genge == GenreOfMovies.fantasy
                       select new { fullName = actor.fullName };
            foreach (var lnk in lnk1)
            {
                Console.WriteLine(lnk);
            }
            Console.WriteLine();

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors which play in fantasy movies using expanded LINQ:");
            var lnk2 = actors
                .Join(linkToMovies,
                actor => actor.fullName,
                link => link.nameOfActor,
                (actor, link) => new
                {
                    name = actor.fullName,
                    actorBirthday = actor.yearOfBirth,
                    title = link.title,
                    year = link.year
                })
                .Join(movies,
                lnk => lnk.title,
                movie => movie.title,
                (lnk, movie) => new
                {
                    actor = lnk.name,
                    genre = movie.genge
                })
                .Where(movie => movie.genre == GenreOfMovies.fantasy)
                .Select(movie => new
                {
                    fullName = movie.actor
                });
            foreach (var lnk in lnk2)
            {
                Console.WriteLine(lnk);
            }
        }
        static void CountOfDramaActor(List<Actor> actors, List<Spectacle> spectacles, List<LinkToSpectacle> linkToSpectacles)
        {
            //Usually LINQ
            Console.WriteLine("Outputing list of actors with their specatle group by specacles using ussualy LINQ:");
            var countOfDramaActorsUsually = (from actor in actors
                                    join link in linkToSpectacles on actor.fullName equals link.nameOfActor
                                    into temp
                                    from t1 in temp
                                    join spectacle in spectacles on t1.title equals spectacle.title
                                    into temp2
                                    from t2 in temp2
                                    where t2.genge == GenreOfSpectacles.drama
                                    let temp3 = new
                                    {
                                        nameOfActor = actor.fullName
                                    }
                                    select temp3)
                                    .Count();
            Console.WriteLine(countOfDramaActorsUsually);

            //Expanded LINQ
            Console.WriteLine("Outputing list of actors with their specatle group by specacles using expanded LINQ:");
            var countOfDramaActorsExpanded = actors
                .Join(linkToSpectacles,
                actor => actor.fullName,
                link => link.nameOfActor,
                (actor, link) => new
                {
                    name = actor.fullName,
                    title = link.title
                })
                .Join(spectacles,
                lnk => lnk.title,
                spectacle => spectacle.title,
                (lnk, spectacle) => new
                {
                    nameOfActor = lnk.name,
                    genre = spectacle.genge
                })
                .Where(info => info.genre == GenreOfSpectacles.drama)
                .Select(info => new
                {
                    fullName = info.nameOfActor
                })
                .Count();
            Console.WriteLine(countOfDramaActorsExpanded);
        }
        static void OutPutActorsBefore80AndPassionateOrHero(List<Actor> actors)
        {
            //Usually LINQ
            Console.WriteLine("List of actors which born before 1980 and play hero or passionate using Usually LINQ:");
            var listOfActors = from actor in actors
                               where actor.yearOfBirth < 1980 && (actor.role == Role.hero || actor.role == Role.passionate)
                               select new
                               {
                                   fullName = actor.fullName
                               };
            foreach(var actor in listOfActors)
            {
                Console.WriteLine(actor);
            }

            //Expanded LINQ
            Console.WriteLine("List of actors which born before 1980 and play hero or passionate using Expanded LINQ:");
            var listOfActorsExpanded = actors
                .Where(actor => actor.yearOfBirth < 1980
                && (actor.role == Role.hero || actor.role == Role.passionate))
                .Select(actor => new
                {
                    fullName = actor.fullName
                });
            foreach(var actor in listOfActorsExpanded)
            {
                Console.WriteLine(actor);
            }
        }
    }
}