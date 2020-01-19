using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.DomainModels.POCO
{
    public class ProductCrud
    {
        #region [- ctor -]
        public ProductCrud()
        {

        }
        #endregion

        #region [- List<Helper.Product.ProductSelectHelper> SelectBySP() -]
        public List<Helper.Product.ProductSelectHelper> SelectBySP()
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities())
            {
                List<Helper.Product.ProductSelectHelper> productSelectHelperList = new List<Helper.Product.ProductSelectHelper>();
                try
                {
                    productSelectHelperList = context.Database.SqlQuery<Helper.Product.ProductSelectHelper>(Helper.Product.ProductSPHelper.usp_SelectProduct).ToList();
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
                return productSelectHelperList;
            }
        } 
        #endregion

        #region [- SaveBySP(List<Helper.Product.ProductSaveHelper> productSaveHelperList) -]
        public void SaveBySP(List<Helper.Product.ProductSaveHelper> productSaveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Product.ProductSPHelper.usp_InsertProduct, Helper.Product.ProductSPHelper.SetInsertParameters(productSaveHelperList));
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
        #endregion

        #region [- EditBySP(List<Helper.Product.ProductEditHelper> productEditHelperList) -]
        public void EditBySP(List<Helper.Product.ProductEditHelper> productEditHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Product.ProductSPHelper.usp_UpdateProduct, Helper.Product.ProductSPHelper.SetUpdateParameters(productEditHelperList));
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
        #endregion

        #region [- RemoveBySP(List<Helper.Product.ProductRemoveHelper> productRemoveHelperList) -]
        public void RemoveBySP(List<Helper.Product.ProductRemoveHelper> productRemoveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Product.ProductSPHelper.usp_DeleteProduct, Helper.Product.ProductSPHelper.SetDeleteParameters(productRemoveHelperList));
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
        #endregion
    }
}
