namespace Minimal_API;

using Microsoft.EntityFrameworkCore;
using Minimal_API.Models;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

public class SearchCriteriaService : ISearchCriteriaService
{
    private readonly ApiContext _context;

    public SearchCriteriaService(ApiContext context)
    {
        _context = context;
    }

    public async Task<ServiceResult<List<AnalyticsSearchCriteriaView>>> GetSearchCriterias()
    {
        try
        {
            List<AnalyticsSearchCriteriaView> result = await _context.AnalyticsSearchCriteriaView.FromSqlRaw("SELECT * FROM AnalyticsSearchCriteriaView").ToListAsync();
            return ServiceResult<List<AnalyticsSearchCriteriaView>>.Success(result);
        }
        catch (Exception ex)
        {
            return ServiceResult<List<AnalyticsSearchCriteriaView>>.Failure($"An error occurred: {ex.Message}");
        }
    }
}