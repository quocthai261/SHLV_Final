using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class LiablityStatusController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public LiablityStatusController(IApiService apiService)
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
        public object GetDataTableList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }


        public static List<LiablityStatusResponseModel> model = new List<LiablityStatusResponseModel>()
        {
            new LiablityStatusResponseModel {
                        LiablityStatusId = 1,
                        LiablityStatusName = "Waiting for Validate",
                        LiablityStatusNameVN = "waiting for validate",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new LiablityStatusResponseModel {
                        LiablityStatusId = 2,
                        LiablityStatusName = "Inforce",
                        LiablityStatusNameVN = "Có hiệu lực",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new LiablityStatusResponseModel {
                        LiablityStatusId = 3,
                        LiablityStatusName = "Lapsed",
                        LiablityStatusNameVN = "Mất hiệu lực",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
