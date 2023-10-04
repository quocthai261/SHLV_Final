﻿using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class GenderController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public GenderController(IApiService apiService)
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


        public static List<GenderResponseModel> model = new List<GenderResponseModel>()
        {
            new GenderResponseModel {
                        GenderId = 1,
                        GenderCode = "M",
                        GenderDescription = "Male",
                        GenderDescriptionVN = "Nam",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new GenderResponseModel {
                        GenderId = 1,
                        GenderCode = "F",
                        GenderDescription = "Female",
                        GenderDescriptionVN = "Nữ",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
