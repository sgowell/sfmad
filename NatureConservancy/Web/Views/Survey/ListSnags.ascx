<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Web.Models.Snag>>" %>

    <table>
        <tr>
            <th></th>
            <th>
                SnagId
            </th>
            <th>
                DBH
            </th>
            <th>
                Height
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%= Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%= Html.Encode(item.SnagId) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.DBH)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.Height)) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    


