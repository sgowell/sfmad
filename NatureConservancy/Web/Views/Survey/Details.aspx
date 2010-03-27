<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NatureConservatory.Survey>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Bearing</div>
        <div class="display-field"><%= Html.Encode(Model.Bearing) %></div>
        
        <div class="display-label">TransectClass</div>
        <div class="display-field"><%= Html.Encode(Model.TransectClass) %></div>
        
        <div class="display-label">TransectNumber</div>
        <div class="display-field"><%= Html.Encode(Model.TransectNumber) %></div>
        
        <div class="display-label">SurveyStartTime</div>
        <div class="display-field"><%= Html.Encode(String.Format("{0:g}", Model.SurveyStartTime)) %></div>
        
        <div class="display-label">SurveyEndTime</div>
        <div class="display-field"><%= Html.Encode(String.Format("{0:g}", Model.SurveyEndTime)) %></div>
        
    </fieldset>
    <p>
        <%= Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%= Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

