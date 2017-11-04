using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommonModels;
using SLMTargets.DAL.Model;



namespace SLMTargets.DAL.DbProviders
{
    public class CampaignProvider
    {
        public static List<TargetSheetModel.CampaignModel> GetAllCampaigns(int ManagerID)
        {
            using (var db = new TargetEntities())
            {
                var res= db.sp_campaignbyManager(ManagerID).ToList();
                List<TargetSheetModel.CampaignModel> _lstCampaign = new List<TargetSheetModel.CampaignModel>();
                foreach (var item in res)
                {
                    TargetSheetModel.CampaignModel objCampModel = new TargetSheetModel.CampaignModel();
                    objCampModel.Id = item.Id;
                    objCampModel.Name = item.Name;
                    objCampModel.Operator = item.Operator;
                    objCampModel.Description = item.Description;
                    objCampModel.TargetHours = (int)item.TargetHours;
                    objCampModel.CreatedOn = (DateTime)item.CreatedOn;
                    _lstCampaign.Add(objCampModel);
                }
                return _lstCampaign;

            }
        }

        public static List<TargetSheetModel.AgentsModel> GetAllAgents(int ManagerID)
        {
            using (var db = new TargetEntities())
            {
                var res= db.sp_AgentsbyManager(ManagerID).ToList();
                List<TargetSheetModel.AgentsModel> _lstAgents = new List<TargetSheetModel.AgentsModel>();
                foreach (var itemi in res)
                {
                    TargetSheetModel.AgentsModel objAgent = new TargetSheetModel.AgentsModel();
                    objAgent.Id = itemi.Id;
                    objAgent.Name = itemi.Name;
                    _lstAgents.Add(objAgent);
                }
                return _lstAgents;
            }
        }

        public static List<TargetSheetModel.Activities> GetAllActivities()
        {
            using (var db = new TargetEntities())
            {
                var res_filter = db.Activities.Where(a => a.IsActive == true);
                var res= res_filter.Select(a => new { a.Id, a.Name }).ToList();
                List<TargetSheetModel.Activities> _lstActivities = new List<TargetSheetModel.Activities>();
                foreach (var item in res)
                {
                    TargetSheetModel.Activities objActivity = new TargetSheetModel.Activities();
                    objActivity.Id = item.Id;
                    objActivity.Name = item.Name;
                    _lstActivities.Add(objActivity);
                }
                return _lstActivities;
            }
        }
    }
}