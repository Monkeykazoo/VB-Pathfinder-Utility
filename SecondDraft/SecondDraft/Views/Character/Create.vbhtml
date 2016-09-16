@ModelType Models.CharacterModel
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Create</title>
</head>
<body>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryval")
    @Using (Html.BeginForm("CreateCharacter", "Character", FormMethod.Post))
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
            <h4>CharacterModel</h4>
            <hr />
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(model) model.CharacterName, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CharacterName, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CharacterName, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.CharacterClass, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CharacterClass, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CharacterClass, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.CharacterRace, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CharacterRace, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CharacterRace, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>
        </div>
    End Using

    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
</body>
</html>