using System.Collections;
using BrightIdeasSoftware;


namespace TaxDataStore.Presentation.Controls
{

    public class CategoryVirtualListDataSource : AbstractVirtualListDataSource
    {
        public CategoryVirtualListDataSource(VirtualObjectListView listView) :
            base(listView)
        {
            this.rowCount = 0;
        }


        protected int rowCount;
        protected Entities.CategoryClass category;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public override object GetNthObject(int n)
        {
            return n;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetObjectCount()
        {
            return this.rowCount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public override int GetObjectIndex(object model)
        {
            return (int)model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelObjects"></param>
        public override void AddObjects(ICollection modelObjects)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelObjects"></param>
        public override void RemoveObjects(ICollection modelObjects)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        public override void SetObjects(IEnumerable collection)
        {
        }


        internal void Reload(Entities.CategoryClass category)
        {
            this.category = category;

            this.rowCount = 0;
            foreach(Entities.CategorySub sub in this.category.SubCategories)
            {
                this.rowCount = System.Math.Max(sub.Types.Count, this.rowCount);
            }

            this.listView.BuildList();
        }
    }
}
