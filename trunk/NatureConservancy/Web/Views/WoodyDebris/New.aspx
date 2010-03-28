<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Web.Models.WoodyDebris>>" %>
<%@ Import Namespace="Web.Models"%>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Enter Woody Debris Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <h2>CreateWoodyDebris</h2>

    <table>


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
    <%=Html.Partial("AddWoodyDebris", new WoodyDebris()) %>
       
    </p>
    <%= Html.ActionLink("Proceed to Next Section", "CreateOverstory") %>
</asp:Content>

