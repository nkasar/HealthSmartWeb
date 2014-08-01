@ModelType IEnumerable(Of PhysicianViewModel)
@Code
ViewData("Title") = "PhysicianList"
End Code

<h2>Physician List</h2>

<p>
    @Html.ActionLink("Create New", "AddPhysician")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.PhysicianID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PhysicianLastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PhysicianFirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddressLine1)
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
            @Html.DisplayNameFor(Function(model) model.HomePhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BusinessPhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmailAddress)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PhysicianID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PhysicianLastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PhysicianFirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AddressLine1)
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
            @Html.DisplayFor(Function(modelItem) item.HomePhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.BusinessPhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmailAddress)
        </td>
         <td>
             @Html.ActionLink("Edit", "EditPhysician", New With {.PhysicianID = item.PhysicianID, .LastName = item.PhysicianLastName, .FirstName = item.PhysicianFirstName}) |
             @Html.ActionLink("Create Login", "Register", New With {.userID = item.PhysicianID, .userType = "P"}) |
             @Html.ActionLink("Delete", "Delete", New With {.PhysicianID = item.PhysicianID})

         </td>
    </tr>
Next

</table>
