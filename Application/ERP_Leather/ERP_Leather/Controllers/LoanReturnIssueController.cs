﻿using ERP.DatabaseAccessLayer.AppSetupGateway;
using ERP.DatabaseAccessLayer.OperationGateway;
using ERP.EntitiesModel.AppSetupModel;
using ERP.EntitiesModel.BaseModel;
using ERP.EntitiesModel.OperationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_Leather.ActionFilters;

namespace ERP_Leather.Controllers
{
    public class LoanReturnIssueController : Controller
    {
        DalSysStore objDalSysStore = new DalSysStore();
        DalSysSupplier objDalSysSupplier = new DalSysSupplier();
        DalSysSize objDalSysSize = new DalSysSize();
        DalSysUnit objDalSysUnit = new DalSysUnit();
        private DalLoanReturnIssue Dalobject;
        private ValidationMsg _vmMsg;

        public LoanReturnIssueController()
        {
            _vmMsg = new ValidationMsg();
            Dalobject = new DalLoanReturnIssue();
        }

        [CheckUserAccess("LoanReturnIssue/LoanReturnIssue")]
        public ActionResult LoanReturnIssue()
        {
            ViewBag.formTiltle = "Loan Return Issue";
            ViewBag.ddlStoreFromList = objDalSysStore.GetAllActiveChemicalStore();
            ViewBag.ddlStoreToList = objDalSysStore.GetAllActiveLoanStore();
            return View();
        }

        [HttpPost]
        public ActionResult LoanReturnIssue(INVStoreTrans model)
        {
            _vmMsg = model.TransactionID == 0 ? Dalobject.Save(model, Convert.ToInt32(Session["UserID"]), "LoanReturnIssue/LoanReturnIssue") : Dalobject.Update(model, Convert.ToInt32(Session["UserID"]));
            return Json(new { TransactionID = Dalobject.GetReceiveID(), TransactionNo = Dalobject.GetReceiveNo(), msg = _vmMsg });
        }

        [HttpPost]
        public ActionResult ConfirmChemicalPurchase(INVStoreTrans model)
        {
            _vmMsg = Dalobject.ConfirmChemicalPurchase(model, Convert.ToInt32(Session["UserID"]));
            return Json(new { msg = _vmMsg });
        }

        [HttpPost]
        public ActionResult CheckedChemicalPurchase(string receiveId, string checkComment)
        {
            _vmMsg = Dalobject.CheckedChemicalPurchase(receiveId, checkComment, Convert.ToInt32(Session["UserID"]));
            return Json(new { msg = _vmMsg });
        }

        public ActionResult GetChemicalSupplierList()
        {
            var chemicalSupplier = objDalSysSupplier.GetAllChemicalSupplier();
            return Json(chemicalSupplier, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetLoanRequestInfoList(string RequestID)
        {
            INVStoreTrans model = new INVStoreTrans();
            model.InvStoreTransRequestList = Dalobject.GetLoanRequestInfoList(RequestID);
            if (model.InvStoreTransRequestList.Count() > 0)
                model.InvStoreTransItemList = Dalobject.GetLoanRequestItemList(model.InvStoreTransRequestList[0].RequestID.ToString());
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetLoanRequestItemList(string RequestID)
        {
            var packingInfoList = Dalobject.GetLoanRequestItemList(RequestID);
            return Json(packingInfoList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetLoanRequestAfterSaveList(string TransactionID)
        {
            var packItemList = Dalobject.GetLoanRequestAfterSaveList(TransactionID);
            return Json(packItemList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetLoanRequestItemAfterSaveList(string TransactionID)
        {
            var packItemList = Dalobject.GetRecvItemListList(TransactionID);
            return Json(packItemList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetChallanAfterSaveList(string TransactionID)
        {
            var challanList = Dalobject.GetChallanList(TransactionID);
            return Json(challanList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllChemicalSupplierList(string supplier)
        {
            SysSupplier sysSupplier = new SysSupplier();

            var supplierList = objDalSysSupplier.GetAllChemicalSupplierList(supplier);
            if (supplierList.Count > 1)
            {
                sysSupplier.Count = 0;
            }
            else
            {
                sysSupplier.Count = 1;
            }
            sysSupplier.ChemicalSupplierList = supplierList;
            return Json(sysSupplier, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetChemicalPurchaseReceiveList()
        {
            var chemicalPurchaseReceiveList = Dalobject.GetChemicalPurchaseReceiveList();
            return Json(chemicalPurchaseReceiveList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllGridList(string TransactionID)
        {
            INVStoreTrans model = new INVStoreTrans();
            if (TransactionID != null)
            {
                model.InvStoreTransRequestList = Dalobject.GetPurcRecvPlList(TransactionID);
                model.InvStoreTransChallanList = Dalobject.GetChallanList(TransactionID);
                model.InvStoreTransItemList = Dalobject.GetRecvItemListList(TransactionID);
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllActiveChemicalPackSize()
        {
            var chemicalItemSizeList = objDalSysSize.GetAllActiveChemicalPackSize();
            return Json(chemicalItemSizeList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllActiveChemicalPackUnit()
        {
            var chemicalUnitList = objDalSysUnit.GetAllActiveChemicalPack();
            return Json(chemicalUnitList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllActiveChemicalUnit()
        {
            var chemicalUnitList = objDalSysUnit.GetAllActiveLeatherChemical();
            return Json(chemicalUnitList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetChemicalItemList()
        {
            var chemicalList = Dalobject.GetChemicalItemList();
            return Json(chemicalList, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DeletedReceive(string TransactionID)
        {
            int receiveID = Convert.ToInt16(TransactionID);
            _vmMsg = Dalobject.DeletedReceive(receiveID);
            return Json(new { msg = _vmMsg });
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DeletedReceiveChallan(string ReceiveChallanID)
        {
            int receiveChallanID = Convert.ToInt16(ReceiveChallanID);
            _vmMsg = Dalobject.DeletedReceiveChallan(receiveChallanID);
            return Json(new { msg = _vmMsg });
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DeletedReceiveItem(string ReceiveItemID)
        {
            int receiveItemID = Convert.ToInt16(ReceiveItemID);
            _vmMsg = Dalobject.DeletedReceiveItem(receiveItemID);
            return Json(new { msg = _vmMsg });
        }

        public ActionResult GetLoanReturnIssueRequestList()
        {
            var loanReceiveRequestList = Dalobject.GetLoanReturnIssueRequestList();
            return Json(loanReceiveRequestList, JsonRequestBehavior.AllowGet);
        }


        //public ActionResult GetLoanRequestInfoList(string RequestID)
        //{
        //    INVStoreTrans model = new INVStoreTrans();
        //    model.InvStoreTransRequestList = Dalobject.GetLoanRequestInfoList(RequestID);
        //    if (model.InvStoreTransRequestList.Count() > 0)
        //        model.InvStoreTransItemList = Dalobject.GetLoanRequestItemList(model.InvStoreTransRequestList[0].RequestID.ToString());
        //    return Json(model, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult GetSupplierSoruceList()
        {
            var SupplierSoruceList = Dalobject.GetSupplierSoruceList();
            return Json(SupplierSoruceList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetStoreSoruceList()
        {
            var StoreSoruceList = Dalobject.GetStoreSoruceList();
            return Json(StoreSoruceList, JsonRequestBehavior.AllowGet);
        }
    }
}