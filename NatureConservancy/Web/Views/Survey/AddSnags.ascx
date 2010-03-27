<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.Snag>" %>

    <% using (Html.BeginForm("AddSnags","Survey")) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.SnagId) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.SnagId) %>
                <%= Html.ValidationMessageFor(model => model.SnagId) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.DBH) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.DBH) %>
                <%= Html.ValidationMessageFor(model => model.DBH) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Height) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Height) %>
                <%= Html.ValidationMessageFor(model => model.Height) %>
            </div>
            
            <p>
                <input type="submit" value="Add" />
            </p>
        </fieldset>

    <% } %>

 


