Imports System.IO
Imports System.Web.Services.Protocols.SoapDocumentServiceAttribute
Imports Valida_SAT_WS
Imports System.Xml.XmlText
Imports System.Xml
Imports System.Xml.Schema


Public Class frmValidaCfdi
    Private Sub btnSeleccionarArchivos_Click(sender As Object, e As EventArgs) Handles btnSeleccionarArchivos.Click
        Dim contadorArchivos As Integer = 0
        dgvCfdi.Rows.Clear()
        Dim rootPath As String = My.Settings.hostExe & "XSD"
        Dim leerXml As readXML_CFDI_class = New readXML_CFDI_class
        Me.Cursor = Cursors.WaitCursor
        btnSeleccionarArchivos.Enabled = False
        ofdSeleccionarArchivos.Title = "Seleccione los archivos XML y PDF a validar..."
        ofdSeleccionarArchivos.InitialDirectory = "Documents"
        ofdSeleccionarArchivos.Filter = "Todos los archivos|*.*"

        If ofdSeleccionarArchivos.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each archivos As String In ofdSeleccionarArchivos.FileNames
                Dim nombreArchivo() As String = archivos.Split(".")
                If nombreArchivo(1).ToLower = "xml" Then
                    If File.Exists(nombreArchivo(0) & ".pdf") Then
                        If leerXml.LeeXML(archivos, "RFCR") = varGlobal_rfcEmpresa Then
                            Dim xml As XmlDocument = New XmlDocument
                            Dim ns As XmlNamespaceManager = New XmlNamespaceManager(xml.NameTable)
                            ns.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")

                            xml.Load(archivos)
                            Dim node As XmlNode = xml.DocumentElement.SelectSingleNode("descendant::cfdi:Addenda", ns)

                            If Not (node Is Nothing) Then
                                node.ParentNode.RemoveChild(node)
                                xml.Save(archivos)
                            End If

                            Dim resXSD As validaXSD = New validaXSD
                                Dim var As String = "Sin errores en XSD"
                                Try
                                    'valida estructura XSD
                                    resXSD.LoadValidatedXmlDocument(archivos, rootPath + "\cfdv33.xsd", rootPath + "\TimbreFiscalDigitalv11.xsd", rootPath + "\implocal.xsd", rootPath + "\terceros11.xsd", rootPath + "\cfdiregistrofiscal.xsd")
                                    resXSD.LoadValidatedXDocument(archivos, rootPath + "\cfdv33.xsd", rootPath + "\TimbreFiscalDigitalv11.xsd", rootPath + "\implocal.xsd", rootPath + "\terceros11.xsd", rootPath + "\cfdiregistrofiscal.xsd")
                                    resXSD.LoadXml(archivos, rootPath + "\cfdv33.xsd", rootPath + "\TimbreFiscalDigitalv11.xsd", rootPath + "\implocal.xsd", rootPath + "\terceros11.xsd", rootPath + "\cfdiregistrofiscal.xsd")
                                    'guarda archivos válidos en servidor
                                    If var = "Sin errores en XSD" Then
                                        If leerXml.LeeXML(archivos, "RFCR") = "SAR951230N5A" Then
                                            If Directory.Exists(My.Settings.addArfinValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day)) Then
                                                File.Copy(archivos, My.Settings.addArfinValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day) & "\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(archivos, My.Settings.addArfinValida & "Todos\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(nombreArchivo(0) & ".pdf", My.Settings.addArfinValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day) & "\" & leerXml.LeeXML(archivos, "UUID") & ".pdf", True)
                                                File.Copy(nombreArchivo(0) & ".pdf", My.Settings.addArfinValida & "Todos\" & leerXml.LeeXML(archivos, "UUID") & ".pdf", True)
                                            Else
                                                Directory.CreateDirectory(My.Settings.addArfinValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day))
                                                File.Copy(archivos, My.Settings.addArfinValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day) & "\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(archivos, My.Settings.addArfinValida & "Todos\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(nombreArchivo(0) & ".pdf", My.Settings.addArfinValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day) & "\" & leerXml.LeeXML(archivos, "UUID") & ".pdf", True)
                                                File.Copy(nombreArchivo(0) & ".pdf", My.Settings.addArfinValida & "Todos\" & leerXml.LeeXML(archivos, "UUID") & ".pdf", True)
                                            End If
                                        Else
                                            If Directory.Exists(My.Settings.addFinagilValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day)) Then
                                                File.Copy(archivos, My.Settings.addFinagilValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day) & "\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(archivos, My.Settings.addFinagilValida & "Todos\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(nombreArchivo(0) & ".pdf", My.Settings.addFinagilValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day) & "\" & leerXml.LeeXML(archivos, "UUID") & ".pdf", True)
                                                File.Copy(nombreArchivo(0) & ".pdf", My.Settings.addFinagilValida & "Todos\" & leerXml.LeeXML(archivos, "UUID") & ".pdf", True)
                                            Else
                                                Directory.CreateDirectory(My.Settings.addFinagilValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day))
                                                File.Copy(archivos, My.Settings.addFinagilValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day) & "\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(archivos, My.Settings.addFinagilValida & "Todos\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(nombreArchivo(0) & ".pdf", My.Settings.addFinagilValida & Date.Now.Year.ToString & "-" & MonthName(Date.Now.Month) & "-" & String.Format("{0:00}", Date.Now.Day) & "\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                                File.Copy(nombreArchivo(0) & ".pdf", My.Settings.addFinagilValida & "Todos\" & leerXml.LeeXML(archivos, "UUID") & ".xml", True)
                                            End If
                                        End If
                                    End If
                                Catch ex As Exception
                                    var = ex.ToString
                                End Try
                                dgvCfdi.Rows.Add(leerXml.LeeXML(archivos, "Serie"), leerXml.LeeXML(archivos, "Folio"), leerXml.LeeXML(archivos, "UUID"), leerXml.Valida_SAT(leerXml.LeeXML(archivos, "RFCE"), leerXml.LeeXML(archivos, "RFCR"), leerXml.LeeXML(archivos, "Total"), leerXml.LeeXML(archivos, "UUID")), var)
                            End If
                        Else
                        MsgBox("No existe el PDF correspondiente", MsgBoxStyle.Information, "")
                    End If
                End If
            Next
            MsgBox("Proceso de validación terminado correctamente...", MsgBoxStyle.Information, "")
        Else
            MsgBox("Proceso cancelado", MsgBoxStyle.Information, "")
        End If
        Me.Cursor = Cursors.Default
        btnSeleccionarArchivos.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class