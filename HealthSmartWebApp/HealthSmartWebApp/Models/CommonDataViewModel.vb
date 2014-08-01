Imports System.ComponentModel.DataAnnotations
Public Class PasswordSecurityQuestionViewModel
    <Required>
    <Display(Name:="PwdSecQuestionID")>
    Public Property PwdSecQuestionID As String
    <Required>
    <Display(Name:="PwdSecQuestionDesc")>
    Public Property PwdSecQuestionDesc As String
End Class
