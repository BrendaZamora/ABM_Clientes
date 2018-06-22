Public Class Form1
    Dim operacion_ As String
    Dim MiClientes As New Clientes
    Dim indice_ As Byte

    Public Property operacion() As String
        Get
            Return operacion_

        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Public Property indice() As String
        Get
            Return indice_

        End Get

        Set(ByVal value As String)
            indice_ = value
        End Set
    End Property


   
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        MiClientes.Id = CInt(TextBox1.Text)
        MiClientes.Nombre = TextBox2.Text
        MiClientes.Direccion = TextBox3.Text
        MiClientes.CategIva = ComboBox1.SelectedItem
        MiClientes.Saldo = CDec(TextBox4.Text)

    End Sub
End Class
