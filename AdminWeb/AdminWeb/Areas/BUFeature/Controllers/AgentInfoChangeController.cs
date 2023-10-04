using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.BUFeature.Controllers
{
    public class AgentInfoChangeController : BaseBUController
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
            var responseModel = model.First(p => p.AgentInforChangeId == id);
            if (responseModel.Status == 1)
            {
                return View("DetailApproved", responseModel);
            }
            if (responseModel.Status == 2)
            {
                return View("DetailProccessing", responseModel);
            }
            if (responseModel.Status == 3)
            {
                return View("DetailRejected", responseModel);
            }
            return View("List");
        }
        public IActionResult DetailProccessing(long id)
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
                        AgentName = "ĐỖ TRƯỜNG AN",
                        OldAgentName = "ĐỖ THỊ THANH THÚY",
                        DOB = DateTime.Now,
                        OldDOB = DateTime.Today,
                        Gender = "Nam",
                        OldGender = "Nữ",
                        Title = "Unit Manager",
                        RequestType = 1,
                        RequestTypeName = "Thông tin email",
                        Status = 1,
                        StatusName = "Đã duyệt",
                        CreationDate = DateTime.Now,
                        IdCardNumber = "000000536",
                        OldIdCardNumber = "040086030460",
                        Email="thanhthuy@gmail.com"
                    },
            new AgentInfoChangeResponseModel {
                        AgentInforChangeId = 2,
                        RequestCode = "RCAI23_000011",
                        AgentCode = "91809576",
                        AgentName = "ĐOÀN THỊ LIÊN",
                        Title = "Service Agent",
                        RequestType = 1,
                        RequestTypeName = "Thông tin email",
                        Status = 2,
                        StatusName = "Đang chờ xử lý",
                        CreationDate = DateTime.Now,
                        OldAgentName = "ĐỖ TRƯỜNG AN",
                           DOB = DateTime.Now,
                        OldDOB = DateTime.Today,
                        Gender = "Nữ",
                        OldGender = "Nam",
                        IdCardNumber = "000000536",
                        OldIdCardNumber = "040086030460",
                        Email="truongan@gmail.com"
                    },
            new AgentInfoChangeResponseModel {
                        AgentInforChangeId = 3,
                        RequestCode = "RCAI22_000041",
                        AgentCode = "92011882",
                        AgentName = "ĐỖ TRƯỜNG AN",
                        Title = "Senior District Manager",
                        RequestType = 2,
                        RequestTypeName = "Thông tin địa chỉ",
                        Status = 3,
                        StatusName = "Đã hủy",
                        CreationDate = DateTime.Now,
                          OldAgentName = "ĐINH THỊ NGÀ",
                           DOB = DateTime.Now,
                        OldDOB = DateTime.Today,
                        Gender = "Nam",
                        OldGender = "Nữ",
                        IdCardNumber = "000000536",
                        OldIdCardNumber = "040086030460",
                        Email="ngadinh@gmail.com"
                    },
        };
    }
}
