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
    }
}
