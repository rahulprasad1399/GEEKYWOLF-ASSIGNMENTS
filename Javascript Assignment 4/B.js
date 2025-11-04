let movies = [
    {
      "MovieName": "The Great Adventure",
      "ActorName": "John Smith",
      "ReleaseDate": "2023-01-15"
    },
    {
      "MovieName": "Mystery in the Woods",
      "ActorName": "Emily Johnson",
      "ReleaseDate": "2022-09-28"
    },
    {
      "MovieName": "Love and Destiny",
      "ActorName": "Michael Brown",
      "ReleaseDate": "2023-05-02"
    },
    {
      "MovieName": "City of Shadows",
      "ActorName": "Sophia Williams",
      "ReleaseDate": "2023-03-12"
    },
    {
      "MovieName": "The Last Stand",
      "ActorName": "William Davis",
      "ReleaseDate": "2022-11-07"
    },
    {
      "MovieName": "Echoes of Time",
      "ActorName": "Olivia Wilson",
      "ReleaseDate": "2022-12-19"
    }
  ]

// 1. List the movie name along with the actor name of those movies released in the year 2022
movies.forEach((movie)=>{
    let year = new Date(movie.ReleaseDate).getFullYear();
    if(year === 2022){
        console.log(movie.MovieName, ":", movie.ActorName)
    }
})

// 2. List the movie names released in the year 2023 where the actor is William Davis.
movies.forEach((movie)=>{
    let year = new Date(movie.ReleaseDate).getFullYear();
    if(year === 2023 && movie.ActorName === "William Davis"){
        console.log(movie.MovieName, ":", movie.ActorName)
    }
})

// 3. Retrieve the Actor name and release date of the movie “The Last Stand”
let theLastStand = movies.find((movie)=>movie.MovieName === "The Last Stand")
let theLastStandActorName = theLastStand.ActorName
let theLastStandReleasedData = theLastStand.ReleaseDate

// 4. Check whether there is any movie in the list with actor name “John Doe”
let JohnDoeMovieExist = movies.some((movie)=>movie.ActorName.toLowerCase() === "John Doe".toLowerCase())

// 5. Display the count of movies where the actor name is "Sophia Williams"
let SophiaWilliamsMovies = movies.filter((movie)=>movie.ActorName.toLowerCase() === "Sophia Williams".toLowerCase())?.length

// 6. Insert an element as last element
let newMovie = {
    "MovieName": "The Final Stage",
    "ActorName": "John Doe",
    "ReleaseDate": "2022-08-11"
} 

movies.push(newMovie)

// 7. Check whether there exists any duplicate movie names present in the array
const movieNames = movies.map((movie)=>movie.MovieName)
const hasDuplicates = movieNames.length !== new Set(movieNames).size

// 8. Create a new array starting from the movie "City of Shadows"
let indexOfCityOfShadows = movies.findIndex(movie => movie.MovieName === "City of Shadows")
let newMovieArray = movies.slice(indexOfCityOfShadows)

// 9. List the distinct actor names in array
let actorNamesArr = [...new Set(movies.map((movie)=>movie.ActorName))]

// 10. Insert an element as next element to movie “Love and Destiny”
let newMovie1 = {
    "MovieName": "Rich & Poor",
    "ActorName": "Johnie Walker",
    "ReleaseDate": "2023-08-11"
}

let indexOfLoveAndDestiny = movies.findIndex((movie)=>movie.MovieName === "Love and Destiny")
movies.splice(indexOfCityOfShadows, 0, newMovie1)

// 11. Display the count of distinct actor names in array
console.log("the count of distinct actor names : ", actorNamesArr.length)

// 12. Remove the movie named  "The Last Stand"
let indexOfLastStand = movies.findIndex((movie)=>movie.MovieName === "The Last Stand")
movies.splice(indexOfLastStand, 1)

// 13. Check whether all the movies are released after 2021 Dec 31
let checkAllMoviesAreReleasedAfter2021 = movies.every((movie)=>{
    let year = new Date(movie.ReleaseDate).getFullYear();
    return year > 2021
})

// 14. Update movie named  "City of Shadows" ‘s release date as  "2023-03-13"
let cityOfShadowMovie = movies.find((movie)=>movie.MovieName === "City of Shadows")
cityOfShadowMovie.ReleaseDate = "2023-03-13"

// 15. Create a new array of movie names whose movie name length is greater than 10.
let movieNameLengthAbove18 = movies.filter((movie)=>movie.MovieName.length > 10).map((movie)=>movie.MovieName)

