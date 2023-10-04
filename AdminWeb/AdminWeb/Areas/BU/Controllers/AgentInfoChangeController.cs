using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.BU.Controllers
{
    [Area("BUFeature")]
    public class AgentInfoChangeController : BasuBUController
    {
        private readonly IApiService _apiService;

        public AgentInfoChangeController(IApiService apiService)
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

        public IActionResult Detail(long id) 
        {
            var _response = model.First(p => p.AgentInforChangeId == id);
            return View(_response);
        }


        [HttpGet]
        public object GetDataTableList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetStatusTypeListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelStatusType;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetRequestTypeListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelRequestType;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<OsModel> modelRequestType = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Thông tin email"
            },
            new OsModel
            {
                code = "2",
                name = "Thông tin địa chỉ"
            },
        };
        public static List<OsModel> modelStatusType = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Đã duyệt"
            },
            new OsModel
            {
                code = "2",
                name = "Đang chờ xử lý"
            },
        };

        public static List<AgentInfoChangeResponseModel> model = new List<AgentInfoChangeResponseModel>()
        {
            new AgentInfoChangeResponseModel {
                        AgentInforChangeId = 1,
                        RequestCode = "RCAI22_000042",
                        AgentCode = "92011882",
                        TVTCName = "ĐỖ THỊ THANH THÚY",
                        Title = "Unit Manager",
                        RequestType = 1,
                        RequestTyleName = "Thông tin email",
                        Status = 1,
                        StatusName = "Đã duyệt",

                        CreationDate = DateTime.Now,
                    },
            new AgentInfoChangeResponseModel {
                        AgentInforChangeId = 2,
                        RequestCode = "RCAI23_000011",
                        AgentCode = "91809576",
                        TVTCName = "ĐOÀN THỊ LIÊN",
                        Title = "Service Agent",
                        RequestType = 1,
                        RequestTyleName = "Thông tin email",
                        Status = 2,
                        StatusName = "Đang chờ xử lý",

                        CreationDate = DateTime.Now,
                    },
            new AgentInfoChangeResponseModel {
                        AgentInforChangeId = 3,
                        RequestCode = "RCAI22_000041",
                        AgentCode = "92011882",
                        TVTCName = "ĐINH THỊ NGÀ",
                        Title = "Senior District Manager",
                        RequestType = 2,
                        RequestTyleName = "Thông tin địa chỉ",
                        Status = 1,
                        StatusName = "Đã duyệt",

                        CreationDate = DateTime.Now,
                    },
        };
    }
}
