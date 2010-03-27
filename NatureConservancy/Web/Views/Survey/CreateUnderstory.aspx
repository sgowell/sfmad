<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Understory>" %>

<%@ Register src="AddDeerHerbivory.ascx" tagname="AddDeerHerbivory" tagprefix="uc1" %>
<%@ Register src="AddUnderstoryItem.ascx" tagname="AddUnderstoryItem" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateUnderstory
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">

    <h2>CreateUnderstory</h2>

  
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Note) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Note) %>
                <%= Html.ValidationMessageFor(model => model.Note) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>


<div>

    <uc2:AddUnderstoryItem ID="AddUnderstoryItem1" runat="server" />

</div>
<div>

    <uc1:AddDeerHerbivory ID="AddDeerHerbivory1" runat="server" />

</div>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>

    </form>

</asp:Content>

