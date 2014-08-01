﻿@ModelType MedicationViewModel
@Code
    ViewData("Title") = "Add Medication"
End Code

<h2>Add Medication</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Please enter medication code and description.</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.MedicationID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MedicationID)
                @Html.ValidationMessageFor(Function(model) model.MedicationID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.MedicationDesc, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MedicationDesc)
                @Html.ValidationMessageFor(Function(model) model.MedicationDesc)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
