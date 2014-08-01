Imports System.Web.Mvc
Imports System.Data
Imports System.Data.Entity.Core.Objects
Imports System.Threading.Tasks


Public Class PatientController
    Inherits Controller
    Dim db As HealthSmartEntities

    Sub New()
        db = New HealthSmartEntities()
    End Sub

    ' GET: /Patient
    Function PatientList() As ActionResult
        Dim patList As List(Of PatientViewModel)
        patList = New List(Of PatientViewModel)
        If db Is Nothing Then
            db = New HealthSmartEntities()
        End If
        For Each patient As Patient In db.Patients
            Dim p As PatientViewModel = New PatientViewModel()
            p.PatientID = patient.PatientID
            p.FirstName = patient.FirstName
            p.LastName = patient.LastName
            p.DOB = patient.DOB
            patList.Add(p)
        Next
        Return View(patList)
    End Function
    ' GET: /Patient
    Function AddPatient() As ActionResult
        Return View()
    End Function
    '
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function AddPatient(model As PatientViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                Dim patientID As ObjectParameter = New ObjectParameter("PatientID", GetType(Int32))
                Dim patID As Integer = db.usp_AddPatient(model.LastName, model.FirstName, Nothing, model.DOB, model.Gender, Nothing, "A", Nothing, Nothing, Nothing, Nothing, Nothing, patientID)

                If patientID.Value IsNot Nothing Then

                    Return RedirectToAction("AddPatientInsurance", "Patient", New With {
                .PatientID = patientID.Value})

                End If
            Else
                ModelState.AddModelError("", "Invalid username or password.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    ' GET: /Patient
    Function EditPatient(ByVal patientID As Int32?, ByVal lastName As String, ByVal firstName As String) As ActionResult
        If patientID IsNot Nothing Then
            Dim patient As PatientViewModel

            patient = New PatientViewModel()
            patient.PatientID = patientID
            patient.LastName = lastName
            patient.FirstName = firstName


            Return View(patient)
        End If
        Return View()
    End Function
    '
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function EditPatient(model As PatientViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                Dim patID As Integer = db.usp_UpdatePatient(model.PatientID, model.LastName, model.FirstName, Nothing, model.DOB, model.Gender, Nothing, "A", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                Return RedirectToAction("PatientList", "Patient")

            End If
        Else
            ModelState.AddModelError("", "Unable to update patient")
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    Function AddPatientInsurance(ByVal patientID As Int32?, ByVal patientName As String) As ActionResult
        If patientID IsNot Nothing Then
            Dim patInsurance As PatientInsuranceViewModel

            patInsurance = New PatientInsuranceViewModel()
            patInsurance.PatientID = patientID
            patInsurance.PatientName = patientName

            'patInsurance.InsuranceList = New List(Of Insurance)

            If db Is Nothing Then
                db = New HealthSmartEntities()
            End If
            If db.Insurances IsNot Nothing Then
                Dim insList As List(Of InsuranceViewModel) = New List(Of InsuranceViewModel)
                For Each ins As Insurance In db.Insurances
                    Dim i As InsuranceViewModel = New InsuranceViewModel()
                    i.InsuranceCompanyID = ins.InsuranceCompanyID
                    i.CompanyName = ins.CompanyName
                    insList.Add(i)
                Next
                patInsurance.InsuranceList = insList


            End If

            Return View(patInsurance)
        End If
    End Function

    <HttpPost>
<AllowAnonymous>
<ValidateAntiForgeryToken>
    Public Async Function AddPatientInsurance(model As PatientInsuranceViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            If db Is Nothing Then
                db = New HealthSmartEntities()
            End If

            If model.InsuranceList Is Nothing Then
                Dim insList As List(Of InsuranceViewModel) = New List(Of InsuranceViewModel)
                For Each ins As Insurance In db.Insurances
                    Dim i As InsuranceViewModel = New InsuranceViewModel()
                    i.InsuranceCompanyID = ins.InsuranceCompanyID
                    i.CompanyName = ins.CompanyName
                    insList.Add(i)
                Next
                model.InsuranceList = insList
            End If
            If db IsNot Nothing Then
                Dim patientID As ObjectParameter = New ObjectParameter("PatientID", GetType(Int32))
                Dim patID As Integer = db.usp_ADDPatientInsurance(model.PatientID, model.InsuranceCompanyID, model.InsuranceNumber, model.PolicyNumber, model.FromDate, model.CoverageAmount, Nothing)

                'If patientID.Value !=null Then

                Return RedirectToAction("AddPatientInsurance", "Patient", New With {
            .PatientID = patientID.Value})

                'End If
            Else
                ModelState.AddModelError("", "Invalid username or password.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    Function AddPatientDiagnosis(ByVal patientID As Int32?, ByVal patientName As String) As ActionResult
        If patientID IsNot Nothing Then
            Dim patDiagnosis As PatientDiagnosisViewModel

            patDiagnosis = New PatientDiagnosisViewModel()
            patDiagnosis.PatientID = patientID
            patDiagnosis.PatientName = patientName
            patDiagnosis.DiagDate = DateTime.Now.ToShortDateString()

            If db Is Nothing Then
                db = New HealthSmartEntities()
            End If
            If db.Diagnosis IsNot Nothing Then
                Dim diagList As List(Of DiagnosisViewModel) = New List(Of DiagnosisViewModel)
                For Each diag As Diagnosi In db.Diagnosis
                    Dim d As DiagnosisViewModel = New DiagnosisViewModel()
                    d.DiagnosisCode = diag.DiagCd
                    d.DiagnosisDesc = diag.DiagDesc
                    diagList.Add(d)
                Next
                patDiagnosis.DiagnosisList = diagList
            End If

            Return View(patDiagnosis)
        End If
    End Function

    <HttpPost>
<AllowAnonymous>
<ValidateAntiForgeryToken>
    Public Async Function AddPatientDiagnosis(model As PatientDiagnosisViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            If db Is Nothing Then
                db = New HealthSmartEntities()
            End If

            If model.DiagnosisList Is Nothing Then
                Dim diagList As List(Of DiagnosisViewModel) = New List(Of DiagnosisViewModel)
                For Each diag As Diagnosi In db.Diagnosis
                    Dim d As DiagnosisViewModel = New DiagnosisViewModel()
                    d.DiagnosisCode = diag.DiagCd
                    d.DiagnosisDesc = diag.DiagDesc
                    diagList.Add(d)
                Next
                model.DiagnosisList = diagList
            End If
            If db IsNot Nothing Then
                Dim patientDiagnosiID As ObjectParameter = New ObjectParameter("PatDiagnosisID", GetType(Int32))
                db.usp_AddPatientDiagnosis(model.PatientID, Nothing, model.DiagCode, model.DiagDate, model.DiagCategoryCode, Nothing, model.Notes, Nothing, patientDiagnosiID)

                If patientDiagnosiID.Value IsNot Nothing Then

                    Return RedirectToAction("AddPatientMedication", "Patient", New With {.PatientID = model.PatientID, .PatientName = model.PatientName})

                End If
            Else
                ModelState.AddModelError("", "Invalid username or password.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    Function AddPatientMedication(ByVal patientID As Int32?, ByVal patientName As String) As ActionResult
        If patientID IsNot Nothing Then
            Dim patMedication As PatientMedicationViewModel

            patMedication = New PatientMedicationViewModel()
            patMedication.PatientID = patientID
            patMedication.PatientName = patientName
            patMedication.MedicationDate = DateTime.Now.ToShortDateString()

            If db Is Nothing Then
                db = New HealthSmartEntities()
            End If
            If db.Medications IsNot Nothing Then
                Dim medList As List(Of MedicationViewModel) = New List(Of MedicationViewModel)
                For Each med As Medication In db.Medications
                    Dim m As MedicationViewModel = New MedicationViewModel()
                    m.MedicationID = med.MedicationID
                    m.MedicationDesc = med.MedicationForDesc
                    medList.Add(m)
                Next
                patMedication.MedicationList = medList
            End If

            Return View(patMedication)
        End If
    End Function

    <HttpPost>
<AllowAnonymous>
<ValidateAntiForgeryToken>
    Public Async Function AddPatientMedication(model As PatientMedicationViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            If db Is Nothing Then
                db = New HealthSmartEntities()
            End If

            If db.Medications IsNot Nothing Then
                Dim medList As List(Of MedicationViewModel) = New List(Of MedicationViewModel)
                For Each med As Medication In db.Medications
                    Dim m As MedicationViewModel = New MedicationViewModel()
                    m.MedicationID = med.MedicationID
                    m.MedicationDesc = med.MedicationForDesc
                    medList.Add(m)
                Next
                model.MedicationList = medList
            End If

            If db IsNot Nothing Then
                Dim patientMedicationID As ObjectParameter = New ObjectParameter("PatMedicationID", GetType(Int32))
                db.usp_ADDPatientMedication(model.PatientID, model.MedicationDate, Nothing, model.Notes, Nothing, patientMedicationID)

                If patientMedicationID.Value IsNot Nothing Then
                    db.usp_ADDPatientMedicationDetail(patientMedicationID.Value, model.MedicationID, model.NoOfTimesDay, model.NoOfDays, model.Dosage, Nothing)

                    Return RedirectToAction("PatientList", "Patient")

                End If
            Else
                ModelState.AddModelError("", "Invalid username or password.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function
End Class