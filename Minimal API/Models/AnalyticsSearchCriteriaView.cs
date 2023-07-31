namespace Minimal_API.Models;

public class AnalyticsSearchCriteriaView
{
    public Int32? Event_ptsEventID { get; set; }
    public Int64? RowNum { get; set; }
    public string? CallSubType { get; set; }
    public string? CallType { get; set; }
    public string? CallMethod { get; set; }
    public Int32? Priority { get; set; }
    public Int32? ptsCityID { get; set; }
    public string? CityDescription { get; set; }
    public string? StreetName { get; set; }
    public string? StreetType { get; set; }
    public string? PostalCode { get; set; }
    public string? Highway { get; set; }
    public Int32? AddressNumber { get; set; }
    public Int32? ptsEventLocationID { get; set; }
    public string? Zone { get; set; }
    public Int32? EventRouting_ptsEventID { get; set; }
    public  string? AgencyID { get; set; }
    public Int32? Disposition_ptsEventID { get; set; }
    public string? Disposition { get; set; }
    public  string? Shift_AgencyID { get; set; }
    public Int32? ptsShiftID { get; set; }
    public string? Designation { get; set; }
}