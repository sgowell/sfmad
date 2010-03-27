<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.OverStory>" %>

<%@ Register src="AddSnags.ascx" tagname="AddSnags" tagprefix="uc1" %>

<%@ Register src="ListSnags.ascx" tagname="ListSnags" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateOverStory
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   

    <form id="form1" runat="server">

   

    <h2>CreateOverStory</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Notes) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Notes) %>
                <%= Html.ValidationMessageFor(model => model.Notes) %>
            </div>
            
            <p>
                &nbsp;</p>
        </fieldset>
        <div>
            
            <uc2:ListSnags ID="ListSnags1" runat="server" />
            
        </div>
<div>

    <uc1:AddSnags ID="AddSnags1" runat="server" />

</div>

   <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
        <%= Html.ActionLink("Create Microtopography","CreateMicrotopography") %>
                <input type="submit" value="Create" /></div>

    

    </form>

    

</asp:Content>

