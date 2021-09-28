using Newtonsoft.Json;
using System;


namespace TaskDataCRMwebApi.Models
{
    
    public class TaskRespModel
    {
        [JsonProperty("new_name")]
        public string Name { get; set; }

        [JsonProperty("new_completed")]
        public bool? Completed { get; set; }

        [JsonProperty("new_enddate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("new_hoursspend")]
        public int? HoursSpend { get; set; }

        [JsonProperty("new_number")]
        public string Number { get; set; }

        [JsonProperty("new_personinit")]
        public string PersonInit { get; set; }

        [JsonProperty("new_personresp")]
        public string PersonResp { get; set; }

        [JsonProperty("new_taskid")]
        public string TaskId { get; set; }  

        [JsonProperty("new_type")]
        public string TypeTask { get; set; }
    }

}