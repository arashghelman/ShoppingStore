using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.ViewModels
{
    public class PersonViewModel
    {
        #region [- ctor -]
        public PersonViewModel()
        {
            Ref_PersonCrud = new DomainModels.POCO.PersonCrud();
        }
        #endregion

        #region [- props -]
        public DomainModels.POCO.PersonCrud Ref_PersonCrud { get; set; }
        #endregion

        #region [- Refresh -]
        public dynamic Refresh()
        {
            return Ref_PersonCrud.SelectBySP();
        }
        #endregion

        #region [- Save(List<Helper.Person.PersonSaveHelper> personSaveHelperList) -]
        public void Save(List<Helper.Person.PersonSaveHelper> personSaveHelperList)
        {
            Ref_PersonCrud.SaveBySP(personSaveHelperList);
        }
        #endregion

        #region [- Remove(List<Helper.Person.PersonRemoveHelper> personRemoveHelperList) -]
        public void Remove(List<Helper.Person.PersonRemoveHelper> personRemoveHelperList)
        {
            Ref_PersonCrud.RemoveBySP(personRemoveHelperList);
        }
        #endregion

        #region [- Edit(List<Helper.Person.PersonEditHelper> personEditHelperList) -]
        public void Edit(List<Helper.Person.PersonEditHelper> personEditHelperList)
        {
            Ref_PersonCrud.EditBySP(personEditHelperList);
        } 
        #endregion
    }
}
