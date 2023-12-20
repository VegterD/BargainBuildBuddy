using System;

namespace Test;

public class SearchUrlHelper
{
    public string? keywords { get; set; }
    public int? categoryId { get; set; }
    public string? sortOrder { get; set; }
    public double? minPrice { get; set; }
    public double? maxPrice { get; set; }
    public bool? returnsAcceptedOnly { get; set; }
    public List<string>? conditions { get; set; }
    public string? itemLocation { get; set; }
    public bool? freeShippingOnly { get; set; }
    public string? expeditedShippingType { get; set; }
    public int? handlingTime { get; set; }
    public string[] outputSelector { get; set; }
    public int? pageNumber { get; set; }
    public int? entriesPerPage { get; set; }

    public override string ToString()
    {
        var url = "";

        var itemFilters = new List<string>();
        if (minPrice.HasValue)
            itemFilters.Add($"itemFilter({itemFilters.Count}).name=MinPrice&itemFilter({itemFilters.Count}).value={minPrice}");

        if (maxPrice.HasValue)
            itemFilters.Add($"itemFilter({itemFilters.Count}).name=MaxPrice&itemFilter({itemFilters.Count}).value={maxPrice}");

        if (returnsAcceptedOnly.HasValue)
            itemFilters.Add($"itemFilter({itemFilters.Count}).name=ReturnsAcceptedOnly&itemFilter({itemFilters.Count}).value={returnsAcceptedOnly}");

        if (conditions != null && conditions.Count > 0)
        {
            var conditionFilter = $"itemFilter({itemFilters.Count}).name=Condition";
            for (int i = 0; i < conditions.Count; i++)
            {
                conditionFilter += $"&itemFilter({itemFilters.Count}).value({i})={conditions[i]}";
            }
            itemFilters.Add(conditionFilter);
        }

        if (!string.IsNullOrEmpty(itemLocation))
            itemFilters.Add($"itemFilter({itemFilters.Count}).name=LocatedIn&itemFilter({itemFilters.Count}).value={itemLocation}");

        if (freeShippingOnly.HasValue)
            itemFilters.Add($"itemFilter({itemFilters.Count}).name=FreeShippingOnly&itemFilter({itemFilters.Count}).value={freeShippingOnly}");

        if (!string.IsNullOrEmpty(expeditedShippingType))
            itemFilters.Add($"itemFilter({itemFilters.Count}).name=ExpeditedShippingType&itemFilter({itemFilters.Count}).value={expeditedShippingType}");

        if (handlingTime.HasValue)
            itemFilters.Add($"itemFilter({itemFilters.Count}).name=MaxHandlingTime&itemFilter({itemFilters.Count}).value={handlingTime}");

        if (itemFilters.Count > 0)
        {
            for (int i = 0; i < itemFilters.Count; i++)
            {
                url += $"&{itemFilters[i]}";
            }
        }

        if (pageNumber.HasValue)
            url += $"&paginationInput.pageNumber={pageNumber}";

        if (entriesPerPage.HasValue)
            url += $"&paginationInput.entriesPerPage={entriesPerPage}";

        if (!string.IsNullOrEmpty(keywords))
            url += $"&keywords={keywords}";

        if (categoryId.HasValue)
            url += $"&categoryId={categoryId}";

        if (!string.IsNullOrEmpty(sortOrder))
            url += $"&sortOrder={sortOrder}";

        if (outputSelector != null && outputSelector.Length > 0)
        {
            for (int i = 0; i < outputSelector.Length; i++)
            {
                url += $"&outputSelector({i})={outputSelector[i]}";
            }
        }


        return url;
    }
}