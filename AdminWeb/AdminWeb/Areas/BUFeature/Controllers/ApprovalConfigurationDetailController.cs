using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace AdminWeb.Areas.BU.Controllers
{

    public class ApprovalConfigurationDetailController : BaseBUController
    {
        private readonly IApiService _apiService;

        public ApprovalConfigurationDetailController(IApiService apiService)
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
        public object GetApprovalConfigurationDetailList(long id, DataSourceLoadOptions loadOptions)
        {
            var _response = approvalConfigurationDetailList.Where(e => e.ApprovalConfigurationId == id);

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetApprovalTypeList(DataSourceLoadOptions loadOptions)
        {
            var _response = approvalTypeList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ApprovalConfigurationDetailResponseModel> approvalConfigurationDetailList = new List<ApprovalConfigurationDetailResponseModel>()
        {
            new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 21,
    ApprovalConfigurationId = 21,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 2,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 22,
    ApprovalConfigurationId = 22,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 23,
    ApprovalConfigurationId = 22,
    Position = "SDM",
    ProcessStep = 3,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 2,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 24,
    ApprovalConfigurationId = 22,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 25,
    ApprovalConfigurationId = 22,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 26,
    ApprovalConfigurationId =23,
    Position = "SDM",
    ProcessStep = 3,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 27,
    ApprovalConfigurationId = 23,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 28,
    ApprovalConfigurationId = 23,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 29,
    ApprovalConfigurationId = 23,
    Position = "SDM",
    ProcessStep = 3,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 30,
    ApprovalConfigurationId = 24,
    Position = "RSD",
    ProcessStep = 4,
    Description = "GĐ KD vùng phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 31,
    ApprovalConfigurationId = 24,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 32,
    ApprovalConfigurationId = 24,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 33,
    ApprovalConfigurationId = 24,
    Position = "SDM",
    ProcessStep = 3,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 34,
    ApprovalConfigurationId = 25,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 35,
    ApprovalConfigurationId = 25,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 36,
    ApprovalConfigurationId = 25,
    Position = "SDM",
    ProcessStep = 3,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 37,
    ApprovalConfigurationId = 26,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 38,
    ApprovalConfigurationId = 26,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 39,
    ApprovalConfigurationId = 26,
    Position = "SDM",
    ProcessStep = 3,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 40,
    ApprovalConfigurationId = 26,
    Position = "RSD",
    ProcessStep = 4,
    Description = "GĐ KD vùng phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 41,
    ApprovalConfigurationId = 27,
    Position = "DM",
    ProcessStep = 1,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 42,
    ApprovalConfigurationId = 27,
    Position = "SDM",
    ProcessStep = 3,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 43,
    ApprovalConfigurationId = 27,
    Position = "RSD",
    ProcessStep = 4,
    Description = "GĐ KD vùng phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 44,
    ApprovalConfigurationId = 28,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 45,
    ApprovalConfigurationId = 28,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 46,
    ApprovalConfigurationId = 28,
    Position = "GAD",
    ProcessStep = 3,
    Description = "GĐ Tổng đại lý phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 47,
    ApprovalConfigurationId = 28,
    Position = "SDM",
    ProcessStep = 4,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 48,
    ApprovalConfigurationId = 29,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 49,
    ApprovalConfigurationId = 29,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 50,
    ApprovalConfigurationId = 29,
    Position = "GAD",
    ProcessStep = 3,
    Description = "GĐ Tổng đại lý phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 41,
    ApprovalConfigurationId = 27,
    Position = "DM",
    ProcessStep = 1,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 42,
    ApprovalConfigurationId = 27,
    Position = "SDM",
    ProcessStep = 3,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 43,
    ApprovalConfigurationId = 27,
    Position = "RSD",
    ProcessStep = 4,
    Description = "GĐ KD vùng phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 44,
    ApprovalConfigurationId = 28,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 45,
    ApprovalConfigurationId = 28,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 46,
    ApprovalConfigurationId = 28,
    Position = "GAD",
    ProcessStep = 3,
    Description = "GĐ Tổng đại lý phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 47,
    ApprovalConfigurationId = 28,
    Position = "SDM",
    ProcessStep = 4,
    Description = "GĐ KDKV phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 48,
    ApprovalConfigurationId = 29,
    Position = "UM",
    ProcessStep = 1,
    Description = "Ban KD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 49,
    ApprovalConfigurationId = 29,
    Position = "DM",
    ProcessStep = 2,
    Description = "KVKD phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
},
new ApprovalConfigurationDetailResponseModel {
    ApprovalConfigurationDetailId = 50,
    ApprovalConfigurationId = 29,
    Position = "GAD",
    ProcessStep = 3,
    Description = "GĐ Tổng đại lý phê duyệt",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = null,
    Type = 1
}
        };

        public class ApprovalTypeModel
        {
            public long ApprovalTypeId { get; set; }
            public string? ApprovalTypeName { get; set; }
        }
        public static List<ApprovalTypeModel> approvalTypeList = new List<ApprovalTypeModel>()
        {
            new ApprovalTypeModel
            {
                ApprovalTypeId = 1,
                ApprovalTypeName = "Cũ và mới được phê duyệt"
            },
            new ApprovalTypeModel
            {
                ApprovalTypeId = 2,
                ApprovalTypeName = "Cũ phê duyệt"
            },
            new ApprovalTypeModel
            {
                ApprovalTypeId = 3,
                ApprovalTypeName = "Mới  phê duyệt"
            },

        };

    }
}
