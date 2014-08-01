@ModelType RegisterViewModel
@Code
    ViewBag.Title = "Register"
End Code

<h2>@ViewBag.Title.</h2>

@Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})

    @Html.AntiForgeryToken()

    @<text>
    <h4>Create a new account.</h4>
    <hr />
    @Html.ValidationSummary()
    <div class="form-group">
        @Html.LabelFor(Function(m) m.UserID, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.EditorFor(Function(m) m.UserID, New With {.class = "form-control"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(m) m.UserName, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.TextBoxFor(Function(m) m.UserName, New With {.class = "form-control"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
        </div>
    </div>
 @If Model.SecurityQuestionList Is Nothing Then
         Dim db As HealthSmartEntities = New HealthSmartEntities
         
                If db.PasswordSecurityQuestions IsNot Nothing Then
                    Dim secList As List(Of PasswordSecurityQuestionViewModel) = New List(Of PasswordSecurityQuestionViewModel)
                    For Each sec As PasswordSecurityQuestion In db.PasswordSecurityQuestions
                        Dim i As PasswordSecurityQuestionViewModel = New PasswordSecurityQuestionViewModel()
                        i.PwdSecQuestionID = sec.PwdSecQuestionID.ToString()

                        i.PwdSecQuestionDesc = sec.PwdSecQuestionDesc
                        secList.Add(i)
                    Next
             Model.SecurityQuestionList = secList
                End If
            End If
    <div class="form-group">
        @Html.LabelFor(Function(model) model.PwdSecQuestionID, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownListFor(Function(model) model.PwdSecQuestionID, New SelectList(Model.SecurityQuestionList, "PwdSecQuestionID", "PwdSecQuestionDesc"))
            @Html.ValidationMessageFor(Function(model) model.PwdSecQuestionID)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(m) m.PwdSecAnswer, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.TextBoxFor(Function(m) m.PwdSecAnswer, New With {.class = "form-control"})
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" class="btn btn-default" value="Register" />
        </div>
    </div>
    </text>
End Using

@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
