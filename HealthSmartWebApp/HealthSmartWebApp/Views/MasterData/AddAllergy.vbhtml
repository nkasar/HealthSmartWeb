@ModelType AllergyViewModel
@Code
    ViewData("Title") = "Add Allergy"
End Code

<h2>Add Allergy</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Please enter allergy code and description</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.AllergyCode, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.AllergyCode)
                @Html.ValidationMessageFor(Function(model) model.AllergyCode)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.AllergyDesc, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.AllergyDesc)
                @Html.ValidationMessageFor(Function(model) model.AllergyDesc)
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
