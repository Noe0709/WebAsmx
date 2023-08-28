Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports LogicaNegocios.ClassHolaMundo

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebServiceHolaMundo
    Inherits System.Web.Services.WebService
    Dim logicHolaMundo As New LogicaNegocios.ClassHolaMundo
    Dim logicVolumenes As New LogicaNegocios.Volumenes

    <WebMethod()> _
    Public Function HelloWorld() As String
       Return "Hola a todos"
    End Function

    <WebMethod()>
    Public Function holamundoDesdeClase() As String

        Return logicHolaMundo.HolaMundo()

    End Function

    '********************* AQUI EMPIEZA LA TAREA ********************'
    'esfera'
    <WebMethod()>
    Public Function VolumenEsfera(radio As Double) As Double
        Return logicVolumenes.VolEsfera(radio)
    End Function

    'cilindro'
    <WebMethod()>
    Public Function VolumenCilindro(radio As Double, altura As Double) As Double
        Return logicVolumenes.VolCilindro(radio, altura)
    End Function

    'piramide'
    <WebMethod()>
    Public Function VolumenPiramide(base As Double, altura As Double) As Double
        Return logicVolumenes.VolPiramide(base, altura)
    End Function

    'cono truncado'
    <WebMethod()>
    Public Function VolumenConoTruncado(radioMayor As Double, radioMenor As Double, altura As Double) As Double
        Return logicVolumenes.VolConoTruncado(radioMayor, radioMenor, altura)
    End Function

End Class