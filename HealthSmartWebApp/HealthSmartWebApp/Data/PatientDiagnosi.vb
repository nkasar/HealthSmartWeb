'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class PatientDiagnosi
    Public Property PatDiagnosisID As Integer
    Public Property PatientID As Integer
    Public Property VisitID As Nullable(Of Integer)
    Public Property DiagCd As String
    Public Property DiagDate As Date
    Public Property DiagCategoryCd As String
    Public Property PhysicianID As Nullable(Of Integer)
    Public Property Notes As String
    Public Property Active As Nullable(Of Boolean)
    Public Property DateEntered As Nullable(Of Date)
    Public Property EnteredBy As Nullable(Of Integer)
    Public Property DateModified As Nullable(Of Date)
    Public Property ModifiedBy As Nullable(Of Integer)

    Public Overridable Property Diagnosi As Diagnosi

End Class
