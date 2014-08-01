Imports System.ComponentModel.DataAnnotations
Public Class DiagnosisViewModel
    <Required>
    <Display(Name:="Diagnosis Code")>
    Public Property DiagnosisCode As String
    <Required>
    <Display(Name:="Diagnosis Description")>
    Public Property DiagnosisDesc As String
End Class
