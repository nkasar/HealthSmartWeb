' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IInsuranceClaimService

    <OperationContract()>
    Function GetInsuranceClaim(subscriberId As String) As IList(Of InsuranceClaim)

    <OperationContract()>
    Function ClaimInsurance(insuranceClaims As IList(Of InsuranceClaim)) As Boolean

    ' TODO: Add your service operations here

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.

<DataContract()>
Public Class InsuranceClaim

    <DataMember()>
    Public Property InsuranceNumber() As String

    <DataMember()>
    Public Property PolicyNumber() As String

    <DataMember()>
    Public Property AppointmentDate() As Date

    <DataMember()>
    Public Property DiagnosisCode() As String

    <DataMember()>
    Public Property MedicalProcedureCode() As String
    <DataMember()>
    Public Property Charge() As Decimal
End Class
