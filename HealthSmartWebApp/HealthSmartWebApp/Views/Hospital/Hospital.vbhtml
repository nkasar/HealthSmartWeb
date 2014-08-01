@ModelType HospitalViewModel
@Code
    ViewData("Title") = "Hospital"
End Code

<h2>Hospital</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>HospitalViewModel</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.HospitalName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.HospitalName, New With {.class = "width: 400px"})
                @Html.ValidationMessageFor(Function(model) model.HospitalName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.HospitalSpeciality, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.HospitalSpeciality)
                @Html.ValidationMessageFor(Function(model) model.HospitalSpeciality)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.AddressLine1, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.AddressLine1)
                @Html.ValidationMessageFor(Function(model) model.AddressLine1)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.AddressLine2, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.AddressLine2)
                @Html.ValidationMessageFor(Function(model) model.AddressLine2)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.City, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.City)
                @Html.ValidationMessageFor(Function(model) model.City)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.State, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.State)
                @Html.ValidationMessageFor(Function(model) model.State)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.HandicapAccess, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.HandicapAccess)
                @Html.ValidationMessageFor(Function(model) model.HandicapAccess)
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
