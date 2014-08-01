@ModelType IEnumerable(Of DiagnosisViewModel)
@Code
    ViewData("Title") = "Diagnosis List"
End Code

<h2>Diagnosis List</h2>

<p>
    @Html.ActionLink("Create New", "AddDiagnosis", "MasterData")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.DiagnosisCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DiagnosisDesc)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DiagnosisCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DiagnosisDesc)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.DiagnosisCode}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.DiagnosisCode}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.DiagnosisCode})
        </td>
    </tr>
Next

</table>
