using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SLMTargets.Models
{
    public class TimeSheetViewModel
    {
        public List<CampaignViewModel> Campaigns { get; set; }
        public List<AgentsViewModel> Agents { get; set; }
        public List<SelectListItem> CampaignsList { get; set; }
        public List<Activity> Activities { get; set; }
    }
    public class CampaignViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Operator { get; set; }
        public string Description { get; set; }
        public int TargetHours { get; set; }
        public DateTime CreatedOn { get; set; }
    }
    public class AgentsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}