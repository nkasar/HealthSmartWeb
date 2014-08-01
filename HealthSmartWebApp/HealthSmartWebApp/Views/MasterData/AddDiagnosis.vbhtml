@ModelType DiagnosisViewModel
@Code
    ViewData("Title") = "AddDiagnosis"
End Code

<h2>Add Diagnosis</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Please enter diagnosis code and description. Diagnosis code will be used for insurance claim</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.DiagnosisCode, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DiagnosisCode)
                @Html.ValidationMessageFor(Function(model) model.DiagnosisCode)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DiagnosisDesc, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DiagnosisDesc)
                @Html.ValidationMessageFor(Function(model) model.DiagnosisDesc)
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
