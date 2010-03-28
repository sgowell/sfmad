<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Web.Models.Snag>>" %>
<%@ Import Namespace="Web.Models"%>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create Snag
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create Snag</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Diameter Breast Height
            </th>
            <th>
                Height
            </th>            
        </tr>

    <% foreach (var item in new List<Snag>()) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%= Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.DiameterBreastHeight)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.Height)) %>
            </td>           
        </tr>
    
    <% } %>

    </table>

    <p>
    <%=Html.Partial("AddSnags", new Snag()) %>
       
    </p>
    <%= Html.ActionLink("Proceed to Next Section", "Microtopography", "New") %>
</asp:Content>

