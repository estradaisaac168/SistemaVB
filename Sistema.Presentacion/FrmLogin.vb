Public Class FrmLogin
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            Dim Email As String
            Dim Clave As String
            Dim Neg As New Negocio.UsuarioBLL
            Dim Obj As New Entidades.Usuario

            Email = TxtEmail.Text.Trim()
            Clave = TxtClave.Text.Trim()

            If Email <> "" And Clave <> "" Then
                Obj = Neg.Login(Email, Clave)

                'Si el objeto esta vacio no existe en la base de datos
                If (Obj Is Nothing) Then
                    MsgBox("No existe el usuario con esas credenciales", vbOKOnly + vbCritical, "Error en acceso")
                Else
                    'Si el usuario esta inactivo
                    If (Obj.Estado = False) Then
                        MsgBox("El usuario esta inactivo", vbOKOnly + vbCritical, "Usuario no tiene acceso")
                    Else
                        'Si el usuario esta activo
                        Me.Hide()
                        FrmPrincipal.IdUsuario = Obj.IdUsuario
                        FrmPrincipal.IdRol = Obj.IdRol
                        FrmPrincipal.Rol = Obj.Rol
                        FrmPrincipal.Nombre = Obj.Nombre
                        FrmPrincipal.ShowDialog()
                        Me.Close()
                    End If
                End If
            Else
                MsgBox("Debe ingresar el email y la clave", vbOKOnly + vbExclamation, "Campos vacios")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error")
        End Try
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class