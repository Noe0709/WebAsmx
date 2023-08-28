Imports Microsoft.VisualBasic
Imports System.Math

Public Class Volumenes

    'Aqui empiezan los calculos'
    'ESFERA'
    Public Function VolEsfera(ByVal radio As Double) As Double
        Return (4 / 3) * Math.PI * Math.Pow(radio, 3)
    End Function

    'CILINDRO'
    <WebMethod()>
    Public Function VolCilindro(ByVal radio As Double, ByVal altura As Double) As Double
        Return Math.PI * Math.Pow(radio, 2) * altura
    End Function

    'PIRAMIDE'
    <WebMethod()>
    Public Function VolPiramide(base As Double, ByVal altura As Double) As Double
        Return (1 / 3) * base * altura
    End Function

    'CONO TRUNCADO'
    <WebMethod()>
    Public Function VolConoTruncado(ByVal radioMayor As Double, ByVal radioMenor As Double, ByVal altura As Double) As Double
        Return (1 / 3) * Math.PI * altura * (Math.Pow(radioMayor, 2) + Math.Pow(radioMenor, 2) + (radioMayor * radioMenor))
    End Function


End Class

Friend Class WebMethodAttribute
    Inherits Attribute
End Class
