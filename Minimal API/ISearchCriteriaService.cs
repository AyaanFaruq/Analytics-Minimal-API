using Minimal_API.Models;

namespace Minimal_API;

public interface ISearchCriteriaService
{
    Task<ServiceResult<List<AnalyticsSearchCriteriaView>>> GetSearchCriterias();
}
