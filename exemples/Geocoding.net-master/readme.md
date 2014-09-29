Generic C# GeoCoding API
========================

Includes a model and interface for communicating with three popular Geocoding providers.  Current implementations include:

  * [Google Maps](https://developers.google.com/maps/) - [docs](https://developers.google.com/maps/documentation/geocoding/)
  * [Yahoo! PlaceFinder](http://developer.yahoo.com/geo/placefinder/) - [docs](http://developer.yahoo.com/geo/placefinder/guide/index.html)
  * [Bing Maps (aka Virtual Earth)](http://www.microsoft.com/maps/) - [docs](http://msdn.microsoft.com/en-us/library/ff701715.aspx)

The API returns latitude/longitude coordinates and normalized address information.  This can be used to perform address validation, real time mapping of user-entered addresses, distance calculations, and much more.

See latest [release notes](https://github.com/chadly/Geocoding.net/wiki/Release-Notes).

### Simple Example

```c#
IGeoCoder geoCoder = new GoogleGeoCoder("my-api-key");
Address[] addresses = geoCoder.GeoCode("123 Main St");
```

It can also be used to return address information from latitude/longitude coordinates (aka reverse geocoding):

```c#
IGeoCoder geoCoder = new YahooGeoCoder("my-app-ID");
Address[] addresses = geoCoder.ReverseGeoCode(38.8976777, -77.036517);
```

How to Build from Source
------------------------

In order to compile the solution in Visual Studio, you must first run build.bat. This will run a basic Debug build without running any tests. The build process generates some files that are needed to compile in Visual Studio.

### Service Tests
You will need to generate API keys for each respective service to run the service tests. Edit App.config in the Tests project and put in your API keys.