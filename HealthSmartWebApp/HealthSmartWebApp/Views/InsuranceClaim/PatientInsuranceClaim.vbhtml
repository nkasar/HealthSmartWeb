@ModelType IEnumerable(Of PatientInsuranceClaimViewModel)
@Code
    ViewData("Title") = "Patient Insurance Claim"
End Code

<h2>Process Patient Insurance Claim</h2>

<div>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.PatientID)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.PatientName)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.InsuranceCompanyName)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.InsuranceNumber)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.PolicyNumber)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.DiagnosisCode)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.DiagnosisDate)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Charge)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.PatientID)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.PatientName)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.InsuranceCompanyName)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.InsuranceNumber)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.PolicyNumber)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.DiagnosisCode)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.DiagnosisDate)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Charge)
                </td>
                 <td>
                     @Html.ActionLink("Process Claim", "ProcessPatientInsuranceClaim", New With {.PatientID = item.PatientID, .DiagnosisDate = item.DiagnosisDate}) |
                 </td>
            </tr>
Next

    </table>

</div>

