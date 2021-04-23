using System;

namespace com.orthofeet.ViewModels.ShipStation
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public int OrderId { get; set; }
        public string OrderKey { get; set; }
        public Guid UserId { get; set; }
        public string CustomerEmail { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ShipDate { get; set; }
        public decimal ShipmentCost { get; set; }
        public decimal InsuranceCost { get; set; }
        public string TrackingNumber { get; set; }
        public bool IsReturnLabel { get; set; }
        public string BatchNumber { get; set; }
        public string CarrierCode { get; set; }
        public string ServiceCode { get; set; }
        public string PackageCode { get; set; }
        public string Confirmation { get; set; }
        public int WarehouseId { get; set; }
        public bool Voided { get; set; }
        public DateTime? VoidDate { get; set; }
        public bool MarketplaceNotified { get; set; }
        public string NotifyErrorMessage { get; set; }
        public Address ShipTo { get; set; }

        public Weight Weight { get; set; }
        public Dimension Dimensions { get; set; }
        public AdvancedShippingOptions AdvancedOptions { get; set; }
        public InsuranceOptions InsuranceOptions { get; set; }
    }

    public class InsuranceOptions
    {
        public string Provider { get; set; }
        public bool InsureShipment { get; set; }
        public decimal InsuredValue { get; set; }
    }

    public class AdvancedShippingOptions
    {
        public string BillToParty { get; set; }
        public string BillToAccount { get; set; }
        public string BillToPostalCode { get; set; }
        public string BillToCountryCode { get; set; }
        public int StoreId { get; set; }
    }

    public class Dimension
    {
        public decimal Units { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
    }

    public class Weight
    {
        public decimal Value { get; set; }
        public string Units { get; set; }
        public int WeightUnits { get; set; }
    }

    public class Address
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Street3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Residential { get; set; }
        public string AddressVerified { get; set; }
    }
}
/*
{"shipments":[{"shipmentId":582999587,"orderId":828120480,"orderKey":"3712565542983","userId":"81ee25b1-dbc6-4d71-b88a-aab56bfdcdb1","customerEmail":"its4mike@hotmail.com","orderNumber":"1595737","createDate":"2021-04-10T06:25:25.3830000","shipDate":"2021-04-10","shipmentCost":9.43,"insuranceCost":0.0,"trackingNumber":"785816451300","isReturnLabel":false,"batchNumber":null,"carrierCode":"fedex","serviceCode":"fedex_home_delivery","packageCode":null,"confirmation":null,"warehouseId":601612,"voided":false,"voidDate":null,"marketplaceNotified":false,"notifyErrorMessage":null,"shipTo":{"name":"Michael  Shernak ","company":"","street1":"60 WIGEON WAY","street2":"","street3":null,"city":"CRAWFORDVILLE","state":"FL","postalCode":"32327-1997","country":"US","phone":"(239) 240-5454","residential":null,"addressVerified":null},"weight":{"value":138.40,"units":"ounces","WeightUnits":1},"dimensions":{"units":"inches","length":15.25,"width":13.75,"height":10.00},"insuranceOptions":{"provider":null,"

 *			"shipmentId": 582999692,
			"orderId": 828254036,
			"orderKey": "3713153466439",
			"userId": "81ee25b1-dbc6-4d71-b88a-aab56bfdcdb1",
			"customerEmail": "tgrlnh@yahoo.com",
			"orderNumber": "1596822",
			"createDate": "2021-04-10T06:28:08.9030000",
			"shipDate": "2021-04-10",
			"shipmentCost": 9.87,
			"insuranceCost": 0.0,
			"trackingNumber": "785816489450",
			"isReturnLabel": false,
			"batchNumber": null,
			"carrierCode": "fedex",
			"serviceCode": "fedex_home_delivery",
			"packageCode": null,
			"confirmation": null,
			"warehouseId": 601612,
			"voided": false,
			"voidDate": null,
			"marketplaceNotified": false,
			"notifyErrorMessage": null,
			"shipTo": {
				"name": "Bobbie Mayo",
				"company": "",
				"street1": "56 MADISON CIR",
				"street2": "",
				"street3": null,
				"city": "HILLSBOROUGH",
				"state": "NH",
				"postalCode": "03244-5329",
				"country": "US",
				"phone": "(603) 721-9122",
				"residential": null,
				"addressVerified": null
			},
			"weight": {
				"value": 87.2,
				"units": "ounces",
				"WeightUnits": 1
			},
			"dimensions": {
				"units": "inches",
				"length": 14.5,
				"width": 10.25,
				"height": 11.0
			},
			"insuranceOptions": {
				"provider": null,
				"insureShipment": false,
				"insuredValue": 0.0
			},
			"advancedOptions": {
				"billToParty": "4",
				"billToAccount": null,
				"billToPostalCode": null,
				"billToCountryCode": null,
				"storeId": 88849
			},
 *
 */
