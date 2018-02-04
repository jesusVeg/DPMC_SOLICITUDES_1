Public Class form_factibilidad
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ft_spo_TextChanged(sender As Object, e As EventArgs) Handles ft_spo.TextChanged
        TextBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ft_dirigido_a.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ft_cliente.Text = ft_empresa_solicitante.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ft_direccion_de_obra.Text = ft_direccion_de_envio.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ft_distrito_de_obra.Text = ft_distrito_de_envio.Text
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub ft_rol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ft_rol.SelectedIndexChanged
        Select Case ft_rol.Text
            Case "moct"
                frame_memo_planeamiento.Visible = True
                frame_servidumbre.Visible = True
            Case Else
                frame_memo_planeamiento.Visible = False
                frame_servidumbre.Visible = False
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles ft_button_limpiar.Click

        ft_spo.Text = ""
        ft_expediente.Text = ""
        ft_rol.Text = ""
        ft_dirigido_a.Text = ""
        ft_empresa_solicitante.Text = ""
        ft_direccion_de_envio.Text = ""
        ft_distrito_de_envio.Text = ""
        ft_pot_soli_mt.Text = ""
        ft_pot_soli_bt.Text = ""
        ft_cliente.Text = ""
        ft_direccion_de_obra.Text = ""
        ft_distrito_de_obra.Text = ""
        ft_provincia_de_obra.Text = ""
        ft_correlativo.Text = ""
        ft_area_servidumbre.Text = ""

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ft_button_generar_carta.Click
        ' Private Sub Button7_Click(ByVal sender As System.Object, _      ByVal e As System.EventArgs) Handles ft_button_generar_carta.Click

        Dim objWord As Object, wdDoc As Object
        Dim datos(0 To 1, 0 To 17) As String
        Dim texto_2_ft As String
        Dim texto_3_ft As String
        Dim mes_letras_ft As String
        Dim mes_numero_ft As String
        Dim texto_potencia_bt_ft As String
        Dim ft_macros_servidumbre As String
        Dim ft_macros As String
        Dim dpd_factibilidad As String
        Dim ruta_carpeta_expedientes As String
        Dim ruta_carpeta_cliente As String
        Dim ruta_carpeta_carta As String
        Dim ft_nombre_carta_hecha As String
        Dim ft_ruta_carta_hecha_memo As String

        Dim Ruta2 As String
        Dim ft_ruta_carta_hecha_clasica As String
        Dim ft_ruta_carta_hecha As String
        Dim rutaCarpetaPlantillas As String
        Dim rutaCarpetaExpedientes As String
        Dim ruta As String
        Dim rutainf As String
        Dim textobuscar As String

        Dim dia_ft As String
        On Error Resume Next

        'MODIFICAR ESTAS
        rutaCarpetaPlantillas = "D:\Macros\Plantillas\"
        rutaCarpetaExpedientes = "D:\Macros\Clientes_DPMC"

        'RUTAS DE PLANTILLAS
        ft_macros_servidumbre = rutaCarpetaPlantillas & "FT_MACROS_SERVIDUMBRE.docx"
        ft_macros = rutaCarpetaPlantillas & "FT_MACROS.docx"
        dpd_factibilidad = rutaCarpetaPlantillas & "DPD-FACTIBILIDAD.docx"

        'RUTA DE LA CARPETA DONDE ESTARÁN LAS CARTAS
        ruta_carpeta_cliente = rutaCarpetaExpedientes & "\" & ft_expediente.Text & "_" & ft_cliente.Text & "_" & ft_distrito_de_obra.Text
        ruta_carpeta_carta = ruta_carpeta_cliente & "\FT\"

        'NOMBRE DE LAS CARTAS HECHAS
        ft_nombre_carta_hecha = "FT_" & ft_spo.Text & "_" & ft_cliente.Text
        ft_ruta_carta_hecha = ruta_carpeta_carta & ft_nombre_carta_hecha

        ft_ruta_carta_hecha_clasica = ft_ruta_carta_hecha & ".docx"
        ft_ruta_carta_hecha_memo = ft_ruta_carta_hecha & "_MEMO" & ".docx"

        'RECONOCE SI LA CARPETA YA EXISTE, SINO CREA UNA NUEVA
        If Len(Dir(ruta_carpeta_cliente & "\*", vbDirectory)) = 0 Then

            MkDir(ruta_carpeta_cliente)

            If Len(Dir(ruta_carpeta_carta & "\*", vbDirectory)) = 0 Then
                MkDir(ruta_carpeta_carta)
            Else
                'no crea carpeta
            End If

        Else

            If Len(Dir(ruta_carpeta_carta & "\*", vbDirectory)) = 0 Then
                MkDir(ruta_carpeta_carta)
            Else
                'no crea carpeta
            End If

        End If

        'DETECTA SI SE INTRODUJO POTENCIA EN BT O NO
        If ft_pot_soli_bt.Text <> "" Then
            texto_potencia_bt_ft = " y " & ft_pot_soli_bt.Text & " kW en baja tensión"
        Else
            texto_potencia_bt_ft = ""
        End If


        'DETECTA SI LA EMPRESA SOLICITANTE ES LA MISMA QUE LA EMPRESA DUEÑA Y CREA EL TEXTO RESPECTIVO
        If ft_cliente.Text <> ft_empresa_solicitante.Text Then
            texto_2_ft = " del cliente " & UCase(ft_cliente.Text)
        Else
            texto_2_ft = ""
        End If

        'DETECTA SI LA PROVINCIA DE LA OBRA ES LIMA U OTRA Y CREA EL TEXTO RESPECTIVO
        If ft_provincia_de_obra.Text = "Lima" Then
            texto_3_ft = "provincia y departamento de Lima"
        Else
            texto_3_ft = "provincia de " & ft_provincia_de_obra.Text & ", departamento de Lima"
        End If

        'BODY

        If ft_correlativo.Text <> "" Then

            If ft_area_servidumbre.Text = "SI" Then

                ruta = ft_macros_servidumbre
            Else
                ruta = ft_macros
            End If


            'wrdDataDoc = wrdApp.Documents.Open(ruta)
            objWord = CreateObject("Word.Application")
            objWord.DisplayAlerts = False
            objWord.Visible = True
            wdDoc = objWord.Documents.Open(ruta)

            rutainf = ft_ruta_carta_hecha_clasica

            'Asignamos a variables que se debe buscar y el texto por que se debe reemplazar
            datos(0, 0) = "[SPO]"
            datos(1, 0) = ft_spo.Text
            datos(0, 1) = "[EXP]"
            datos(1, 1) = ft_expediente.Text
            datos(0, 2) = "[DIA]"
            datos(1, 2) = DateAndTime.Day(Now())
            datos(0, 3) = "[MES]"
            datos(1, 3) = LCase(DateAndTime.MonthName(Month(Now())))
            datos(0, 4) = "[POTENCIA_KW]"
            datos(1, 4) = ft_pot_soli_mt.Text
            datos(0, 5) = "[DIRECCION_OBRA]"
            datos(1, 5) = StrConv(ft_direccion_de_obra.Text, VbStrConv.ProperCase)
            datos(0, 6) = "[DISTRITO_OBRA]"
            datos(1, 6) = StrConv(ft_distrito_de_obra.Text, VbStrConv.ProperCase)
            datos(0, 7) = "[SEÑOR_]"
            datos(1, 7) = ft_dirigido_a.Text
            datos(0, 8) = "[EMPRESA_SOLICITANTE]"
            datos(1, 8) = UCase(ft_empresa_solicitante.Text)
            datos(0, 9) = "[DIRECCION_ENVIO]"
            datos(1, 9) = StrConv(ft_direccion_de_envio.Text, VbStrConv.ProperCase)
            datos(0, 10) = "[DISTRITO_ENVIO]"
            datos(1, 10) = StrConv(ft_distrito_de_envio.Text, VbStrConv.ProperCase)
            datos(0, 11) = "[TEXTO_2]"
            datos(1, 11) = texto_2_ft
            datos(0, 12) = "[TEXTO_3]"
            datos(1, 12) = texto_3_ft
            datos(0, 13) = "[ROL]"
            datos(1, 13) = ft_rol.Text
            datos(0, 14) = "[DPD]"
            datos(1, 14) = Year(Now()) & "." & ft_correlativo.Text
            datos(0, 15) = "[POTENCIA_BT]"
            datos(1, 15) = texto_potencia_bt_ft
            datos(0, 16) = "[AÑO]"
            datos(1, 16) = Year(Now())
            datos(0, 17) = "[CLIENTE]"
            datos(1, 17) = ft_cliente.Text

            'Creamos un bucle que va desde el primero al último número de la matriz
            For i = 0 To UBound(datos, 2)
                textobuscar = datos(0, i)
                objWord.Selection.Move(6, -1)
                objWord.Selection.Find.Execute(FindText:=textobuscar)
                'Bucle para reemplazar todo el texto que encuentre y solo el primero que encuentre
                While objWord.Selection.Find.Found = True
                    objWord.Selection.Text = datos(1, i) 'texto a reemplazar
                    objWord.Selection.Move(6, -1)
                    objWord.Selection.Find.Execute(FindText:=textobuscar)
                End While
            Next i

            'Guarda el archivo con el nombre asignado
            wdDoc.SaveAs(Filename:=rutainf)
            'wdDoc.Close
            MsgBox("La carta se generó con éxito, " + Chr(13) + "No olvide lo siguiente:" + Chr(13) + "Verificar que la carta esté correctamente cuadrada.")

            wdDoc.Activate
            wdDoc.ScreenUpdating = True
            wdDoc.DisplayAlerts = True

            'DPD
            Ruta2 = dpd_factibilidad
            objWord = CreateObject("Word.Application")
            objWord.DisplayAlerts = False
            objWord.Visible = True
            wdDoc = objWord.Documents.Open(Ruta2)

            rutainf = ft_ruta_carta_hecha_memo

            'Asignamos a variables que se debe buscar y el texto por que se debe reemplazar
            datos(0, 0) = "[SPO]"
            datos(1, 0) = ft_spo.Text
            datos(0, 1) = "[EXP]"
            datos(1, 1) = ft_expediente.Text
            datos(0, 2) = "[DIA]"
            datos(1, 2) = DateAndTime.Day(Now())
            datos(0, 3) = "[MES]"
            datos(1, 3) = LCase(DateAndTime.MonthName(Month(Now())))
            datos(0, 4) = "[POTENCIA_KW]"
            datos(1, 4) = ft_pot_soli_mt.Text
            datos(0, 5) = "[DIRECCION_OBRA]"
            datos(1, 5) = StrConv(ft_direccion_de_obra.Text, VbStrConv.ProperCase)
            datos(0, 6) = "[DISTRITO_OBRA]"
            datos(1, 6) = StrConv(ft_distrito_de_obra.Text, VbStrConv.ProperCase)
            datos(0, 7) = "[SEÑOR_]"
            datos(1, 7) = ft_dirigido_a.Text
            datos(0, 8) = "[EMPRESA_SOLICITANTE]"
            datos(1, 8) = UCase(ft_empresa_solicitante.Text)
            datos(0, 9) = "[DIRECCION_ENVIO]"
            datos(1, 9) = StrConv(ft_direccion_de_envio.Text, VbStrConv.ProperCase)
            datos(0, 10) = "[DISTRITO_ENVIO]"
            datos(1, 10) = StrConv(ft_distrito_de_envio.Text, VbStrConv.ProperCase)
            datos(0, 11) = "[TEXTO_2]"
            datos(1, 11) = texto_2_ft
            datos(0, 12) = "[TEXTO_3]"
            datos(1, 12) = texto_3_ft
            datos(0, 13) = "[ROL]"
            datos(1, 13) = ft_rol.Text
            datos(0, 14) = "[DPD]"
            datos(1, 14) = Year(Now()) & "." & ft_correlativo.Text
            datos(0, 15) = "[POTENCIA_BT]"
            datos(1, 15) = texto_potencia_bt_ft
            datos(0, 16) = "[AÑO]"
            datos(1, 16) = Year(Now())
            datos(0, 17) = "[CLIENTE]"
            datos(1, 17) = ft_cliente.Text

            'Creamos un bucle que va desde el primero al último número de la matriz
            For i = 0 To UBound(datos, 2)
                textobuscar = datos(0, i)
                objWord.Selection.Move(6, -1)
                objWord.Selection.Find.Execute(FindText:=textobuscar)
                'Bucle para reemplazar todo el texto que encuentre y solo el primero que encuentre
                While objWord.Selection.Find.Found = True
                    objWord.Selection.Text = datos(1, i) 'texto a reemplazar
                    objWord.Selection.Move(6, -1)
                    objWord.Selection.Find.Execute(FindText:=textobuscar)
                End While
            Next i

            'Guarda el archivo con el nombre asignado
            wdDoc.SaveAs(Filename:=rutainf)
            'wdDoc.Close
            MsgBox("La carta se generó con éxito, " + Chr(13) + "No olvide lo siguiente:" + Chr(13) + "Verificar que la carta esté correctamente cuadrada.")

            wdDoc.Activate
            wdDoc.ScreenUpdating = True
            wdDoc.DisplayAlerts = True

        Else
            If ft_correlativo.Text = "" Then

                If ft_area_servidumbre.Text = "SI" Then
                    ruta = ft_macros_servidumbre
                Else
                    ruta = ft_macros
                End If


                objWord = CreateObject("Word.Application")
                objWord.DisplayAlerts = False
                objWord.Visible = True
                wdDoc = objWord.Documents.Open(ruta)

                rutainf = ft_ruta_carta_hecha_clasica


                'Asignamos a variables que se debe buscar y el texto por que se debe reemplazar
                datos(0, 0) = "[SPO]"
                datos(1, 0) = ft_spo.Text
                datos(0, 1) = "[EXP]"
                datos(1, 1) = ft_expediente.Text
                datos(0, 2) = "[DIA]"
                datos(1, 2) = DateAndTime.Day(Now())
                datos(0, 3) = "[MES]"
                datos(1, 3) = LCase(DateAndTime.MonthName(Month(Now())))
                datos(0, 4) = "[POTENCIA_KW]"
                datos(1, 4) = ft_pot_soli_mt.Text
                datos(0, 5) = "[DIRECCION_OBRA]"
                datos(1, 5) = StrConv(ft_direccion_de_obra.Text, VbStrConv.ProperCase)
                datos(0, 6) = "[DISTRITO_OBRA]"
                datos(1, 6) = StrConv(ft_distrito_de_obra.Text, VbStrConv.ProperCase)
                datos(0, 7) = "[SEÑOR_]"
                datos(1, 7) = ft_dirigido_a.Text
                datos(0, 8) = "[EMPRESA_SOLICITANTE]"
                datos(1, 8) = UCase(ft_empresa_solicitante.Text)
                datos(0, 9) = "[DIRECCION_ENVIO]"
                datos(1, 9) = StrConv(ft_direccion_de_envio.Text, VbStrConv.ProperCase)
                datos(0, 10) = "[DISTRITO_ENVIO]"
                datos(1, 10) = StrConv(ft_distrito_de_envio.Text, VbStrConv.ProperCase)
                datos(0, 11) = "[TEXTO_2]"
                datos(1, 11) = texto_2_ft
                datos(0, 12) = "[TEXTO_3]"
                datos(1, 12) = texto_3_ft
                datos(0, 13) = "[ROL]"
                datos(1, 13) = ft_rol.Text
                datos(0, 14) = "[DPD]"
                datos(1, 14) = Year(Now()) & "." & ft_correlativo.Text
                datos(0, 15) = "[POTENCIA_BT]"
                datos(1, 15) = texto_potencia_bt_ft
                datos(0, 16) = "[AÑO]"
                datos(1, 16) = Year(Now())
                datos(0, 17) = "[CLIENTE]"
                datos(1, 17) = ft_cliente.Text

                'Creamos un bucle que va desde el primero al último número de la matriz
                For i = 0 To UBound(datos, 2)
                    textobuscar = datos(0, i)
                    objWord.Selection.Move(6, -1)
                    objWord.Selection.Find.Execute(FindText:=textobuscar)
                    'Bucle para reemplazar todo el texto que encuentre y solo el primero que encuentre
                    While objWord.Selection.Find.Found = True
                        objWord.Selection.Text = datos(1, i) 'texto a reemplazar
                        objWord.Selection.Move(6, -1)
                        objWord.Selection.Find.Execute(FindText:=textobuscar)
                    End While
                Next i

                'Guarda el archivo con el nombre asignado
                wdDoc.SaveAs(Filename:=rutainf)
                'wdDoc.Close
                MsgBox("La carta se generó con éxito, " + Chr(13) + "No olvide lo siguiente:" + Chr(13) + "Verificar que la carta esté correctamente cuadrada.")

                wdDoc.Activate
                wdDoc.ScreenUpdating = True
                wdDoc.DisplayAlerts = True

            End If
        End If

    End Sub

    Private Sub ft_button_registrar_Click(sender As Object, e As EventArgs) Handles ft_button_registrar_base_clientes.Click

    End Sub

    Private Sub ft_button_buscar_filtro_Click(sender As Object, e As EventArgs) Handles ft_button_buscar_filtro_1.Click

    End Sub
End Class