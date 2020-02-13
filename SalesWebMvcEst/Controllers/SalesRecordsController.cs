using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvcEst.Services;

namespace SalesWebMvcEst.Controllers
{
    public class SalesRecordsController : Controller
    {

        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? dateInitial, DateTime? dateFinal)
        {
            if(!dateInitial.HasValue) //Caso não passe valor da data
            {
                dateInitial = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if(!dateFinal.HasValue) //Caso não passe valor da data
            {
                dateFinal = DateTime.Now;
            }

            ViewData["dateInitial"] = dateInitial.Value.ToString("yyyy-MM-dd");
            ViewData["dateFinal"] = dateFinal.Value.ToString("yyyy-MM-dd");
            var result = await _salesRecordService.FindByDate(dateInitial, dateFinal);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? dateInitial, DateTime? dateFinal)
        {
            if(!dateInitial.HasValue)
            {
                dateInitial = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if(!dateFinal.HasValue)
            {
                dateFinal = DateTime.Now;
            }

            ViewData["dateInitial"] = dateInitial.Value.ToString("yyyy-MM-dd");
            ViewData["dateFinal"] = dateFinal.Value.ToString("yyyy-MM-dd");
            var result = await _salesRecordService.FindByDateGrouping(dateInitial, dateFinal);
            return View(result);
        }
    }
}