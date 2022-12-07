using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    string rootPath = "";

    protected override void OnInit(EventArgs e)
    {
        rootPath = this.MapPath("");
        base.OnInit(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ASPxTreeList1.DataBind();
        ASPxGridView1.DataBind();
    }
    protected void ASPxGridView1_DataBinding(object sender, EventArgs e)
    {
        ASPxGridView grid = (ASPxGridView)sender;
        if (ASPxTreeList1.FocusedNode == null)
        {
            grid.DataSource = null;
        }
        else
        {
            string path = ASPxTreeList1.FocusedNode.Key;
            DirectoryInfo di = new DirectoryInfo(path);
            grid.DataSource = di.GetFiles();
        }
    }
    protected void ASPxTreeList1_VirtualModeCreateChildren(object sender, DevExpress.Web.ASPxTreeList.TreeListVirtualModeCreateChildrenEventArgs e)
    {
        string path = (e.NodeObject == null) ? rootPath : e.NodeObject.ToString();
        e.Children = Directory.GetDirectories(path);
    }
    protected void ASPxTreeList1_VirtualModeNodeCreated(object sender, DevExpress.Web.ASPxTreeList.TreeListVirtualNodeEventArgs e)
    {
    }
    protected void ASPxTreeList1_VirtualModeNodeCreating(object sender, DevExpress.Web.ASPxTreeList.TreeListVirtualModeNodeCreatingEventArgs e)
    {
        string path = (e.NodeObject == null) ? rootPath : e.NodeObject.ToString();
        e.NodeKeyValue = path;
        e.SetNodeValue("Name", Path.GetFileName(path));
    }
}
