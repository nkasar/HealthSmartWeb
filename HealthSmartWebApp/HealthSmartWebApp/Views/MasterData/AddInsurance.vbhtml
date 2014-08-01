@ModelType InsuranceViewModel
@Code
    ViewData("Title") = "Add Insurance"
End Code

<h2>Add Insurance</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Please enter followimg insurance company details</h4>
        <hr />
        @Html.ValidationSummary(true)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CompanyName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CompanyName)
                @Html.ValidationMessageFor(Function(model) model.CompanyName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ContactPersonName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ContactPersonName)
                @Html.ValidationMessageFor(Function(model) model.ContactPersonName)
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
            @Html.LabelFor(Function(model) model.PinCode, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PinCode)
                @Html.ValidationMessageFor(Function(model) model.PinCode)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.BusinessPhone, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.BusinessPhone)
                @Html.ValidationMessageFor(Function(model) model.BusinessPhone)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.FaxNumber, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.FaxNumber)
                @Html.ValidationMessageFor(Function(model) model.FaxNumber)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.EmailAddress, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.EmailAddress)
                @Html.ValidationMessageFor(Function(model) model.EmailAddress)
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
    @Html.ActionLink("Back to List", "InsuranceList","MasterData")
</div>
