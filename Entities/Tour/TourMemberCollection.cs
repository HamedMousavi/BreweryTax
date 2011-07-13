using System.ComponentModel;


namespace Entities
{

    public class TourMemberCollection : BindingList<TourMember>
    {
        internal void CopyTo(TourMemberCollection members)
        {
            members.Clear();

            foreach (TourMember member in this)
            {
                TourMember memberCopy = new TourMember();
                member.CopyTo(memberCopy);

                members.Add(memberCopy);
            }
        }

        public void UndoDelete(TourMemberCollection originalList)
        {
            foreach (TourMember member in this)
            {
                originalList.Add(member);
            }

            this.Clear();
        }


        public new bool Contains(TourMember member)
        {
            foreach (Entities.TourMember tm in this)
            {
                if (member.Id == tm.Id)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
