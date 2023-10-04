using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace AdminWeb.Areas.BUFeature.Controllers
{
    public class ApprovalAgentTerminationController : BaseBUController
    {
        private readonly IApiService _apiService;

        public ApprovalAgentTerminationController(IApiService apiService)
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
        public object GetAgentTerSimpleList(DataSourceLoadOptions loadOptions)
        {
            var _response = getAgentTerSimpleList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public IActionResult DetailTypes(long id)
        {
            var responseModel = getAgentTerSimpleList.First(p => p.AgentTerSimpleId == id);
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

        public IActionResult CreateOrUpdate(long id)
        {
            var _response = getAgentTerSimpleList.First(p => p.AgentTerSimpleId == id);
            return View(_response);
        }

        public static List<AgentTerSimpleResponseModel> getAgentTerSimpleList = new List<AgentTerSimpleResponseModel>()
        {
            new AgentTerSimpleResponseModel
            {
                AgentTerSimpleId = 1,
                RequestCode = "CRAT22_000001",
                AgentCode = "91810988",
                UnitName = "NGUYỄN THỊ THÚY NGA",
                PositionName = "Senior District Manager",
                DistrictName = "HCM 107",
                RegionName = "GA HO CHI MINH 1",
                PositionApply = "FC",
                RequestDate = DateTime.Now,
                Reason = "Vì lý do cá nhân",
                StatusName = "Đang chờ duyệt",
                Status = 2
            },
             new AgentTerSimpleResponseModel
            {
                AgentTerSimpleId = 2,
                RequestCode = "CRAT22_000002",
                AgentCode = "91810988",
                UnitName = "NGUYỄN THỊ THÚY NGA",
                PositionName = "Senior District Manager",
                DistrictName = "HCM 107",
                RegionName = "GA HO CHI MINH 1",
                PositionApply = "UM",
                RequestDate = DateTime.Now,
                Reason = "Vì lý do cá nhân",
                StatusName = "Đã duyệt",
                Status = 1
            },
              new AgentTerSimpleResponseModel
            {
                AgentTerSimpleId = 3,
                RequestCode = "CRAT22_000003",
                AgentCode = "91810988",
                UnitName = "NGUYỄN THỊ THÚY NGA",
                PositionName = "Financial Consultant",
                DistrictName = "HCM 107",
                RegionName = "GA HAI CHAU 2",
                PositionApply = "DM",
                RequestDate = DateTime.Now,
                Reason = "Vì lý do cá nhân",
                StatusName = "Đã từ chối",
                Status = 3

            },
               new AgentTerSimpleResponseModel
            {
                AgentTerSimpleId = 4,
                RequestCode = "CRAT22_000004",
                AgentCode = "91810988",
                UnitName = "NGUYỄN THỊ THÚY NGA",
                PositionName = "Senior District Manager",
                DistrictName = "HẢI CHÂU 2 - 02",
                RegionName = "GA HO CHI MINH 2",
                PositionApply = "FC",
                RequestDate = DateTime.Now,
                Reason = "Vì lý do cá nhân",
                StatusName = "Đã hủy",
                Status = 4
            },
        };

      /*  public static List<string> StatusNameList = new List<string>();
        public static List<string> positionList = new List<string>();

        [HttpGet]
        public object GetStatusName(DataSourceLoadOptions loadOptions)
        {
            List<string> list = new List<string>();
            StatusNameList.Clear();
            foreach (var item in getAgentTerSimpleList)
            {
                if (!list.Contains(item.StatusName))
                {
                    StatusNameList.Add(item.StatusName);
                    list.Add(item.StatusName);
                }
            }
            var _response = StatusNameList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetPosition(DataSourceLoadOptions loadOptions)
        {
            List<string> list = new List<string>();
            positionList.Clear();
            foreach (var item in getAgentTerSimpleList)
            {
                if (!list.Contains(item.PositionApply))
                {
                    positionList.Add(item.PositionApply);
                    list.Add(item.PositionApply);
                }
            }
            var _response = positionList;

            return DataSourceLoader.Load(_response, loadOptions);
        }*/
    }
}
