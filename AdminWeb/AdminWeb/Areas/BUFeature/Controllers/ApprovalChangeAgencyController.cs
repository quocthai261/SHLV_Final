using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.BUFeature.Controllers
{
    public class ApprovalChangeAgencyController : BaseBUController
    {
        private readonly IApiService _apiService;

        public ApprovalChangeAgencyController(IApiService apiService)
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
            var _response = model.First(p => p.ApprovalChangeAgencyId == id);
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
        [HttpGet]
        public object GetDataTableChildList(long id, DataSourceLoadOptions loadOptions)
        {
            var _response = model.First(p => p.ApprovalChangeAgencyId == id).lstUserApprove;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<OsModel> modelRequestType = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Đang chờ BU duyệt"
            },
            new OsModel
            {
                code = "2",
                name = "Đang chờ duyệt"
            },
        };
        public static List<OsModel> modelStatusType = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Chuyển KVKD"
            },
            new OsModel
            {
                code = "2",
                name = "Chuyển văn phòng KD"
            },
        };

        public static List<ApprovalChangeAgencyResponseModel> model = new List<ApprovalChangeAgencyResponseModel>()
        {
            new ApprovalChangeAgencyResponseModel {
                        ApprovalChangeAgencyId = 1,
                        RequestType = 1,
                        RequestTypeName = "Chuyển KVKD",
                        RequestCode = "CRAM22_000002",
                        Name = "Chuyển KVKD",
                        FCCode = "92004352",
                        RequestName = "NGUYỄN THỊ TIÊN",
                        Reason = "THUẬN TIỆN CHO VIỆC PHÁT TRIỂN VÀ HỖ TRỢ KINH DOANH",
                        StepRequest = "4 / 4",
                        RequestNameNext = "Admin",
                        Status = 1,
                        StatusName = "Đang chờ Admin duyệt",

                        CreationDate = DateTime.Now,

                        lstUserApprove = new List<ListUserApprove>
                        {
                            new ListUserApprove
                            {
                                UserId = 12,
                                UserName = "NGUYỄN QUỐC ANH TUẤN",
                                UserCode = "92204484",
                                PhoneNumber = "0968275797",
                                Position = "DM mới",
                                ApproveDate = DateTime.Now
                            },
                            new ListUserApprove
                            {
                                UserId = 13,
                                UserName = "PHẠM NGUYỄN THẾ HUY",
                                UserCode = "90001616",
                                PhoneNumber = "",
                                Position = "RSD hiện tại",
                                ApproveDate = DateTime.Now
                            },
                        }
                    },
            new ApprovalChangeAgencyResponseModel {
                        ApprovalChangeAgencyId = 2,
                        RequestType = 2,
                        RequestTypeName = "Chuyển văn phòng KD",
                        RequestCode = "CRAM22_000001",
                        Name = "Chuyển văn phòng KD",
                        FCCode = "92104202",
                        RequestName = "NGUYỄN THỊ TIÊN",
                        Reason = "gần nhà tiện cho công việc",
                        StepRequest = "1 / 6",
                        RequestNameNext = "Admin",
                        Status = 1,
                        StatusName = "Đang chờ Admin duyệt",

                        CreationDate = DateTime.Now,

                        lstUserApprove = new List<ListUserApprove>
                        {
                            new ListUserApprove
                            {
                                UserId = 14,
                                UserName = "LÊ ĐỨC TIẾN",
                                UserCode = "91306931",
                                PhoneNumber = "0912488296",
                                Position = "UM hiện tại",
                                ApproveDate = DateTime.Now
                            },
                        }
                    },
        };
    }
}
