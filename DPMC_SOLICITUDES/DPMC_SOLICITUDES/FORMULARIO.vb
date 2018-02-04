Public Class form_formulario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_generarFormulario.Click

        Select Case formulario_tipo_de_solicitud.Text
            Case "FACTIBILIDAD"
                form_factibilidad.Show()
            Case "PUNTO DE DISEÑO"
                form_puntodediseño.Show()
            Case "PRESUPUESTO"
                form_presupuesto.Show()
            Case "REVISIÓN"
                form_revision.Show()
            Case "CONFORMIDAD TÉCNICA"
                form_conformidadtecnica.Show()
            Case "RECHAZO"
                form_rechazo.Show()
            Case Else
                MsgBox("Seleccione un tipo de solicitud")
        End Select

    End Sub
End Class
