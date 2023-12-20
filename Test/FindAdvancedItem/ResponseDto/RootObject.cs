namespace Test.FindAdvancedItem.ResponseDto;

using System.Collections.Generic;
using System.Text.Json.Serialization;

//public class Item
//{
//    [JsonPropertyName("itemId")]
//    public List<string> ItemId { get; set; }

//    [JsonPropertyName("title")]
//    public List<string> Title { get; set; }

//    [JsonPropertyName("globalId")]
//    public List<string> GlobalId { get; set; }

//    [JsonPropertyName("primaryCategory")]
//    public List<PrimaryCategory> PrimaryCategory { get; set; }

//    [JsonPropertyName("galleryURL")]
//    public List<string> GalleryURL { get; set; }

//    [JsonPropertyName("viewItemURL")]
//    public List<string> ViewItemURL { get; set; }

//    [JsonPropertyName("autoPay")]
//    public List<string> AutoPay { get; set; }

//    [JsonPropertyName("postalCode")]
//    public List<string> PostalCode { get; set; }

//    [JsonPropertyName("location")]
//    public List<string> Location { get; set; }

//    [JsonPropertyName("country")]
//    public List<string> Country { get; set; }

//    [JsonPropertyName("shippingInfo")]
//    public List<ShippingInfo> ShippingInfo { get; set; }

//    [JsonPropertyName("sellingStatus")]
//    public List<SellingStatus> SellingStatus { get; set; }

//    [JsonPropertyName("listingInfo")]
//    public List<ListingInfo> ListingInfo { get; set; }

//    [JsonPropertyName("returnsAccepted")]
//    public List<string> ReturnsAccepted { get; set; }

//    [JsonPropertyName("condition")]
//    public List<Condition> Condition { get; set; }

//    [JsonPropertyName("isMultiVariationListing")]
//    public List<string> IsMultiVariationListing { get; set; }

//    [JsonPropertyName("topRatedListing")]
//    public List<string> TopRatedListing { get; set; }
//    [JsonPropertyName("productId")] 
//    public List<ProductId> ProductId { get; set; }
//}

//public class ProductId
//{
//    [JsonPropertyName("type")]
//    public string Type { get; set; }

//    [JsonPropertyName("value")]
//    public string Value { get; set; }
//}

//public class PrimaryCategory
//{
//    [JsonPropertyName("categoryId")]
//    public List<string> CategoryId { get; set; }

//    [JsonPropertyName("categoryName")]
//    public List<string> CategoryName { get; set; }
//}

//public class ShippingInfo
//{
//    [JsonPropertyName("shippingServiceCost")]
//    public List<ShippingServiceCost> ShippingServiceCost { get; set; }

//    [JsonPropertyName("shippingType")]
//    public List<string> ShippingType { get; set; }

//    [JsonPropertyName("shipToLocations")]
//    public List<string> ShipToLocations { get; set; }

//    [JsonPropertyName("expeditedShipping")]
//    public List<string> ExpeditedShipping { get; set; }

//    [JsonPropertyName("oneDayShippingAvailable")]
//    public List<string> OneDayShippingAvailable { get; set; }

//    [JsonPropertyName("handlingTime")]
//    public List<string> HandlingTime { get; set; }
//}

//public class ShippingServiceCost
//{
//    [JsonPropertyName("currencyId")]
//    public string CurrencyId { get; set; }

//    [JsonPropertyName("value")]
//    public string Value { get; set; }
//}

//public class SellingStatus
//{
//    [JsonPropertyName("currentPrice")]
//    public List<CurrentPrice> CurrentPrice { get; set; }

//    [JsonPropertyName("convertedCurrentPrice")]
//    public List<CurrentPrice> ConvertedCurrentPrice { get; set; }

//    [JsonPropertyName("sellingState")]
//    public List<string> SellingState { get; set; }

//    [JsonPropertyName("timeLeft")]
//    public List<string> TimeLeft { get; set; }

//    [JsonPropertyName("bidCount")]
//    public List<string> BidCount { get; set; }
//}

//public class CurrentPrice
//{
//    [JsonPropertyName("currencyId")]
//    public string CurrencyId { get; set; }

//    [JsonPropertyName("value")]
//    public string Value { get; set; }
//}

//public class ListingInfo
//{
//    [JsonPropertyName("bestOfferEnabled")]
//    public List<string> BestOfferEnabled { get; set; }

//    [JsonPropertyName("buyItNowAvailable")]
//    public List<string> BuyItNowAvailable { get; set; }

//    [JsonPropertyName("startTime")]
//    public List<string> StartTime { get; set; }

//    [JsonPropertyName("endTime")]
//    public List<string> EndTime { get; set; }

//    [JsonPropertyName("listingType")]
//    public List<string> ListingType { get; set; }

//    [JsonPropertyName("gift")]
//    public List<string> Gift { get; set; }

//    [JsonPropertyName("watchCount")]
//    public List<string> WatchCount { get; set; }
//}

//public class Condition
//{
//    [JsonPropertyName("conditionId")]
//    public List<string> ConditionId { get; set; }

//    [JsonPropertyName("conditionDisplayName")]
//    public List<string> ConditionDisplayName { get; set; }
//}

//public class FindItemsAdvancedResponse
//{
//    [JsonPropertyName("ack")]
//    public List<string> Ack { get; set; }

//    [JsonPropertyName("version")]
//    public List<string> Version { get; set; }

//    [JsonPropertyName("timestamp")]
//    public List<string> Timestamp { get; set; }

//    [JsonPropertyName("searchResult")]
//    public List<SearchResult> SearchResult { get; set; }
//}

//public class SearchResult
//{
//    [JsonPropertyName("@count")]
//    public string Count { get; set; }

//    [JsonPropertyName("item")]
//    public List<Item> Item { get; set; }
//}

//public class PaginationOutput
//{
//    [JsonPropertyName("pageNumber")]
//    public List<string> PageNumber { get; set; }

//    [JsonPropertyName("entriesPerPage")]
//    public List<string> EntriesPerPage { get; set; }

//    [JsonPropertyName("totalPages")]
//    public List<string> TotalPages { get; set; }

//    [JsonPropertyName("totalEntries")]
//    public List<string> TotalEntries { get; set; }
//}

//public class RootObject
//{
//    [JsonPropertyName("findItemsAdvancedResponse")]
//    public List<FindItemsAdvancedResponse> FindItemsAdvancedResponse { get; set; }
//}



// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class BuyItNowPrice
{
    [JsonPropertyName("@currencyId")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("__value__")]
    public string Value { get; set; }
}

public class Condition
{
    [JsonPropertyName("conditionId")]
    public List<string> ConditionId { get; set; }

    [JsonPropertyName("conditionDisplayName")]
    public List<string> ConditionDisplayName { get; set; }
}

public class ConvertedBuyItNowPrice
{
    [JsonPropertyName("@currencyId")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("__value__")]
    public string Value { get; set; }
}

public class ConvertedCurrentPrice
{
    [JsonPropertyName("@currencyId")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("__value__")]
    public string Value { get; set; }
}

public class CurrentPrice
{
    [JsonPropertyName("@currencyId")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("__value__")]
    public string Value { get; set; }
}

public class DiscountPriceInfo
{
    [JsonPropertyName("originalRetailPrice")]
    public List<OriginalRetailPrice> OriginalRetailPrice { get; set; }

    [JsonPropertyName("pricingTreatment")]
    public List<string> PricingTreatment { get; set; }

    [JsonPropertyName("soldOnEbay")]
    public List<string> SoldOnEbay { get; set; }

    [JsonPropertyName("soldOffEbay")]
    public List<string> SoldOffEbay { get; set; }
}

public class FindItemsAdvancedResponse
{
    [JsonPropertyName("ack")]
    public List<string> Ack { get; set; }

    [JsonPropertyName("version")]
    public List<string> Version { get; set; }

    [JsonPropertyName("timestamp")]
    public List<DateTime> Timestamp { get; set; }

    [JsonPropertyName("searchResult")]
    public List<SearchResult> SearchResult { get; set; }

    [JsonPropertyName("paginationOutput")]
    public List<PaginationOutput> PaginationOutput { get; set; }

    [JsonPropertyName("itemSearchURL")]
    public List<string> ItemSearchURL { get; set; }
}

public class Item
{
    [JsonPropertyName("itemId")]
    public List<string> ItemId { get; set; }

    [JsonPropertyName("title")]
    public List<string> Title { get; set; }

    [JsonPropertyName("globalId")]
    public List<string> GlobalId { get; set; }

    [JsonPropertyName("primaryCategory")]
    public List<PrimaryCategory> PrimaryCategory { get; set; }

    [JsonPropertyName("galleryURL")]
    public List<string> GalleryURL { get; set; }

    [JsonPropertyName("viewItemURL")]
    public List<string> ViewItemURL { get; set; }

    [JsonPropertyName("productId")]
    public List<ProductId> ProductId { get; set; }

    [JsonPropertyName("autoPay")]
    public List<string> AutoPay { get; set; }

    [JsonPropertyName("postalCode")]
    public List<string> PostalCode { get; set; }

    [JsonPropertyName("location")]
    public List<string> Location { get; set; }

    [JsonPropertyName("country")]
    public List<string> Country { get; set; }

    [JsonPropertyName("shippingInfo")]
    public List<ShippingInfo> ShippingInfo { get; set; }

    [JsonPropertyName("sellingStatus")]
    public List<SellingStatus> SellingStatus { get; set; }

    [JsonPropertyName("listingInfo")]
    public List<ListingInfo> ListingInfo { get; set; }

    [JsonPropertyName("returnsAccepted")]
    public List<string> ReturnsAccepted { get; set; }

    [JsonPropertyName("condition")]
    public List<Condition> Condition { get; set; }

    [JsonPropertyName("isMultiVariationListing")]
    public List<string> IsMultiVariationListing { get; set; }

    [JsonPropertyName("topRatedListing")]
    public List<string> TopRatedListing { get; set; }

    [JsonPropertyName("paymentMethod")]
    public List<string> PaymentMethod { get; set; }

    [JsonPropertyName("discountPriceInfo")]
    public List<DiscountPriceInfo> DiscountPriceInfo { get; set; }
}

public class ListingInfo
{
    [JsonPropertyName("bestOfferEnabled")]
    public List<string> BestOfferEnabled { get; set; }

    [JsonPropertyName("buyItNowAvailable")]
    public List<string> BuyItNowAvailable { get; set; }

    [JsonPropertyName("startTime")]
    public List<DateTime> StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public List<DateTime> EndTime { get; set; }

    [JsonPropertyName("listingType")]
    public List<string> ListingType { get; set; }

    [JsonPropertyName("gift")]
    public List<string> Gift { get; set; }

    [JsonPropertyName("watchCount")]
    public List<string> WatchCount { get; set; }

    [JsonPropertyName("buyItNowPrice")]
    public List<BuyItNowPrice> BuyItNowPrice { get; set; }

    [JsonPropertyName("convertedBuyItNowPrice")]
    public List<ConvertedBuyItNowPrice> ConvertedBuyItNowPrice { get; set; }
}

public class OriginalRetailPrice
{
    [JsonPropertyName("@currencyId")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("__value__")]
    public string Value { get; set; }
}

public class PaginationOutput
{
    [JsonPropertyName("pageNumber")]
    public List<string> PageNumber { get; set; }

    [JsonPropertyName("entriesPerPage")]
    public List<string> EntriesPerPage { get; set; }

    [JsonPropertyName("totalPages")]
    public List<string> TotalPages { get; set; }

    [JsonPropertyName("totalEntries")]
    public List<string> TotalEntries { get; set; }
}

public class PrimaryCategory
{
    [JsonPropertyName("categoryId")]
    public List<string> CategoryId { get; set; }

    [JsonPropertyName("categoryName")]
    public List<string> CategoryName { get; set; }
}

public class ProductId
{
    [JsonPropertyName("@type")]
    public string Type { get; set; }

    [JsonPropertyName("__value__")]
    public string Value { get; set; }
}

public class RootObject
{
    [JsonPropertyName("findItemsAdvancedResponse")]
    public List<FindItemsAdvancedResponse> FindItemsAdvancedResponse { get; set; }
}

public class SearchResult
{
    [JsonPropertyName("@count")]
    public string Count { get; set; }

    [JsonPropertyName("item")]
    public List<Item> Item { get; set; }
}

public class SellingStatus
{
    [JsonPropertyName("currentPrice")]
    public List<CurrentPrice> CurrentPrice { get; set; }

    [JsonPropertyName("convertedCurrentPrice")]
    public List<ConvertedCurrentPrice> ConvertedCurrentPrice { get; set; }

    [JsonPropertyName("bidCount")]
    public List<string> BidCount { get; set; }

    [JsonPropertyName("sellingState")]
    public List<string> SellingState { get; set; }

    [JsonPropertyName("timeLeft")]
    public List<string> TimeLeft { get; set; }
}

public class ShippingInfo
{
    [JsonPropertyName("shippingServiceCost")]
    public List<ShippingServiceCost> ShippingServiceCost { get; set; }

    [JsonPropertyName("shippingType")]
    public List<string> ShippingType { get; set; }

    [JsonPropertyName("shipToLocations")]
    public List<string> ShipToLocations { get; set; }

    [JsonPropertyName("expeditedShipping")]
    public List<string> ExpeditedShipping { get; set; }

    [JsonPropertyName("oneDayShippingAvailable")]
    public List<string> OneDayShippingAvailable { get; set; }

    [JsonPropertyName("handlingTime")]
    public List<string> HandlingTime { get; set; }
}

public class ShippingServiceCost
{
    [JsonPropertyName("@currencyId")]
    public string CurrencyId { get; set; }

    [JsonPropertyName("__value__")]
    public string Value { get; set; }
}

