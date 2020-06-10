Imports System.IO
Public Class frmGenPolizas


    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        generaPolizaD()
    End Sub

    Private Sub generaPolizaD()
        Dim filePolizaD As StreamWriter
        Dim encabezadoD As String = ""
        Dim renglonD As String = ""
        Dim taPolizasEnc As New dsProductionTableAdapters.Vw_CXP_PolizasEncTableAdapter
        Dim dtPolizasEnc As New dsProduction.Vw_CXP_PolizasEncDataTable

        Dim taPolizaDet As New dsProductionTableAdapters.Vw_CXP_PolizasDetTableAdapter
        Dim dtPolizaDet As New dsProduction.Vw_CXP_PolizasDetDataTable

        'Dim CuentasTableAdapter As New contpaqTableAdapters.CuentasTableAdapter
        Dim dtCuentasCpq As New contpaq.CuentasDataTable
        Dim rwCuentasCpq As contpaq.CuentasRow

        taPolizasEnc.PolizasXRangoFechas_FillBy(dtPolizasEnc, dtpFechaProceso.Value.AddDays(-40), Date.Now, 3, 24)

        If dtPolizasEnc.Rows.Count > 0 Then
            filePolizaD = New StreamWriter("C:\Files\PolizaPrueba.txt")
            For Each rwPolizasEnc As dsProduction.Vw_CXP_PolizasEncRow In dtPolizasEnc.Rows
                Dim nConcepto As String = Stuff(Trim(rwPolizasEnc.nConcepto), "D", " ", 100)
                encabezadoD = "P  " & dtpFechaProceso.Value.ToString("yyyyMMdd") & "   99" & Space(10 - rwPolizasEnc.folioTipoDocumento.ToString.Length) & rwPolizasEnc.folioTipoDocumento.ToString & " 1 0          " & nConcepto & " 11 0 0 "
                taPolizaDet.DetallePoliza_FillBy(dtPolizaDet, rwPolizasEnc.idEmpresa, rwPolizasEnc.idTipoDocumento, rwPolizasEnc.folioSolicitud)
                filePolizaD.WriteLine(encabezadoD)
                Dim uuid As String = ""
                For Each rwPolizasDet As dsProduction.Vw_CXP_PolizasDetRow In dtPolizaDet.Rows
                    CuentasTableAdapter.DatosCtas_FillBy(dtCuentasCpq, rwPolizasDet.idCuenta)
                    If dtCuentasCpq.Rows.Count >= 1 Then
                        rwCuentasCpq = dtCuentasCpq.Rows(0)
                        Dim dImporte As String = Stuff(Trim(rwPolizasDet.importe.ToString), "D", " ", 20)
                        Dim dReferencia As String = Stuff(Trim(rwPolizasDet.concepto), "D", " ", 100)
                        Dim dReferencia1 As String = Stuff(Trim(rwPolizasDet.folioSolicitud), "D", " ", 20)
                        Dim dsegNegocios As String = Stuff(Trim(rwPolizasDet.idSuc), "D", " ", 4)
                        Dim idDiario As String = Stuff("0", "D", " ", 10)
                        Dim importeME As String = Stuff("0.0", "D", " ", 20)
                        If dReferencia.Length > 100 Then
                            dReferencia = dReferencia.Substring(0, 100)
                        End If

                        renglonD = "M1 " & rwCuentasCpq.Codigo & Space(15) & dReferencia1 & Space(1) & rwPolizasDet.TipoMovto & Space(1) & dImporte & Space(1) & idDiario & Space(1) & importeME & Space(1) & dReferencia & Space(1) & dsegNegocios & Space(1) & uuid & Space(37)
                        uuid = rwPolizasDet.uuid
                        'Renglon = "M1 " & cCuenta             & Space(15) &                         cDescRef       & Space(11) & cCoa & Space(1) & cImporte & Space(1) & cidDirario & Space(1) & cImporteME & Space(1) & cConcepto & Space(1) & cSegmento & Space(1) & Space(37)
                    End If
                    filePolizaD.WriteLine(renglonD)
                Next
                renglonD = "AM " & uuid & vbNewLine & "AD " & uuid
                filePolizaD.WriteLine(renglonD)
            Next
            filePolizaD.Close()
        End If
    End Sub

    Private Sub frmGenPolizas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If varGlobal_IdEmpresa = "24" Then
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctCONEARFIN;Persist Security Info=True;User ID=finagil;Password=finagil"
            Else
                CuentasTableAdapter.Connection.ConnectionString = "Data Source=compaq01\compac;Initial Catalog=ctFINAGILCONEFINAGIL2015;Persist Security Info=True;User ID=finagil;Password=finagil"
            End If
            'TODO: esta línea de código carga datos en la tabla 'Contpaq.Cuentas' Puede moverla o quitarla según sea necesario.
            Me.CuentasTableAdapter.Fill(Me.Contpaq.Cuentas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error en conexión...")
        End Try
    End Sub

    Public Function Stuff(ByVal Cadena As String, ByVal Lado As String, ByVal Llenarcon As String, ByVal Longitud As Integer) As String

        ' Declaración de variables de datos

        Dim cCadenaAuxiliar As String
        Dim nVeces As Integer
        Dim i As Integer

        nVeces = Longitud - Val(Len(Cadena))

        cCadenaAuxiliar = ""
        For i = 1 To nVeces
            cCadenaAuxiliar = cCadenaAuxiliar & Llenarcon
        Next
        If Lado = "D" Then
            Stuff = Cadena & cCadenaAuxiliar
        Else
            Stuff = cCadenaAuxiliar & Cadena
        End If

    End Function
End Class