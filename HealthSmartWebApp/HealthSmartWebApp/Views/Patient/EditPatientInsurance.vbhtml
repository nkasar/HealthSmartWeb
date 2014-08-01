@ModelType PatientInsuranceViewModel
@Code
    ViewData("Title") = "EditPatientInsurance"
End Code

<h2>EditPatientInsurance</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>PatientInsuranceViewModel</h4>
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
            @Html.LabelFor(Function(model) model.InsuranceCompanyID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.InsuranceCompanyID)
                @Html.ValidationMessageFor(Function(model) model.InsuranceCompanyID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.InsuranceNumber, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.InsuranceNumber)
                @Html.ValidationMessageFor(Function(model) model.InsuranceNumber)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PolicyNumber, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PolicyNumber)
                @Html.ValidationMessageFor(Function(model) model.PolicyNumber)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.FromDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.FromDate)
                @Html.ValidationMessageFor(Function(model) model.FromDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CoverageAmount, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CoverageAmount)
                @Html.ValidationMessageFor(Function(model) model.CoverageAmount)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
