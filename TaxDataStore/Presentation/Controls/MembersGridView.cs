using System.Drawing;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{
    public class MembersGridView : FlatGridView
    {

        public MembersGridView(TourMemberCollection members)
            : base()
        {
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridColor = Color.LightGray;

            this.hiddenColumnNames.Add("Title");
            this.hiddenColumnNames.Add("Contacts");
            this.hiddenColumnNames.Add("MemberShip");
            this.SetDataSource(members);
        }
    }}
