<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.WoodyDebris>" %>

    <% using (Html.BeginForm("AddWoodyDebris", "Survey")) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.TotalLength) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.TotalLength) %>
                <%= Html.ValidationMessageFor(model => model.TotalLength) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.IntersectDiameter) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.IntersectDiameter) %>
                <%= Html.ValidationMessageFor(model => model.IntersectDiameter) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.LargeEndDiameter) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.LargeEndDiameter) %>
                <%= Html.ValidationMessageFor(model => model.LargeEndDiameter) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.SmallEndDiameter) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.SmallEndDiameter) %>
                <%= Html.ValidationMessageFor(model => model.SmallEndDiameter) %>
            </div>
            
            <p>
            
                
              <input name="Add" type="submit" value="Add" />
            </p>
        </fieldset>

    <% } %>


