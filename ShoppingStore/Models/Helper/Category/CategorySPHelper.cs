using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.Helper.Category
{
    public static class CategorySPHelper
    {
        public const string usp_SelectCategory = "exec dbo.usp_SelectCategory";
        public const string usp_InsertCategory = "dbo.usp_InsertCategory @categoryInsertList";
        public const string usp_UpdateCategory = "dbo.usp_UpdateCategory @categoryUpdateList";
        public const string usp_DeleteCategory = "dbo.usp_DeleteCategory @categoryDeleteList";

        public static object[] SetInsertParameters(List<CategorySaveHelper> categorySaveHelperList)
        {
            SqlParameter categoryList = new SqlParameter()
            {
                ParameterName = "@categoryInsertList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_CategoryInsertList",
                Value = categorySaveHelperList.ToDataTable()
            };

            object[] parameters = { categoryList };

            return parameters;
        }

        public static object[] SetUpdateParameters(List<CategoryEditHelper> categoryEditHelperList)
        {
            SqlParameter categoryList = new SqlParameter()
            {
                ParameterName = "@categoryUpdateList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_CategoryUpdateList",
                Value = categoryEditHelperList.ToDataTable()
            };

            object[] parameters = { categoryList };

            return parameters;
        }

        public static object[] SetDeleteParameters(List<CategoryRemoveHelper> categoryRemoveHelperList)
        {
            SqlParameter categoryList = new SqlParameter()
            {
                ParameterName = "@categoryDeleteList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_CategoryDeleteList",
                Value = categoryRemoveHelperList.ToDataTable()
            };

            object[] parameters = { categoryList };

            return parameters;
        }
    }
}
