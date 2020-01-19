using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.ViewModels
{
    public class OrderViewModel
    {
        #region [- ctor -]
        public OrderViewModel()
        {
            Ref_OrderCrud = new DomainModels.POCO.OrderCrud();
        }
        #endregion

        #region [- props -]
        public DomainModels.POCO.OrderCrud Ref_OrderCrud { get; set; }
        #endregion

        #region [- RefreshMaster() -]
        public dynamic RefreshMaster()
        {
            return Ref_OrderCrud.SelectMasterBySP();
        }
        #endregion

        #region [- RefreshDetail() -]
        public dynamic RefreshDetail()
        {
            return Ref_OrderCrud.SelectDetailBySP();
        }
        #endregion

        #region [- Save(List<Helper.Order.OrderMasterSaveHelper> orderMasterSaveHelperList, List<Helper.Order.OrderDetailSaveHelper> orderDetailSaveHelperList) -]
        public void Save(List<Helper.Order.OrderMasterSaveHelper> orderMasterSaveHelperList, List<Helper.Order.OrderDetailSaveHelper> orderDetailSaveHelperList)
        {
            Ref_OrderCrud.SaveBySP(orderMasterSaveHelperList, orderDetailSaveHelperList);
        }
        #endregion

        #region [- Edit(List<Helper.Order.OrderMasterEditHelper> orderMasterEditHelperList, List<Helper.Order.OrderDetailEditHelper> orderDetailEditHelperList) -]
        public void Edit(List<Helper.Order.OrderMasterEditHelper> orderMasterEditHelperList, List<Helper.Order.OrderDetailEditHelper> orderDetailEditHelperList)
        {
            Ref_OrderCrud.EditBySP(orderMasterEditHelperList, orderDetailEditHelperList);
        }
        #endregion

        #region [- Remove(List<Helper.Order.OrderMasterRemoveHelper> orderMasterRemoveHelperList, List<Helper.Order.OrderDetailRemoveHelper> orderDetailRemoveHelperList) -]
        public void Remove(List<Helper.Order.OrderMasterRemoveHelper> orderMasterRemoveHelperList, List<Helper.Order.OrderDetailRemoveHelper> orderDetailRemoveHelperList)
        {
            Ref_OrderCrud.RemoveBySP(orderMasterRemoveHelperList, orderDetailRemoveHelperList);
        }
        #endregion

        #region [- RemoveProduct(List<Helper.Order.OrderProductRemoveHelper> orderProductRemoveHelperList) -]
        public void RemoveProduct(List<Helper.Order.OrderProductRemoveHelper> orderProductRemoveHelperList)
        {
            Ref_OrderCrud.RemoveProductBySP(orderProductRemoveHelperList);
        } 
        #endregion
    }
}
