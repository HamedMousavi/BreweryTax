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

            base.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
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


        public new bool Remove(TourMember member)
        {
            bool res = true;

            TourMember ftm = null;

            foreach (Entities.TourMember tm in this)
            {
                if (member.Id == tm.Id)
                {
                    ftm = tm;
                    break;
                }
            }

            if (ftm != null)
            {
                res = this.Items.Remove(ftm);
            }

            base.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, 0));

            return res;
        }
    }
}
