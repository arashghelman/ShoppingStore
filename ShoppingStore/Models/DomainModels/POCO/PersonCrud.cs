using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.DomainModels.POCO
{
    public class PersonCrud
    {
        #region [- ctor -]
        public PersonCrud()
        {

        }
        #endregion

        #region [- List<Helper.Person.PersonSelectHelper> SelectBySP() -]
        public List<Helper.Person.PersonSelectHelper> SelectBySP()
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                List<Helper.Person.PersonSelectHelper> personSelectHelperList = new List<Helper.Person.PersonSelectHelper>();
                try
                {
                    personSelectHelperList = context.Database.SqlQuery<Helper.Person.PersonSelectHelper>(Helper.Person.PersonSPHelper.usp_SelectPerson).ToList();
                }
                catch (Exception)
                {

                    throw;
                }

                return personSelectHelperList;
            }
        } 
        #endregion

        #region [- SaveBySP(List<Models.Helper.Person.PersonSaveHelper> personSaveHelperList) -]
        public void SaveBySP(List<Helper.Person.PersonSaveHelper> personSaveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Person.PersonSPHelper.usp_InsertPerson, Helper.Person.PersonSPHelper.SetInsertParameters(personSaveHelperList));
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

        #region [- RemoveBySP(List<Helper.Person.PersonRemoveHelper> personRemoveHelperList) -]
        public void RemoveBySP(List<Helper.Person.PersonRemoveHelper> personRemoveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Person.PersonSPHelper.usp_DeletePerson, Helper.Person.PersonSPHelper.SetDeleteParameters(personRemoveHelperList));
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

        #region [- EditBySP(List<Helper.Person.PersonEditHelper> personEditHelperList) -]
        public void EditBySP(List<Helper.Person.PersonEditHelper> personEditHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Person.PersonSPHelper.usp_UpdatePerson, Helper.Person.PersonSPHelper.SetUpdateParameters(personEditHelperList));
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
