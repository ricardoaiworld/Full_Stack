export interface Cast {
    id: number;
    name: string;
    gender?: any;
    tmdbUrl?: any;
    profilePath: string;
    character: string;
}

export interface Genre {
    id: number;
    name: string;
}

export interface Movie {
    id: number;
    title: string;
    posterUrl: string;
    backdropUrl?: any;
    rating: number;
    overview: string;
    tagline: string;
    budget: number;
    revenue?: any;
    imdbUrl?: any;
    tmdbUrl?: any;
    releaseDate: Date;
    runTime?: any;
    price: number;
    favoritesCount: number;
    casts: Cast[];
    genres: Genre[];
}