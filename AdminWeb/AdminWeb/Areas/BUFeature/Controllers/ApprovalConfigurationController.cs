using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.BU.Controllers
{
    public class ApprovalConfigurationController : BaseBUController
    {
        private readonly IApiService _apiService;

        public ApprovalConfigurationController(IApiService apiService)
        {
            _apiService = apiService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        public object GetApprovalConfigurationListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = approvalConfigurationList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ApprovalConfigurationResponseModel> approvalConfigurationList = new List<ApprovalConfigurationResponseModel>()
        {
            new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 21,
    TypeCode = "M1",
    PositionCode = "SA",
    Description = "SA Chuyển ban KD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 22,
    TypeCode = "M2",
    PositionCode = "SA",
    Description = "SA Chuyển KVKD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 23,
    TypeCode = "M1",
    PositionCode = "FC",
    Description = "FC Chuyển ban KD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 24,
    TypeCode = "M1",
    PositionCode = "RM",
    Description = "RM Chuyển ban KD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 25,
    TypeCode = "M2",
    PositionCode = "FC",
    Description = "FC Chuyển KVKD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 26,
    TypeCode = "M2",
    PositionCode = "RM",
    Description = "RM Chuyển KVKD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 27,
    TypeCode = "M2",
    PositionCode = "UM",
    Description = "UM, SrUM Chuyển KVKD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 28,
    TypeCode = "M3",
    PositionCode = "SA",
    Description = "SA Chuyển văn phòng KD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 29,
    TypeCode = "M3",
    PositionCode = "FC",
    Description = "FC Chuyển văn phòng KD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 30,
    TypeCode = "M3",
    PositionCode = "RM",
    Description = "RM Chuyển văn phòng KD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 31,
    TypeCode = "M3",
    PositionCode = "UM",
    Description = "UM, SrUM Chuyển văn phòng KD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ApprovalConfigurationResponseModel {
    ApprovalConfigurationId = 32,
    TypeCode = "M3",
    PositionCode = "DM",
    Description = "DM, SrDM Chuyển văn phòng KD",
    ApplyDate = DateTime.Now,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
}

        };
    }
}
