Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security

<Authorize>
Public Class AccountController
    Inherits Controller
    Dim db As HealthSmartEntities

    Public Sub New()
        db = New HealthSmartEntities()

    End Sub

    Public Sub New(manager As UserManager(Of ApplicationUser))
        UserManager = manager
    End Sub

    Public Property UserManager As UserManager(Of ApplicationUser)

    '
    ' GET: /Account/Login
    <AllowAnonymous>
    Public Function Login(returnUrl As String) As ActionResult
        ViewBag.ReturnUrl = returnUrl
        Return View()
    End Function

    '
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function Login(model As LoginViewModel, returnUrl As String) As Task(Of ActionResult)
        If ModelState.IsValid Then
            ' Validate the password
            If db Is Nothing Then
                db = New HealthSmartEntities()
            End If
            Dim appUser = db.usp_AuthenticateUser(model.UserName, model.Password, "P")
            If appUser Then
                Return RedirectToLocal(returnUrl)
            Else
                ModelState.AddModelError("", "Invalid username or password.")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    '
    ' GET: /Account/Register
    <AllowAnonymous>
    Public Function Register(ByVal userID As Int32?, ByVal userType As String) As ActionResult

        If userID IsNot Nothing Then
            Dim userViewModel As RegisterViewModel
            userViewModel = New RegisterViewModel()

            userViewModel.UserID = userID
            userViewModel.UserType = userType
            If userViewModel.SecurityQuestionList Is Nothing Then

                If db.PasswordSecurityQuestions IsNot Nothing Then
                    Dim secList As List(Of PasswordSecurityQuestionViewModel) = New List(Of PasswordSecurityQuestionViewModel)
                    For Each sec As PasswordSecurityQuestion In db.PasswordSecurityQuestions
                        Dim i As PasswordSecurityQuestionViewModel = New PasswordSecurityQuestionViewModel()
                        i.PwdSecQuestionID = sec.PwdSecQuestionID.ToString()

                        i.PwdSecQuestionDesc = sec.PwdSecQuestionDesc
                        secList.Add(i)
                    Next
                    userViewModel.SecurityQuestionList = secList
                End If
            End If
            Return View(userViewModel)
        End If

    End Function

    '
    ' POST: /Account/Register
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function Register(model As RegisterViewModel) As Task(Of ActionResult)
        If ModelState.IsValid Then
            If db Is Nothing Then
                db = New HealthSmartEntities()
            End If
            If model.SecurityQuestionList Is Nothing Then

                If db IsNot Nothing Then
                    If db.PasswordSecurityQuestions IsNot Nothing Then
                        Dim secList As List(Of PasswordSecurityQuestionViewModel) = New List(Of PasswordSecurityQuestionViewModel)
                        For Each sec As PasswordSecurityQuestion In db.PasswordSecurityQuestions
                            Dim i As PasswordSecurityQuestionViewModel = New PasswordSecurityQuestionViewModel()
                            i.PwdSecQuestionID = sec.PwdSecQuestionID.ToString()
                            i.PwdSecQuestionDesc = sec.PwdSecQuestionDesc
                            secList.Add(i)
                        Next
                        model.SecurityQuestionList = secList
                    End If
                End If
                model.UserType = "P"
                If model.UserType = "P" Then
                    db.usp_CreatePhysicianLogin(model.UserID, model.UserName, model.Password, model.PwdSecQuestionID, model.PwdSecAnswer, Nothing)
                End If
                Return RedirectToAction("Index", "Home")
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function


    '
    ' POST: /Account/LogOff
    <HttpPost>
    <ValidateAntiForgeryToken>
    Public Function LogOff() As ActionResult
        AuthenticationManager.SignOut()
        Return RedirectToAction("Index", "Home")
    End Function

    '
    ' GET: /Account/ExternalLoginFailure
    <AllowAnonymous>
    Public Function ExternalLoginFailure() As ActionResult
        Return View()
    End Function


    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso UserManager IsNot Nothing Then
            UserManager.Dispose()
            UserManager = Nothing
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Helpers"
    ' Used for XSRF protection when adding external logins
    Private Const XsrfKey As String = "XsrfId"

    Private Function AuthenticationManager() As IAuthenticationManager
        Return HttpContext.GetOwinContext().Authentication
    End Function

    Private Async Function SignInAsync(user As ApplicationUser, isPersistent As Boolean) As Task
        AuthenticationManager.SignOut(Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ExternalCookie)
        Dim identity = Await UserManager.CreateIdentityAsync(user, Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ApplicationCookie)
        AuthenticationManager.SignIn(New AuthenticationProperties() With {.IsPersistent = isPersistent}, identity)
    End Function

    Private Sub AddErrors(result As IdentityResult)
        For Each [error] As String In result.Errors
            ModelState.AddModelError("", [error])
        Next
    End Sub


    Private Function RedirectToLocal(returnUrl As String) As ActionResult
        If Url.IsLocalUrl(returnUrl) Then
            Return Redirect(returnUrl)
        Else
            Return RedirectToAction("Index", "Home")
        End If
    End Function

    Public Enum ManageMessageId
        ChangePasswordSuccess
        SetPasswordSuccess
        RemoveLoginSuccess
        UnknownError
    End Enum

    Private Class ChallengeResult
        Inherits HttpUnauthorizedResult
        Public Sub New(provider As String, redirectUri As String)
            Me.New(provider, redirectUri, Nothing)
        End Sub
        Public Sub New(provider As String, redirectUri As String, userId As String)
            Me.LoginProvider = provider
            Me.RedirectUri = redirectUri
            Me.UserId = userId
        End Sub

        Public Property LoginProvider As String
        Public Property RedirectUri As String

        Public Property UserId As String

        Public Overrides Sub ExecuteResult(context As ControllerContext)
            Dim properties = New AuthenticationProperties() With {.RedirectUri = RedirectUri}
            If UserId IsNot Nothing Then
                properties.Dictionary(XsrfKey) = UserId
            End If
            context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider)
        End Sub
    End Class
#End Region

End Class
