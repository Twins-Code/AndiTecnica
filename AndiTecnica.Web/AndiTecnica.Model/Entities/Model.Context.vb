﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq

Partial Public Class Entities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Entities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property CategoriasProductos() As DbSet(Of CategoriasProductos)
    Public Property Productos() As DbSet(Of Productos)
    Public Property Autorizaciones() As DbSet(Of Autorizaciones)
    Public Property Botones() As DbSet(Of Botones)
    Public Property Empleados() As DbSet(Of Empleados)
    Public Property Estados() As DbSet(Of Estados)
    Public Property Menus() As DbSet(Of Menus)
    Public Property Modulos() As DbSet(Of Modulos)
    Public Property Opciones() As DbSet(Of Opciones)
    Public Property Perfiles() As DbSet(Of Perfiles)
    Public Property Permisos() As DbSet(Of Permisos)
    Public Property Usuarios() As DbSet(Of Usuarios)
    Public Property Proveedores() As DbSet(Of Proveedores)
    Public Property Clientes() As DbSet(Of Clientes)

    Public Overridable Function ConsultarMenusxUsuarioId(usuarioId As Nullable(Of Integer), moduloId As Nullable(Of Integer)) As ObjectResult(Of ConsultarMenusxUsuarioId_Result)
        Dim usuarioIdParameter As ObjectParameter = If(usuarioId.HasValue, New ObjectParameter("UsuarioId", usuarioId), New ObjectParameter("UsuarioId", GetType(Integer)))

        Dim moduloIdParameter As ObjectParameter = If(moduloId.HasValue, New ObjectParameter("ModuloId", moduloId), New ObjectParameter("ModuloId", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of ConsultarMenusxUsuarioId_Result)("ConsultarMenusxUsuarioId", usuarioIdParameter, moduloIdParameter)
    End Function

    Public Overridable Function ConsultarModulosxUsuarioId(usuarioId As Nullable(Of Integer)) As ObjectResult(Of ConsultarModulosxUsuarioId_Result)
        Dim usuarioIdParameter As ObjectParameter = If(usuarioId.HasValue, New ObjectParameter("UsuarioId", usuarioId), New ObjectParameter("UsuarioId", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of ConsultarModulosxUsuarioId_Result)("ConsultarModulosxUsuarioId", usuarioIdParameter)
    End Function

    Public Overridable Function AutorizarBotones(usuarioId As Nullable(Of Integer), menu As String) As ObjectResult(Of AutorizarBotones_Result)
        Dim usuarioIdParameter As ObjectParameter = If(usuarioId.HasValue, New ObjectParameter("UsuarioId", usuarioId), New ObjectParameter("UsuarioId", GetType(Integer)))

        Dim menuParameter As ObjectParameter = If(menu IsNot Nothing, New ObjectParameter("Menu", menu), New ObjectParameter("Menu", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of AutorizarBotones_Result)("AutorizarBotones", usuarioIdParameter, menuParameter)
    End Function

End Class
