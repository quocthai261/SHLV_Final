using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class RelationController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public RelationController(IApiService apiService)
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
        public object GetRelationList(DataSourceLoadOptions loadOptions)
        {
            var _response = relationList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<RelationResponseModel> relationList = new List<RelationResponseModel>()
        {
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "03",
                        RelationName = "Cha Mẹ ruột",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "04",
                        RelationName = "Con ruột",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "05",
                        RelationName = "Anh Chị Em ruột",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "06",
                        RelationName = "Cháu nội/Cháu ngoại ruột",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "07",
                        RelationName = "Người giám hộ",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "08",
                        RelationName = "Nhân viên/Người lao dộng",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "09",
                        RelationName = "Mỗi quan hệ khác",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "01",
                        RelationName = "Bản thân",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new RelationResponseModel {
                        RelationId = 1,
                        RelationCode = "02",
                        RelationName = "Vợ chồng",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    }
        };

        #endregion
    }
}
