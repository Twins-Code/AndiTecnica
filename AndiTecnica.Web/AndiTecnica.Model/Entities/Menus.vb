'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Menus
    Public Property MenuId As Integer
    Public Property Nombre As String
    Public Property Ruta As String
    Public Property ModuloFk As Integer

    Public Overridable Property Autorizaciones As ICollection(Of Autorizaciones) = New HashSet(Of Autorizaciones)
    Public Overridable Property Modulos As Modulos
    Public Overridable Property Opciones As ICollection(Of Opciones) = New HashSet(Of Opciones)

End Class
