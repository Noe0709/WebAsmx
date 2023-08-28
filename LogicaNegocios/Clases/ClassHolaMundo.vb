Imports Oracle.DataAccess.Client
Imports System.Configuration




Public Class ClassHolaMundo

    Dim Esquema As String = ConfigurationSettings.AppSettings("Esquema")
    Dim connString As String = ConfigurationSettings.AppSettings("Oracle")


    Public Function HolaMundo() As String
        Return "Hola Mundo desde Clase de Ws"
    End Function





End Class
