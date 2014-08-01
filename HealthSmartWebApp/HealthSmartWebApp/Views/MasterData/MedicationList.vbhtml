@ModelType IEnumerable(Of MedicationViewModel)
@Code
ViewData("Title") = "MedicationList"
End Code

<h2>Medication List</h2>

<p>
    @Html.ActionLink("Create New", "AddMedication")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.MedicationID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MedicationDesc)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MedicationID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MedicationDesc)
        </td>
        <td>
            @Html.ActionLink("Delete", "DeleteMedication", New With {.MedicationID = item.MedicationID, .MedicationDesc = item.MedicationDesc})
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
