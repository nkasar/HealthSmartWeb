<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Health Smart</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @*@Html.ActionLink("Application name", "Index", "Home", Nothing, New With {.[class] = "navbar-brand"})*@
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li class="submenu">
                        Administraton
                        <ul>
                            <li>@Html.ActionLink("Hospital", "Hospital", "Hospital")</li>
                            <li>@Html.ActionLink("Insurance Companies", "InsuranceList", "MasterData")</li>
                        </ul>
                     </li>
                    <li class="submenu">
                        Physician
                        <ul>
                            <li>@Html.ActionLink("Physician List", "PhysicianList", "Physician")</li>
                            <li>@Html.ActionLink("Physician Registration", "AddPhysician", "Physician")</li>
                        </ul>
                    </li>
                    <li class="submenu">
                        Patient
                        <ul>
                            <li>@Html.ActionLink("Patient List", "PatientList", "Patient")</li>
                            <li>@Html.ActionLink("Patient Registration", "AddPatient", "Patient")</li>
                            <li>@Html.ActionLink("Patient Checkup", "PatientCheckup", "Patient")</li>
                        </ul>
                    </li>
                    <li class="submenu">
                        Masters
                        <ul>
                            <li>@Html.ActionLink("Allergy List", "AllergyList", "MasterData")</li>
                            <li>@Html.ActionLink("Diagnosis Codes", "DiagnosisList", "MasterData")</li>
                            <li>@Html.ActionLink("Medications", "MedicationList", "MasterData")</li>
                        </ul>
                    </li>

                    <li class="submenu">
                        Claims
                        <ul>
                            <li>@Html.ActionLink("Process Claims", "PatientInsuranceClaim", "InsuranceClaim")</li>

                        </ul>
                    </li>
                </ul>
                    @Html.Partial("_LoginPartial")
</div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - HealthSmart</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
