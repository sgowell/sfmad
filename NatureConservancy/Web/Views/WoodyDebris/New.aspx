<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Web.Models.WoodyDebris>>" %>
<%@ Import Namespace="Web.Models"%>

<%@ Register src="AddWoodyDebris.ascx" tagname="AddWoodyDebris" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateWoodyDebris
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <h2>CreateWoodyDebris</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Total Length
            </th>
            <th>
                Intersect Diameter
            </th>
            <th>
                Large End Diameter
            </th>
            <th>
                Small End Diameter
            </th>
        </tr>

    <% foreach (var item in new List<WoodyDebris>()) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%= Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.TotalLength)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.IntersectDiameter)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.LargeEndDiameter)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.SmallEndDiameter)) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <uc1:AddWoodyDebris ID="AddWoodyDebris1" runat="server" />
    </p>
    <%= Html.ActionLink("Proceed to Next Section", "CreateOverstory") %>
</asp:Content>

