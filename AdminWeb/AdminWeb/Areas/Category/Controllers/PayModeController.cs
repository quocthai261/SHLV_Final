using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class PayModeController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public PayModeController(IApiService apiService)
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
        public object GetPayModeList(DataSourceLoadOptions loadOptions)
        {
            var _response = payModeList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<PayModeResponseModel> payModeList = new List<PayModeResponseModel>()
        {
            new PayModeResponseModel
            {
                PayModeId = 1,
                PayModeType="1",
                PayModeName="Cash",
                PayModeNameVN="Tiền mặt",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new PayModeResponseModel
            {
                PayModeId = 1,
                PayModeType="1",
                PayModeName="Cash",
                PayModeNameVN="Tiền mặt",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new PayModeResponseModel
            {
                PayModeId = 1,
                PayModeType="2",
                PayModeName="Bank Transfer",
                PayModeNameVN="Chuyển khoản",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
