﻿Friend Class EmpleadosDao
    Public Function ListarEmpleados() As List(Of Empleados)
        Using bd As New AndiTecnicaEntities
            Dim query = From tbl In bd.Empleados
                        Select tbl
            Return query.ToList
        End Using
    End Function

    Public Function BuscarEmpleados(ByVal Nombre As String) As List(Of Empleados)
        Using bd As New AndiTecnicaEntities
            Dim query = From tbl In bd.Empleados
                        Where tbl.Nombre.Contains(Nombre)
                        Select tbl
            Return query.ToList
        End Using
    End Function

    Public Function ConsultarEmpleadoxId(ByVal Empleadoid As Integer) As Empleados
        Using bd As New AndiTecnicaEntities
            Dim query = From tbl In bd.Empleados
                        Where tbl.EmpleadoId = Empleadoid
                        Select tbl
            Return query.FirstOrDefault
        End Using
    End Function

    Public Sub GuardarEmpleado(ByVal Empleado As Empleados)
        Using bd As New AndiTecnicaEntities
            bd.Entry(Empleado).State = EntityState.Added
            bd.SaveChanges()
        End Using
    End Sub

    Public Sub ActualizarEmpleado(ByVal Empleado As Empleados)
        Using bd As New AndiTecnicaEntities
            bd.Entry(Empleado).State = EntityState.Modified
            bd.SaveChanges()
        End Using
    End Sub

    Public Sub EliminarEmpleado(ByVal Empleado As Empleados)
        Using bd As New AndiTecnicaEntities
            bd.Entry(Empleado).State = EntityState.Deleted
            bd.SaveChanges()
        End Using
    End Sub
End Class