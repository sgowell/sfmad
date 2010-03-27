<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Stand>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateStand
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

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

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>
    
  

    </form>

</asp:Content>

