<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table><tr><td valign="top">
        <dxwtl:ASPxTreeList ID="ASPxTreeList1" runat="server" ClientSideEvents-FocusedNodeChanged='<%# "function(s,e){"+ASPxGridView1.ClientID+".Refresh();}" %>' AutoGenerateColumns="False" OnVirtualModeCreateChildren="ASPxTreeList1_VirtualModeCreateChildren" OnVirtualModeNodeCreated="ASPxTreeList1_VirtualModeNodeCreated" OnVirtualModeNodeCreating="ASPxTreeList1_VirtualModeNodeCreating">
            <SettingsBehavior AllowFocusedNode="True" />
            <Columns>
                <dxwtl:TreeListTextColumn FieldName="Name" VisibleIndex="0">
                </dxwtl:TreeListTextColumn>
            </Columns>
            <SettingsPager Mode="ShowPager">
            </SettingsPager>
            <Settings GridLines="Horizontal" />
        </dxwtl:ASPxTreeList>
    </td><td valign="top">
        <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" KeyFieldName="FullName" OnDataBinding="ASPxGridView1_DataBinding" Width="100%">
            <Columns>
                <dxwgv:GridViewDataTextColumn FieldName="Name" VisibleIndex="0">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Length" VisibleIndex="1">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="LastWriteTime" VisibleIndex="2">
                </dxwgv:GridViewDataTextColumn>
            </Columns>
        </dxwgv:ASPxGridView>
    </td></tr></table>
    
    </div>
    </form>
</body>
</html>
