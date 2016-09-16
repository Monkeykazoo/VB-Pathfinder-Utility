Imports DAL
Imports Models

Public Class CharacterBLO

    Private CharMap As CharacterMapper

    Sub New(iConnectionString As String)
        CharMap = New CharacterMapper(iConnectionString)
    End Sub

    Sub CreateNewCharacter(iCharacterToCreate As CharacterModel)
        CharMap.CreateNewCharacter(iCharacterToCreate)
    End Sub
End Class