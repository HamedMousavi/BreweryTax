using System;
using System.Drawing;
using BrightIdeasSoftware;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class CategoryListView : VirtualObjectListView
    {

        protected CategoryVirtualListDataSource virtualDataSource;
        protected Entities.CategoryClass category;
        protected int currColumn;


        public CategoryListView()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();

            AddColumns();

            this.RightToLeftLayout = false;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font(
                "Tahoma", 9.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                ((byte)(0)));
            this.FullRowSelect = true;
            this.Location = new Point(0, 0);
            this.Name = "CategoryListView";
            this.OwnerDraw = true;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowGroups = false;
            this.ShowImagesOnSubItems = false;
            this.ShowItemToolTips = false;
            this.UseAlternatingBackColors = false;
            this.UseCompatibleStateImageBehavior = false;
            this.UseHotItem = true;
            this.UseSubItemCheckBoxes = false;
            this.View = System.Windows.Forms.View.Details;
            this.VirtualMode = true;
            this.CellEditActivation = ObjectListView.CellEditActivateMode.SingleClick;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridLines = true;

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

            this.virtualDataSource = new CategoryVirtualListDataSource(this);
            this.VirtualListDataSource = this.virtualDataSource;
        }


        private void AddColumns()
        {
            CultureCollection cultures =
                DomainModel.Cultures.GetAll();


            // A useless uneditable column
            OLVColumn column = new OLVColumn("", "");
            column.Width = 0;
            this.Columns.Add(column);

            foreach (Culture culture in cultures)
            {
                column = new OLVColumn();
                column.Text = culture.LanguageName;
                column.Name = culture.LanguageName;
                column.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                column.FillsFreeSpace = true;
                column.AspectGetter = GetTypeValue;
                column.AspectPutter = SetTypeValue;
                column.IsEditable = true;
                column.HeaderFont = new Font("Tahome", 9.25F, FontStyle.Bold);

                this.Columns.Add(column);
            }
        }


        public Object GetTypeValue(Object sender, Object rowObject)
        {
            if (sender is OLVColumn)
            {
                int rowIndex = (int)rowObject;

                string columnName = ((OLVColumn)sender).Name;

                CategorySub sub = this.category.SubCategories[columnName];
                if (sub != null && sub.Types.Count > rowIndex)
                {
                    return sub.Types[rowIndex].Name;
                }
            }
            else
            {
            }

            return string.Empty;
        }


        public void SetTypeValue(Object sender, Object rowObject, Object newValue)
        {
            if (sender is OLVColumn)
            {
                int rowIndex = (int)rowObject;

                string columnName = ((OLVColumn)sender).Name;

                CategorySub sub = this.category.SubCategories[columnName];
                if (sub != null)
                {
                    if (sub.Types.Count > rowIndex)
                    {
                        string name = (string)newValue;
                        if (DomainModel.Types.Update(sub, sub.Types[rowIndex], name))
                        {
                            sub.Types[rowIndex].Name = name;
                        }
                        else
                        {
                            // Do nothing
                        }
                    }
                    else
                    {
                        int typeId = -1;
                        CategorySub neighbour = this.category.GetSubByTypesCount(rowIndex);
                        if (neighbour != null)
                        {
                            typeId = neighbour.Types[rowIndex].Id;
                        }

                        GeneralType type = new GeneralType();
                        type.Name = (string)newValue;
                        type.Id = typeId;

                        if (DomainModel.Types.Insert(this.category, sub, type))
                        {
                            sub.Types.Add(type);
                        }
                    }
                }
            }
            else
            {
            }
        }


        public Entities.CategoryClass DataSource
        {
            get
            {
                return this.category;
            }

            set
            {
                if (value != this.category)
                {
                    this.category = value;
                    this.virtualDataSource.Reload(value);
                }
            }
        }


        internal void DeleteSelected()
        {
            int rowIndex = this.SelectedIndex;

            if (rowIndex < 0)
            {
            }
            else
            {
                foreach (CategorySub sub in this.category.SubCategories)
                {
                    if (sub != null)
                    {
                        if (sub.Types.Count > rowIndex)
                        {
                            if (DomainModel.Types.DeleteById(sub.Types[rowIndex].Id))
                            {
                                this.category.RemoveFromAllTypes(rowIndex);
                                this.virtualDataSource.Reload(this.category);
                                break;
                            }
                        }
                    }
                }
            }
        }


        internal void InsertNewRow()
        {
            this.VirtualListSize++;
        }
    }
}
