<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Site>" %>



<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateSite
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>Create Site</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.SiteName) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.SiteName) %>
                <%= Html.ValidationMessageFor(model => model.SiteName) %>
            </div>
            
            
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
       
    </div>
    <div>
        
    </div>

    </form>

</asp:Content>

