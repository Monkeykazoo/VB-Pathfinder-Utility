@ModelType IEnumerable(Of Models.CharacterModel)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.CharacterName)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.CharacterClass)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.CharacterRace)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.CharacterName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.CharacterClass)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.CharacterRace)
            </td>
            <td>
                @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
