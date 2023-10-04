﻿using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class GroupPhoneNumberController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public GroupPhoneNumberController(IApiService apiService)
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


        public static List<GroupPhoneNumberResponseModel> model = new List<GroupPhoneNumberResponseModel>()
        {
            new GroupPhoneNumberResponseModel {
                        GroupPhoneNumberID = 1,
                        PhoneNumber = "0768930266",
                        GroupFunction = 1,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new GroupPhoneNumberResponseModel {
                        GroupPhoneNumberID = 1,
                        PhoneNumber = "0968657899",
                        GroupFunction = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new GroupPhoneNumberResponseModel {
                        GroupPhoneNumberID = 1,
                        PhoneNumber = "0938272727",
                        GroupFunction = 3,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
