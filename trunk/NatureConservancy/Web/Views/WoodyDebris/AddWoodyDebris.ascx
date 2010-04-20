<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Web.Models.WoodyDebris>" %>
<%@ Import Namespace="Web" %>
    <% using (Html.BeginForm("New", "WoodyDebris", new {surveyId = ViewData["SurveyId"]})) {%>
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
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.DecayClass)%>                 
            </div>
            <div class="editor-field">
                <%= Html.DropDownListFor(model => model.DecayClass, Model.DecayClass.ToSelectList())%>
                <%= Html.ValidationMessageFor(model => model.DecayClass )%>
            </div>
                
            <p>                           
                <input name="Add" type="submit" value="Add" />
            </p>
        </fieldset>

    <% } %>


