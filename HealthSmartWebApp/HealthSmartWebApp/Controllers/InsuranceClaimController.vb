Imports System.Web.Mvc
Imports System.Data.Entity.Core.Objects
Imports System.Threading.Tasks
Imports HealthSmartWebApp.InsuranceClaimServiceReference

Public Class InsuranceClaimController
    Inherits Controller
    Dim db As HealthSmartEntities
    Dim patInsuranceClaimList As List(Of PatientInsuranceClaimViewModel)

    Sub New()
        db = New HealthSmartEntities()
        patInsuranceClaimList = New List(Of PatientInsuranceClaimViewModel)

    End Sub
    ' GET: /InsuranceClaim
    Function PatientInsuranceClaim() As ActionResult
        If db Is Nothing Then
            db = New HealthSmartEntities()
        End If
        For Each claim As vw_PatientInsuranceClaim In db.vw_PatientInsuranceClaim
            Dim c As PatientInsuranceClaimViewModel = New PatientInsuranceClaimViewModel()
            c.PatientID = claim.PatientID
            c.PatientName = claim.FirstName + " " + claim.LastName
            c.InsuranceCompanyName = claim.CompanyName
            c.InsuranceNumber = claim.InsuranceNumber
            c.PolicyNumber = claim.PolicyNumber
            c.DiagnosisCode = claim.DiagCd
            c.DiagnosisDate = claim.DiagDate
            c.Charge = 2000

            patInsuranceClaimList.Add(c)
        Next
        Return View(patInsuranceClaimList)
    End Function


    Function ProcessPatientInsuranceClaim(ByVal patientID As Int32?, ByVal diagnosisDate As Date) As ActionResult
        Dim serviceClient As InsuranceClaimServiceClient = New InsuranceClaimServiceClient()
        Dim claims As List(Of InsuranceClaim) = New List(Of InsuranceClaim)

        If patInsuranceClaimList IsNot Nothing Then
            For Each cl As vw_PatientInsuranceClaim In db.vw_PatientInsuranceClaim
                Dim claim As InsuranceClaim = New InsuranceClaim()
                If cl.PatientID = patientID Then
                    claim.InsuranceNumber = cl.InsuranceNumber
                    claim.PolicyNumber = cl.PolicyNumber
                    claim.DiagnosisCode = cl.DiagCd
                    Try
                        claim.AppointmentDate = cl.DiagDate
                    Catch
                    End Try

                    claim.Charge = 2000
                    claims.Add(claim)
                End If

            Next

            Dim success As Boolean = serviceClient.ClaimInsurance(claims.ToArray())
            If success Then
                Return View()
            End If
        End If

        ' If we got this far, something failed, redisplay form
        Return View()

    End Function
End Class