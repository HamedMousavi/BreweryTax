using System;
using System.Transactions;
using Entities;


namespace DomainModel
{

    public class Tours
    {

        private static string cnnString;
        private static TourCollection cache;
        private static Repository.Sql.Tours toursRepo;


        public static void Init(string sqlConnectionString)
        {
            cnnString = sqlConnectionString;
            cache = new TourCollection();

            toursRepo = new Repository.Sql.Tours(sqlConnectionString);
        }


        public static bool Save(Entities.Tour tour)
        {
            bool res = false;
            try
            {
                if (tour.IsDirty)
                {
                    if (tour.Id < 0)
                    {
                        res = toursRepo.Insert(tour);

                        if (!cache.Contains(tour) &&
                            (tour.Time.Value.Date - cache.Time.Date).Days == 0)
                        {
                            InsertInCache(tour);
                        }
                    }
                    else
                    {
                        res = toursRepo.Update(tour);

                        if (cache.Contains(tour) &&
                            (tour.Time.Value.Date - cache.Time.Date).Days != 0)
                        {
                            cache.Remove(tour);
                        }
                        else
                        {
                            UpdateInCache(tour);
                        }
                    }

                    if (res)
                    {
                        tour.IsDirty = false;
                    }
                }
                else
                {
                    res = true;
                }
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }


        private static Int32 GetIndexInCache(Entities.Tour tour)
        {
            int index = 0;

            foreach (Entities.Tour item in cache)
            {
                if (tour != item)
                {
                    if (tour.Time.Value > item.Time.Value) break;
                    index++;
                }
            }

            return index;
        }
        
        
        private static void UpdateInCache(Entities.Tour tour)
        {
            int index = GetIndexInCache(tour);

            if (index != cache.IndexOf(tour))
            {
                cache.Remove(tour);
                cache.Insert(index, tour);
            }
        }


        private static void InsertInCache(Entities.Tour tour)
        {
            int index = GetIndexInCache(tour);

            cache.Insert(index, tour);
        }


        private static void UndoDeleteCaches(Entities.Tour tour)
        {
            // Clean deleted items cause they saved with no problem
            //tour.DeletedPayments.UndoDelete(tour.Payments);
            //tour.DeletedMembers.UndoDelete(tour.Members);
            //tour.DeletedEmployees.UndoDelete(tour.Employees);
            //foreach (Entities.TourMember member in tour.Members)
            //{
            //    member.DeletedContacts.UndoDelete(member.Contacts);
            //}
        }


        private static void ClearDeleteCaches(Entities.Tour tour)
        {
            // Clean deleted items cause they saved with no problem
            //tour.DeletedPayments.Clear();
            //tour.DeletedMembers.Clear();
            //tour.DeletedEmployees.Clear();
            //foreach (Entities.TourMember member in tour.Members)
            //{
            //    member.DeletedContacts.Clear();
            //}
        }


        public static bool Delete(Entities.Tour tour)
        {
            bool res = true;

            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    foreach (Entities.TourGroup group in tour.Groups)
                    {
                        if (!(res = DomainModel.TourGroups.Delete(group))) break;
                    }

                    if (res)
                    {
                        res = toursRepo.Delete(tour);

                        if (res)
                        {
                            ts.Complete();
                            if (cache.Contains(tour)) cache.Remove(tour);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res = false;

                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }


        public static void LoadByDate(DateTime date, TourCollection tours)
        {
            try
            {
                cache = tours;
                cache.Time = date;

                tours.Clear();
                toursRepo.GetByDate(tours, date);

                foreach (Entities.Tour tour in tours)
                {
                    DomainModel.TourGroups.Load(tour);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

        }

        /*
        public static bool SaveChanges(Entities.Tour tour)
        {
            bool res = false;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    res = Save(tour);
                    if (res) res = DomainModel.TourGroups.Save(tour);

                    ts.Complete();
                }

            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }*/
    }
}
