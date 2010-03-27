<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Web.Models.Snag>>" %>
<%@ Import Namespace="Web.Models"%>

    <table>
        <tr>
            <th>
                Species
            </th>
            <th>
                DBH
            </th>
            <th>
                Height
            </th>
            <th>
                Decay Class
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
                <%= Html.Encode(String.Format("{0}", item.Species)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.DBH)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.Height)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0}", item.SnagDecayClass )) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    


