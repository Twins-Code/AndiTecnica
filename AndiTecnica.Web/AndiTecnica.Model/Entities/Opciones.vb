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

Partial Public Class Opciones
    Public Property OpcionId As Integer
    Public Property Nombre As String
    Public Property BotonFk As Integer
    Public Property MenuFk As Nullable(Of Integer)
    Public Property Describe As String
    Public Property Creado As Date
    Public Property Modificado As Date

    Public Overridable Property Botones As Botones
    Public Overridable Property Menus As Menus
    Public Overridable Property Permisos As ICollection(Of Permisos) = New HashSet(Of Permisos)

End Class