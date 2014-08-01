@ModelType PatientViewModel
@Code
    ViewData("Title") = "Edit Patient"
End Code

<h2>Edit Patient Information</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Please enter following information to update patient</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.LastName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.LastName)
                @Html.ValidationMessageFor(Function(model) model.LastName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.FirstName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.FirstName)
                @Html.ValidationMessageFor(Function(model) model.FirstName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Gender, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Gender)
                @Html.ValidationMessageFor(Function(model) model.Gender)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DOB, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DOB)
                @Html.ValidationMessageFor(Function(model) model.DOB)
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
