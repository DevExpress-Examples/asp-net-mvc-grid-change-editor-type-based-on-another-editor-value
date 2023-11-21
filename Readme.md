<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552131/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4825)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid View for ASP.NET MVC - How to change an editor's type based on another editor's value
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4825/)**
<!-- run online end -->

This example demonstrates how to change the editor type for a certain field based on the value of another editor in the edit form. 

![](grid-edit-form.png)

## Implementation Details

In this example, the type of `LastName` column editor changes from _textbox_ to _combobox_ when the `FirstName` editor value equals `newperson`.

```jscript
﻿function onTextChanged(s, e) {
    if (s.GetText() == 'newperson') {
        cbEdit.SetVisible(true);
        txtEdit.SetVisible(false);
    } else {
        cbEdit.SetVisible(false);
        txtEdit.SetVisible(true);
    }
}
```

It is impossible to bind two editors placed on one form to the same field (in this case, their `Name` property will be equal, which is forbidden). This is why a hidden field is used to store values and transfer them to the server.

```jscript
function ChangeHiddenValue(s, e) { 
    var hidden = document.getElementById('LastName');
    hidden.value = cbEdit.GetVisible() ? cbEdit.GetText() : txtEdit.GetText();
}
```

## Files to Review

* [MyScript.js](./CS/WebSite/Scripts/MyScript.js) (VB: [MyScript.js](./VB/WebSite/Scripts/MyScript.js))
* [GridViewPartial.cshtml](./CS/WebSite/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/WebSite/Views/Home/Index.cshtml)
