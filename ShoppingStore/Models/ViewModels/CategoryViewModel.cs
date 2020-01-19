using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.ViewModels
{
    public class CategoryViewModel
    {
        #region [- ctor -]
        public CategoryViewModel()
        {
            Ref_CategoryCrud = new DomainModels.POCO.CategoryCrud();
        }
        #endregion

        #region [- props -]
        public DomainModels.POCO.CategoryCrud Ref_CategoryCrud { get; set; }
        #endregion

        #region [- Refresh() -]
        public dynamic Refresh()
        {
            return Ref_CategoryCrud.SelectBySP();
        } 
        #endregion

        public void Save(List<Helper.Category.CategorySaveHelper> categorySaveHelperList)
        {
            Ref_CategoryCrud.SaveBySP(categorySaveHelperList);
        }

        public void Edit(List<Helper.Category.CategoryEditHelper> categoryEditHelperList)
        {
            Ref_CategoryCrud.EditBySP(categoryEditHelperList);
        }
        public void Remove(List<Helper.Category.CategoryRemoveHelper> categoryRemoveHelperList)
        {
            Ref_CategoryCrud.RemoveBySP(categoryRemoveHelperList);
        }
    }
}
