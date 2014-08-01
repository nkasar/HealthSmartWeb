@ModelType PatientViewModel

@Code
    ViewBag.Title = "Patient Registration"
End Code

<h2>@ViewBag.Title.</h2>
<div class="row">
    <div class="col-md-8">
        <section id="loginForm">
            @Using Html.BeginForm("AddPatient", "Patient", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                @Html.AntiForgeryToken()
                @<text>
                    <h4>Please complete this form to register a patient</h4>
                    <hr />
                    @Html.ValidationSummary(True)
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.FirstName, New With {.class = "col-md-2 control-label"})
                        <div class="col-md-10">
                            @Html.TextBoxFor(Function(m) m.FirstName, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) m.FirstName)
                        </div>
                    </div>
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.LastName, New With {.class = "col-md-2 control-label"})
                        <div class="col-md-10">
                            @Html.TextBoxFor(Function(m) m.LastName, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) m.LastName)
                        </div>
                    </div>

                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.Gender, New With {.class = "col-md-2 control-label"})
                        <div class="col-md-10">
                            @Html.TextBoxFor(Function(m) m.Gender, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) m.Gender)
                        </div>
                    </div>
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.DOB, New With {.class = "col-md-2 control-label"})
                        <div class="col-md-10">
                            @Html.TextBoxFor(Function(m) m.DOB, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) m.DOB)
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <input type="submit" value="Register" class="btn btn-default" />
                        </div>
                    </div>
                </text>
            End Using
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
