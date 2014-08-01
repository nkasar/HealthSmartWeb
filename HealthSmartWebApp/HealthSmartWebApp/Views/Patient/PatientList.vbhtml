@ModelType IEnumerable(Of PatientViewModel)
@Code
ViewData("Title") = "PatientList"
End Code

<h2>Patient List</h2>

<p>
    @Html.ActionLink("Register a patient", "AddPatient", "Patient")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.PatientID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Gender)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DOB)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
         <td>
             @Html.DisplayFor(Function(modelItem) item.PatientID)
         </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Gender)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DOB)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PatientID, .PatientName = item.FirstName & " " & item.LastName}) |
            @Html.ActionLink("Insurance Details", "AddPatientInsurance", New With {.PatientID = item.PatientID, .PatientName = item.FirstName & " " & item.LastName}) |
            @Html.ActionLink("Checkup", "AddPatientDiagnosis", New With {.PatientID = item.PatientID, .PatientName = item.FirstName & " " & item.LastName}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PatientID})
        
         </td>
    </tr>
Next

</table>
