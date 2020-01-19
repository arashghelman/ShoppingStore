using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.Helper.Product
{
    public static class ProductSPHelper
    {
        public const string usp_SelectProduct = "exec dbo.usp_SelectProduct";
        public const string usp_InsertProduct = "dbo.usp_InsertProduct @productInsertList";
        public const string usp_UpdateProduct = "dbo.usp_UpdateProduct @productUpdateList";
        public const string usp_DeleteProduct = "dbo.usp_DeleteProduct @productDeleteList";

        #region [- SetInsertParameters(List<ProductSaveHelper> productSaveHelperList) -]
        public static object[] SetInsertParameters(List<ProductSaveHelper> productSaveHelperList)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@productInsertList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_ProductInsertList",
                Value = productSaveHelperList.ToDataTable()
            };

            SqlParameter productCode = new SqlParameter()
            {
                ParameterName = "@productCode",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = productSaveHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { productListParameter };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetUpdateParameters(List<ProductEditHelper> productEditHelperList) -]
        public static object[] SetUpdateParameters(List<ProductEditHelper> productEditHelperList)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@productUpdateList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_ProductUpdateList",
                Value = productEditHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { productListParameter };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetDeleteParameters(List<ProductRemoveHelper> productRemoveHelperList) -]
        public static object[] SetDeleteParameters(List<ProductRemoveHelper> productRemoveHelperList)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@productDeleteList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_ProductDeleteList",
                Value = productRemoveHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { productListParameter };
            #endregion

            return parameters;
        } 
        #endregion
    }
}
