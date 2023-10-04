using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class DocumentTypeController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public DocumentTypeController(IApiService apiService)
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
        

        public static List<DocumentTypeResponseModel> model = new List<DocumentTypeResponseModel>()
        {
            new DocumentTypeResponseModel {
                        DocumentTypeId = 1,
                        DocumentTypeName = "Giấy ra viện/ Giấy chuyển viện",
                        IsExternal = true,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new DocumentTypeResponseModel {
                        DocumentTypeId = 2,
                        DocumentTypeName = "Các chứng từ khác",
                        IsExternal = true,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new DocumentTypeResponseModel {
                        DocumentTypeId = 3,
                        DocumentTypeName = "Thay đổi thông tin thanh toán",
                        IsExternal = true,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
