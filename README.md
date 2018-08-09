# DLL-Exposed-over-endpoint-url

If you want to consume dotnet dll in java or any other language, you can't simply add or reference it.If you can expose dll over endpoint url, It will be possible to consume it using any programming language.<br>How?<br>
<br>
1.Create empty web application in ASP.NET CORE.<br>
2.Use App.Map() method like App.Map('/Dll',ActionMethod) in startup.cs<br>
3.Just call dll object,methods and return json result in ActionMethod.<br>
4.http://localhost:55845/Dll will give you json response and you consume it in any code.:) woho!!<br>

This is possible because of awesome middleware concept introduced in asp.net core and this is very useful when you are working with legacy code :) <br>
~Happy Coding:)

