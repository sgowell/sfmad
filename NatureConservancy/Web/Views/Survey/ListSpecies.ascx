<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Web.Models.Species>>" %>

    <table>
        <tr>
            <th></th>
            <th>
                SpeciesAcronym
            </th>
            <th>
                ScientificName
            </th>
            <th>
                CommonName
            </th>
            <th>
                Id
            </th>
        </tr>

    <% foreach (var item in Web.Models.Species.AllSpecies ) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%= Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%= Html.Encode(item.SpeciesAcronym) %>
            </td>
            <td>
                <%= Html.Encode(item.ScientificName) %>
            </td>
            <td>
                <%= Html.Encode(item.CommonName) %>
            </td>
            <td>
                <%= Html.Encode(item.Id) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
      
    </p>


