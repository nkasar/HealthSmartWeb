@ModelType PatientDiagnosisViewModel
@Code
    ViewData("Title") = "AddPatientDiagnosis"
End Code

<h2>AddPatientDiagnosis</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>PatientDiagnosisViewModel</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.PatientID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PatientID)
                @Html.ValidationMessageFor(Function(model) model.PatientID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PatientName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PatientName)
                @Html.ValidationMessageFor(Function(model) model.PatientName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DiagCategoryCode, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DiagCategoryCode)
                @Html.ValidationMessageFor(Function(model) model.DiagCategoryCode)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DiagCode, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownListFor(Function(model) model.DiagCode, New SelectList(Model.DiagnosisList, "DiagnosisCode", "DiagnosisDesc"))
                @Html.ValidationMessageFor(Function(model) model.DiagCode)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DiagDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DiagDate)
                @Html.ValidationMessageFor(Function(model) model.DiagDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Notes, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Notes)
                @Html.ValidationMessageFor(Function(model) model.Notes)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PhysicianID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PhysicianID)
                @Html.ValidationMessageFor(Function(model) model.PhysicianID)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Prescribe Medication" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
