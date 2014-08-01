Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="User name")>
    Public Property UserName As String
End Class

Public Class ManageUserViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Current password")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="New password")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm new password")>
    <Compare("NewPassword", ErrorMessage:="The new password and confirmation password do not match.")>
    Public Property ConfirmPassword As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="User name")>
    Public Property UserName As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Password")>
    Public Property Password As String

    <Display(Name:="Remember me?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel

    <Required>
    <Display(Name:="User ID")>
    Public Property UserID As String

    <Display(Name:="User Type")>
    Public Property UserType As String

    <Required>
    <Display(Name:="User name")>
    Public Property UserName As String

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Password")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm password")>
    <Compare("Password", ErrorMessage:="The password and confirmation password do not match.")>
    Public Property ConfirmPassword As String

    <Display(Name:="Security Question")>
    Public Property PwdSecQuestionID As String

    <Required>
    <Display(Name:="Security Answer")>
    Public Property PwdSecAnswer As String

    Public Property SecurityQuestionList As IEnumerable(Of PasswordSecurityQuestionViewModel)
End Class
