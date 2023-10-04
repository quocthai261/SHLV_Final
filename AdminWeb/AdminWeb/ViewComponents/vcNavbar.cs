using AdminWeb.Models.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System;

namespace AdminWeb.ViewComponents
{
    public class vcNavbar : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SiteMap = await GetSiteMap();

            return View();
        }

        private async Task<IEnumerable<TreeMenuItem<SiteMapNode>>> GetSiteMap()
        {
            IEnumerable<TreeMenuItem<SiteMapNode>> siteMap = null;

            List<SiteMapNode> menus = null;

            menus = new List<SiteMapNode>()
                {
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Chức năng nhân viên nghiệp vụ",
                        ICONCLASS = "glyphicon glyphicon-folder-close",
                        ID = 1,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = null,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Duyệt thay đổi thông tin đại lý",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 2,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "BUFeature/AgentInfoChange"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Duyệt chuyển đổi đại lý",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 3,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "BUFeature/ApprovalChangeAgency"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Duyệt chấm dứt hợp đồng",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 4,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "BUFeature/ApprovalAgentTermination"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình thông báo",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 5,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 4,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "BUFeature/Notifications"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quy trình chuyển đổi đại lý",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 6,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 5,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "BUFeature/ApprovalConfiguration"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "DanhMuc",
                        ICONCLASS = "glyphicon glyphicon-folder-close",
                        ID = 7,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = null,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại chuyển đổi đại lý",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 8,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/AgentMoveTypes"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tiêu chí đánh giá",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 9,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Criterias"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Câu trả lời tiêu chí đánh giá",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 10,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Answers"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Danh mục ngân hàng",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 11,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 4,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Bank"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Chi nhánh ngân hàng",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 12,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 5,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/BankOrg"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại giấy tờ tùy thân",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 13,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 6,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/CertiType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tình trạng hồ sơ",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 14,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 7,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/ClaimStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại quyền lợi bảo hiểm",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 15,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 8,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/ClaimType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình thăng/giáng chức",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 16,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 9,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/ConfigProDemotion"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại khách hàng",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 17,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 10,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/CustomerType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại chẩn đoán",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 18,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 11,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/DiagnosisCategory"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Chẩn đoán",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 19,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 12,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Diagnosis"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quận / huyện",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 20,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 13,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/District"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quận / huyện",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 21,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 14,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/DocumentType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Danh sách tài liệu",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 21,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 14,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/DocumentType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Biểu mẫu email",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 22,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 15,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/EmailTemplate"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Câu hỏi PTNCTC",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 23,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 16,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/FinancialQuestion"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Câu trả lời PTNCTC",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 24,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 17,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/FinancialAnswers"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại sản phẩm tài chính",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 25,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 18,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/FinancialProductType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình công thức",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 26,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 19,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Formula"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Giới tính",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 27,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 20,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Gender"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Nhóm điện thoại",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 28,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 21,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/GroupPhoneNumber"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Bệnh viện",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 29,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 22,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Hospital"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Sự kiện",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 30,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 23,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/IntegrationEvent"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tình trạng sản phẩm",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 31,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 24,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/LiablityStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Thiết lập TCĐG theo vị trí",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 32,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 25,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/MapCriPosition"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Vị trí kế tiếp",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 33,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 26,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/MappingNextPosition"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại tình trạng hôn nhân",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 34,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 27,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Marriage"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quốc gia",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 35,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 28,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Nationalities"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại thanh toán",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 36,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 29,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/PayMode"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Trạng thái hợp đồng",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 37,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 30,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/PolicyStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Vị trí ứng tuyển",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 38,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 31,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/PositionApplings"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Vị trí",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 39,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 32,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Position"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tình trạng phí của sản phẩm chính",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 40,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 33,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/PremiumStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tiêu chí thăng/giáng chức",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 41,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 34,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/ProDeCriteria"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Tỉnh thành Việt Nam",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 42,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 35,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/ProDeCriteria"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại lý do",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 43,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 36,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Reason"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Trạng thái YC đăng ký BFC",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 44,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 37,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/RegisterBfcStatus"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Đăng ký thi đua",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 45,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 38,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/RegisterContest"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Mối quan hệ",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 46,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 39,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Relation"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Kỳ lương",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 47,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 40,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/SalaryPeriod"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Kế hoạch kinh doanh",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 48,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 41,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/SalePlanConfig"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Loại kế hoạch kinh doanh",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 49,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 42,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/SalePlanTypes"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Phường/Xã",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 50,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 43,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/Ward"
                    },


                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản trị hệ thống",
                        ICONCLASS = "glyphicon glyphicon-folder-close",
                        ID = 51,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = null,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Người dùng",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 52,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Users"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Nhóm người dùng",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 53,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Roles"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý quyền",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 54,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Permissions"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý Menu",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 55,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 4,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Menu"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý Menu Mobile",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 56,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 5,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/MenuMobile"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý log",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 57,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 6,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/ActivityLog"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý ứng dụng",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 58,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 7,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Application"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý ngôn ngữ",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 59,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 8,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Language"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý thông báo",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 60,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 9,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/LocaleMessage"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 61,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 10,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Setting"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Cấu hình SMTP",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 62,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 11,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/SmtpConfig"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý job và đồng bộ",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 63,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 12,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/SyncJobs"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Lịch sử người dùng đăng nhập",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 64,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 13,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/UserLoginHistory"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Quản lý versions",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 65,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 14,
                        PARENTID = 51,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Version"
                    },
                };

            if (menus != null && menus.Count > 0)
            {
                siteMap = menus.GenerateTreeMenu(c => c.ID, c => c.PARENTID, c => c.ORDER_);
            }

            return siteMap;
        }
    }
}
