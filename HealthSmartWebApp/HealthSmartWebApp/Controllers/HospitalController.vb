Imports System.Web.Mvc
Imports System.Threading.Tasks

Public Class HospitalController
    Inherits Controller
    Dim db As HealthSmartEntities

    ' GET: /Hospital
    Function Hospital() As ActionResult
        Dim hospitalViewModel As HospitalViewModel
        db = New HealthSmartEntities()
        Dim hosp As Hospital = db.Hospitals.FirstOrDefault()
        If hosp Is Nothing Then
            hospitalViewModel = New HospitalViewModel()
        Else
            hospitalViewModel = New HospitalViewModel()
            hospitalViewModel.HospitalID = hosp.HospitalID
            hospitalViewModel.HospitalName = hosp.HospitalName

        End If

        Return View(hospitalViewModel)
    End Function

    '
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function Hospital(model As HospitalViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                db.usp_UpdateHospital(model.HospitalID, model.HospitalName, model.HospitalSpeciality, model.HandicapAccess, False, Nothing)


                Return RedirectToAction("HospitalLocation", "Hospital")
            Else
                ModelState.AddModelError("", "Invalid username or password.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function
    ' GET: /Hospital
    Function HospitalLocation() As ActionResult
        Return View()
    End Function
End Class