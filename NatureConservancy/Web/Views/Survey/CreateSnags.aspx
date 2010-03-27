<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Snag>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateSnags
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>CreateSnags</h2>

    <% using (Html.BeginForm()) {%>
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
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

