<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_formulario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.formulario_tipo_de_solicitud = New System.Windows.Forms.ComboBox()
        Me.button_generarFormulario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(191, 227)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 19)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TIPO DE SOLICITUD"
        '
        'formulario_tipo_de_solicitud
        '
        Me.formulario_tipo_de_solicitud.FormattingEnabled = True
        Me.formulario_tipo_de_solicitud.Items.AddRange(New Object() {"FACTIBILIDAD", "PUNTO DE DISEÑO", "REVISIÓN", "CONFORMIDAD TÉCNICA", "RECHAZO", "PRESUPUESTO"})
        Me.formulario_tipo_de_solicitud.Location = New System.Drawing.Point(393, 227)
        Me.formulario_tipo_de_solicitud.Name = "formulario_tipo_de_solicitud"
        Me.formulario_tipo_de_solicitud.Size = New System.Drawing.Size(246, 24)
        Me.formulario_tipo_de_solicitud.TabIndex = 1
        '
        'button_generarFormulario
        '
        Me.button_generarFormulario.Location = New System.Drawing.Point(659, 217)
        Me.button_generarFormulario.Name = "button_generarFormulario"
        Me.button_generarFormulario.Size = New System.Drawing.Size(203, 42)
        Me.button_generarFormulario.TabIndex = 2
        Me.button_generarFormulario.Text = "GENERAR FORMULARIO"
        Me.button_generarFormulario.UseVisualStyleBackColor = True
        '
        'form_formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1045, 538)
        Me.Controls.Add(Me.button_generarFormulario)
        Me.Controls.Add(Me.formulario_tipo_de_solicitud)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "form_formulario"
        Me.Text = "FORMULARIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents formulario_tipo_de_solicitud As ComboBox
    Friend WithEvents button_generarFormulario As Button
End Class
