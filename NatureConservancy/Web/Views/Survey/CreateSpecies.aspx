<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Species>" %>

<%@ Register src="ListSpecies.ascx" tagname="ListSpecies" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateSpecies
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>CreateSpecies</h2>

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
                <%= Html.LabelFor(model => model.Acronym) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Acronym) %>
                <%= Html.ValidationMessageFor(model => model.Acronym) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.ScientificName) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.ScientificName) %>
                <%= Html.ValidationMessageFor(model => model.ScientificName) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.CommonName) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.CommonName) %>
                <%= Html.ValidationMessageFor(model => model.CommonName) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
        
    </div>
    </form>
    
     <div>
    <uc1:ListSpecies ID="ListSpecies1" runat="server" />
    </div>

</asp:Content>

