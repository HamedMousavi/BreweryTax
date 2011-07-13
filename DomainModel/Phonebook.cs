using System;


namespace DomainModel
{

    public class Phonebook
    {

        private static Entities.TourMemberCollection cache;
        private static Repository.Sql.Phonebook persons;
        private static Repository.Sql.PersonContacts contacts;


        public static void Init(string sqlConnectionString)
        {
            cache = new Entities.TourMemberCollection();

            persons = new Repository.Sql.Phonebook(sqlConnectionString);
            contacts = new Repository.Sql.PersonContacts(sqlConnectionString);

            LoadAll();
        }


        private static void LoadAll()
        {
            try
            {
                // Load member details
                persons.LoadAll(cache);

                // Load each member contacts
                foreach (Entities.TourMember member in cache)
                {
                    contacts.GetByMember(member);
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


        public static Entities.TourMemberCollection GetAll()
        {
            return cache;
        }


        internal static bool Contains(Entities.TourMember member)
        {
            return cache.Contains(member);
        }


        public static void Save(Entities.TourMember person)
        {
            try
            {
                if (person.IsInPhonebook)
                {
                    if (cache.Contains(person))
                    {
                        persons.Delete(person);
                        cache.Remove(person);
                    }
                }
                else
                {
                    if (!cache.Contains(person))
                    {
                        persons.Insert(person);
                        cache.Add(person);
                    }
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


        internal static Entities.TourMember FindById(int id)
        {
            foreach (Entities.TourMember person in cache)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }

            return null;
        }
    }
}
