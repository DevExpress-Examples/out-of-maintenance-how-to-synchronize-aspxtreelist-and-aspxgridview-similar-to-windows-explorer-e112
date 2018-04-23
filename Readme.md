# How to synchronize ASPxTreeList and ASPxGridView similar to Windows Explorer


<p>To accomplish this task, handle the client-side ASPxClientTreeList.FocusedNodeChanged event, and call the ASPxClientGridView.Refresh method. The ASPxGridView.DataBinding event is handled to assign a datasource created based on the currently focused ASPxTreeList node.</p>

<br/>


