using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVCApplication.Models
{
    public static class DataHandler
    {
        public static List<Movie> GetAllMovies()
        {
            List<Movie> listMovies = new List<Movie>();
            using (var mvcEntity = new MVCApplicationEntities())
            {
                foreach (Movie movie in mvcEntity.Movies)
                {
                    listMovies.Add(movie);
                }
            }
            return listMovies;
        }
        public static WrapperModel WrapperMethod()
        {
            WrapperModel wrapperModel = new WrapperModel();
            wrapperModel.Movies = GetAllMovies();
            return wrapperModel;
        }
    }
}