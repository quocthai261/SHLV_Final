using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class FinancialProductTypeController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public FinancialProductTypeController(IApiService apiService)
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
        public object GetFinancialProductTypeList(DataSourceLoadOptions loadOptions)
        {
            var _response = financialProductTypeList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<FinancialProductTypeResponseModel> financialProductTypeList = new List<FinancialProductTypeResponseModel>()
        {
            new FinancialProductTypeResponseModel
            {
                FinProductTypeId = 1,
                ProductTypeCode ="DDTM",
                Image = "FinalcialDemandAnalysis/ProductType/DTTM.png",
                ProductTypeName = "Đầu tư thông minh",
                Description = "Đầu tư tài chính",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new FinancialProductTypeResponseModel
            {
                FinProductTypeId = 2,
                ProductTypeCode ="HTTV",
                Image = "FinalcialDemandAnalysis/ProductType/HTTV.png",
                ProductTypeName = "Hưu trí tuổi vàng",
                Description = "Bảo vệ thu nhập cho tuổi vàng",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new FinancialProductTypeResponseModel
            {
                FinProductTypeId = 3,
                ProductTypeCode ="HVCC",
                Image = "FinalcialDemandAnalysis/ProductType/HVCC.png",
                ProductTypeName = "Học vấn cho con",
                Description = "Quý Giáo dục cho con yêu",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
