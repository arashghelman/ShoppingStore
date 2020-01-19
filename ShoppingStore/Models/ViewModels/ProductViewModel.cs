using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.ViewModels
{
    public class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {
            Ref_ProductCrud = new DomainModels.POCO.ProductCrud();
        }
        #endregion

        #region [- props -]
        public DomainModels.POCO.ProductCrud Ref_ProductCrud { get; set; }
        #endregion

        #region [- Refresh() -]
        public dynamic Refresh()
        {
            return Ref_ProductCrud.SelectBySP();
        } 
        #endregion

        #region [- Save(List<Models.Helper.Product.ProductSaveHelper> productSaveHelperList) -]
        public void Save(List<Models.Helper.Product.ProductSaveHelper> productSaveHelperList)
        {
            Ref_ProductCrud.SaveBySP(productSaveHelperList);
        }
        #endregion

        #region [- Edit(List<Models.Helper.Product.ProductEditHelper> productEditHelperList) -]
        public void Edit(List<Models.Helper.Product.ProductEditHelper> productEditHelperList)
        {
            Ref_ProductCrud.EditBySP(productEditHelperList);
        }
        #endregion

        #region [- Remove(List<Helper.Product.ProductRemoveHelper> productRemoveHelperList) -]
        public void Remove(List<Helper.Product.ProductRemoveHelper> productRemoveHelperList)
        {
            Ref_ProductCrud.RemoveBySP(productRemoveHelperList);
        } 
        #endregion
    }
}
