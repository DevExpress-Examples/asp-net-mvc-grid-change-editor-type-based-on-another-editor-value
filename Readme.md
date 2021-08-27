<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552131/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4825)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/WebSite/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/WebSite/Controllers/HomeController.vb))
* [Person.cs](./CS/WebSite/Models/Person.cs) (VB: [Person.vb](./VB/WebSite/Models/Person.vb))
* [PersonsList.cs](./CS/WebSite/Models/PersonsList.cs) (VB: [PersonsList.vb](./VB/WebSite/Models/PersonsList.vb))
* [MyScript.js](./CS/WebSite/Scripts/MyScript.js) (VB: [MyScript.js](./VB/WebSite/Scripts/MyScript.js))
* [GridViewPartial.cshtml](./CS/WebSite/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/WebSite/Views/Home/Index.cshtml)
<!-- default file list end -->
# MVC GridView - How to change an EditForm editor's type depending on another editor's value
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4825/)**
<!-- run online end -->


<p>This example demonstrates how to implement a scenario when an editor for a certain field changes its type (for example, from ComboBox to TextBox)  depending on the value in another editor.</p><p>Since it is impossible to bind two editors placed on one form to the same field (in this case, their Name property will be equal, which is forbidden), the HiddenField is used for storing values and transferring them to the server.</p>

<br/>


