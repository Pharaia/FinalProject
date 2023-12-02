Imports MySql.Data.MySqlClient

Public Class Main
    Public Sub searchrec(ByRef SQLSTATEMENT As String)

        SQLCONN.ConnectionString = con

        If SQLCONN.State = ConnectionState.Closed Then

            SQLCONN.Open()

            Dim dt As New DataTable

            Dim MyCommand As New MySqlCommand(SQLSTATEMENT, SQLCONN)

            Dim myDataAdapter As New MySqlDataAdapter(SQLSTATEMENT, SQLCONN)
            myDataAdapter.Fill(dt)

            Dim sqlrdr As MySqlDataReader

            sqlrdr = MyCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection)

            While sqlrdr.Read()



                id.Text = sqlrdr("id")

                fname.Text = sqlrdr("Fullname")

                fname.Text = sqlrdr("Fullname")

                email.Text = sqlrdr("Email")

                uname.Text = sqlrdr("Username")

                pass.Text = sqlrdr("Password")

            End While

        End If

        SQLCONN.Close()

        SQLCONN.Dispose()

    End Sub

    Private Sub Updbtn_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SQLSTATEMENT As String = "UPDATE `user` SET `Fullname`='" & fname.Text & "',`Email`='" & email.Text & "',`Username`='" & uname.Text & "',`Password`='" & pass.Text & "' Where id = '" & id.Text & "'"
    End Sub
End Class