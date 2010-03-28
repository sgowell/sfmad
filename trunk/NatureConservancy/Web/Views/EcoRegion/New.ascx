<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.EcoRegion>" %>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

            <div class="editor-label">
                <%= Html.LabelFor(model => model.RegionNumber) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.RegionNumber) %>
                <%= Html.ValidationMessageFor(model => model.RegionNumber) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Name) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Name) %>
                <%= Html.ValidationMessageFor(model => model.Name) %>
            </div>
            
  
 

    <% } %>


