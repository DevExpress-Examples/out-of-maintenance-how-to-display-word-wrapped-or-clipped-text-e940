<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WordWrapClippingAndEllipsis._Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <dxwgv:GridViewDataMemoColumn FieldName="WordWrap" VisibleIndex="0" Width="150px">
                </dxwgv:GridViewDataMemoColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Clipped" VisibleIndex="1" Width="150px">
                    <DataItemTemplate>
                        <div style="overflow:hidden;white-space:nowrap;text-overflow:clip"><%# Eval("Clipped") %></div>
                    </DataItemTemplate>
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Ellipsis" VisibleIndex="2" Width="150px">
                    <DataItemTemplate>
                        <div style="overflow:hidden;white-space:nowrap;text-overflow:ellipsis"><%# Eval("Ellipsis") %></div>
                    </DataItemTemplate>
                </dxwgv:GridViewDataTextColumn>
            </Columns>
            <SettingsBehavior ColumnResizeMode="Control" />
        </dxwgv:ASPxGridView>
    </div>
    </form>
</body>
</html>
