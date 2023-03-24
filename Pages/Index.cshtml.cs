﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using procedure_report_app.Data;
using procedure_report_app.Services;
using procedure_report_app.Models;

namespace procedure_report_app.Pages;

public class IndexModel : PageModel
{
    public string DisplayValue  { get; set; }
    private readonly ILogger<IndexModel> _logger;
    private BalanceHCService _service;

    public IndexModel(ILogger<IndexModel> logger)
    {
         _logger = logger;
    }

    public void OnGet()
    {
        ApplicationDbContextFactory db_fac = new ApplicationDbContextFactory();

        var args = new string[] {};
        using (ApplicationDbContext db = db_fac.CreateDbContext(args))
        {
            _service = new BalanceHCService(db);
            IQueryable<ReserveReportItem> result = _service.GetTmpListByPlace(2000, "", "", "");
            DisplayValue = result.Single().GUID_Object.ToString();
        }
    }
}
