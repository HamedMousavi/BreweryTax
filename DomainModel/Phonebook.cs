using System;
using System.Transactions;


namespace DomainModel
{

    public class Phonebook
    {

        private static Entities.TourMemberCollection cache;
        private static Repository.Sql.Phonebook persons;
        private static Repository.Sql.PersonContacts contacts;
        private static Repository.Sql.TourGroupMembers members;


        public static void Init(string sqlConnectionString)
        {
            cache = new Entities.TourMemberCollection();

            persons = new Repository.Sql.Phonebook(sqlConnectionString);
            contacts = new Repository.Sql.PersonContacts(sqlConnectionString);
            members = new Repository.Sql.TourGroupMembers(sqlConnectionString);

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
                    if (!cache.Contains(person))
                    {
                        persons.Insert(person);
                        cache.Add(person);
                    }
                }
                else
                {
                    if (cache.Contains(person))
                    {
                        persons.Delete(person);
                        cache.Remove(person);
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


        public static bool Delete(Entities.TourMember person)
        {
            bool res = true;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    foreach (Entities.Contact contact in person.Contacts)
                    {
                        if (!(res = contacts.Delete(contact))) break;
                    }

                    if (res) res = persons.Delete(person);

                    if (res) res = members.Delete(person);

                    if (res) ts.Complete();
                }

                if (res) cache.Remove(person);
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
    }
}
