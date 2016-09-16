Imports System.Web.Mvc
Imports BLL

Namespace Controllers
    Public Class CharacterController
        Inherits Controller

        Property CharBLO As CharacterBLO()

        ' GET: Character
        Function Index() As ActionResult
            Return View()
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function CreateCharacter(iCharacterToCreate) As ActionResult
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace