using Entities;
using System;


namespace DomainModel
{

    public class Tours
    {

        private static string cnnString;
        private static TourCollection cache;


        public static void Init(string sqlConnectionString)
        {
            cnnString = sqlConnectionString;
            cache = new TourCollection();
        }


        public static TourCollection GetByDate(DateTime date)
        {
            TourCollection daily = new TourCollection();
            foreach (Tour tour in cache)
            {
                if (tour.Time.Value.Date == date.Date)
                {
                    daily.Add(tour);
                }
            }

            return daily;
        }


        public static TourCollection GetAll()
        {
            return cache;
        }

        
        public static bool Save(Entities.Tour tour)
        {
            if (!cache.Contains(tour))
            {
                cache.Add(tour);
            }

            return true;
        }


        public static void Delete(Tour tour)
        {
            cache.Remove(tour);
        }


        public static void LoadByDate(DateTime date, TourCollection tours)
        {
            tours.Clear();

            foreach (Tour tour in cache)
            {
                if (tour.Time.Value.Date == date.Date)
                {
                    tours.Add(tour);
                }
            }
        }
    }
}
