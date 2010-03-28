<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.UnderstoryItem>" %>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Tally) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Tally) %>
                <%= Html.ValidationMessageFor(model => model.Tally) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>


