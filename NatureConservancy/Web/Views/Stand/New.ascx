﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.Stand>" %>


    <form id="create_stand_form" runat="server">

    <h2>Create Stand</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.EcoSystem) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.EcoSystem) %>
                <%= Html.ValidationMessageFor(model => model.EcoSystem) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Treatment) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Treatment) %>
                <%= Html.ValidationMessageFor(model => model.Treatment) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>
    </form>
