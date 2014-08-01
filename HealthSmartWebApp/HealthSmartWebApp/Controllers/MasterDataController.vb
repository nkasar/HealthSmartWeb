Imports System.Web.Mvc
Imports System.Threading.Tasks
Imports System.Data.Entity.Core.Objects

Public Class MasterDataController
    Inherits Controller
    Dim db As HealthSmartEntities

    Public Sub MasterDataController()
        db = New HealthSmartEntities()
    End Sub

#Region "Allergy"
    ' GET: /Allergy
    Function AddAllergy() As ActionResult
        Return View()
    End Function

    ' GET: /Allergy
    Function AllergyList() As ActionResult
        Dim allList As List(Of AllergyViewModel)
        allList = New List(Of AllergyViewModel)
        If db Is Nothing Then
            db = New HealthSmartEntities()
        End If
        For Each allergy As Allergy In db.Allergies
            Dim a As AllergyViewModel = New AllergyViewModel()
            a.AllergyCode = allergy.AllergyCd
            a.AllergyDesc = allergy.AllergyDesc
            allList.Add(a)
        Next
        Return View(allList)
    End Function

    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function AddAllergy(model As AllergyViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                db.usp_AddAllergy(model.AllergyCode, model.AllergyDesc)


                Return RedirectToAction("AllergyList", "MasterData")
            Else
                ModelState.AddModelError("", "Invalid allergy code or description.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function
#End Region

#Region "Diagnosis"
    ' GET: /Allergy
    Function AddDiagnosis() As ActionResult
        Return View()
    End Function

    ' GET: /Allergy
    Function DiagnosisList() As ActionResult
        Dim diagList As List(Of DiagnosisViewModel)
        diagList = New List(Of DiagnosisViewModel)
        If db Is Nothing Then
            db = New HealthSmartEntities()
        End If
        For Each diag As Diagnosi In db.Diagnosis
            Dim d As DiagnosisViewModel = New DiagnosisViewModel()
            d.DiagnosisCode = diag.DiagCd
            d.DiagnosisDesc = diag.DiagDesc
            diagList.Add(d)
        Next
        Return View(diagList)
    End Function

    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function AddDiagnosis(model As DiagnosisViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                db.usp_AddDiagnosis(model.DiagnosisCode, model.DiagnosisDesc)


                Return RedirectToAction("DiagnosisList", "MasterData")
            Else
                ModelState.AddModelError("", "Invalid Diagnosis code or description.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function
#End Region

#Region "Medication"
    ' GET: /Allergy
    Function MedicationList() As ActionResult
        Dim medList As List(Of MedicationViewModel)
        medList = New List(Of MedicationViewModel)
        If db Is Nothing Then
            db = New HealthSmartEntities()
        End If
        For Each med As Medication In db.Medications
            Dim m As MedicationViewModel = New MedicationViewModel()
            m.MedicationID = med.MedicationID
            m.MedicationDesc = med.MedicationForDesc
            medList.Add(m)
        Next
        Return View(medList)
    End Function

    ' GET: /Allergy
    Function AddMedication() As ActionResult
        Return View()
    End Function
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function AddMedication(model As MedicationViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                Dim medicationID As ObjectParameter = New ObjectParameter("MedicationID", GetType(Int32))
                db.usp_AddMedication(model.MedicationDesc, Nothing, medicationID)
                Return RedirectToAction("MedicationList", "MasterData")
            Else
                ModelState.AddModelError("", "Invalid Medication.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    ' GET: /Allergy
    Function DeleteMedication(ByVal medicationID As String, ByVal medicationDesc As String) As ActionResult
        If medicationID IsNot Nothing Then
            Dim medication As MedicationViewModel

            medication = New MedicationViewModel()
            medication.MedicationID = medicationID
            medication.MedicationDesc = medicationDesc
            Return View(medication)
        End If
        Return View()
    End Function
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function DeleteMedication(model As MedicationViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                db.usp_DeleteMedication(model.MedicationID)
                Return RedirectToAction("MedicationList", "MasterData")
            Else
                ModelState.AddModelError("", "Invalid Medication.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function
#End Region
#Region "Insurance"

    Function AddInsurance() As ActionResult
        Return View()
    End Function


    Function InsuranceList() As ActionResult
        Dim insList As List(Of InsuranceViewModel)
        insList = New List(Of InsuranceViewModel)
        If db Is Nothing Then
            db = New HealthSmartEntities()
        End If
        For Each ins As Insurance In db.Insurances
            Dim i As InsuranceViewModel = New InsuranceViewModel()
            i.InsuranceCompanyID = ins.InsuranceCompanyID
            i.CompanyName = ins.CompanyName
            i.ContactPersonName = ins.ContactPersonName
            i.AddressLine1 = ins.AddressLine1
            i.AddressLine2 = ins.AddressLine2
            i.City = ins.City
            i.State = ins.State
            i.BusinessPhone = ins.BusinessPhone
            i.EmailAddress = ins.EmailAddress
            i.PinCode = ins.PinCode
            i.FaxNumber = ins.FaxNumber
            insList.Add(i)
        Next
        Return View(insList)
    End Function


    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function AddInsurance(model As InsuranceViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                db.usp_AddInsurance(model.CompanyName, model.AddressLine1, model.AddressLine2, model.City, model.State, "IND", Nothing, model.BusinessPhone, model.EmailAddress, model.PinCode, model.FaxNumber, Nothing, New ObjectParameter("InsuranceCompanyID", GetType(Int32)))
                           

                Return RedirectToAction("InsuranceList", "MasterData")
            Else
                ModelState.AddModelError("", "Invalid Insurance information.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function
#End Region
End Class