<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1126)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/E1126/Default.aspx) (VB: [Default.aspx](./VB/E1126/Default.aspx))
* [Default.aspx.cs](./CS/E1126/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/E1126/Default.aspx.vb))
<!-- default file list end -->
# How to synchronize ASPxTreeList and ASPxGridView similar to Windows Explorer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1126/)**
<!-- run online end -->


<p>To accomplish this task, handle the client-side ASPxClientTreeList.FocusedNodeChanged event, and call the ASPxClientGridView.Refresh method. The ASPxGridView.DataBinding event is handled to assign a datasource created based on the currently focused ASPxTreeList node.</p>

<br/>


