﻿' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class InsuranceClaimService
    Implements IInsuranceClaimService

    Public Sub New()
    End Sub

    Public Function GetInsuranceClaim(subscriberId As String) As IList(Of InsuranceClaim) Implements IInsuranceClaimService.GetInsuranceClaim

        Return Nothing

    End Function

    Public Function ClaimInsurance(insuranceClaims As IList(Of InsuranceClaim)) As Boolean Implements IInsuranceClaimService.ClaimInsurance
        Return True
    End Function

End Class
