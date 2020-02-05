using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.DomainModels.POCO
{
    public class OrderCrud
    {
        #region [- ctor -]
        public OrderCrud()
        {

        } 
        #endregion

        #region [- List<Helper.Order.OrderMasterSelectHelper> SelectMasterBySP() -]
        public List<Helper.Order.OrderMasterSelectHelper> SelectMasterBySP()
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                List<Helper.Order.OrderMasterSelectHelper> orderMasterSelectHelperList = new List<Helper.Order.OrderMasterSelectHelper>();
                try
                {
                    orderMasterSelectHelperList = context.Database.SqlQuery<Helper.Order.OrderMasterSelectHelper>(Helper.Order.OrderSPHelper.usp_SelectOrderMaster).ToList();
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
                return orderMasterSelectHelperList;
            }
        }
        #endregion

        #region [- List<Helper.Order.OrderDetailSelectHelper> SelectDetailBySP() -]
        public List<Helper.Order.OrderDetailSelectHelper> SelectDetailBySP()
        {
            using (var context = new Models.DomainModels.DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                List<Helper.Order.OrderDetailSelectHelper> orderDetailSelectHelperList = new List<Helper.Order.OrderDetailSelectHelper>();
                try
                {
                    orderDetailSelectHelperList = context.Database.SqlQuery<Helper.Order.OrderDetailSelectHelper>(Helper.Order.OrderSPHelper.usp_SelectOrderDetail).ToList();
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
                return orderDetailSelectHelperList;
            }
        }
        #endregion

        #region [- SaveBySP(List<Helper.Order.OrderMasterSaveHelper> orderMasterSaveHelperList, List<Helper.Order.OrderDetailSaveHelper> orderDetailSaveHelperList) -]
        public void SaveBySP(List<Helper.Order.OrderMasterSaveHelper> orderMasterSaveHelperList, List<Helper.Order.OrderDetailSaveHelper> orderDetailSaveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Order.OrderSPHelper.usp_InsertOrder, Helper.Order.OrderSPHelper.SetInsertParameters(orderMasterSaveHelperList, orderDetailSaveHelperList));
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

        #region [- EditBySP(List<Helper.Order.OrderMasterEditHelper> orderMasterEditHelperList, List<Helper.Order.OrderDetailEditHelper> orderDetailEditHelperList) -]
        public void EditBySP(List<Helper.Order.OrderMasterEditHelper> orderMasterEditHelperList, List<Helper.Order.OrderDetailEditHelper> orderDetailEditHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Order.OrderSPHelper.usp_UpdateOrder, Helper.Order.OrderSPHelper.SetUpdateParameters(orderMasterEditHelperList, orderDetailEditHelperList));
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

        #region [- RemoveBySP(List<Helper.Order.OrderMasterRemoveHelper> orderMasterRemoveHelperList, List<Helper.Order.OrderDetailRemoveHelper> orderDetailRemoveHelperList) -]
        public void RemoveBySP(List<Helper.Order.OrderMasterRemoveHelper> orderMasterRemoveHelperList, List<Helper.Order.OrderDetailRemoveHelper> orderDetailRemoveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Order.OrderSPHelper.usp_DeleteOrder, Helper.Order.OrderSPHelper.SetDeleteParameters(orderMasterRemoveHelperList, orderDetailRemoveHelperList));
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

        #region [- RemoveProductBySP(List<Helper.Order.OrderProductRemoveHelper> orderProductRemoveHelperList) -]
        public void RemoveProductBySP(List<Helper.Order.OrderProductRemoveHelper> orderProductRemoveHelperList)
        {
            using (var context = new DTO.EF.ShoppingStoreDBFirstEntities1())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.Order.OrderSPHelper.usp_DeleteOrderProducts, Helper.Order.OrderSPHelper.SetProductDeleteParameters(orderProductRemoveHelperList));
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
