namespace AdminWeb.Dtos.ApiResponse
{
    public class AgentInfoChangeResponseModel
    {
        public long AgentInforChangeId { get; set; }
        public string RequestCode { get; set; }
        public string AgentCode { get; set; }
        public string AgentName { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string IdCardNumber { get; set; }
        public string Title { get; set; }
        public int RequestType { get; set; }
        public string RequestTypeName { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string Gender { get; set; }
        public string ReasonReject { get; set; }
        public string OldAgentName { get; set; }
        public string OldGender { get; set; }
        public DateTime OldDOB { get; set; }
        public string OldIdCardNumber { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }

    }
}
