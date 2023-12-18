
using Azure.Core;
using kendoTest.Data;
using kendoTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace KendoUI.FromController
{
    public class Report404Controller : Controller
    {
        private readonly Report404Context _report404Context;
        public Report404Controller(Report404Context report404Context)
        {
            _report404Context = report404Context;
        }
        [HttpGet]
        public IActionResult Report404()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Report404(Report404ViewModel jsonOBJ)
        {
            var newEntry = new Report404ViewModel
            {
             FiscalYear = jsonOBJ.FiscalYear,
            ReportId = 10001,
            AcceptedBy = jsonOBJ.AcceptedBy,
            ExpenditureClaimFormNo=jsonOBJ.ExpenditureClaimFormNo,
            Date=jsonOBJ.Date,
            OfficeName=jsonOBJ.OfficeName,
            OfficeCodeNo=jsonOBJ.OfficeCodeNo,
            
        };
            var subform = new Report404ModelSubField
            {
                SN = jsonOBJ.SubForms.First().SN,
                Specificatin_No=jsonOBJ.SubForms.First().Specificatin_No,
                Symbol_No=jsonOBJ.SubForms.First().Symbol_No,
                Akin_no=jsonOBJ.SubForms.First().Akin_no,
                Quantity=jsonOBJ.SubForms.First().Quantity,
                Rate=jsonOBJ.SubForms.First().Rate,
                Remark=jsonOBJ.SubForms.First().Remark, 
                Total=jsonOBJ.SubForms.First().Total,
            };


            await _report404Context.Report404Models.AddAsync(newEntry);
            await _report404Context.SaveChangesAsync();
            return View(jsonOBJ);
        }
        public IActionResult FormFroHaideep()
        {
            return View();
        }

        public async Task<IActionResult> PostThis()
        {
            Report404ViewModel model = new()
            {

            };
            _report404Context.Report404Models.Add(model);
            await _report404Context.SaveChangesAsync();
            return Ok();
        }

    }
}