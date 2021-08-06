Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO

Imports PdfSharp
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports PdfSharp.Pdf.PdfDocumentOptions
Imports PdfSharp.Pdf.PdfDocument
Imports PdfSharp.Pdf.PdfDocumentInformation
Imports PdfSharp.Pdf.PdfCustomValueCompressionMode

Imports PdfSharp.PdfSharpException
Imports PdfSharp.PageSize
Imports PdfSharp.PageSizeConverter
Imports PdfSharp.PageOrientation
Imports PdfSharp.ProductVersionInfo


'Imports iTextSharp.text.pdf
'Imports iTextSharp.text.pdf.parser

Module utilerias

    Public varGlobal_IdUsuario As String
    Public varGlobal_NombreUsuario As String
    Public varGlobal_IdEmpresa As String
    Public varGlobal_Empresa As String
    Public varGlobal_rfcEmpresa As String
    Public varGlobal_idDocumento As String
    Public varGlobal_NombreCompletoUsuario As String
    Public contadorActividad As Integer
    Public contadorPagosTes As Integer
    Public contadorPagosSol As Integer
    Public contadorPagosPag As Integer
    Dim estatusProceso As Boolean = True
    Public varGlobal_ToolStrip As String

    Public Function obtNumCadena(cadena As String)
        Dim str As String = String.Empty
        For i = 0 To cadena.Trim().Length - 1
            Try
                If IsNumeric(cadena.Substring(i, 1)) Or cadena.Substring(i, 1) = "." Then
                    str += cadena.Substring(i, 1)
                End If
            Catch exp As Exception
                str = ""
            End Try
        Next
        Return str
    End Function

    Public Function validaRfc(rfc As String)
        If (Regex.IsMatch(rfc.Trim, "^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1]))([A-Z\d]{3})?$")) Then
            Return ""
        Else
            Return MsgBox("No ha ingresado un RFC válido o está incompleto", MsgBoxStyle.Information)
        End If
    End Function
    Public Function esFisicaOMoral(rfc As String)
        If rfc.Length = 12 Or rfc = "XEXX010101000" Then
            Return "M"
        ElseIf rfc.Length = 13 Then
            Return "F"
        Else
            Return MsgBox("No ha ingresado un RFC válido o está incompleto", MsgBoxStyle.Information)
        End If
    End Function
    Public Function validaMail(mail As String)
        If (Regex.IsMatch(mail.Trim, "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")) Then
            Return ""
        Else
            Return MsgBox("No ha ingresado un mail válido", MsgBoxStyle.Information)
        End If
    End Function

    Public Function deshabilitar(form As Object)
        Dim name As frmEmpresas
        name = New frmEmpresas

        Dim f As Integer
        For f = 0 To form.Controls.Count - 1
            If TypeOf form.Controls(f) Is TextBox Or TypeOf form.Controls(f) Is CheckBox Or TypeOf form.Controls(f) Is DateTimePicker Or TypeOf form.Controls(f) Is ComboBox Then
                form.Controls(f).Enabled = False
            End If
        Next
        'form.BindingNavigatorAddNewItem.Enabled = False
        'form.CXP_ProveedoresBindingNavigatorSaveItem.Enabled = True
    End Function

    Function Genera_Pass(Longitud As Byte, Optional MiCadena As String = "", Optional Codigo_ansii As Boolean = False,
Optional Numeros As Boolean = False, Optional Minusculas As Boolean = False, Optional Mayusculas As _
Boolean = False, Optional Especiales As Boolean = False, Optional bRepetir As Boolean = True)
        'Longitud = Parametro para SAber de cuantos caracteres se hara el pass
        'MiCadena = PArametro para trabajar con los caracteres seleccionados por el usuario
        'Codigo_ansi = Parametro para trabajar con todos los caracteres
        'Numeros,Minusculas,Mayusculas,Especiales = PArametros para armar la cadena con lo que seleccione el usuario
        Const sNum = "1234567890"
        Const sMin = "abcdefghijklmnopqrstuvwxyz"
        Const sMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Const sEsp = "[]{}!¡¿?#$%&/()"
        Dim sIn As String = "" 'Variable para armar la contraseña
        Dim sFi As String 'Variable para armar la cadena sobre la que se va a sacar la contraseña
        Dim i As Integer 'Variable para los bucles
        Dim iRan As Integer 'Variable para saber la posicion de donde vamos a sacar el caracter
        Dim iCadFin As Integer 'Variable para saber la longitud de la cadena armada
        Try

            sFi = "" 'Iniciamos la variable por si las dudas
            If MiCadena = "" Then 'Si esta es diferente entonces ya no arma nada
                If Codigo_ansii = True Then 'Si se escoge el codigo ansi como verdadero entonces ya no checa nada mas
                    For i = 33 To 126 'Bucle para armar la cadena con los caracteres ascii del 33 al 126
                        sFi = sFi & Chr(i)
                    Next
                Else
                    'Las siguientes condiciones son para armar la cadena segun las opciones seleccionadas
                    If Numeros = True Then sFi = sFi & sNum
                    If Minusculas = True Then sFi = sFi & sMin
                    If Mayusculas = True Then sFi = sFi & sMay
                    If Especiales = True Then sFi = sFi & sEsp
                End If
            Else
                sFi = MiCadena
            End If


            iCadFin = Len(sFi) 'Aqui se sabe la logitud de la cadena final
            If bRepetir = False Then
                If Longitud > iCadFin Then Longitud = iCadFin
            End If
            If iCadFin = 0 Or Longitud < 1 Then 'Si la cadena final es "" lo longitud es menor de 1 entonces Pone mi Alias JeJe ;-)
                Genera_Pass = "ZiTrO" : Exit Function
            End If
            For i = 1 To Longitud 'Bucle para hacer el pass con la longitud seleccionada
                Randomize() 'Empieza la funcion de numeros aleatorios
                Do
                    iRan = Math.Round(Rnd(iCadFin) * iCadFin, 0) 'Aqui generamos la posicion aleatoria de un numero valido dentro de la cadena de caracteres
                Loop While iRan = 0 'Si el azar nos da 0 lo volvemos a hacer, por que en el mid nos daria error el 0
                sIn = sIn & Mid(sFi, iRan, 1) 'Aqui ya obtenemos el caracter y lo concatenamos con el anterior
                If bRepetir = False Then
                    sFi = Replace(sFi, Mid(sFi, iRan, 1), "")
                    iCadFin = iCadFin - 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(Err.Number & " " & Err.Description, "Error a Tratar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sIn = ""
        End Try
        Return sIn
    End Function

    Function getMd5Hash(ByVal input As String) As String
        Dim md5Hasher As MD5 = MD5.Create()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Public Function Stuff(ByVal Cadena As String, ByVal Lado As String, ByVal Llenarcon As String, ByVal Longitud As Integer) As String

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

    Public Function tokenReferencia(ByVal cadena As String, ByVal lado As String, ByVal longitud As Integer, ByVal longitudMaxima As Integer) As String
        Dim aCadenaAuxiliar() As String
        Dim cCadenaAuxiliar As String = ""
        aCadenaAuxiliar = cadena.Trim.Split(" ")

        If cadena.Trim.Length >= longitudMaxima Then

            For i As Integer = 0 To aCadenaAuxiliar.Length - 1

                If aCadenaAuxiliar(i).Length > longitud Then
                    If lado = "D" Then
                        cCadenaAuxiliar += aCadenaAuxiliar(i).Substring(0, longitud) & " "
                    Else
                        cCadenaAuxiliar += aCadenaAuxiliar(i).Substring(aCadenaAuxiliar(i).Length - longitud, longitud) & " "
                    End If
                Else
                    If lado = "D" Then
                        cCadenaAuxiliar += aCadenaAuxiliar(i) & " "
                    Else
                        cCadenaAuxiliar += aCadenaAuxiliar(i) & " "
                    End If
                End If

            Next
            If cCadenaAuxiliar.Length <= longitudMaxima Then
                tokenReferencia = Eliminar_Acentos(cCadenaAuxiliar.Trim)
            Else
                tokenReferencia = Eliminar_Acentos(cCadenaAuxiliar.Substring(0, longitudMaxima).Trim)
            End If
        Else
            tokenReferencia = Eliminar_Acentos(cadena.Trim)
        End If
    End Function

    Public Function Eliminar_Acentos(ByVal accentedStr As String) As String

        accentedStr = accentedStr.Replace("ü", "u")
        accentedStr = accentedStr.Replace("Ñ", "N")
        accentedStr = accentedStr.Replace("ñ", "n")
        accentedStr = accentedStr.Replace("á", "a")
        accentedStr = accentedStr.Replace("é", "e")
        accentedStr = accentedStr.Replace("í", "i")
        accentedStr = accentedStr.Replace("ó", "o")
        accentedStr = accentedStr.Replace("ú", "u")
        accentedStr = accentedStr.Replace("Á", "A")
        accentedStr = accentedStr.Replace("É", "E")
        accentedStr = accentedStr.Replace("Ó", "O")
        accentedStr = accentedStr.Replace("Ú", "U")
        accentedStr = accentedStr.Replace("°", "o")
        accentedStr = accentedStr.Replace("Ü", "U")
        accentedStr = accentedStr.Replace(".", " ")
        accentedStr = accentedStr.Replace(",", " ")


        Dim tempBytes As Byte()
        tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(accentedStr)
        Return System.Text.Encoding.UTF8.GetString(tempBytes)
    End Function

    Public Function Eliminar_AcentosPolizas(ByVal accentedStr As String) As String
        accentedStr = accentedStr.Replace("&#224;", "a")
        accentedStr = accentedStr.Replace("&#225;", "a")
        accentedStr = accentedStr.Replace("&#192;", "A")
        accentedStr = accentedStr.Replace("&#193;", "A")

        accentedStr = accentedStr.Replace("&#232;", "e")
        accentedStr = accentedStr.Replace("&#233;", "e")
        accentedStr = accentedStr.Replace("&#200;", "E")
        accentedStr = accentedStr.Replace("&#201;", "E")

        accentedStr = accentedStr.Replace("&#236;", "i")
        accentedStr = accentedStr.Replace("&#237;", "i")
        accentedStr = accentedStr.Replace("&#204;", "I")
        accentedStr = accentedStr.Replace("&#205;", "I")

        accentedStr = accentedStr.Replace("&#242;", "o")
        accentedStr = accentedStr.Replace("&#243;", "o")
        accentedStr = accentedStr.Replace("&#210;", "O")
        accentedStr = accentedStr.Replace("&#211;", "O")

        accentedStr = accentedStr.Replace("&#249;", "u")
        accentedStr = accentedStr.Replace("&#250;", "u")
        accentedStr = accentedStr.Replace("&#217;", "U")
        accentedStr = accentedStr.Replace("&#218;", "U")

        'accentedStr = accentedStr.Replace(vbCrLf, " ")


        Dim tempBytes As Byte()
        tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(accentedStr)
        Return System.Text.Encoding.UTF8.GetString(tempBytes)
    End Function


    Sub extraePaginaSharp(ByVal origen As String, ByVal destino As String, ByVal guuid As String, ByVal tdc As String, ByVal folioSolicitud As String, ByVal tipoSolicitud As String, ByVal idBanco As String, ByVal referencia As String)
        Dim ficheroPDFOrigenDividir As PdfDocument = utilerias.Open(origen)
        Dim nombreFicheroDestinoPaginasPDF As String = Path.GetFileNameWithoutExtension(destino)
        contadorPagosSol = 0
        contadorPagosTes = 0
        contadorPagosPag = ficheroPDFOrigenDividir.PageCount


        For paginaPDFActual As Integer = 0 To ficheroPDFOrigenDividir.PageCount - 1
            ' Crear el documento PDF destino de la página extraida
            Dim ficheroPDFPaginaDestino As PdfDocument = New PdfDocument()

            ficheroPDFPaginaDestino.Info.Creator = Application.ProductName
            ficheroPDFPaginaDestino.Info.ModificationDate = DateTime.Now

            ficheroPDFPaginaDestino.Info.Title = String.Format("Página {0} de {1}", paginaPDFActual + 1, ficheroPDFOrigenDividir.PageCount)

            ' Añadir la página y guardar el fichero PDF creado
            ficheroPDFPaginaDestino.AddPage(ficheroPDFOrigenDividir.Pages(paginaPDFActual))

            Dim Pagina As Integer = paginaPDFActual + 1

            Dim nombreFicheroPDFDestino As String = Path.Combine(destino, nombreFicheroDestinoPaginasPDF & guuid & "-" + Pagina.ToString & ".pdf")

            ficheroPDFPaginaDestino.Save(nombreFicheroPDFDestino)

            leePDF(destino & guuid & "-" + Pagina.ToString & ".pdf", destino & guuid & "-" + Pagina.ToString & ".txt", guuid, Pagina, tdc, folioSolicitud, tipoSolicitud, idBanco, referencia)

            'actualiza formulario
            frmTesSolicitudesDePago.generaConsulta()
        Next
    End Sub

    Public Function Open(ByVal sFilename As String) As PdfDocument

        Dim reader As New PdfDocument()

        Try
            reader = PdfReader.Open(sFilename, PdfDocumentOpenMode.Import)
        Catch generatedExceptionName As PdfSharp.Pdf.IO.PdfReaderException
            MsgBox(generatedExceptionName.ToString)
            'caso de que pdfsharp no admita el archivo pdf
            'Dim newName As MemoryStream = ReturnCompatiblePdf(sFilename)
            'reader = PdfReader.Open(newName, PdfDocumentOpenMode.Import)
        End Try

        Return reader
    End Function

    Public Sub leePDF(ByVal origen As String, ByVal destino As String, ByVal guuid As String, ByVal pagina As Integer, ByVal tdc As String, ByVal folioSolicitud As String, ByVal tipoSolicitud As String, ByVal idBanco As String, ByVal referencia As String)
        Dim taPagos As New dsTesoreriaTableAdapters.CXP_PagosTableAdapter
        Dim taPagosTesoreria As New dsTesoreriaTableAdapters.CXP_PagosTesoreriaTableAdapter
        Dim taCuentasProv As New dsTesoreriaTableAdapters.CXP_CuentasBancariasProvTableAdapter
        Dim taCuentasBanc As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter
        Dim taImpuestos As New dsTesoreriaTableAdapters.Vw_CXP_ImpuestosCFDITableAdapter
        Dim taRegContable As New dsTesoreriaTableAdapters.CXP_RegContTableAdapter
        Dim taConceptos As New dsTesoreriaTableAdapters.CXP_ConceptosTableAdapter
        Dim taDatosSolicitud As New dsTesoreriaTableAdapters.DatosSolicitudTableAdapter
        Dim taPolizas As New dsTesoreriaTableAdapters.CXP_tipoDeDocumentoTableAdapter
        Dim taDatosPolizas As New dsTesoreriaTableAdapters.DatosPolizasTableAdapter
        Dim dtGeneralesSolicitud As New dsTesoreria.CXP_PagosTesoreriaDataTable
        Dim rwGeneralesSolicitud As dsTesoreria.CXP_PagosTesoreriaRow
        Dim taCuentasBanco As New dsTesoreriaTableAdapters.CXP_CuentaBancoTableAdapter
        Dim taAutorizaciones As New dsTesoreriaTableAdapters.Vw_CXP_AutorizacionesTableAdapter

        Dim arreglo(5) As String
        Dim escritor As StreamWriter
        Dim text As String = ""
        Dim procesadosTes, procesadosSol As Integer
        Dim idBancoXEmpresa As Integer

        If varGlobal_IdEmpresa = 24 Then idBancoXEmpresa = 1 Else idBancoXEmpresa = 2

        If System.IO.File.Exists(origen) Then
            Dim PdfReader As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(origen)
            For i = 1 To PdfReader.NumberOfPages
                procesadosSol = 0
                procesadosTes = 0
                text += i.ToString & " -- " & Trim(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(PdfReader, i) & vbNewLine & "/#/#/")
                If text.IndexOf("Tipo de operación:") >= 0 And text.IndexOf("Registro Patronal:") <= 0 Then
                    If tdc = "" Then
                        'lee PDF para llenar arreglo
                        arreglo(0) = Trim(text.Substring(text.IndexOf("Tipo de operación:") + 18, text.IndexOf("Descripción:") - (text.IndexOf("Tipo de operación:") + 18))).Replace(vbLf, "")
                        arreglo(1) = Trim(text.Substring(text.IndexOf("Cuenta de retiro:") + 17, text.IndexOf("Cuenta de depósito:") - (text.IndexOf("Cuenta de retiro:") + 17))).Replace(vbLf, "")
                        arreglo(2) = Trim(text.Substring(text.IndexOf("Cuenta de depósito:") + 19, text.IndexOf("Divisa de la cuenta:") - (text.IndexOf("Cuenta de depósito:") + 19))).Replace(vbLf, "")
                        If text.IndexOf("Importe:") > 0 Then
                            arreglo(3) = utilerias.obtNumCadena(Trim(text.Substring(text.IndexOf("Importe:") + 8, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe:") + 8))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim)
                        Else
                            arreglo(3) = utilerias.obtNumCadena(Trim(text.Substring(text.IndexOf("Importe de la operación:") + 24, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe de la operación:") + 24))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim)
                        End If
                        arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de aplicación:") + 20, 12)).Replace(vbLf, "")
                        If arreglo(0) = "Grupo Pago Mismo Banco" Or arreglo(0) = "Traspaso Mismo Banco" Then
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Motivo de pago:") + 15, text.IndexOf("Datos de confirmación de la transferencia") - (text.IndexOf("Motivo de pago:") + 15))).Replace(vbLf, " ")
                        ElseIf arreglo(0) = "Pago Mismo Banco" Then
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe de la operación:") + 24, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe de la operación:") + 24))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Motivo de pago:") + 15, text.IndexOf("Datos de confirmación de la transferencia") - (text.IndexOf("Motivo de pago:") + 15))).Replace(vbLf, " ")
                        ElseIf arreglo(0) = "Grupo Pago Interbancario" Then
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Concepto de pago:") + 17, text.IndexOf("Referencia:") - (text.IndexOf("Concepto de pago:") + 17))).Replace(vbLf, "")
                        ElseIf arreglo(0) = "Grupo Pago CIE" Then
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Descripción:") + 12, text.IndexOf("Importe:") - (text.IndexOf("Descripción:") + 12))).Replace(vbLf, "")
                        ElseIf arreglo(0) = "Pago Interbancario" Then
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Concepto de pago:") + 17, text.IndexOf("Referencia numérica:") - (text.IndexOf("Concepto de pago:") + 17))).Replace(vbLf, "")
                        End If
                        'actualiza registro correspondiente
                        If arreglo(4).Trim.ToString.Length > 10 Then
                            procesadosTes = taPagosTesoreria.CambiaEstatusPago_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, arreglo(3).Trim, arreglo(4).Substring(0, 10).Trim, taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1).Trim), 37)
                        Else
                            procesadosTes = taPagosTesoreria.CambiaEstatusPago_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, arreglo(3).Trim, arreglo(4).Trim, taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1).Trim), 37)
                        End If
                        If procesadosTes = 1 Then
                            procesadosSol = taPagos.CambiaEstatus_UpdateQuery("Pagada", taPagosTesoreria.ObtFolioSolicitud_ScalarQuery(arreglo(3).Trim, arreglo(4).Trim, taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1).Trim)), "En Proceso de Pago", varGlobal_IdEmpresa)
                            'obtienes tipo de solicitud y folio
                            taPagosTesoreria.GeneralesSolicitud_FillBy(dtGeneralesSolicitud, arreglo(3).Trim, arreglo(4).Trim, taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1).Trim), 34, varGlobal_IdEmpresa)
                            If dtGeneralesSolicitud.Rows.Count > 0 Then
                                rwGeneralesSolicitud = dtGeneralesSolicitud.Rows(0)
                                folioSolicitud = rwGeneralesSolicitud.folioSolicitud
                                tipoSolicitud = rwGeneralesSolicitud.tipoSolicitud
                            Else
                                MsgBox("No se pudo encontrar el documento relacionado", MsgBoxStyle.Critical, "")
                            End If
                        End If



                    ElseIf tdc = "TDC" Then
                        'lee PDF para llenar arreglo
                        If text.IndexOf("Tipo de operación: Pago SAT Referenciado") > 0 Then
                            arreglo(0) = Trim(text.Substring(text.IndexOf("Tipo de operación: Pago SAT Referenciado") + 18, 20)).Replace(vbLf, "")
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe de la operación:") + 24, text.IndexOf("Asunto Ordenante:") - (text.IndexOf("Importe de la operación:") + 24))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de proceso:") + 17, 12)).Replace(vbLf, "")
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Línea de captura:") + 17, text.IndexOf("Divisa Asunto Ordenante:") - (text.IndexOf("Línea de captura:") + 17))).Replace(vbLf, " ")
                        Else
                            arreglo(0) = Trim(text.Substring(text.IndexOf("Tipo de operación:") + 18, text.IndexOf("Descripción:") - (text.IndexOf("Tipo de operación:") + 18))).Replace(vbLf, "")
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe de la operación:") + 24, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe de la operación:") + 24))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de creación:") + 18, 12)).Replace(vbLf, "")
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Descripción:") + 12, text.IndexOf("Importe de la operación:") - (text.IndexOf("Descripción:") + 12))).Replace(vbLf, " ")
                        End If
                        'arreglo(1) = Trim(text.Substring(text.IndexOf("Cuenta de retiro:") + 17, text.IndexOf("Tarjeta de crédito:") - (text.IndexOf("Cuenta de retiro:") + 17))).Replace(vbLf, "")
                        'arreglo(2) = Trim(text.Substring(text.IndexOf("Tarjeta de crédito:") + 19, text.IndexOf("Divisa cuenta de retiro:") - (text.IndexOf("Tarjeta de crédito:") + 19))).Replace(vbLf, "")

                        'actualiza registro correspondiente
                        procesadosTes = taPagosTesoreria.CambiaEstatusPagoTdcTdc_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, idBanco, arreglo(4), CDec(taCuentasBanc.ConsultaChequeActual_ScalarQuery(idBancoXEmpresa)), arreglo(3).Trim, 33, folioSolicitud, tipoSolicitud)
                        taCuentasBanc.ConsumeFolioCheque_UpdateQuery(idBancoXEmpresa)
                        'procesadosTes = taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, idBanco, arreglo(3).Trim, 37, folioSolicitud, tipoSolicitud)
                        If procesadosTes = 1 Then
                            procesadosSol = taPagos.CambiaEstatus_UpdateQuery("Pagada", folioSolicitud, "No Pagada", varGlobal_IdEmpresa)
                        Else
                            estatusProceso = False
                        End If
                    ElseIf tdc = "CIE" Then
                        'lee PDF para llenar arreglo
                        arreglo(0) = Trim(text.Substring(text.IndexOf("Tipo de operación:") + 18, text.IndexOf("Descripción:") - (text.IndexOf("Tipo de operación:") + 18))).Replace(vbLf, "")
                        If text.IndexOf("Tipo de operación:") > 0 Then
                            arreglo(0) = Trim(text.Substring(text.IndexOf("Tipo de operación:") + 18, text.IndexOf("Descripción:") - (text.IndexOf("Tipo de operación:") + 18))).Replace(vbLf, "")
                            arreglo(1) = Trim(text.Substring(text.IndexOf("Cuenta de retiro:") + 17, text.IndexOf("Cuenta de depósito:") - (text.IndexOf("Cuenta de retiro:") + 17))).Replace(vbLf, "")
                            arreglo(2) = Trim(text.Substring(text.IndexOf("Cuenta de depósito:") + 19, text.IndexOf("Divisa de la cuenta:") - (text.IndexOf("Cuenta de depósito:") + 19))).Replace(vbLf, "")
                            If text.IndexOf("Importe:") > 0 Then
                                arreglo(3) = Trim(text.Substring(text.IndexOf("Importe:") + 8, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe:") + 8))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
                            Else
                                arreglo(3) = Trim(text.Substring(text.IndexOf("Importe de la operación:") + 24, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe de la operación:") + 24))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
                            End If
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de aplicación:") + 20, 12)).Replace(vbLf, "")
                        End If
                        procesadosTes = taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, idBanco, arreglo(4), arreglo(3).Trim, 37, folioSolicitud, tipoSolicitud)
                        If procesadosTes = 1 Then
                            procesadosSol = taPagos.CambiaEstatus_UpdateQuery("Pagada", folioSolicitud, "En Proceso de Pago", varGlobal_IdEmpresa)
                        End If
                    End If
                Else
                    'lee PDF para llenar arreglo
                    If text.IndexOf("Linea de Captura:") > 0 Or text.IndexOf("Línea de captura:") > 0 Then
                        If text.IndexOf("Linea de Captura:") > 0 Then
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Linea de Captura:") + 17, text.IndexOf("Entidad Receptora:") - (text.IndexOf("Linea de Captura:") + 17))).Replace(vbLf, " ")
                        End If
                        If text.IndexOf("Línea de captura:") > 0 Then
                            If text.IndexOf("Pago SAT Referenciado") > 0 Then
                                arreglo(4) = Trim(text.Substring(text.IndexOf("Línea de captura:") + 17, text.IndexOf("Divisa Asunto Ordenante:") - (text.IndexOf("Línea de captura:") + 17))).Replace(vbLf, " ")
                                arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de proceso:") + 17, 11)).Replace(vbLf, "")
                            Else
                                arreglo(4) = Trim(text.Substring(text.IndexOf("Línea de captura:") + 17, text.IndexOf("Origen de la línea de captura:") - (text.IndexOf("Línea de captura:") + 17))).Replace(vbLf, " ")
                            End If
                            If text.IndexOf("Fecha de Operación:") > 0 Then
                                arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de Operación:") + 19, 12)).Replace(vbLf, "")
                            End If
                        End If

                        'actualiza registro correspondiente
                        If text.IndexOf("Fecha de pago: Hora de Pago: Total de Pago:") > 0 Then
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de pago: Hora de Pago: Total de Pago:") + 44, 45)).Replace(vbLf, "")
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Fecha de pago: Hora de Pago: Total de Pago:") + 120, text.IndexOf("Linea de Captura:") - (text.IndexOf("Fecha de pago: Hora de Pago: Total de Pago:") + 120))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim.Replace("$", "").Trim
                        End If
                        'Importe Total de Pago:
                        If text.IndexOf("Importe Total de Pago:") > 0 Then
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe Total de Pago:") + 22, text.IndexOf("Fecha de Operación:") - (text.IndexOf("Importe Total de Pago:") + 22))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim.Replace("$", "").Trim
                        End If

                        procesadosTes = taPagosTesoreria.CambiaEstatusPagoImss_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, idBanco, arreglo(4).Trim, CDec(taCuentasBanc.ConsultaChequeActual_ScalarQuery(idBancoXEmpresa)), taCuentasProv.ObtIdPorReferencia_ScalarQuery("No Pagada", arreglo(4).Trim), folioSolicitud, varGlobal_IdEmpresa)
                        taCuentasBanc.ConsumeFolioCheque_UpdateQuery(idBancoXEmpresa)

                        If procesadosTes = 1 Then
                            procesadosSol = taPagos.CambiaEstatus_UpdateQuery("Pagada", folioSolicitud, "No Pagada", varGlobal_IdEmpresa)
                        End If
                    Else
                        If text.IndexOf("Cifra de control:") > 0 Then
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Cifra de control:") + 17, text.IndexOf("Fecha de creación:") - (text.IndexOf("Cifra de control:") + 17))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim.Replace("$", "").Trim
                        ElseIf text.IndexOf("Importe Pagado:") > 0 Then
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe Pagado:") + 15, text.IndexOf("Fecha y Hora de Pago:") - (text.IndexOf("Importe Pagado:") + 15))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim.Replace("$", "").Trim
                        ElseIf text.IndexOf("Importe de la Transacción:") > 0 Then
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe de la Transacción:") + 26, text.IndexOf("Hora de Operación:") - (text.IndexOf("Importe de la Transacción:") + 26))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim.Replace("$", "").Trim
                        ElseIf text.IndexOf("Importe de la Operación:") > 0 Then
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe de la Operación:") + 26, text.IndexOf("Cuenta de Retiro:") - (text.IndexOf("Importe de la Operación:") + 26))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim.Replace("$", "").Trim
                        End If
                        If text.IndexOf("Fecha de creación:") > 0 Then
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de creación:") + 18, 12)).Replace(vbLf, "")
                        ElseIf text.IndexOf("Fecha y Hora de Pago:") > 0 Then
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha y Hora de Pago:") + 21, 12)).Replace(vbLf, "")
                        ElseIf text.IndexOf("Fecha de Operación:") > 0 Then
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de Operación:") + 19, 12)).Replace(vbLf, "")
                        ElseIf text.IndexOf("Fecha de pago:") > 0 Then
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de pago:") + 19, 12)).Replace(vbLf, "")
                        End If

                        If text.IndexOf("Línea de Captura:") > 0 Then
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Línea de Captura:") + 17, text.IndexOf("Importe Pagado:") - (text.IndexOf("Línea de Captura:") + 17))).Replace(vbLf, " ")
                        End If
                        'actualiza registro correspondiente
                        procesadosTes = taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, idBanco, arreglo(4), arreglo(3).Trim, 33, folioSolicitud, tipoSolicitud)
                        If procesadosTes = 1 Then
                            procesadosSol = taPagos.CambiaEstatus_UpdateQuery("Pagada", folioSolicitud, "No Pagada", varGlobal_IdEmpresa)
                        End If
                    End If

                End If
                taCuentasBanco.CambiaEstatus_UpdateQuery(True, arreglo(2))

            Next
            PdfReader.Close()
        End If


        If procesadosTes = 1 Then
            contadorPagosTes += 1
        Else
            System.IO.File.Delete(destino & guuid & "-" + pagina.ToString & ".pdf")
        End If

        If procesadosSol = 1 Then
            contadorPagosSol += 1
        End If

        If procesadosTes = 1 Then
            Try

                Dim fechaHorActual As Date = CDate(arreglo(5))
                'contadorPagosTes += 1
                Dim dtDatosSolicitud As New dsTesoreria.DatosSolicitudDataTable
                Dim rwDatosSolTmp As dsTesoreria.DatosSolicitudRow
                Dim dtDatosDetalleSolicitud As New dsTesoreria.DatosSolicitudDataTable
                Dim taCuentasConpaq As New contpaqTableAdapters.CuentasTableAdapter
                Dim taDatosAnexos As New dsProductionTableAdapters.SacaIVAanexoTableAdapter
                Dim taFactoraje As New dsTesoreriaTableAdapters.FactorajeTableAdapter
                Dim dtFactoraje As New dsTesoreria.FactorajeDataTable
                Dim taGenCorreos As New dsProductionTableAdapters.GEN_CorreosFasesTableAdapter
                Dim dtGenCorreos As New dsProduction.GEN_CorreosFasesDataTable
                Dim taGenCorreosFinagil As New dsProductionTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
                Dim taSugPagos As New dsTesoreriaTableAdapters.Vw_CXP_SugPagoTesoreriaTableAdapter
                Dim dtSugPagos As New dsTesoreria.Vw_CXP_SugPagoTesoreriaDataTable
                Dim taCorreosProveedores As New dsHerramientasTableAdapters.DatosPagosTableAdapter
                Dim dtCorreosProveedores As New dsHerramientas.DatosPagosDataTable
                Dim rwCorreosProveedores As dsHerramientas.DatosPagosRow
                Dim taDetallePago As New dsHerramientasTableAdapters.CXP_PagosTableAdapter
                Dim dtDetallePago As New dsHerramientas.CXP_PagosDataTable
                Dim rwDetallePago As dsHerramientas.CXP_PagosRow
                Dim rwDetallePagoEnc As dsHerramientas.CXP_PagosRow
                Dim taCuentasBancarias As New dsTesoreriaTableAdapters.CXP_CuentasBancariasTableAdapter


                taDatosSolicitud.SolicitudesDePago_FillBy(dtDatosSolicitud, tipoSolicitud, folioSolicitud, arreglo(3))
                If dtDatosSolicitud.Rows.Count > 0 Then
                    rwDatosSolTmp = dtDatosSolicitud.Rows(0)
                    Dim tipoPoliza As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa)
                    Dim origenRecurso As Integer = taCuentasBanc.ObtieneCuentaContable_ScalarQuery(rwDatosSolTmp.origenRecurso)
                    Dim folioPoliza As Integer = taPolizas.ConsultaUltimoFolio_ScalarQuery(tipoPoliza, varGlobal_IdEmpresa)


                    'Notifica pago
                    taCorreosProveedores.Fill(dtCorreosProveedores, rwDatosSolTmp.idProveedor)
                    Dim contNotifica As Integer = 0

                    For Each rwCorreosProveedores In dtCorreosProveedores.Rows
                        If rwCorreosProveedores.notificaPago = True Then
                            taDetallePago.Fill(dtDetallePago, rwDatosSolTmp.tipoSolicitud, varGlobal_IdEmpresa, rwDatosSolTmp.folioSolicitud)
                            If dtDetallePago.Rows.Count > 0 Then
                                rwDetallePagoEnc = dtDetallePago.Rows(0)
                                Dim mensaje As String = "<html><body><font size=3 face='Arial'><h1><font size=3 align'center'> Estimado (a): " & rwDetallePagoEnc.razonSocial &
                                    " le notificamos que se ha pagado la solicitud " & tipoSolicitud & " - " & folioSolicitud & " por la cantidad de " & FormatCurrency(rwDetallePagoEnc.importe) & " que contiene los siguientes comprobantes: " &
                                    "<table align='center' border='1' cellspacing='0' cellpadding='2'>" &
                                    "<tr>" &
                                        "<td>Folio de Factura</td>" &
                                        "<td>Serie</td>" &
                                        "<td>UUID</td>" &
                                        "<td>Importe Factura</td>" &
                                        "<td>Importe Pagado</td>" &
                                        "<td>Moneda</td>" &
                                        "<td>Fecha Pago</td>" &
                                        "<td>Referencia</td>" &
                                    "</tr>"
                                For Each rwDetallePago In dtDetallePago.Rows
                                    mensaje = mensaje &
                                     "<tr>" &
                                        "<td>" & rwDetallePago.folio & "</td>" &
                                        "<td>" & rwDetallePago.serie & "</td>" &
                                        "<td>" & rwDetallePago.uuid & "</td>" &
                                        "<td>" & rwDetallePago.total.ToString("c") & "</td>" &
                                        "<td>" & rwDetallePago.totalPagado.ToString("c") & "</td>" &
                                        "<td>" & rwDetallePago.monedaPago & "</td>" &
                                        "<td>" & rwDetallePago.fechaPago & "</td>" &
                                        "<td>" & rwDetallePago.referencia & "</td>" &
                                    "</tr>"
                                Next
                                mensaje = mensaje & "</table>" & vbNewLine &
                                "<HR width=20%>" &
                                    "<tfoot><tr><font align=" & Chr(34) & "center" & Chr(34) & "size=3 face=" & Chr(34) & "Arial" & Chr(34) & ">" & "Atentamente: " & rwDetallePagoEnc.nombreEmpresa & vbNewLine & "</font></tr></tfoot>" &
                                "</body></html>"
                                If rwCorreosProveedores.adjuntaComprobante = True Then
                                    taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", rwCorreosProveedores.direccionCorreo, "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "CXP\ComPago\" & rwDetallePagoEnc.uuidPago & ".pdf")
                                    taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", "viapolo@finagil.com.mx", "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "CXP\ComPago\" & rwDetallePagoEnc.uuidPago & ".pdf")
                                Else
                                    taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", rwCorreosProveedores.direccionCorreo, "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "")
                                    taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", "viapolo@finagil.com.mx", "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "")
                                End If
                                If rwCorreosProveedores.notificaContabilidad = True And contNotifica = 0 Then
                                    taGenCorreosFinagil.Insert("Pagos@finagil.com.mx", "lgarcia@finagil.com.mx", "Notificación de pago de Factura: " & rwDetallePagoEnc.idEmpresas.ToString.Replace("24", "Servicios Arfin").Replace("23", "Finagil"), mensaje, False, Date.Now, "CXP\ComPago\" & rwDetallePagoEnc.uuidPago & ".pdf")
                                End If
                            End If
                        End If
                        contNotifica += 1
                    Next
                    'Termina notifica pago

                    If rwDatosSolTmp.tipoSolicitud = "CXP" Then
                        If taConceptos.GeneraEventoContable_ScalarQuery(rwDatosSolTmp.idConcepto) = 1 Then
                            If tipoPoliza <> 0 Then
                                If rwDatosSolTmp.idConcepto = 43 Then
                                    'Pago de contratos L, R y S
                                    taDatosSolicitud.Detalle_Contabilidad_Tradic_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, folioSolicitud)
                                    If dtDatosDetalleSolicitud.Rows.Count > 0 Then
                                        'Dim perImpuesto As Decimal = taDatosAnexos.ScalarQuery_SacaIVAAnexo(rwDatosSolTmp.noContrato)
                                        For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                                            If rwDetalleEvento.Tipar = "L" Or rwDetalleEvento.Tipar = "R" Or rwDetalleEvento.Tipar = "S" Then
                                                'cargo
                                                taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("2311040100000000"), rwDetalleEvento.idProveedor, rwDetalleEvento.subtotalPagado, 0, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                'abono
                                                taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.importeSolicitado, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                            ElseIf rwDetalleEvento.Tipar = "B" Then
                                                Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
                                                taImpuestos.Fill(dtImpuestos, rwDetalleEvento.uuid)
                                                For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestos
                                                    Dim efecto As String = ""
                                                    Dim tipo As String = ""
                                                    Dim retecionL As String = ""
                                                    Dim mPago As Decimal = 0
                                                    Dim percentPago As Decimal
                                                    Dim tasaGen As String = ""
                                                    Dim idCuenta As Integer = 0

                                                    If rwDetalleEvento.totalOrg > 0 Then
                                                        percentPago = CDec(rwDetalleEvento.totalPagado) / CDec(rwDetalleEvento.totalOrg)
                                                    Else
                                                        percentPago = 1
                                                    End If

                                                    If rowsCfdi.mTras <> "X" Then
                                                        efecto = "TRA"
                                                        mPago = Math.Round(CDec(Val(rowsCfdi.mTras) * percentPago), 2)
                                                        tipo = "Federal"
                                                        If rowsCfdi.tasaOCuota = "0.080000" Then
                                                            idCuenta = taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040100080000")
                                                        ElseIf rowsCfdi.tasaOCuota = "0.160000" Then
                                                            idCuenta = taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040100060000")
                                                        End If
                                                        taRegContable.Insert(idCuenta, CDec(rwDetalleEvento.idProveedor), CDec(mPago), 0, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, CDec(tipoPoliza), CDec(folioPoliza), CDec(varGlobal_IdEmpresa), rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, CDec(rwDetalleEvento.idConcepto), 2, rwDatosSolTmp.tipoSolicitud)
                                                        taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040300000000"), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                    End If
                                                Next
                                            End If
                                        Next
                                    Else
                                        taDatosSolicitud.Detalle_ContabilidadTradCfdi_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, folioSolicitud)
                                        For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                                            If rwDetalleEvento.Tipar = "B" Or rwDetalleEvento.Tipar = "F" Then
                                                Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
                                                Dim percentPago As Decimal
                                                taImpuestos.Fill(dtImpuestos, rwDetalleEvento.uuid)

                                                If rwDetalleEvento.totalOrg > 0 Then
                                                    percentPago = CDec(rwDetalleEvento.totalPagado) / CDec(rwDetalleEvento.totalOrg)
                                                Else
                                                    percentPago = 1
                                                End If
                                                'cargo
                                                taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("2311040100000000"), CDec(rwDetalleEvento.idProveedor), CDec(rwDetalleEvento.totalPagado), 0, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, CDec(tipoPoliza), CDec(folioPoliza), CDec(varGlobal_IdEmpresa), rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, CDec(rwDetalleEvento.idConcepto), 2, rwDatosSolTmp.tipoSolicitud)

                                                For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestos
                                                    Dim efecto As String = ""
                                                    Dim tipo As String = ""
                                                    Dim retecionL As String = ""
                                                    Dim mPago As Decimal = 0

                                                    Dim tasaGen As String = ""
                                                    Dim idCuenta As Integer = 0



                                                    If rowsCfdi.mTras <> "X" Then
                                                        efecto = "TRA"
                                                        mPago = Math.Round(CDec(Val(rowsCfdi.mTras) * percentPago), 2)
                                                        tipo = "Federal"
                                                        If rowsCfdi.tasaOCuota = "0.080000" Then
                                                            idCuenta = taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040100080000")
                                                        ElseIf rowsCfdi.tasaOCuota = "0.160000" Then
                                                            idCuenta = taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040100060000")
                                                        End If
                                                        taRegContable.Insert(idCuenta, CDec(rwDetalleEvento.idProveedor), CDec(mPago), 0, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, CDec(tipoPoliza), CDec(folioPoliza), CDec(varGlobal_IdEmpresa), rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, CDec(rwDetalleEvento.idConcepto), 2, rwDatosSolTmp.tipoSolicitud)
                                                        taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040300000000"), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                    End If
                                                Next
                                                taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.totalPagado, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                            End If
                                            If rwDetalleEvento.Tipar = "P" Then
                                                Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
                                                Dim percentPago As Decimal
                                                taImpuestos.Fill(dtImpuestos, rwDetalleEvento.uuid)

                                                If rwDetalleEvento.totalOrg > 0 Then
                                                    percentPago = CDec(rwDetalleEvento.totalPagado) / CDec(rwDetalleEvento.totalOrg)
                                                Else
                                                    percentPago = 1
                                                End If
                                                'cargo
                                                taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("2311040100000000"), CDec(rwDetalleEvento.idProveedor), CDec(rwDetalleEvento.totalPagado), 0, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, CDec(tipoPoliza), CDec(folioPoliza), CDec(varGlobal_IdEmpresa), rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, CDec(rwDetalleEvento.idConcepto), 2, rwDatosSolTmp.tipoSolicitud)

                                                For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestos
                                                    Dim efecto As String = ""
                                                    Dim tipo As String = ""
                                                    Dim retecionL As String = ""
                                                    Dim mPago As Decimal = 0

                                                    Dim tasaGen As String = ""
                                                    Dim idCuenta As Integer = 0



                                                    If rowsCfdi.mTras <> "X" Then
                                                        efecto = "TRA"
                                                        mPago = Math.Round(CDec(Val(rowsCfdi.mTras) * percentPago), 2)
                                                        tipo = "Federal"
                                                        If rowsCfdi.tasaOCuota = "0.080000" Then
                                                            idCuenta = taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040100070000")
                                                        ElseIf rowsCfdi.tasaOCuota = "0.160000" Then
                                                            idCuenta = taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040100020000")
                                                        End If
                                                        taRegContable.Insert(idCuenta, CDec(rwDetalleEvento.idProveedor), CDec(mPago), 0, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, CDec(tipoPoliza), CDec(folioPoliza), CDec(varGlobal_IdEmpresa), rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, CDec(rwDetalleEvento.idConcepto), 2, rwDatosSolTmp.tipoSolicitud)
                                                        'taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("1501040300000000"), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                    End If
                                                Next
                                                taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.totalPagado, rwDetalleEvento.noContrato, rwDetalleEvento.Descr, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                            End If
                                        Next
                                    End If
                                    taPolizas.ConsumeUltimoFolio_UpdateQuery(taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa), varGlobal_IdEmpresa)
                                    'Termina pago de contratos
                                Else
                                    'taDatosSolicitud.Detalle_Contabilidad_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, rwDatosSolTmp.referencia, folioSolicitud)
                                    If rwDatosSolTmp.idConcepto <> 40 And rwDatosSolTmp.idConcepto <> 42 Then
                                        taDatosSolicitud.DetalleSinReferencia_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, folioSolicitud)
                                        If dtDatosDetalleSolicitud.Rows.Count > 0 Then
                                            For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                                                Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
                                                taImpuestos.Fill(dtImpuestos, rwDetalleEvento.uuid)
                                                Dim contador As Integer = 0

                                                If rwDatosSolTmp.idConcepto = 34 Or rwDatosSolTmp.idConcepto = 41 Then
                                                    'Dim folioCheque As Integer = taCuentasBancarias.ConsultaChequeActual_ScalarQuery(idBanco)
                                                    'Dim fechaProceso As Date = Date.Now
                                                    'taPagosTesoreria.CambiaEstatus_UpdateQuery(34, fechaProceso, Eliminar_Acentos(referencia.Trim), idBanco, folioCheque, tipoSolicitud, folioSolicitud, 34, varGlobal_IdEmpresa)
                                                    'cargo
                                                    taRegContable.Insert(rwDetalleEvento.ctaCargoPago, rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, "GASTOS A COMPROBAR", rwDetalleEvento.razonSocial & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                    'abono
                                                    taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.totalPagado, "GASTOS A COMPROBAR", rwDetalleEvento.razonSocial & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                    'taCuentasBancarias.ConsumeFolioCheque_UpdateQuery(idBanco)
                                                Else
                                                    If rwDetalleEvento.serie = "PSC" Then
                                                        Dim conceptoCorto As String = taAutorizaciones.ObtConcepto_ScalarQuery(varGlobal_IdEmpresa, CInt(folioSolicitud), rwDatosSolTmp.tipoSolicitud)
                                                        If conceptoCorto.Length > 20 Then
                                                            conceptoCorto = conceptoCorto.Substring(0, 19)
                                                        End If

                                                        If rwDatosSolTmp.idConcepto = 102 Then 'Devolución saldos a favor
                                                            'cargo
                                                            taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("231101900008" & rwDetalleEvento.noContrato.Substring(1, 4)), rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, conceptoCorto, rwDetalleEvento.folio.Replace("PROVEEDOR", "") & " " & rwDetalleEvento.razonSocial.Trim & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                            'abono
                                                            taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.totalPagado, conceptoCorto, rwDetalleEvento.folio.Replace("PROVEEDOR", "") & " " & rwDetalleEvento.razonSocial.Trim & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                        Else
                                                            'cargo
                                                            taRegContable.Insert(rwDetalleEvento.ctaCargoPago, rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, conceptoCorto, rwDetalleEvento.folio.Replace("PROVEEDOR", "") & " " & rwDetalleEvento.razonSocial & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                            'abono
                                                            taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.totalPagado, conceptoCorto, rwDetalleEvento.folio.Replace("PROVEEDOR", "") & " " & rwDetalleEvento.razonSocial.Trim & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                        End If
                                                    Else
                                                        'cargo
                                                        taRegContable.Insert(rwDetalleEvento.ctaCargoPago, rwDetalleEvento.idProveedor, rwDetalleEvento.totalPagado, 0, "PAGO-F-" & rwDetalleEvento.folio.Replace("PROVEEDOR", ""), "F-" & rwDetalleEvento.folio.Replace("PROVEEDOR", "") & " " & rwDetalleEvento.razonSocial.Trim & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                        'abono
                                                        taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.totalPagado, "PAGO-F-" & rwDetalleEvento.folio.Replace("PROVEEDOR", ""), "F-" & rwDetalleEvento.folio.Replace("PROVEEDOR", "") & " " & rwDetalleEvento.razonSocial.Trim & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                    End If
                                                End If


                                                For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestos
                                                    Dim efecto As String = ""
                                                    Dim tipo As String = ""
                                                    Dim retecionL As String = ""
                                                    Dim mPago As Decimal = 0
                                                    Dim percentPago As Decimal

                                                    If rwDetalleEvento.totalOrg > 0 Then
                                                        percentPago = CDec(rwDetalleEvento.totalPagado) / CDec(rwDetalleEvento.totalOrg)
                                                    Else
                                                        percentPago = 1
                                                    End If



                                                    If rowsCfdi.mTras <> "X" Then
                                                        efecto = "TRA"
                                                        mPago = Math.Round(CDec(Val(rowsCfdi.mTras) * percentPago), 2)
                                                        tipo = "Federal"
                                                        taRegContable.Insert(CDec(taConceptos.ObtCtaImpTrasPago_ScalarQuery(rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P", rowsCfdi.tasaOCuota.ToString.Replace("0.000000", "0.000099"), CDec(varGlobal_IdEmpresa), rwDetalleEvento.idConcepto)), CDec(rwDetalleEvento.idProveedor), CDec(mPago), 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, CDec(tipoPoliza), CDec(folioPoliza), CDec(varGlobal_IdEmpresa), rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, CDec(rwDetalleEvento.idConcepto), 2, rwDatosSolTmp.tipoSolicitud)
                                                        taRegContable.Insert(CDec(taConceptos.ObtCtaImpTraSol_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S", CDec(varGlobal_IdEmpresa))), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                    End If

                                                    If rowsCfdi.mRet <> "X" Then
                                                        efecto = "RET"
                                                        mPago = Math.Round(CDec(Val(rowsCfdi.mRet) * percentPago), 2)
                                                        tipo = "Federal"
                                                        taRegContable.Insert(CDec(taConceptos.ObtCtaImpTrasPago_ScalarQuery(rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P", rowsCfdi.tasaOCuota, CDec(varGlobal_IdEmpresa), rwDetalleEvento.idConcepto)), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                        taRegContable.Insert(CDec(taConceptos.ObtCtaImpTraSol_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S", CDec(varGlobal_IdEmpresa))), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                    End If

                                                    If contador = 0 Then
                                                        If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                                                            efecto = "LOC"
                                                            mPago = Math.Round(CDec(Val(rowsCfdi.mLocTra) * percentPago), 2)
                                                            tipo = "Local"
                                                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "TRA", "P")), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "TRA", "S")), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                        End If

                                                        If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                                                            efecto = "LOC"
                                                            mPago = Math.Round(CDec(Val(rowsCfdi.mLocRet) * percentPago), 2)
                                                            tipo = "Local"
                                                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "RET", "P")), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "RET", "S")), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                                                        End If
                                                    End If

                                                    contador += 1
                                                Next

                                            Next
                                        Else

                                        End If
                                        taPolizas.ConsumeUltimoFolio_UpdateQuery(taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa), varGlobal_IdEmpresa)
                                    End If
                                End If
                            End If
                        End If
                    ElseIf rwDatosSolTmp.tipoSolicitud = "AVI" Then

                        taDatosSolicitud.Detalle_Contabilidad_Avio_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, arreglo(4).Trim, folioSolicitud)
                        For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                            'cargo
                            taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("231101900020" & rwDetalleEvento.referencia.Substring(1, 4)), rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, rwDetalleEvento.referencia.Substring(0, 11), rwDetalleEvento.referencia.Substring(9, 2) & "-" & rwDetalleEvento.razonSocial, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                            'abono
                            taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.importeSolicitado, rwDetalleEvento.referencia.Substring(0, 11), rwDetalleEvento.referencia.Substring(9, 2) & "-" & rwDetalleEvento.razonSocial, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                        Next
                        taPolizas.ConsumeUltimoFolio_UpdateQuery(taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa), varGlobal_IdEmpresa)
                        ''''Para otro tipo de asientos
                    ElseIf rwDatosSolTmp.tipoSolicitud = "FAC" Then
                        'Envia correo del pago
                        taFactoraje.Fill(dtFactoraje, arreglo(4).Trim)
                        taSugPagos.DatosSolicitud_FillBy(dtSugPagos, "FAC", folioSolicitud)

                        Dim rwSugPago As dsTesoreria.Vw_CXP_SugPagoTesoreriaRow
                        If dtSugPagos.Rows.Count > 0 Then
                            rwSugPago = dtSugPagos.Rows(0)
                        End If

                        Dim rwFactoraje As dsTesoreria.FactorajeRow
                        If dtFactoraje.Rows.Count > 0 Then
                            rwFactoraje = dtFactoraje.Rows(0)
                            If rwFactoraje.existe = 0 Then
                                taGenCorreos.Fill(dtGenCorreos, "Riesgos")
                                For Each rwGenCorreos As dsProduction.GEN_CorreosFasesRow In dtGenCorreos.Rows
                                    taGenCorreosFinagil.Insert("PagosFactoraje@finagil.com.mx", rwGenCorreos.Correo, "Confirmación de pago: " & rwSugPago.razonSocial, "Cliente: " & rwSugPago.razonSocial & vbNewLine & " Importe: " & FormatCurrency(rwSugPago.importeSolicitado) & " Moneda:" & rwSugPago.monedaPago, False, Date.Now, "")
                                Next
                                taGenCorreosFinagil.Insert("PagosFactoraje@finagil.com.mx", "viapolo@cmoderna.com", "Confirmación de pago: " & rwSugPago.razonSocial, "Cliente: " & rwSugPago.razonSocial & vbNewLine & " Importe: " & FormatCurrency(rwSugPago.importeSolicitado) & " Moneda:" & rwSugPago.monedaPago, False, Date.Now, "")
                            End If
                        End If
                    ElseIf rwDatosSolTmp.tipoSolicitud = "TRA" Then
                        taDatosSolicitud.Detalle_Contabilidad_Avio_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, arreglo(4).Trim, folioSolicitud)
                        For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                            'cargo
                            taRegContable.Insert(taCuentasBanc.ObtieneCuentaContable_ScalarQuery(taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(2))), rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, rwDetalleEvento.referencia, "TRASPASO ENTRE CUENTAS " & taCuentasBanc.ObtNombreCuenta_ScalarQuery(taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1))) & " A " & taCuentasBanc.ObtNombreCuenta_ScalarQuery(taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(2))), tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                            'abono
                            taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.importeSolicitado, rwDetalleEvento.referencia, "TRASPASO ENTRE CUENTAS " & taCuentasBanc.ObtNombreCuenta_ScalarQuery(taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1))) & " A " & taCuentasBanc.ObtNombreCuenta_ScalarQuery(taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(2))), tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 40, rwDetalleEvento.idConcepto, 2, rwDatosSolTmp.tipoSolicitud)
                        Next
                        taPolizas.ConsumeUltimoFolio_UpdateQuery(taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa), varGlobal_IdEmpresa)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
                Exit Sub
            End Try
        End If

        escritor = File.AppendText(destino)
        escritor.Write(arreglo(0) & vbNewLine & arreglo(1) & vbNewLine & arreglo(2) & vbNewLine & arreglo(3) & vbNewLine & arreglo(4))
        escritor.Flush()
        escritor.Close()
    End Sub

    Public Sub insertaCuentaNuevaEnBanco(ByVal idProveedor As Integer, ByVal razonSocial As String)
        Dim taCuentasProveedores As New dsConfiguracionTableAdapters.CXP_CuentasBancariasProvTableAdapter
        Dim dtCuentasProveedores As New dsConfiguracion.CXP_CuentasBancariasProvDataTable
        Dim drCuentasProveedores As dsConfiguracion.CXP_CuentasBancariasProvRow
        Dim taCuentasBancos As New dsConfiguracionTableAdapters.CXP_CuentaBancoTableAdapter

        taCuentasProveedores.ObtCtasProv_FillBy(dtCuentasProveedores, idProveedor)
        For Each drCuentasProveedores In dtCuentasProveedores.Rows
            If taCuentasBancos.ExisteCuentaLike_ScalarQuery(drCuentasProveedores.cuenta) = "NE" Then
                If drCuentasProveedores.idBanco = 4 Then
                    taCuentasBancos.Insert(drCuentasProveedores.clabe, drCuentasProveedores.moneda, razonSocial, "TER", False)
                Else
                    taCuentasBancos.Insert(drCuentasProveedores.clabe, drCuentasProveedores.moneda, razonSocial, "INT", False)
                End If
            End If
        Next
    End Sub

    Public Function obtienePermisosLecturEscritura(ByVal nombreToolStrip As String)
        Dim lectura As Boolean = False
        Dim taPermisos As New dsProductionTableAdapters.PermisosPerfilesTableAdapter
        Dim dtPermisos As New dsProduction.PermisosPerfilesDataTable
        Dim drPermisos As dsProduction.PermisosPerfilesRow

        taPermisos.PermisosLectura_FillBy(dtPermisos, nombreToolStrip, varGlobal_IdUsuario)
        For Each drPermisos In dtPermisos
            If drPermisos.submenu2 = nombreToolStrip.Replace("ToolStripMenuItem", "") Then
                lectura = drPermisos.lecturaEscritura
                Exit For
            Else
                If drPermisos.submenu1 = nombreToolStrip.Replace("ToolStripMenuItem", "") Then
                    lectura = drPermisos.lecturaEscritura
                    Exit For
                End If
            End If
        Next
        Return lectura
    End Function

    Public Sub habilitaControles(ByVal formulario As Object, ByVal estatus As Boolean)
        Dim f As Integer
        For f = 0 To formulario.Controls.Count - 1
            If TypeOf formulario.Controls(f) Is TextBox Or TypeOf formulario.Controls(f) Is CheckBox Or TypeOf formulario.Controls(f) Is DateTimePicker Or TypeOf formulario.Controls(f) Is ComboBox Or TypeOf formulario.Controls(f) Is Label Or TypeOf formulario.Controls(f) Is DataGridView Then
                formulario.Controls(f).Enabled = estatus
            End If
        Next
    End Sub

End Module
