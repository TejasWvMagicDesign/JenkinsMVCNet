Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult

        ViewData("Message") = "Jenkins CI/CD."
        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Jenkins CI/CD contact page."

        Return View()
    End Function
End Class
