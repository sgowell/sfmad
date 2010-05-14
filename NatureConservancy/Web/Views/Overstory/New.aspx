<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	New
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <h2>Create Overstory</h2>

    <table>
        <thead>
            <th>Tree species</th>
            <th>Intersect Diameter</th>
            <th>Large End Diameter</th>
            <th>Small End Diameter</th>
            <th>Actions</th>
        </thead>
    <% foreach (var item in Model) { %>
    
        <tr>            
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
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%= Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
    <%=Html.Partial("AddWoodyDebris", new WoodyDebris()) %>
       
    </p>
    <%= Html.ActionLink("Proceed to Next Section", "CreateOverstory") %>
</asp:Content>
