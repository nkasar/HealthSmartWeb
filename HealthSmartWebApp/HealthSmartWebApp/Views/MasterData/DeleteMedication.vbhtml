@ModelType MedicationViewModel
@Code
    ViewData("Title") = "DeleteMedication"
End Code

<h2>Delete Medication</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Deleting Medication</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MedicationID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MedicationID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MedicationDesc)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MedicationDesc)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
