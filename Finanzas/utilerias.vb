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
                tokenReferencia = cCadenaAuxiliar.Trim
            Else
                tokenReferencia = cCadenaAuxiliar.Substring(0, longitudMaxima).Trim
            End If
        Else
            tokenReferencia = cadena.Trim
        End If
    End Function

    Public Function Eliminar_Acentos(ByVal accentedStr As String) As String
        accentedStr = accentedStr.Replace("°", "o")
        accentedStr = accentedStr.Replace("Ü", "U")
        accentedStr = accentedStr.Replace(".", "")
        accentedStr = accentedStr.Replace(",", "")
        accentedStr = accentedStr.Replace("Ñ", "N")
        accentedStr = accentedStr.Replace("ñ", "n")

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

    Sub extraePaginaSharp(ByVal origen As String, ByVal destino As String, ByVal guuid As String)
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

            leePDF(destino & guuid & "-" + Pagina.ToString & ".pdf", destino & guuid & "-" + Pagina.ToString & ".txt", guuid, Pagina)

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

    Public Sub leePDF(ByVal origen As String, ByVal destino As String, ByVal guuid As String, ByVal pagina As Integer)
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

                    arreglo(0) = Trim(text.Substring(text.IndexOf("Tipo de operación:") + 18, text.IndexOf("Descripción:") - (text.IndexOf("Tipo de operación:") + 18))).Replace(vbLf, "")
                    arreglo(1) = Trim(text.Substring(text.IndexOf("Cuenta de retiro:") + 17, text.IndexOf("Cuenta de depósito:") - (text.IndexOf("Cuenta de retiro:") + 17))).Replace(vbLf, "")
                    arreglo(2) = Trim(text.Substring(text.IndexOf("Cuenta de depósito:") + 19, text.IndexOf("Divisa de la cuenta:") - (text.IndexOf("Cuenta de depósito:") + 19))).Replace(vbLf, "")
                    arreglo(3) = Trim(text.Substring(text.IndexOf("Importe:") + 8, text.IndexOf("Cuenta de retiro:") - (text.IndexOf("Importe:") + 8))).Replace(vbLf, "").Replace(",", "")
                    arreglo(5) = Trim(text.Substring(text.IndexOf("Fecha de aplicación:") + 20, 12)).Replace(vbLf, "")
                    If arreglo(0) = "Grupo Pago Mismo Banco" Then
                        arreglo(4) = Trim(text.Substring(text.IndexOf("Motivo de pago:") + 15, text.IndexOf("Datos de confirmación de la transferencia") - (text.IndexOf("Motivo de pago:") + 15))).Replace(vbLf, " ")
                    Else
                        arreglo(4) = Trim(text.Substring(text.IndexOf("Concepto de pago:") + 17, text.IndexOf("Referencia:") - (text.IndexOf("Concepto de pago:") + 17))).Replace(vbLf, "")
                    End If
                End If
            Next
            PdfReader.Close()
        End If

        procesadosTes = taPagosTesoreria.CambiaEstatusPago_UpdateQuery(34, CDate(arreglo(5)), guuid & "-" & pagina.ToString, taCuentasProv.ObtClabe_ScalarQuery(arreglo(2).Trim), arreglo(3).Trim, arreglo(4).Trim, taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1).Trim), 37)
        procesadosSol = taPagos.CambiaEstatus_UpdateQuery("Pagada", taPagosTesoreria.ObtFolioSolicitud_ScalarQuery(taCuentasProv.ObtClabe_ScalarQuery(arreglo(2).Trim), arreglo(3).Trim, arreglo(4).Trim, taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1).Trim)), "En Proceso de Pago", varGlobal_IdEmpresa)

        If procesadosTes = 1 Then
            contadorPagosTes += 1
        End If

        If procesadosSol = 1 Then
            contadorPagosSol += 1
        End If

        'If procesadosTes = 1 Then
        '    Try

        '        Dim fechaHorActual As Date = Date.Now
        '        contadorPagosTes += 1
        '        Dim dtDatosSolicitud As New dsTesoreria.DatosSolicitudDataTable
        '        Dim rwDatosSolTmp As dsTesoreria.DatosSolicitudRow
        '        taDatosSolicitud.Fill(dtDatosSolicitud, taCuentasProv.ObtClabe_ScalarQuery(arreglo(2).Trim), arreglo(3).Trim, taCuentasBanc.ObtIdCuenta_ScalarQuery(arreglo(1).Trim), arreglo(4).Trim)

        '        rwDatosSolTmp = dtDatosSolicitud.Rows(0)
        '        If rwDatosSolTmp.tipoSolicitud = "CXP" Then
        '            Dim tipoPoliza As Integer = taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa)

        '            If tipoPoliza <> 0 Then
        '                Dim folioPoliza As Integer = taPolizas.ConsultaUltimoFolio_ScalarQuery(tipoPoliza, varGlobal_IdEmpresa)

        '                For Each rwDatosSolicitud As dsTesoreria.DatosSolicitudRow In dtDatosSolicitud

        '                    Dim dtImpuestos As New dsTesoreria.Vw_CXP_ImpuestosCFDIDataTable
        '                    taImpuestos.Fill(dtImpuestos, rwDatosSolicitud.uuid)
        '                    Dim contador As Integer = 0

        '                    For Each rowsCfdi As dsTesoreria.Vw_CXP_ImpuestosCFDIRow In dtImpuestos
        '                        Dim efecto As String = ""
        '                        Dim tipo As String = ""
        '                        Dim retecionL As String = ""
        '                        Dim mPago As Decimal = 0

        '                        Dim percentPago As Decimal = CDec(rwDatosSolicitud.totalPagado) / CDec(rwDatosSolicitud.totalOrg)
        '                        'cargo
        '                        taRegContable.Insert(rwDatosSolicitud.ctaCargoPago, rwDatosSolicitud.idProveedor, rwDatosSolicitud.importeSolicitado, 0, taConceptos.ObtCtaImpTraDescripcion_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                        'abono
        '                        taRegContable.Insert(rwDatosSolicitud.ctaAbonoPago, rwDatosSolicitud.idProveedor, 0, rwDatosSolicitud.totalPagado, taConceptos.ObtCtaImpTraDescripcion_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)

        '                        If rowsCfdi.mTras <> "X" Then
        '                            efecto = "TRA"
        '                            mPago = Math.Round(CDec(Val(rowsCfdi.mTras) * percentPago), 2)
        '                            tipo = "Federal"
        '                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P")), rwDatosSolicitud.idProveedor, mPago, 0, taConceptos.ObtCtaImpTraDescripcion_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S")), rwDatosSolicitud.idProveedor, 0, mPago, taConceptos.ObtCtaImpTraDescripcion_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                        End If

        '                        If rowsCfdi.mRet <> "X" Then
        '                            efecto = "RET"
        '                            mPago = Math.Round(CDec(Val(rowsCfdi.mRet) * percentPago), 2)
        '                            tipo = "Federal"
        '                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P")), rwDatosSolicitud.idProveedor, 0, mPago, taConceptos.ObtCtaImpTraDescripcion_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "P") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                            taRegContable.Insert(CDec(taConceptos.ObtCtaImpTras_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S")), rwDatosSolicitud.idProveedor, mPago, 0, taConceptos.ObtCtaImpTraDescripcion_ScalarQuery(rwDatosSolicitud.idConcepto, rowsCfdi.Impuesto, efecto, rowsCfdi.tipoFactor, tipo, "S") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                        End If

        '                        If contador = 0 Then
        '                            If rowsCfdi.mLocTra <> "X" And rowsCfdi.mLocTra <> 0 Then
        '                                efecto = "LOC"
        '                                mPago = Math.Round(CDec(Val(rowsCfdi.mLocTra) * percentPago), 2)
        '                                tipo = "Local"
        '                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDatosSolicitud.idConcepto, tipo, "TRA", "P")), rwDatosSolicitud.idProveedor, 0, mPago, taConceptos.ObtCtaImpLocalDes_ScalarQuery(rwDatosSolicitud.idConcepto, tipo, "TRA", "P") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDatosSolicitud.idConcepto, tipo, "TRA", "S")), rwDatosSolicitud.idProveedor, mPago, 0, taConceptos.ObtCtaImpLocalDes_ScalarQuery(rwDatosSolicitud.idConcepto, tipo, "TRA", "S") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                            End If

        '                            If rowsCfdi.mLocRet <> "X" And rowsCfdi.mLocRet <> 0 Then
        '                                efecto = "LOC"
        '                                mPago = Math.Round(CDec(Val(rowsCfdi.mLocRet) * percentPago), 2)
        '                                tipo = "Local"
        '                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDatosSolicitud.idConcepto, tipo, "RET", "P")), rwDatosSolicitud.idProveedor, 0, mPago, taConceptos.ObtCtaImpLocalDes_ScalarQuery(rwDatosSolicitud.idConcepto, tipo, "RET", "P") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                                taRegContable.Insert(CDec(taConceptos.ObtCtaImpLocal_ScalarQuery(rwDatosSolicitud.idConcepto, tipo, "RET", "S")), rwDatosSolicitud.idProveedor, mPago, 0, taConceptos.ObtCtaImpLocalDes_ScalarQuery(rwDatosSolicitud.idConcepto, tipo, "RET", "S") & " " & rwDatosSolicitud.rfc, "F-" & rwDatosSolicitud.serie & " " & rwDatosSolicitud.folio & " " & rwDatosSolicitud.decripcion, tipoPoliza, folioPoliza, varGlobal_IdEmpresa, rwDatosSolicitud.uuid, rwDatosSolicitud.folioSolicitud, fechaHorActual, 29, rwDatosSolicitud.idConcepto, 2)
        '                            End If
        '                        End If

        '                        contador += 1
        '                    Next
        '                Next

        '                taPolizas.ConsumeUltimoFolio_UpdateQuery(taDatosPolizas.ObtTipoPoliza_ScalarQuery(rwDatosSolTmp.tipoSolicitud, rwDatosSolTmp.formaDePago, rwDatosSolTmp.monedaPago, rwDatosSolTmp.idEmpresa), varGlobal_IdEmpresa)
        '            End If
        '        Else
        '            ''''Para otro tipo de asientos
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.ToString, MsgBoxStyle.Critical, "")
        '    End Try
        'End If

        escritor = File.AppendText(destino)
        escritor.Write(arreglo(0) & vbNewLine & arreglo(1) & vbNewLine & arreglo(2) & vbNewLine & arreglo(3) & vbNewLine & arreglo(4))
        escritor.Flush()
        escritor.Close()
    End Sub


End Module
