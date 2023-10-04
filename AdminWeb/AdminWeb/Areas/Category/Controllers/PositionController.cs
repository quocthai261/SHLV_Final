using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class PositionController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public PositionController(IApiService apiService)
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

        #region -- Methods --

        [HttpGet]
        public object GetPositionList(DataSourceLoadOptions loadOptions)
        {
            var _response = positionList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<PositionResponseModel> positionList = new List<PositionResponseModel>()
        {
            new PositionResponseModel {
    PositionId = 1,
    PositionCode = "FC",
    PositionName = "Tư vấn viên tài chính",
    IsRegister = true,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = "RM",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 2,
    PositionCode = "UM",
    PositionName = "Quản lý ban KD",
    IsRegister = true,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = "DM",
    NextPositionDescription = null,
    IsActive = false,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 3,
    PositionCode = "DM",
    PositionName = "Quản lý KVKD",
    IsRegister = true,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = "SrDM",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 4,
    PositionCode = "GAD",
    PositionName = "GĐ tổng đại lý",
    IsRegister = false,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = "SDM",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 5,
    PositionCode = "SDM",
    PositionName = "GĐ KVKD",
    IsRegister = false,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = "RSD",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 6,
    PositionCode = "TSD",
    PositionName = "GĐ KD miền",
    IsRegister = false,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = null,
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 7,
    PositionCode = "SrDM",
    PositionName = "Quản lý KVKD Cấp cao",
    IsRegister = true,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = "GAD",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 8,
    PositionCode = "SrUM",
    PositionName = "Quản lý ban KD Cấp cao",
    IsRegister = true,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = "DM",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 9,
    PositionCode = "RSD",
    PositionName = "GĐ KD vùng",
    IsRegister = false,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = "TSD",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 10,
    PositionCode = "HrDM",
    PositionName = "Honor DM",
    IsRegister = true,
    IsApproval = true,
    Description = null,
    Image = null,
    NextPosition = null,
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 11,
    PositionCode = "SA",
    PositionName = "Cộng tác viên",
    IsRegister = false,
    IsApproval = false,
    Description = null,
    Image = null,
    NextPosition = "FC",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new PositionResponseModel {
    PositionId = 12,
    PositionCode = "RM",
    PositionName = "Quản lý vùng KD",
    IsRegister = false,
    IsApproval = false,
    Description = null,
    Image = null,
    NextPosition = "UM",
    NextPositionDescription = null,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = null,
    LastUpdatedDate = null,
    LastUpdatedBy = null
}

        };

        #endregion
    }
}
