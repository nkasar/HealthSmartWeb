Imports System.Web.Mvc
Imports System.Data.Entity.Core.Objects
Imports System.Threading.Tasks

Public Class PhysicianController
    Inherits Controller
    Dim db As HealthSmartEntities

    Public Sub New()
        db = New HealthSmartEntities()
    End Sub

    ' GET: /Patient
    Function AddPhysician() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function AddPhysician(model As PhysicianViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                Dim physicianID As ObjectParameter = New ObjectParameter("PhysicianID", GetType(Int32))
                Dim patID As Integer = db.usp_AddPhysician(model.PhysicianLastName, model.PhysicianFirstName, model.MiddleInitial, model.AddressLine1, model.AddressLine2, model.City, model.State, model.PinCode, "IND", model.HomePhone, model.BusinessPhone, model.EmailAddress, model.FaxNumber, Nothing, Nothing, Nothing, Nothing, physicianID)

                If physicianID.Value IsNot Nothing Then

                    Return RedirectToAction("Register", "Account", New With {
                .userID = physicianID.Value, .userType = "P"})

                End If
            Else
                ModelState.AddModelError("", "Unable to register physician")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    ' GET: /Patient
    Function EditPhysician(ByVal physicianID As Int32?, ByVal lastName As String, ByVal firstName As String) As ActionResult
        If physicianID IsNot Nothing Then
            Dim phy = db.Physicians.Find(physicianID)

            If phy IsNot Nothing Then

                Dim physician As PhysicianViewModel

                physician = New PhysicianViewModel()
                physician.PhysicianID = physicianID
                physician.PhysicianLastName = lastName
                physician.PhysicianFirstName = firstName
                physician.AddressLine1 = phy.AddressLine1
                physician.AddressLine2 = phy.AddressLine2
                physician.City = phy.City
                physician.State = phy.State
                physician.PinCode = phy.PinCode
                physician.HomePhone = phy.HomePhone
                physician.BusinessPhone = phy.BusinessPhone
                physician.EmailAddress = phy.EmailAddress
                physician.FaxNumber = phy.FaxNumber


                Return View(physician)
            End If
        End If
        Return View()
    End Function

    '
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function EditPhysician(model As PhysicianViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            Dim db = New HealthSmartEntities()
            If db IsNot Nothing Then
                Dim phyID As Integer = db.usp_UpdatePhysician(model.PhysicianID, model.PhysicianLastName, model.PhysicianFirstName, model.MiddleInitial, model.AddressLine1, model.AddressLine2, model.City, model.State, model.PinCode, "IND", model.HomePhone, model.BusinessPhone, model.EmailAddress, model.FaxNumber, Nothing, Nothing, Nothing, Nothing)

                If phyID Then

                    Return RedirectToAction("Register", "Account", New With {
                .userID = model.PhysicianID, .userType = "P"})

                End If
            Else
                ModelState.AddModelError("", "Unable to register physician")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    ' GET: /Patient
    Function PhysicianList() As ActionResult
        Dim phyList As List(Of PhysicianViewModel)
        phyList = New List(Of PhysicianViewModel)
        If db Is Nothing Then
            db = New HealthSmartEntities()
        End If
        For Each physician As Physician In db.Physicians
            Dim p As PhysicianViewModel = New PhysicianViewModel()
            p.PhysicianID = physician.PhysicianID
            p.PhysicianLastName = physician.PhysicianLastName
            p.PhysicianFirstName = physician.PhysicianFirstName
            p.AddressLine1 = physician.AddressLine1
            p.AddressLine2 = physician.AddressLine2
            p.City = physician.City
            p.State = physician.State
            p.PinCode = physician.PinCode
            p.HomePhone = physician.HomePhone
            p.BusinessPhone = physician.BusinessPhone
            p.EmailAddress = physician.EmailAddress
            p.FaxNumber = physician.FaxNumber

            phyList.Add(p)
        Next
        Return View(phyList)
    End Function

    Function Register(ByVal userID As Int32?, ByVal userType As String) As ActionResult
        Return RedirectToAction("Register", "Account", New With {
.userID = userID, .userType = "P"})

    End Function
End Class