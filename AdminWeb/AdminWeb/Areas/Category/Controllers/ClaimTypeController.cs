using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class ClaimTypeController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public ClaimTypeController(IApiService apiService)
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
        public object GetClaimTypeList(DataSourceLoadOptions loadOptions)
        {
            var _response = claimTypeList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ClaimTypeResponseModel> claimTypeList = new List<ClaimTypeResponseModel>()
        {
            new ClaimTypeResponseModel()
            {
                ClaimTypeId = 1,
                Description="Quyền lợi Hỗ trợ viện phí và phẫu thuật",
                ClaimTypeCode="HOS",
                IsActive=false,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new ClaimTypeResponseModel()
            {
                ClaimTypeId = 2,
                Description="Medical",
                ClaimTypeCode="MED",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new ClaimTypeResponseModel()
            {
                ClaimTypeId = 3,
                Description="Great Lady",
                ClaimTypeCode="GRL",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new ClaimTypeResponseModel()
            {
                ClaimTypeId = 4,
                Description="Bồi hoàn chi phí y tế thực tế",
                ClaimTypeCode="RIM",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            }
        };
    }
}
