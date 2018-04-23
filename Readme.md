# MVC GridView - How to change an EditForm editor's type depending on another editor's value


<p>This example demonstrates how to implement a scenario when an editor for a certain field changes its type (for example, from ComboBox to TextBox)  depending on the value in another editor.</p><p>Since it is impossible to bind two editors placed on one form to the same field (in this case, their Name property will be equal, which is forbidden), the HiddenField is used for storing values and transferring them to the server.</p>

<br/>


