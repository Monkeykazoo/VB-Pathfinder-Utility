Imports System.Web.Mvc

Namespace Controllers
    Public Class CharacterController
        Inherits Controller

        ' GET: Character
        Function Index() As ActionResult
            Return View()
        End Function

        Function Create() As ActionResult
            Return View()
        End Function
    End Class
End Namespace