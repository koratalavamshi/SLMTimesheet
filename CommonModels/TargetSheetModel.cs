using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
    public class TargetSheetModel
    {
        public class TimeSheetModel
        {
            public List<CampaignModel> Campaigns { get; set; }
            public List<AgentsModel> Agents { get; set; }
        }
        public class CampaignModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Operator { get; set; }
            public string Description { get; set; }
            public int TargetHours { get; set; }
            public DateTime CreatedOn { get; set; }
        }
        public class AgentsModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Activities
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
