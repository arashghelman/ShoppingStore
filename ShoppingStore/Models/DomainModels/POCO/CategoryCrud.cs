using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.DomainModels.POCO
{
    public class CategoryCrud
    {
        #region [- ctor -]
        public CategoryCrud()
        {

        }
        #endregion

        #region [- List<Helper.Category.CategorySelectHelper> SelectBySP() -]
        public List<Helper.Category.CategorySelectHelper> SelectBySP()
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities())
            {
                List<Helper.Category.CategorySelectHelper> categorySelectHelperList = new List<Helper.Category.CategorySelectHelper>();
                try
                {
                    categorySelectHelperList = context.Database.SqlQuery<Helper.Category.CategorySelectHelper>(Helper.Category.CategorySPHelper.usp_SelectCategory).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return categorySelectHelperList;
            }
        } 
        #endregion

        public void SaveBySP(List<Helper.Category.CategorySaveHelper> categorySaveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Category.CategorySPHelper.usp_InsertCategory, Helper.Category.CategorySPHelper.SetInsertParameters(categorySaveHelperList));
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context!=null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        public void EditBySP(List<Helper.Category.CategoryEditHelper> categoryEditHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Category.CategorySPHelper.usp_UpdateCategory, Helper.Category.CategorySPHelper.SetUpdateParameters(categoryEditHelperList));
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        public void RemoveBySP(List<Helper.Category.CategoryRemoveHelper> categoryRemoveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Category.CategorySPHelper.usp_DeleteCategory, Helper.Category.CategorySPHelper.SetDeleteParameters(categoryRemoveHelperList));
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
    }
}
