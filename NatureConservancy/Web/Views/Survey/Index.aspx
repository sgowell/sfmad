<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<NatureConservatory.Survey>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Bearing
            </th>
            <th>
                TransectClass
            </th>
            <th>
                TransectNumber
            </th>
            <th>
                SurveyStartTime
            </th>
            <th>
                SurveyEndTime
            </th>
        </tr>

<%--    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%= Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%= Html.Encode(item.Bearing) %>
            </td>
            <td>
                <%= Html.Encode(item.TransectClass) %>
            </td>
            <td>
                <%= Html.Encode(item.TransectNumber) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}", item.SurveyStartTime)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}", item.SurveyEndTime)) %>
            </td>
        </tr>
    
    <% } %>

    </table>--%>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

