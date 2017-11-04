using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLMTargets.Models;

namespace SLMTargets.ConvertToModel
{
    public class ConvertToTimeSheetVM
    {
        public static List<AgentsViewModel> GetAllAgents(int ManagerId)
        {
            var agents = DAL.DbProviders.CampaignProvider.GetAllAgents(ManagerId);
            List<AgentsViewModel> _lstAgents = new List<AgentsViewModel>();
            foreach (var item in agents)
            {
                AgentsViewModel objAgent = new AgentsViewModel();
                objAgent.Id = item.Id;
                objAgent.Name = item.Name;
                _lstAgents.Add(objAgent);
            }
            return _lstAgents;
        }
        public static List<CampaignViewModel> GetAllCampaigns(int ManagerId)
        {
            var items = DAL.DbProviders.CampaignProvider.GetAllCampaigns(ManagerId);
            List<CampaignViewModel> _lstCampaign = new List<CampaignViewModel>();
            foreach (var item in items)
            {
                CampaignViewModel objCampModel = new CampaignViewModel();
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
        public static List<Activity> GetAllActivities()
        {
            var activities = DAL.DbProviders.CampaignProvider.GetAllActivities();
            List<Activity> _lstActivities = new List<Activity>();
            foreach (var item in activities)
            {
                Activity objActivity = new Activity();
                objActivity.Id = item.Id;
                objActivity.Name = item.Name;
                _lstActivities.Add(objActivity);
            }
            return _lstActivities;
        }
    }
}