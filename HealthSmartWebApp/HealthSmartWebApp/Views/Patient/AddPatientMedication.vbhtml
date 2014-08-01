@ModelType PatientMedicationViewModel
@Code
    ViewData("Title") = "AddPatientMedication"
End Code

<h2>AddPatientMedication</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>PatientMedicationViewModel</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.PatientID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PatientID)
                @Html.ValidationMessageFor(Function(model) model.PatientID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PatientName, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PatientName)
                @Html.ValidationMessageFor(Function(model) model.PatientName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.MedicationID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownListFor(Function(model) model.MedicationID, New SelectList(Model.MedicationList, "MedicationID", "MedicationDesc"))
                @Html.ValidationMessageFor(Function(model) model.MedicationID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.MedicationDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.MedicationDate)
                @Html.ValidationMessageFor(Function(model) model.MedicationDate)
            </div>
        </div>

         <div class="form-group">
             @Html.LabelFor(Function(model) model.NoOfTimesDay, New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @Html.EditorFor(Function(model) model.NoOfTimesDay)
                 @Html.ValidationMessageFor(Function(model) model.NoOfTimesDay)
             </div>
         </div>

         <div class="form-group">
             @Html.LabelFor(Function(model) model.NoOfDays, New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @Html.EditorFor(Function(model) model.NoOfDays)
                 @Html.ValidationMessageFor(Function(model) model.NoOfDays)
             </div>
         </div>

         <div class="form-group">
             @Html.LabelFor(Function(model) model.Dosage, New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 @Html.EditorFor(Function(model) model.Dosage)
                 @Html.ValidationMessageFor(Function(model) model.Dosage)
             </div>
         </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Notes, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.TextAreaFor(Function(model) model.Notes)
                @Html.ValidationMessageFor(Function(model) model.Notes)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PhysicianID, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PhysicianID)
                @Html.ValidationMessageFor(Function(model) model.PhysicianID)
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
    @Html.ActionLink("Back to List", "Index")
</div>
