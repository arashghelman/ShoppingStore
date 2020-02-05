using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.Helper.Order
{
    public static class OrderSPHelper
    {
        public const string usp_InsertOrder = "dbo.usp_InsertOrder @insertOrderMasterList, @insertOrderDetailList";
        public const string usp_UpdateOrder = "dbo.usp_UpdateOrder @updateOrderMasterList, @updateOrderDetailList";
        public const string usp_DeleteOrder = "dbo.usp_DeleteOrder @orderMasterDeleteList, @orderDetailDeleteList";
        public const string usp_DeleteOrderProducts = "dbo.usp_DeleteOrderProducts @deleteOrderProductList";
        public const string usp_SelectOrderMaster = "exec dbo.usp_SelectOrderMaster";
        public const string usp_SelectOrderDetail = "exec dbo.usp_SelectOrderDetail";

        #region [- SetInsertParameters(List<OrderMasterSaveHelper> orderMasterSaveHelperList, List<OrderDetailSaveHelper> orderDetailSaveHelperList) -]
        public static object[] SetInsertParameters(List<OrderMasterSaveHelper> orderMasterSaveHelperList, List<OrderDetailSaveHelper> orderDetailSaveHelperList)
        {
            #region [- SqlParameters -]
            SqlParameter orderMasterList = new SqlParameter()
            {
                ParameterName = "@insertOrderMasterList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_InsertOrderMasterList",
                Value = orderMasterSaveHelperList.ToDataTable()
            };
            SqlParameter orderDetailList = new SqlParameter()
            {
                ParameterName = "@insertOrderDetailList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_InsertOrderDetailList",
                Value = orderDetailSaveHelperList.ToDataTable()
            };
            SqlParameter orderCode = new SqlParameter()
            {
                ParameterName = "@orderCode",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = orderMasterSaveHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { orderMasterList, orderDetailList };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetUpdateParameters(List<OrderMasterEditHelper> orderMasterEditHelperList, List<OrderDetailEditHelper> orderDetailEditHelperList) -]
        public static object[] SetUpdateParameters(List<OrderMasterEditHelper> orderMasterEditHelperList, List<OrderDetailEditHelper> orderDetailEditHelperList)
        {
            #region [- SqlParameters -]
            SqlParameter orderMasterList = new SqlParameter()
            {
                ParameterName = "@updateOrderMasterList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_UpdateOrderMasterList",
                Value = orderMasterEditHelperList.ToDataTable()
            };
            SqlParameter orderDetailList = new SqlParameter()
            {
                ParameterName = "@updateOrderDetailList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_UpdateOrderDetailList",
                Value = orderDetailEditHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { orderMasterList, orderDetailList };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetDeleteParameters(List<OrderMasterRemoveHelper> orderMasterRemoveHelperList, List<OrderDetailRemoveHelper> orderDetailRemoveHelperList) -]
        public static object[] SetDeleteParameters(List<OrderMasterRemoveHelper> orderMasterRemoveHelperList, List<OrderDetailRemoveHelper> orderDetailRemoveHelperList)
        {
            #region [- SqlParameters -]
            SqlParameter orderMasterList = new SqlParameter()
            {
                ParameterName = "@orderMasterDeleteList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_DeleteOrderMasterList",
                Value = orderMasterRemoveHelperList.ToDataTable()
            };
            SqlParameter orderDetailList = new SqlParameter()
            {
                ParameterName = "@orderDetailDeleteList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_DeleteOrderDetailList",
                Value = orderDetailRemoveHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { orderMasterList, orderDetailList };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetProductDeleteParameters(List<OrderProductRemoveHelper> orderProductRemoveHelperList) -]
        public static object[] SetProductDeleteParameters(List<OrderProductRemoveHelper> orderProductRemoveHelperList)
        {
            #region [- SqlParameter -]
            SqlParameter orderList = new SqlParameter()
            {
                ParameterName = "@deleteOrderProductList",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "udt_DeleteOrderProductList",
                Value = orderProductRemoveHelperList.ToDataTable()
            };
            #endregion

            #region [- parameters -]
            object[] parameters = { orderList };
            #endregion

            return parameters;
        } 
        #endregion
    }
}
