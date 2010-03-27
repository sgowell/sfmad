<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.OverStory>" %>

<%@ Register src="AddSnags.ascx" tagname="AddSnags" tagprefix="uc1" %>
<%@ Register src="AddMicrotopography.ascx" tagname="AddMicrotopography" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateOverStory
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>CreateOverStory</h2>

   
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
                <input type="submit" value="Create" />
            </p>
        </fieldset>
<div>

    <uc1:AddSnags ID="AddSnags1" runat="server" />

</div>
<div>

    <uc2:AddMicrotopography ID="AddMicrotopography1" runat="server" />

</div>
   

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>

    </form>

</asp:Content>

