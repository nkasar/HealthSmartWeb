@ModelType IEnumerable(Of InsuranceViewModel)
@Code
    ViewData("Title") = "Insurance Companies"
End Code

<h2>Insurance Companies</h2>

<p>
    @Html.ActionLink("Create New", "AddInsurance", "MasterData")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CompanyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContactPersonName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddressLine1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddressLine2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.City)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.State)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PinCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BusinessPhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FaxNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmailAddress)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CompanyName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContactPersonName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AddressLine1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AddressLine2)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.City)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.State)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PinCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.BusinessPhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FaxNumber)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmailAddress)
        </td>
        <td>
            @Html.ActionLink("Edit", "EditInsurance", New With {.id = item.InsuranceCompanyID}) |
            @Html.ActionLink("Delete", "DeleteInsurance", New With {.id = item.InsuranceCompanyID})
        </td>
    </tr>
Next

</table>
