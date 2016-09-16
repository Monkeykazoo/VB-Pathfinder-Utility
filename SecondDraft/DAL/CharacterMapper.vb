Imports System.IO.File
Imports System.Web.Script.Serialization
Imports Models

Public Class CharacterMapper
    Property ConnectionString As String

    Sub New(iConnectionString)
        ConnectionString = iConnectionString
    End Sub

    Sub CreateNewCharacter(iCharacterToCreate As CharacterModel)
        Dim JSonifier As New JavaScriptSerializer
        Dim SerializedCharacter As String = JSonifier.Serialize(iCharacterToCreate)
        FileIO.FileSystem.WriteAllText(ConnectionString, SerializedCharacter, True)
    End Sub
End Class