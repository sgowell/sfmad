<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.DeerHerbivory>" %>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Id) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Id) %>
                <%= Html.ValidationMessageFor(model => model.Id) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Browsed) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Browsed) %>
                <%= Html.ValidationMessageFor(model => model.Browsed) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Unbrowsed) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Unbrowsed) %>
                <%= Html.ValidationMessageFor(model => model.Unbrowsed) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>


