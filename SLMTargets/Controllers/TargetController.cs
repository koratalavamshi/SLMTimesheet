using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using SLMTargets.Models;
using CommonModels;
using SLMTargets.DAL;



namespace SLMTargets.Controllers
{
    public class TargetController : Controller
    {
        public ActionResult TimeSheet(int ManagerId)
        {
            //    try
            //    {
            //        TimeSheetViewModel objTSVM = new TimeSheetViewModel();
            //        List<AgentsViewModel> _lstAgents=ConvertToModel.ConvertToTimeSheetVM.GetAllAgents(ManagerId);
            //        objTSVM.Agents = _lstAgents;

            //        List<CampaignViewModel> _lstCampaign = ConvertToModel.ConvertToTimeSheetVM.GetAllCampaigns(ManagerId);
            //        objTSVM.Campaigns = _lstCampaign;
            //        objTSVM.CampaignsList = _lstCampaign.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name }).ToList();

            //        List<Activity> _lstActivities = ConvertToModel.ConvertToTimeSheetVM.GetAllActivities();
            //        objTSVM.Activities = _lstActivities;
            //        return View(objTSVM);
            //    }
            //    catch (Exception ex) { return null; }
            return View();
        }

        public JsonResult GetList(int ManagerId)
        {
            try
            {
                List<AgentsViewModel> _lstAgents = new List<AgentsViewModel>();
                _lstAgents = ConvertToModel.ConvertToTimeSheetVM.GetAllAgents(ManagerId);
                List<CampaignViewModel> _lstCampaigns = new List<CampaignViewModel>();
                _lstCampaigns = ConvertToModel.ConvertToTimeSheetVM.GetAllCampaigns(ManagerId);
                List<Activity> _lstActivities = new List<Activity>();
                _lstActivities = ConvertToModel.ConvertToTimeSheetVM.GetAllActivities();
                return Json(new { _lstAgents = _lstAgents, _lstCampaigns = _lstCampaigns ,_lstActivities=_lstActivities}, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex) { return null; }

        }
        public JsonResult GetCampaigns(int ManagerId)
        {
            try
            {
                List<CampaignViewModel> _lstCampaigns = new List<CampaignViewModel>();
                _lstCampaigns = ConvertToModel.ConvertToTimeSheetVM.GetAllCampaigns(ManagerId);
                return Json(new { _lstCampaigns = _lstCampaigns },JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex) { return null; }
        }

     }
}
