﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers {
    public class MoviesController : Controller {
        public ActionResult Index() {
            var movies = GetMovies();
            return View(movies);
        }

        private List<Movie> GetMovies() {
            return new List<Movie> {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "The Lord of the Rings"}
            };
        }

        public ActionResult Random() {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer> {
                new Customer{Name = "Customer1"},
                new Customer{Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}