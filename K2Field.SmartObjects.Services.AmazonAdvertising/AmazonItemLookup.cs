﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using Attributes = SourceCode.SmartObjects.Services.ServiceSDK.Attributes;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;
using System.Net;
using System.Xml.Serialization;
using AmazonProductAdvtApi;
using System.IO;
using System.Xml;

namespace K2Field.SmartObjects.Services.AmazonAdvertising
{
    [Attributes.ServiceObject("AmazonItemLookup", "Amazon Item Lookup", "Amazon Item Lookup")]
    public class AmazonItemLookup
    {
        //http://docs.aws.amazon.com/AWSECommerceService/latest/DG/ItemLookup.html
        //http://docs.aws.amazon.com/AWSECommerceService/latest/DG/RG_ItemAttributes.html


        //const string _decimalFormat = "#.##";

        public ServiceConfiguration ServiceConfiguration { get; set; }


        // Standard Returns
        [Attributes.Property("ASIN", SoType.Text, "ASIN", "ASIN")]
        public string ASIN { get; set; }

        [Attributes.Property("UPC", SoType.Number, "UPC", "UPC")]
        public long UPC { get; set; }

        [Attributes.Property("ParentASIN", SoType.Text, "ParentASIN", "ParentASIN")]
        public string ParentASIN { get; set; }

        [Attributes.Property("Title", SoType.Text, "Title", "Title")]
        public string Title { get; set; }

        [Attributes.Property("FeatureDescription", SoType.Memo, "Feature Description", "Feature Description")]
        public string FeatureDescription { get; set; }

        [Attributes.Property("Manufacturer", SoType.Text, "Manufacturer", "Manufacturer")]
        public string Manufacturer { get; set; }

        [Attributes.Property("ProductGroup", SoType.Text, "ProductGroup", "ProductGroup")]
        public string ProductGroup { get; set; }

        [Attributes.Property("Model", SoType.Text, "Model", "Model")]
        public string Model { get; set; }

        [Attributes.Property("ProductType", SoType.Text, "Product Type", "Product Type")]
        public string ProductType { get; set; }

        [Attributes.Property("ListPrice", SoType.Text, "List Price", "List Price")]
        public string ListPrice { get; set; }

        [Attributes.Property("ListPriceCurrency", SoType.Text, "List Price Currency", "List Price Currency")]
        public string ListPriceCurrency { get; set; }

        [Attributes.Property("ListPriceValue", SoType.Decimal, "List Price Value", "List Price Value")]
        public double ListPriceValue { get; set; }

        //model, producttypename, lowest new price, lowest used, lowestrefurbished / totalnew, totaluses, totlarefurbished

        [Attributes.Property("DetailPageURL", SoType.Memo, "Detail Page URL", "Detail Page URL")]
        public string DetailPageURL { get; set; }

        [Attributes.Property("SmallImageUrl", SoType.Memo, "Small Image Url", "Small Image Url")]
        public string SmallImageUrl { get; set; }

        [Attributes.Property("MediumImageUrl", SoType.Memo, "Medium Image Url", "Medium Image Url")]
        public string MediumImageUrl { get; set; }

        [Attributes.Property("LargeImageUrl", SoType.Memo, "Large Image Url", "Large Image Url")]
        public string LargeImageUrl { get; set; }

        [Attributes.Property("AttributeName", SoType.Text, "Attribute Name", "Attribute Name")]
        public string AttributeName { get; set; }

        [Attributes.Property("AttributeValue", SoType.Text, "Attribute Value", "Attribute Value")]
        public string AttributeValue { get; set; }

        [Attributes.Property("ResultXML", SoType.Memo, "Result XML", "Result XML")]
        public string ResultXML { get; set; }

        [Attributes.Property("ItemId", SoType.Text, "Item Id", "Item Id")]
        public string ItemId { get; set; }

        [Attributes.Property("IdType", SoType.Text, "Id Type", "Id Type")]
        public string IdType { get; set; }

        [Attributes.Property("SearchIndex", SoType.Text, "Search Index", "Search Index")]
        public string SearchIndex { get; set; }

        [Attributes.Property("Condition", SoType.Text, "Condition", "Condition")]
        public string Condition { get; set; } // All, New, Collectible, Refurbished

        [Attributes.Property("Keywords", SoType.Text, "Keywords", "Keywords")]
        public string Keywords { get; set; }

        [Attributes.Property("Sort", SoType.Text, "Sort", "Sort")]
        public string Sort { get; set; } // 

        [Attributes.Property("ItemPage", SoType.Number, "Item Page", "Item Page")]
        public int ItemPage { get; set; } 

        [Attributes.Property("ErrorCode", SoType.Text, "Error Code", "Error Code")]
        public string ErrorCode { get; set; }

        [Attributes.Property("ErrorMessage", SoType.Memo, "Error Message", "Error Message")]
        public string ErrorMessage { get; set; }


        [Attributes.Property("ResultStatus", SoType.Text, "Result Status", "Result Status")]
        public string ResultStatus { get; set; }

        [Attributes.Property("ResultMessage", SoType.Text, "Result Message", "Result Message")]
        public string ResultMessage { get; set; }



        [Attributes.Method("Lookup Item", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.Read, "Lookup Item", "Lookup Item",
        new string[] { "ItemId", "IdType" }, //required property array (no required properties for this sample)
        new string[] { "ItemId", "IdType", "SearchIndex", "Condition" }, //input property array (no optional input properties for this sample)
        new string[] { "ItemId", "IdType", "SearchIndex", "Condition", "ASIN", "ParentASIN", "UPC", "Manufacturer", "ProductGroup", "Title", "DetailPageUrl", "SmallImageUrl", "MediumImageUrl", "LargeImageUrl", "Model", "FeatureDescription", "ProductType", "ListPrice", "ListPriceCurrency", "ListPriceValue", "ResultXML", "ErrorCode", "ErrorMessage", "ResultStatus", "ResultMessage" })]
        public AmazonItemLookup ItemLookupByInput()
        {
            return GetResult();
        }


        [Attributes.Method("ItemLookupByUPC", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.Read, "Item Lookup By UPC", "Item Lookup By UPC",
        new string[] { "ItemId" }, //required property array (no required properties for this sample)
        new string[] { "ItemId", "SearchIndex", "Condition" }, //input property array (no optional input properties for this sample)
        new string[] { "ItemId", "IdType", "SearchIndex", "Condition", "ASIN", "ParentASIN", "UPC", "Manufacturer", "ProductGroup", "Title", "DetailPageUrl", "SmallImageUrl", "MediumImageUrl", "LargeImageUrl", "Model", "FeatureDescription", "ProductType", "ListPrice", "ListPriceCurrency", "ListPriceValue", "ResultXML", "ErrorCode", "ErrorMessage", "ResultStatus", "ResultMessage" })]
        public AmazonItemLookup ItemLookupByUPC()
        {
            this.IdType = "UPC";
            return GetResult();
        }


        [Attributes.Method("ItemLookupByASIN", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.Read, "Item Lookup By ASIN", "Item Lookup By ASIN",
        new string[] { "ItemId" }, //required property array (no required properties for this sample)
        new string[] { "ItemId", "SearchIndex", "Condition" }, //input property array (no optional input properties for this sample)
        new string[] { "ItemId", "IdType", "SearchIndex", "Condition", "ASIN", "ParentASIN", "UPC", "Manufacturer", "ProductGroup", "Title", "DetailPageUrl", "SmallImageUrl", "MediumImageUrl", "LargeImageUrl", "Model", "FeatureDescription", "ProductType", "ListPrice", "ListPriceCurrency", "ListPriceValue", "ResultXML", "ErrorCode", "ErrorMessage", "ResultStatus", "ResultMessage" })]
        public AmazonItemLookup ItemLookupByASIN()
        {
            this.IdType = "ASIN";
            return GetResult();
        }


        [Attributes.Method("ItemLookupByISBN", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.Read, "Item Lookup By ISBN", "Item Lookup By ISBN",
        new string[] { "ItemId" }, //required property array (no required properties for this sample)
        new string[] { "ItemId", "SearchIndex", "Condition" }, //input property array (no optional input properties for this sample)
        new string[] { "ItemId", "IdType", "SearchIndex", "Condition", "ASIN", "ParentASIN", "UPC", "Manufacturer", "ProductGroup", "Title", "DetailPageUrl", "SmallImageUrl", "MediumImageUrl", "LargeImageUrl", "Model", "FeatureDescription", "ProductType", "ListPrice", "ListPriceCurrency", "ListPriceValue", "ResultXML", "ErrorCode", "ErrorMessage", "ResultStatus", "ResultMessage" })]
        public AmazonItemLookup ItemLookupByISBN()
        {
            this.IdType = "ISBN";
            return GetResult();
        }


        [Attributes.Method("ItemLookupBySKU", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.Read, "Item Lookup By SKU", "Item Lookup By SKU",
        new string[] { "ItemId" }, //required property array (no required properties for this sample)
        new string[] { "ItemId", "SearchIndex", "Condition" }, //input property array (no optional input properties for this sample)
        new string[] { "ItemId", "IdType", "SearchIndex", "Condition", "ASIN", "ParentASIN", "UPC", "Manufacturer", "ProductGroup", "Title", "DetailPageUrl", "SmallImageUrl", "MediumImageUrl", "LargeImageUrl", "Model", "FeatureDescription", "ProductType", "ListPrice", "ListPriceCurrency", "ListPriceValue", "ResultXML", "ErrorCode", "ErrorMessage", "ResultStatus", "ResultMessage" })]
        public AmazonItemLookup ItemLookupBySKU()
        {
            this.IdType = "SKU";
            return GetResult();
        }


        [Attributes.Method("ItemLookupByEAN", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.Read, "Item Lookup By EAN", "Item Lookup By EAN",
        new string[] { "ItemId" }, //required property array (no required properties for this sample)
        new string[] { "ItemId", "SearchIndex", "Condition" }, //input property array (no optional input properties for this sample)
        new string[] { "ItemId", "IdType", "SearchIndex", "Condition", "ASIN", "ParentASIN", "UPC", "Manufacturer", "ProductGroup", "Title", "DetailPageUrl", "SmallImageUrl", "MediumImageUrl", "LargeImageUrl", "Model", "FeatureDescription", "ProductType", "ListPrice", "ListPriceCurrency", "ListPriceValue", "ResultXML", "ErrorCode", "ErrorMessage", "ResultStatus", "ResultMessage" })]
        public AmazonItemLookup ItemLookupByEAN()
        {
            this.IdType = "EAN";
            return GetResult();
        }

        [Attributes.Method("Search", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.List, "Search", "Search",
        new string[] { "Keywords" }, //required property array (no required properties for this sample)
        new string[] { "Keywords", "SearchIndex", "Condition", "Sort", "ItemPage" }, //input property array (no optional input properties for this sample)
        new string[] { "Keywords", "SearchIndex", "Condition", "Sort", "ItemPage", "ItemId", "IdType", "ASIN", "ParentASIN", "UPC", "Manufacturer", "ProductGroup", "Title", "DetailPageUrl", "SmallImageUrl", "MediumImageUrl", "Model", "FeatureDescription", "ProductType", "ListPrice", "ListPriceCurrency", "ListPriceValue", "LargeImageUrl", "ErrorCode", "ErrorMessage", "ResultStatus", "ResultMessage" })]
        public List<AmazonItemLookup> Search()
        {
            return GetSearchResults();
        }


        [Attributes.Method("ListItemLookupAttributes", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.List, "List Item Lookup Attibutes", "List Item Lookup Attibutes",
        new string[] { "ResultXML" }, //required property array (no required properties for this sample)
        new string[] { "ResultXML" }, //input property array (no optional input properties for this sample)
        new string[] { "AttributeName", "AttributeValue" })]
        public List<AmazonItemLookup> ListItemLookupAttributes()
        {
            var settings = new Settings(ServiceConfiguration);
            List<AmazonItemLookup> items = new List<AmazonItemLookup>();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(this.ResultXML);
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                nsmgr.AddNamespace("ns", "http://webservices.amazon.com/AWSECommerceService/2011-08-01");

                XmlNode attributes = doc.SelectSingleNode("/ns:ItemLookupResponse/ns:Items/ns:Item/ns:ItemAttributes", nsmgr);

                foreach (XmlNode attribute in attributes.ChildNodes)
                {
                    AmazonItemLookup item = new AmazonItemLookup();
                    item.AttributeName = attribute.Name;
                    item.AttributeValue = attribute.InnerText;

                    items.Add(item);
                }
                
                return items;
            }
            catch (Exception ex)
            {
                throw ex;
                //this.ResultStatus = "Exception";
                //this.ResultMessage = ex.GetBaseException().Message;
                //return this;
            }
        }

        [Attributes.Method("GetItemLookupAttributes", SourceCode.SmartObjects.Services.ServiceSDK.Types.MethodType.Read, "Get Item Lookup Attibute", "Get Item Lookup Attibute",
        new string[] { "ResultXML", "AttributeName" }, //required property array (no required properties for this sample)
        new string[] { "ResultXML", "AttributeName" }, //input property array (no optional input properties for this sample)
        new string[] { "AttributeName", "AttributeValue", "ResultStatus", "ResultMessage" })]
        public AmazonItemLookup GetItemLookupAttribute()
        {
            var settings = new Settings(ServiceConfiguration);
            AmazonItemLookup item = new AmazonItemLookup();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(this.ResultXML);

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                nsmgr.AddNamespace("ns", "http://webservices.amazon.com/AWSECommerceService/2011-08-01");

                XmlNode attribute = doc.SelectSingleNode("/ns:ItemLookupResponse/ns:Items/ns:Item/ns:ItemAttributes/ns:" + this.AttributeName, nsmgr);

                if (attribute != null)
                {
                    this.ResultStatus = "OK";
                    this.AttributeValue = attribute.InnerText;
                }
                else
                {
                    this.ResultStatus = "Not Found";
                }
                
                return this;
            }
            catch (Exception ex)
            {
                this.ResultStatus = "Exception";
                this.ResultMessage = ex.GetBaseException().Message;
                return this;
            }
        }

        private AmazonItemLookup GetResult()
        {
            var settings = new Settings(ServiceConfiguration);

            try
            {
                string searchindex = "All";
                if (!string.IsNullOrWhiteSpace(this.SearchIndex))
                {
                    searchindex = this.SearchIndex;
                }

                string condition = "All";
                if (!string.IsNullOrWhiteSpace(this.Condition))
                {
                    condition = this.Condition;
                }

                IDictionary<string, string> query = new Dictionary<string, String>();
                query["Service"] = "AWSECommerceService";
                query["AssociateTag"] = settings.AssoicateTag;
                query["Operation"] = "ItemLookup";
                query["ItemId"] = this.ItemId;
                query["IdType"] = this.IdType;
                query["ResponseGroup"] = "Images,ItemAttributes,Offers,OfferSummary";

                if (!this.IdType.Equals("ASIN", StringComparison.OrdinalIgnoreCase))
                {
                    query["SearchIndex"] = searchindex;
                }
                if (!string.IsNullOrWhiteSpace(this.Condition))
                {
                    query["Condition"] = condition;
                }

                var item = ExecuteItemLookup(query, settings.AWSAccessKeyId, settings.AWSSecretKey, settings.Marketplace);

                var returnItem = MapProperties(item);
                returnItem.ItemId = this.ItemId;
                returnItem.IdType = this.IdType;
                returnItem.SearchIndex = searchindex;
                returnItem.Condition = condition;

                returnItem.ResultStatus = "OK";

                return returnItem;
            }
            catch (Exception ex)
            {
                this.ResultStatus = "Exception";
                this.ResultMessage = ex.GetBaseException().Message;
                return this;
            }
        }

        //private string GetAttribute(string xpath)
        //{

        //}

        private AmazonItemLookup MapProperties(ItemLookupResponse response)
        {
            AmazonItemLookup item = new AmazonItemLookup();

            if (response.Items != null && response.Items.Item != null)
            {
                item.ASIN = response.Items.Item.ASIN;
                item.ParentASIN = response.Items.Item.ParentASIN != null ? response.Items.Item.ParentASIN : "";
                item.DetailPageURL = response.Items.Item.DetailPageURL != null ? response.Items.Item.DetailPageURL : "";

                if (response.Items.Item.SmallImage != null)
                    item.SmallImageUrl = response.Items.Item.SmallImage.URL != null ? response.Items.Item.SmallImage.URL : "";

                if (response.Items.Item.MediumImage != null)
                    item.MediumImageUrl = response.Items.Item.MediumImage.URL != null ? response.Items.Item.MediumImage.URL : "";

                if (response.Items.Item.MediumImage != null)
                    item.LargeImageUrl = response.Items.Item.LargeImage.URL != null ? response.Items.Item.LargeImage.URL : "";

                if (response.Items.Item.ItemAttributes != null)
                {
                    item.Manufacturer = response.Items.Item.ItemAttributes.Manufacturer != null ? response.Items.Item.ItemAttributes.Manufacturer : "";
                    item.ProductGroup = response.Items.Item.ItemAttributes.ProductGroup != null ? response.Items.Item.ItemAttributes.ProductGroup : "";
                    item.Title = response.Items.Item.ItemAttributes.Title != null ? response.Items.Item.ItemAttributes.Title : "";

                    if (response.Items.Item.ItemAttributes.Feature != null && response.Items.Item.ItemAttributes.Feature.Count() > 0)
                    {
                        item.FeatureDescription = string.Join(" ", response.Items.Item.ItemAttributes.Feature);
                    }

                    item.ProductType = response.Items.Item.ItemAttributes.ProductTypeName;
                    item.UPC = Convert.ToInt64(response.Items.Item.ItemAttributes.UPC);
                    item.Model = response.Items.Item.ItemAttributes.Model != null ? response.Items.Item.ItemAttributes.Model : "";

                    if (response.Items.Item.ItemAttributes.ListPrice != null)
                    {
                        item.ListPrice = response.Items.Item.ItemAttributes.ListPrice.FormattedPrice != null ? response.Items.Item.ItemAttributes.ListPrice.FormattedPrice : "";
                        item.ListPriceCurrency = response.Items.Item.ItemAttributes.ListPrice.CurrencyCode != null ? response.Items.Item.ItemAttributes.ListPrice.CurrencyCode : "";
                        item.ListPriceValue = response.Items.Item.ItemAttributes.ListPrice.Amount != null ? response.Items.Item.ItemAttributes.ListPrice.Amount : ulong.MinValue;
                    }
                }

                //if (response.Items.Item.OfferSummary != null)
                //{
                //    if (response.Items.Item.OfferSummary.LowestNewPrice != null)
                //    {
                //        item.ListPriceCurrency = response.Items.Item.OfferSummary.LowestNewPrice.CurrencyCode;
                //        item.ListPrice = response.Items.Item.OfferSummary.LowestNewPrice.FormattedPrice;
                //        item.ListPriceValue = response.Items.Item.OfferSummary.LowestNewPrice.Amount;
                //    }
                //}
            }

            if (response.Items != null && response.Items.Request != null && response.Items.Request.Errors != null)
            {
                item.ErrorCode = response.Items.Request.Errors.Error.Code != null ? response.Items.Request.Errors.Error.Code : "";
                item.ErrorMessage = response.Items.Request.Errors.Error.Message != null ? response.Items.Request.Errors.Error.Message : "";
            }

            // inefficient - change FetchItem
            item.ResultXML = SerializeObject(response);

            return item;
        }

        private ItemLookupResponse ExecuteItemLookup(IDictionary<string, string> query, string AWSAccessKeyId, string AWSSecretKey, string AWSMarketPlace)
        {
            String requestUrl;
            SignedRequestHelper helper = new SignedRequestHelper(AWSAccessKeyId, AWSSecretKey, AWSMarketPlace);

            requestUrl = helper.Sign(query);
            var item = FetchItem(requestUrl);

            return item;
        }


        private string SerializeObject(ItemLookupResponse toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        private ItemLookupResponse FetchItem(string url)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(url);
                WebResponse response = request.GetResponse();

                ItemLookupResponse item;

                XmlSerializer xs = new XmlSerializer(typeof(ItemLookupResponse));
                item = (ItemLookupResponse)xs.Deserialize(response.GetResponseStream());

                return item;

            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }

        
        // duplicate methods for search - needs cleaning up 

        private List<AmazonItemLookup> GetSearchResults()
        {
            var settings = new Settings(ServiceConfiguration);

            try
            {
                string searchindex = "All";
                if (!string.IsNullOrWhiteSpace(this.SearchIndex))
                {
                    searchindex = this.SearchIndex;
                }

                IDictionary<string, string> query = new Dictionary<string, String>();
                query["Service"] = "AWSECommerceService";
                query["AssociateTag"] = settings.AssoicateTag;
                query["Operation"] = "ItemSearch";
                query["Keywords"] = this.Keywords;
                query["SearchIndex"] = searchindex;
                query["ResponseGroup"] = "Images,ItemAttributes,Offers,OfferSummary";
                if (this.ItemPage > 0)
                {
                    query["ItemPage"] = this.ItemPage.ToString();
                }

                if (!string.IsNullOrWhiteSpace(this.Sort))
                {
                    query["Sort"] = this.Sort;
                }

                string condition = "All";
                if (!string.IsNullOrWhiteSpace(this.Condition))
                {
                    query["Condition"] = this.Condition;
                    condition = this.Condition;
                }

                var item = ExecuteItemSearch(query, settings.AWSAccessKeyId, settings.AWSSecretKey, settings.Marketplace);

                List<AmazonItemLookup> results = MapSearchProperties(item);
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        private List<AmazonItemLookup> MapSearchProperties(ItemSearchResponse response)
        {
            List<AmazonItemLookup> items = new List<AmazonItemLookup>();

            if (response.Items != null && response.Items.Request != null && response.Items.Request.Errors != null)
            {
                throw new Exception(response.Items.Request.Errors.Error.Code + " - " + response.Items.Request.Errors.Error.Message);
            }

            if (response.Items != null && response.Items.Item != null)
            {
                foreach (var resultItem in response.Items.Item)
                {
                    AmazonItemLookup item = new AmazonItemLookup();

                    item.Keywords = this.Keywords;
                    item.ItemPage = this.ItemPage;
                    item.Sort = this.Sort;
                    item.Condition = this.Condition;
                    item.SearchIndex = this.SearchIndex;


                    item.ASIN = resultItem.ASIN;
                    item.ParentASIN = resultItem.ParentASIN != null ? resultItem.ParentASIN : "";
                    item.DetailPageURL = resultItem.DetailPageURL != null ? resultItem.DetailPageURL : "";

                    if (resultItem.SmallImage != null)
                        item.SmallImageUrl = resultItem.SmallImage.URL != null ? resultItem.SmallImage.URL : "";

                    if (resultItem.MediumImage != null)
                        item.MediumImageUrl = resultItem.MediumImage.URL != null ? resultItem.MediumImage.URL : "";

                    if (resultItem.MediumImage != null)
                        item.LargeImageUrl = resultItem.LargeImage.URL != null ? resultItem.LargeImage.URL : "";

                    if (resultItem.ItemAttributes != null)
                    {
                        item.Manufacturer = resultItem.ItemAttributes.Manufacturer != null ? resultItem.ItemAttributes.Manufacturer : "";
                        item.ProductGroup = resultItem.ItemAttributes.ProductGroup != null ? resultItem.ItemAttributes.ProductGroup : "";
                        item.Title = resultItem.ItemAttributes.Title != null ? resultItem.ItemAttributes.Title : "";

                        if (resultItem.ItemAttributes.Feature != null && resultItem.ItemAttributes.Feature.Count() > 0)
                        {
                            item.FeatureDescription = resultItem.ItemAttributes.Feature != null ? string.Join(" ", resultItem.ItemAttributes.Feature) : "";
                        }

                        item.Model = resultItem.ItemAttributes.Model != null ? resultItem.ItemAttributes.Model : "";
                        item.UPC = Convert.ToInt64(resultItem.ItemAttributes.UPC);
                        item.ProductType = resultItem.ItemAttributes.ProductTypeName;
                        if (resultItem.ItemAttributes.ListPrice != null)
                        {
                            item.ListPrice = resultItem.ItemAttributes.ListPrice.FormattedPrice != null ? resultItem.ItemAttributes.ListPrice.FormattedPrice : "";
                            item.ListPriceCurrency = resultItem.ItemAttributes.ListPrice.CurrencyCode != null ? resultItem.ItemAttributes.ListPrice.CurrencyCode : "";
                            item.ListPriceValue = resultItem.ItemAttributes.ListPrice.Amount != null ? resultItem.ItemAttributes.ListPrice.Amount : ulong.MinValue;
                        }
                    }

                    //if (resultItem.OfferSummary != null)
                    //{
                    //    if (resultItem.OfferSummary.ListPrice != null)
                    //    {
                    //        item.ListPriceCurrency = resultItem.OfferSummary.ListPrice.CurrencyCode;
                    //        item.ListPrice = resultItem.OfferSummary.ListPrice.FormattedPrice;
                    //        item.ListPriceValue = resultItem.OfferSummary.ListPrice.Amount;
                    //    }
                    //}

                    // inefficient - change FetchItem
                    //item.ResultXML = SerializeObject(resultItem);

                    items.Add(item);
                }
            }

            return items;
        }

        private ItemSearchResponse ExecuteItemSearch(IDictionary<string, string> query, string AWSAccessKeyId, string AWSSecretKey, string AWSMarketPlace)
        {
            String requestUrl;
            SignedRequestHelper helper = new SignedRequestHelper(AWSAccessKeyId, AWSSecretKey, AWSMarketPlace);

            requestUrl = helper.Sign(query);
            var item = FetchSearchItem(requestUrl);

            return item;
        }


        private string SerializeSearchObject(ItemLookupResponse toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        private ItemSearchResponse FetchSearchItem(string url)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(url);
                WebResponse response = request.GetResponse();

                ItemSearchResponse item;

                XmlSerializer xs = new XmlSerializer(typeof(ItemSearchResponse));
                item = (ItemSearchResponse)xs.Deserialize(response.GetResponseStream());

                return item;

            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }
    }
}
