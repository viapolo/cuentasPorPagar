
Public Class frmCargaCuentas
    Private Sub btnSeleccionarArchivo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarArchivo.Click
        ' // Pasar valores para Leer el rango      
        ' loadRange("E:\DatosCTAB.xls", "Hoja1", "A1:N628", DataGridView1)
        leeTxt("C:\Users\vicente-apolonio\OneDrive - Corporativo La Moderna\Desktop\files\Cuentas Tarjetas de Credito 3.txt")
    End Sub

    Private Sub loadRange(
        ByVal sFileName As String,
        ByVal sSheetName As String,
        ByVal sRange As String,
        ByVal dv As DataGridView)

        Try
            ' // Comprobar que el archivo Excel existe  
            If System.IO.File.Exists(sFileName) Then

                Dim objDataSet As System.Data.DataSet
                Dim objDataAdapter As System.Data.OleDb.OleDbDataAdapter
                ' // Declarar la Cadena de conexión  
                Dim sCs As String = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sFileName & ";Extended Properties=Excel 8.0;"
                Dim objOleConnection As System.Data.OleDb.OleDbConnection
                objOleConnection = New System.Data.OleDb.OleDbConnection(sCs)

                ' // Declarar la consulta SQL que indica el libro y el rango de la hoja  
                Dim sSql As String = "Select * from " & "[" & sSheetName & "$" & sRange & "]"
                ' // Obtener los datos  
                objDataAdapter = New System.Data.OleDb.OleDbDataAdapter(sSql, objOleConnection)

                ' // Crear DataSet y llenarlo  
                objDataSet = New System.Data.DataSet

                objDataAdapter.Fill(objDataSet)
                ' // Cerrar la conexión  
                objOleConnection.Close()

                ' // Enlazar DataGrid al Dataset  
                With dv
                    .DataSource = objDataSet
                    .DataMember = objDataSet.Tables(0).TableName
                End With
            Else
                MsgBox("No se ha encontrado el archivo: " & sFileName, MsgBoxStyle.Exclamation)
            End If

            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub


    Private Sub leeTxt(ByVal archivo As String)
        ' Apuntador libre a archivo
        Dim Apunt As Integer = FreeFile()
        ' Variable donde guardamos cada línea de texto
        Dim Texto As String
        ' Abrimos el archivo y lo recorremos hasta el final línea por línea
        DataGridView1.Columns.Add("cuenta", "Cuenta")
        DataGridView1.Columns.Add("moneda", "Moneda")
        DataGridView1.Columns.Add("nombre", "Nombre")
        DataGridView1.Columns.Add("mail", "Mail")

        FileOpen(Apunt, archivo, OpenMode.Input, OpenAccess.Read)
        Do While Not EOF(Apunt)
            ' Leemos la línea de texto del archivo
            Texto = LineInput(Apunt)
            ' Aqui ya puedes hacer el tratamiento que desees con la línea de texto
            '.....
            If Text <> String.Empty Then
                DataGridView1.Rows.Add(Texto.Substring(2, 18), Texto.Substring(20, 3), Texto.Substring(39, 30), Texto.Substring(99, 70), True)
            End If
        Loop
        ' Cerramos el archivo
        FileClose(Apunt)
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        procesaTxt()
    End Sub

    Private Sub procesaTxt()
        Dim taCuentasBanco As New dsConfiguracionTableAdapters.CXP_CuentaBancoTableAdapter
        For Each rowsDg As DataGridViewRow In DataGridView1.Rows
            taCuentasBanco.Insert(rowsDg.Cells("cuenta").Value, rowsDg.Cells("moneda").Value, rowsDg.Cells("nombre").Value, "TCR", True)
        Next
    End Sub

    Private Sub procesaExcel()
        Dim taProveedores As New dsHerramientasTableAdapters.CXP_ProveedoresTableAdapter
        Dim taCuentasBancariasProv As New dsHerramientasTableAdapters.CXP_CuentasBancariasProvTableAdapter
        Dim taBancos As New dsHerramientasTableAdapters.CXP_BancosTableAdapter
        Dim cont As Integer = 0
        For Each rowsDg As DataGridViewRow In DataGridView1.Rows
            Dim fecha As Date = Date.Now
            If taProveedores.ExisteRfcScalarQuery(DataGridView1.Item(0, cont).Value) = "NE" Then
                Dim idProveedor As Integer = taProveedores.NuevoProveedor_ScalarQuery(DataGridView1.Item(0, cont).Value, Nothing, DataGridView1.Item(1, cont).Value.ToString, DataGridView1.Item(2, cont).Value, Nothing, False, Nothing, Nothing, False, Nothing, fecha, DataGridView1.Item(3, cont).Value, Nothing, Nothing, Nothing, Nothing, True, False, DataGridView1.Item(4, cont).Value, DataGridView1.Item(5, cont).Value, DataGridView1.Item(6, cont).Value, DataGridView1.Item(7, cont).Value, DataGridView1.Item(8, cont).Value, "MEX", DataGridView1.Item(10, cont).Value, "ACTIVO", "AUTORIZADO", "roberto.zarza@finagil.com.mx", "", "factoraje", Nothing, False)
                taCuentasBancariasProv.Insert(idProveedor, taBancos.claveBanco_ScalarQuery(DataGridView1.Item(12, cont).Value.ToString.Substring(0, 3)), DataGridView1.Item(11, cont).Value, DataGridView1.Item(12, cont).Value, "CTA BANCARIA FACTORAJE", DataGridView1.Item(13, cont).Value.ToString.Replace("PESO", "MXN").Replace("DOLAR", "USD"), Nothing, True, "roberto.zarza", Nothing, Nothing, Nothing, fecha, SqlTypes.SqlDateTime.Null, SqlTypes.SqlDateTime.Null, SqlTypes.SqlDateTime.Null, 11, Nothing, Nothing, Nothing, True)
            End If
            cont += 1
            If cont = 200 Or cont = 300 Or cont = 400 Or cont = 500 Or cont = 600 Then
                MsgBox(cont.ToString)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(obtNumCadena(TextBox1.Text))
    End Sub
End Class