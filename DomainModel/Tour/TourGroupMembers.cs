using System;
using System.Transactions;


namespace DomainModel
{

    public class TourGroupMembers
    {

        private static Repository.Sql.TourGroupMembers members;
        private static Repository.Sql.TourGroupMembersRelation groupMembers;
        private static Repository.Sql.PersonContacts contacts;


        public static void Init(string sqlConnectionString)
        {
            members = new Repository.Sql.TourGroupMembers(sqlConnectionString);
            groupMembers = new Repository.Sql.TourGroupMembersRelation(sqlConnectionString);

            contacts = new Repository.Sql.PersonContacts(sqlConnectionString);
        }

        // Provide group for inserts
        public static bool Save(Entities.TourMember member, Entities.TourGroup group = null)
        {
            bool res = true;

            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    if (member.IsDirty)
                    {
                        if (member.Id < 0)
                        {
                            if (!(res = members.Insert(member))) return res;
                            if (!(res = groupMembers.Insert(group, member))) return res;
                        }
                        else
                        {
                            if (!(res = members.Update(member))) return res;
                        }

                    }

                    foreach (Entities.Contact contact in member.Contacts)
                    {
                        if (contact.IsDirty)
                        {
                            if (contact.Id < 0)
                            {
                                if (!(res = contacts.Insert(member, contact))) return res;
                            }
                            else
                            {
                                if (!(res = contacts.Update(member, contact))) return res;
                            }
                        }
                    }

                    foreach (Entities.Contact contact in member.DeletedContacts)
                    {
                        if (!(res = contacts.Delete(contact))) return res;
                    }

                    if (group != null && !group.Members.Contains(member))
                    {
                        group.Members.Add(member);
                    }

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
        }


        public static void Load(Entities.TourGroup group)
        {
            try
            {
                // Load member details
                members.GetByGroup(group);

                // Load each member contacts
                foreach (Entities.TourMember member in group.Members)
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


        public static bool Delete(Entities.TourGroup group, Entities.TourMember member)
        {
            bool res = true;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    foreach (Entities.Contact contact in member.Contacts)
                    {
                        if (!(res = contacts.Delete(contact))) break;
                    }


                    if (res) res = groupMembers.Delete(group, member);
                    if (res) res = members.Delete(member);

                    if (res) ts.Complete();
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
    }
}
