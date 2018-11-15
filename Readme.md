<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/E1126/Default.aspx) (VB: [Default.aspx.vb](./VB/E1126/Default.aspx.vb))
* [Default.aspx.cs](./CS/E1126/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/E1126/Default.aspx.vb))
<!-- default file list end -->
# How to synchronize ASPxTreeList and ASPxGridView similar to Windows Explorer


<p>To accomplish this task, handle the client-side ASPxClientTreeList.FocusedNodeChanged event, and call the ASPxClientGridView.Refresh method. The ASPxGridView.DataBinding event is handled to assign a datasource created based on the currently focused ASPxTreeList node.</p>

<br/>


