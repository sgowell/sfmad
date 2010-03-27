<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Microtopography>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateMicrotopography
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>CreateMicrotopography</h2>

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

</asp:Content>

