<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.Snag>" %>

    <% using (Html.BeginForm("AddSnags","Survey")) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Species ) %>
            </div>
            <div class="editor-field">
                <%=Html.TextBoxFor( model => model.Species ) %>
            </div>
                        
            <div class="editor-label">
                <%= Html.LabelFor(model => model.DiameterBreastHeight)%>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.DiameterBreastHeight)%>
                <%= Html.ValidationMessageFor(model => model.DiameterBreastHeight)%>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Height) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Height) %>
                <%= Html.ValidationMessageFor(model => model.Height) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.SnagDecayClass ) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.SnagDecayClass)%>
                <%= Html.ValidationMessageFor(model => model.SnagDecayClass)%>
            </div>
            
            <p>
                <input type="submit" value="Add" />
            </p>
        </fieldset>

    <% } %>

 


