﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.Survey>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Bearing) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Bearing) %>
                <%= Html.ValidationMessageFor(model => model.Bearing) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.TransectClass) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.TransectClass) %>
                <%= Html.ValidationMessageFor(model => model.TransectClass) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.TransectNumber) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.TransectNumber) %>
                <%= Html.ValidationMessageFor(model => model.TransectNumber) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.SurveyStartTime) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.SurveyStartTime) %>
                <%= Html.ValidationMessageFor(model => model.SurveyStartTime) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.SurveyEndTime) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.SurveyEndTime) %>
                <%= Html.ValidationMessageFor(model => model.SurveyEndTime) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Surveyors) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Surveyors) %>
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

