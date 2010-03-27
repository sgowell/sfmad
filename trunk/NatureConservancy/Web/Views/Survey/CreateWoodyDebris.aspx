<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.WoodyDebris>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateWoodyDebris
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>CreateWoodyDebris</h2>

    <% using (Html.BeginForm()) {%>
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
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

