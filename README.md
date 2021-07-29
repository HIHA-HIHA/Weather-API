# Weather API C#
 API for Open Weather API 
 
 usage:
need lib Newtonsoft.Json
 
```c#
using WeahterAPI;

namespace SomeNameSpace
{
	class SomeClass
	{
		void SomeMethod()
		{
			// it exampel
			API.apiKey = "Some api key"; // api key for api OpenWeatherAPI
			API.Language = "ru"; // or en, or ja...
			API.NameCity = "Some name city";
			API.Units = "metric"; // or imperial
			
			Response response = await API.GetInfoAboutCity();
			
			string NameCity = response.NameCity;
			string temperature = response.MainInformation.Temperature;
			
			// some code.
			
			
		}
	}
}

```
  
