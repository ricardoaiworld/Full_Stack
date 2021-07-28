import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MovieService } from 'src/app/core/services/movie.service';
@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {

  movie! : Movie;
  movieId!: number;
  constructor(private router : ActivatedRoute, private movieService : MovieService) { }

  //get the movie id from the url and call the movieService, getMovieDetails method
  ngOnInit(): void {
    this.router.paramMap.subscribe(
      p => {
        this.movieId = +p.get('id');
        this.movieService.getMovieDetails(this.movieId)
        .subscribe( m => {
          this.movie = m
        })

      }
    )
  }

}
