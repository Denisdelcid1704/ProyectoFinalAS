Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnconsulta_Click(sender As Object, e As EventArgs) Handles btnconsulta.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-O6OF1SL\SQLEXPRESS; Initial Catalog=DBProductos ; Integrated Security= True")
        Dim consulta As String = "select * from Productos"
        Dim cmd As New SqlCommand(consulta, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Productos")
            Me.DataGridView1.DataSource = ds.Tables("Productos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class
