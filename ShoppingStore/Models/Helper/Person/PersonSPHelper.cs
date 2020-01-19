using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.Helper.Person
{
    public static class PersonSPHelper
    {
        public const string usp_SelectPerson = "exec dbo.usp_SelectPerson";
        public const string usp_InsertPerson = "dbo.usp_InsertPerson @personInsertList";
        public const string usp_DeletePerson = "dbo.usp_DeletePerson @personDeleteList";
        public const string usp_UpdatePerson = "dbo.usp_UpdatePerson @personUpdateList";


        #region [- SetInsertParameters(List<PersonSaveHelper> personSaveHelperList) -]
        public static object[] SetInsertParameters(List<PersonSaveHelper> personSaveHelperList)
        {
            #region [- SqlParameter -]
            SqlParameter personListParameter = new SqlParameter()
            {
                ParameterName = "@personInsertList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_PersonInsertList",
                Value = personSaveHelperList.ToDataTable()
            };

            SqlParameter personCode = new SqlParameter()
            {
                ParameterName = "@personCode",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = personSaveHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { personListParameter };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetDeleteParameters(List<PersonRemoveHelper> personRemoveHelperList) -]
        public static object[] SetDeleteParameters(List<PersonRemoveHelper> personRemoveHelperList)
        {
            #region [- SqlParameter -]
            SqlParameter personListParameter = new SqlParameter()
            {
                ParameterName = "@personDeleteList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_PersonDeleteList",
                Value = personRemoveHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { personListParameter };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetUpdateParameters(List<PersonEditHelper> personEditHelperList) -]
        public static object[] SetUpdateParameters(List<PersonEditHelper> personEditHelperList)
        {
            #region [- SqlParameter -]
            SqlParameter personListParameter = new SqlParameter()
            {
                ParameterName = "@personUpdateList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_PersonUpdateList",
                Value = personEditHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { personListParameter };
            #endregion

            return parameters;
        } 
        #endregion
    }
}
