using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class TourMembers
    {

        private static Repository.Sql.TourMembers members;
        private static Repository.Sql.TourMembersRelation tourMembers;
        private static Repository.Sql.PersonContacts contacts;
        private static Repository.Sql.PersonContactsRelation personContacts;


        public static void Init(string sqlConnectionString)
        {
            members = new Repository.Sql.TourMembers(sqlConnectionString);
            tourMembers = new Repository.Sql.TourMembersRelation(sqlConnectionString);

            contacts = new Repository.Sql.PersonContacts(sqlConnectionString);
            personContacts = new Repository.Sql.PersonContactsRelation(sqlConnectionString);
        }


        internal static bool Save(Entities.Tour tour)
        {
            bool res = true;

            foreach (Entities.TourMember member in tour.Members)
            {
                if (member.IsDirty)
                {
                    if (member.Id < 0)
                    {
                        if (!(res = members.Insert(member))) break;
                        if (!(res = tourMembers.Insert(tour, member))) break;
                    }
                    else
                    {
                        if (!(res = members.Update(member))) break;
                    }

                    foreach(Entities.Contact contact in member.Contacts)
                    {
                        if (contact.Id < 0)
                        {
                            if (!(res = contacts.Insert(contact))) break;
                            if (!(res = personContacts.Insert(member, contact))) break;
                        }
                        else
                        {
                            if (!(res = contacts.Update(contact))) break;
                        }
                    }
                }
            }

            return res;
        }


        internal static void Load(Entities.Tour tour)
        {
            try
            {
                members.GetByTour(tour);

                foreach (Entities.TourMember member in tour.Members)
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
    }
}
