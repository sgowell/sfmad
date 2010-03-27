<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.Microtopography>" %>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.MicrotopographyId) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.MicrotopographyId) %>
                <%= Html.ValidationMessageFor(model => model.MicrotopographyId) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Comments) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Comments) %>
                <%= Html.ValidationMessageFor(model => model.Comments) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>


