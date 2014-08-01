@ModelType IEnumerable(Of AllergyViewModel)
@Code
ViewData("Title") = "AllergyList"
End Code

<h2>Allergy List</h2>

<p>
    @Html.ActionLink("Create New", "AddAllergy", "MasterData")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.AllergyCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AllergyDesc)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AllergyCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AllergyDesc)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
