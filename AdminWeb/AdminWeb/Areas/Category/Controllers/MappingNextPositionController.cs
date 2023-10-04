using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class MappingNextPositionController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public MappingNextPositionController(IApiService apiService)
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


        public static List<MappingNextPositionResponseModel> model = new List<MappingNextPositionResponseModel>()
        {
            new MappingNextPositionResponseModel {
                        MappingId = 1,
                        CurrentPositionCode = "FC",
                        NextPositionCode = "RM",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new MappingNextPositionResponseModel {
                        MappingId = 2,
                        CurrentPositionCode = "RM",
                        NextPositionCode = "UM",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new MappingNextPositionResponseModel {
                        MappingId = 3,
                        CurrentPositionCode = "UM",
                        NextPositionCode = "SrUM",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new MappingNextPositionResponseModel {
                        MappingId = 4,
                        CurrentPositionCode = "UM",
                        NextPositionCode = "DM",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
