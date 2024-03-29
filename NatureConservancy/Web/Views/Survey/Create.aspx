<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Survey>" %>
<%@ Import Namespace="Web.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Enter your Survey Details</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>General Info</legend>
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Transect.Stand.Site.EcoRegion ) %>
                 <a href="" class="ecoregionLink" title="Add New EcoRegion" name="ecoregion">New</a>
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.Transect.Stand.Site.EcoRegion.Name,
                                        new List<SelectListItem>(), new Dictionary<string, object> { { "class", "ecoregion-dropdown" } })%>
                <%= Html.ValidationMessageFor(model => model.Transect.Stand.Site.EcoRegion.Name )%>
            </div>
             <div class="editor-label">
                <%= Html.LabelFor(model => model.Transect.Stand.Site) %>
                <a href="" class="siteLink" title="Add New Site" name="site">New</a>
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.Transect.Stand.Site.Name, 
                    new List<SelectListItem>(), new Dictionary<string, object> {{"class", "site-dropdown"}})%>
                <%= Html.ValidationMessageFor(model => model.Transect.Stand.Site.Name)%>
            </div>
  
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Bearing) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Bearing) %>
                <%= Html.ValidationMessageFor(model => model.Bearing) %>
            </div>
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Date) %>
            </div>
            <div class="editor-field datepicker">
                <%= Html.TextBoxFor(model => model.Date) %>
                <%= Html.ValidationMessageFor(model => model.Date) %>
            </div>            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.StartTime) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.StartTime) %>
                <%= Html.ValidationMessageFor(model => model.StartTime) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.EndTime) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.EndTime) %>
                <%= Html.ValidationMessageFor(model => model.EndTime) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Surveyors) %>
            </div>
            <div class="editor-field">
                <%= Html.TextAreaFor( model => model.Surveyors,6,100,null) %>
                <%= Html.ValidationMessageFor(model => model.Surveyors) %>
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

