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


        Dim tempBytes As Byte()
        tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(accentedStr)
        Return System.Text.Encoding.UTF8.GetString(tempBytes)
    End Function

    Sub GuardarOtroFormato(PDFPath As String, FileExtension As String)

        'Saves a PDF file as another format using Adobe Professional.

        'By Christos Samaras
        'http://www.myengineeringworld.net

        'In order to use the macro you must enable the Acrobat library from VBA editor:
        'Go to Tools -> References -> Adobe Acrobat xx.0 Type Library, where xx depends
        'on your Acrobat Professional version (i.e. 9.0 or 10.0) you have installed to your PC.

        'Alternatively you can find it Tools -> References -> Browse and check for the path
        'C:\Program Files\Adobe\Acrobat xx.0\Acrobat\acrobat.tlb
        'where xx is your Acrobat version (i.e. 9.0 or 10.0 etc.).

        Dim objAcroApp As Acrobat.AcroApp
        Dim objAcroAVDoc As Acrobat.AcroAVDoc
        Dim objAcroPDDoc As Acrobat.AcroPDDoc
        Dim objJSO As Object
        Dim boResult As Boolean
        Dim ExportFormat As String
        Dim NewFilePath As String


        'Check if the file exists.
        If Dir(PDFPath) = "" Then
            MsgBox("Cannot find the PDF file!" & vbCrLf & "Check the PDF path and retry.",
                    vbCritical, "File Path Error")
            Exit Sub
        End If

        'Check if the input file is a PDF file.
        If System.IO.Path.GetExtension(PDFPath) <> ".pdf" Then
            MsgBox("The input file is not a PDF file!", vbCritical, "File Type Error")
            Exit Sub
        End If

        'Initialize Acrobat by creating App object.
        objAcroApp = CreateObject("AcroExch.App")

        'Set AVDoc object.
        objAcroAVDoc = CreateObject("AcroExch.AVDoc")

        'Open the PDF file.
        boResult = objAcroAVDoc.Open(PDFPath, "")

        'Set the PDDoc object.
        objAcroPDDoc = objAcroAVDoc.GetPDDoc

        'Set the JS Object - Java Script Object.
        objJSO = objAcroPDDoc.GetJSObject

        'Check the type of conversion.
        Select Case LCase(FileExtension)
            Case "eps" : ExportFormat = "com.adobe.acrobat.eps"
            Case "html", "htm" : ExportFormat = "com.adobe.acrobat.html"
            Case "jpeg", "jpg", "jpe" : ExportFormat = "com.adobe.acrobat.jpeg"
            Case "jpf", "jpx", "jp2", "j2k", "j2c", "jpc" : ExportFormat = "com.adobe.acrobat.jp2k"
            Case "docx" : ExportFormat = "com.adobe.acrobat.docx"
            Case "doc" : ExportFormat = "com.adobe.acrobat.doc"
            Case "png" : ExportFormat = "com.adobe.acrobat.png"
            Case "ps" : ExportFormat = "com.adobe.acrobat.ps"
            Case "rft" : ExportFormat = "com.adobe.acrobat.rft"
            Case "xlsx" : ExportFormat = "com.adobe.acrobat.xlsx"
            Case "xls" : ExportFormat = "com.adobe.acrobat.spreadsheet"
            Case "txt" : ExportFormat = "com.adobe.acrobat.accesstext"
            Case "tiff", "tif" : ExportFormat = "com.adobe.acrobat.tiff"
            Case "xml" : ExportFormat = "com.adobe.acrobat.xml-1-00"
            Case Else : ExportFormat = "Wrong Input"
        End Select

        'Check if the format is correct and there are no errors.
        If ExportFormat <> "Wrong Input" And Err.Number = 0 Then

            'Format is correct and no errors.

            'Set the path of the new file. Note that Adobe instead of xls uses xml files.
            'That's why here the xls extension changes to xml.
            If LCase(FileExtension) <> "xls" Then
                NewFilePath = Regex.Replace(PDFPath, ".pdf", "." & LCase(FileExtension))
            Else
                NewFilePath = Regex.Replace(PDFPath, ".pdf", ".xml")
            End If

            'Save PDF file to the new format.
            boResult = objJSO.SaveAs(NewFilePath, ExportFormat)
            'objJSO.saveas
            'Close the PDF file without saving the changes.
            boResult = objAcroAVDoc.Close(True)

            'Close the Acrobat application.
            boResult = objAcroApp.Exit

            'Inform the user that conversion was successfully.
            MsgBox("The PDf file:" & vbNewLine & PDFPath & vbNewLine & vbNewLine &
            "Was saved as: " & vbNewLine & NewFilePath, vbInformation, "Conversion finished successfully")

        Else

            'Something went wrong, so close the PDF file and the application.

            'Close the PDF file without saving the changes.
            boResult = objAcroAVDoc.Close(True)

            'Close the Acrobat application.
            boResult = objAcroApp.Exit

            'Inform the user that something went wrong.
            MsgBox("Something went wrong!" & vbNewLine & "The conversion of the following PDF file FAILED:" &
            vbNewLine & PDFPath, vbInformation, "Conversion failed")

        End If

        'Release the objects.
        objAcroPDDoc = Nothing
        objAcroAVDoc = Nothing
        objAcroApp = Nothing

    End Sub

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

        Dim arreglo(5) As String
        Dim escritor As StreamWriter
        Dim text As String = ""
        Dim procesadosTes, procesadosSol As Integer

        If System.IO.File.Exists(origen) Then
            Dim PdfReader As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(origen)
            For i = 1 To PdfReader.NumberOfPages
                procesadosSol = 0
                procesadosTes = 0
                text += i.ToString & " -- " & Trim(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(PdfReader, i) & vbNewLine & "/#/#/")
                If text.IndexOf("Tipo de operación:") >= 0 Then
                    If tdc = "" Then
                        'lee PDF para llenar arreglo
                        arreglo(0) = Trim(text.Substring(text.IndexOf("Tipo de operación:") + 18, text.IndexOf("Descripción:") - (text.IndexOf("Tipo de operación:") + 18))).Replace(vbLf, "")
                        arreglo(1) = Trim(text.Substring(text.IndexOf("Cuenta de retiro:") + 17, text.IndexOf("Cuenta de depósito:") - (text.IndexOf("Cuenta de retiro:") + 17))).Replace(vbLf, "")
                        arreglo(2) = Trim(text.Substring(text.IndexOf("Cuenta de depósito:") + 19, text.IndexOf("Divisa de la cuenta:") - (text.IndexOf("Cuenta de depósito:") + 19))).Replace(vbLf, "")
                        If text.IndexOf("Importe:") > 0 Then
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe:") + 8, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe:") + 8))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
                        Else
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe de la operación:") + 24, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe de la operación:") + 24))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
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
                            arreglo(0) = Trim(text.Substring(text.IndexOf("Tipo de operación:") + 18, text.IndexOf("Descripción:") - (text.IndexOf("Tipo de operación:") + 18))).Replace(vbLf, "")
                            'arreglo(1) = Trim(text.Substring(text.IndexOf("Cuenta de retiro:") + 17, text.IndexOf("Tarjeta de crédito:") - (text.IndexOf("Cuenta de retiro:") + 17))).Replace(vbLf, "")
                            'arreglo(2) = Trim(text.Substring(text.IndexOf("Tarjeta de crédito:") + 19, text.IndexOf("Divisa cuenta de retiro:") - (text.IndexOf("Tarjeta de crédito:") + 19))).Replace(vbLf, "")
                            arreglo(3) = Trim(text.Substring(text.IndexOf("Importe de la operación:") + 24, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe de la operación:") + 24))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de creación:") + 18, 12)).Replace(vbLf, "")
                            arreglo(4) = Trim(text.Substring(text.IndexOf("Descripción:") + 12, text.IndexOf("Importe de la operación:") - (text.IndexOf("Descripción:") + 12))).Replace(vbLf, " ")
                            'actualiza registro correspondiente
                            procesadosTes = taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, idBanco, arreglo(3).Trim, 33, folioSolicitud, tipoSolicitud)
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
                            'arreglo(4) = Trim(text.Substring(text.IndexOf("Descripción:") + 12, text.IndexOf("Importe:") - (text.IndexOf("Descripción:") + 12))).Replace(vbLf, "")
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de aplicación:") + 20, 12)).Replace(vbLf, "")
                            'Else
                            '    arreglo(3) = Trim(text.Substring(text.IndexOf("Cifra de control:") + 8, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe:") + 8))).Replace(vbLf, "").Replace(",", "").Replace("MXN", "").Replace("USD", "").Replace("EUR", "").Replace("MXP", "").Trim
                            'arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de creación:") + 18, 12)).Replace(vbLf, "")
                            'arreglo(4) = Trim(text.Substring(text.IndexOf("Descripción:") + 12, text.IndexOf("Cifra de control:") - (text.IndexOf("Descripción:") + 12))).Replace(vbLf, " ")
                        End If
                        'actualiza registro correspondiente
                        procesadosTes = taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, idBanco, arreglo(3).Trim, 37, folioSolicitud, tipoSolicitud)
                        If procesadosTes = 1 Then
                            procesadosSol = taPagos.CambiaEstatus_UpdateQuery("Pagada", folioSolicitud, "En Proceso de Pago", varGlobal_IdEmpresa)
                        End If
                    End If
                Else
                    'lee PDF para llenar arreglo
                    If text.IndexOf("Linea de Captura:") > 0 Then
                        arreglo(4) = Trim(text.Substring(text.IndexOf("Linea de Captura:") + 17, text.IndexOf("Entidad Receptora:") - (text.IndexOf("Linea de Captura:") + 17))).Replace(vbLf, " ")
                        'actualiza registro correspondiente
                        procesadosTes = taPagosTesoreria.CambiaEstatusPagoImss_UpdateQuery(34, Date.Now, guuid & "-" & pagina.ToString, idBanco, taCuentasProv.ObtIdPorReferencia_ScalarQuery(arreglo(4).Trim), folioSolicitud, varGlobal_IdEmpresa)
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
                        End If
                        If text.IndexOf("Fecha de creación:") > 0 Then
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de creación:") + 18, 12)).Replace(vbLf, "")
                        ElseIf text.IndexOf("Fecha y Hora de Pago:") > 0 Then
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha y Hora de Pago:") + 21, 12)).Replace(vbLf, "")
                        ElseIf text.IndexOf("Fecha de Operación:") > 0 Then
                            arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de Operación:") + 19, 12)).Replace(vbLf, "")
                        End If
                        'actualiza registro correspondiente
                        procesadosTes = taPagosTesoreria.CambiaEstatusPagoTdc_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, idBanco, arreglo(3).Trim, 33, folioSolicitud, tipoSolicitud)
                        If procesadosTes = 1 Then
                            procesadosSol = taPagos.CambiaEstatus_UpdateQuery("Pagada", folioSolicitud, "No Pagada", varGlobal_IdEmpresa)
                        End If
                    End If

                End If
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

                Dim fechaHorActual As Date = Date.Now
                'contadorPagosTes += 1
                Dim dtDatosSolicitud As New dsTesoreria.DatosSolicitudDataTable
                Dim rwDatosSolTmp As dsTesoreria.DatosSolicitudRow
                Dim dtDatosDetalleSolicitud As New dsTesoreria.DatosSolicitudDataTable
                Dim taCuentasConpaq As New contpaqTableAdapters.CuentasTableAdapter

                taDatosSolicitud.SolicitudesDePago_FillBy(dtDatosSolicitud, arreglo(3), tipoSolicitud, folioSolicitud)
                If dtDatosSolicitud.Rows.Count > 0 Then
                    rwDatosSolTmp = dtDatosSolicitud.Rows(0)
                    Dim tipoPoliza As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa)
                    Dim origenRecurso As Integer = taCuentasBanc.ObtieneCuentaContable_ScalarQuery(rwDatosSolTmp.origenRecurso)
                    Dim folioPoliza As Integer = taPolizas.ConsultaUltimoFolio_ScalarQuery(tipoPoliza, varGlobal_IdEmpresa)
                    If rwDatosSolTmp.tipoSolicitud = "CXP" Then

                        If tipoPoliza <> 0 Then
                            If rwDatosSolTmp.idConcepto = 43 Then

                            Else
                                taDatosSolicitud.Detalle_Contabilidad_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, rwDatosSolTmp.referencia)
                                If dtDatosDetalleSolicitud.Rows.Count > 0 Then
                                    For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                                        Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
                                        taImpuestos.Fill(dtImpuestos, rwDetalleEvento.uuid)
                                        Dim contador As Integer = 0

                                        'cargo
                                        taRegContable.Insert(rwDetalleEvento.ctaCargoPago, rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                                        'abono
                                        taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.totalPagado, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)

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
                                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P")), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S")), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                                            End If

                                            If rowsCfdi.mRet <> "X" Then
                                                efecto = "RET"
                                                mPago = Math.Round(CDec(Val(rowsCfdi.mRet) * percentPago), 2)
                                                tipo = "Federal"
                                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P")), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDetalleEvento.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S")), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                                            End If

                                            If contador = 0 Then
                                                If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
                                                    efecto = "LOC"
                                                    mPago = Math.Round(CDec(Val(rowsCfdi.mLocTra) * percentPago), 2)
                                                    tipo = "Local"
                                                    taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "TRA", "P")), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                                                    taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "TRA", "S")), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                                                End If

                                                If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
                                                    efecto = "LOC"
                                                    mPago = Math.Round(CDec(Val(rowsCfdi.mLocRet) * percentPago), 2)
                                                    tipo = "Local"
                                                    taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "RET", "P")), rwDetalleEvento.idProveedor, 0, mPago, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                                                    taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDetalleEvento.idConcepto, tipo, "RET", "S")), rwDetalleEvento.idProveedor, mPago, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " " & rwDetalleEvento.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
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
                    ElseIf rwDatosSolTmp.tipoSolicitud = "AVI" Then

                        taDatosSolicitud.Detalle_Contabilidad_FillBy(dtDatosDetalleSolicitud, rwDatosSolTmp.destinoRecurso, rwDatosSolTmp.importeSolicitado, rwDatosSolTmp.origenRecurso, rwDatosSolTmp.referencia)
                        For Each rwDetalleEvento As dsTesoreria.DatosSolicitudRow In dtDatosDetalleSolicitud
                            'cargo
                            taRegContable.Insert(taCuentasConpaq.ObtieneIdCta_ScalarQuery("231101900020" & rwDetalleEvento.referencia.Substring(1, 4)), rwDetalleEvento.idProveedor, rwDetalleEvento.importeSolicitado, 0, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " AVIO " & rwDetalleEvento.referencia, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                            'abono
                            taRegContable.Insert(origenRecurso, rwDetalleEvento.idProveedor, 0, rwDetalleEvento.importeSolicitado, rwDetalleEvento.rfc, "F-" & rwDetalleEvento.serie & " " & rwDetalleEvento.folio & " AVIO " & rwDetalleEvento.referencia, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDetalleEvento.uuid, rwDetalleEvento.folioSolicitud, fechaHorActual, 29, rwDetalleEvento.idConcepto, 2)
                        Next
                        ''''Para otro tipo de asientos
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


End Module
