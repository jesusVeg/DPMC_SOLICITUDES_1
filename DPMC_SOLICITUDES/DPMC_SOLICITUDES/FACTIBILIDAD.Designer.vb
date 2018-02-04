<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_factibilidad
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ft_expediente = New System.Windows.Forms.RichTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ft_rol = New System.Windows.Forms.ComboBox()
        Me.ft_spo = New System.Windows.Forms.RichTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ft_distrito_de_envio = New System.Windows.Forms.RichTextBox()
        Me.ft_direccion_de_envio = New System.Windows.Forms.RichTextBox()
        Me.ft_empresa_solicitante = New System.Windows.Forms.ComboBox()
        Me.ft_dirigido_a = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ft_provincia_de_obra = New System.Windows.Forms.ComboBox()
        Me.ft_direccion_de_obra = New System.Windows.Forms.RichTextBox()
        Me.ft_cliente = New System.Windows.Forms.RichTextBox()
        Me.ft_distrito_de_obra = New System.Windows.Forms.RichTextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ft_pot_soli_bt = New System.Windows.Forms.RichTextBox()
        Me.ft_pot_soli_mt = New System.Windows.Forms.RichTextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.frame_memo_planeamiento = New System.Windows.Forms.GroupBox()
        Me.ft_correlativo = New System.Windows.Forms.RichTextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.frame_servidumbre = New System.Windows.Forms.GroupBox()
        Me.ft_area_servidumbre = New System.Windows.Forms.ComboBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ft_button_generar_carta = New System.Windows.Forms.Button()
        Me.ft_button_registrar = New System.Windows.Forms.Button()
        Me.ft_button_limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.frame_memo_planeamiento.SuspendLayout()
        Me.frame_servidumbre.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(4, 17)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(37, 14)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "SPO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ft_expediente)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.ft_rol)
        Me.GroupBox1.Controls.Add(Me.ft_spo)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(314, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ft_expediente
        '
        Me.ft_expediente.Location = New System.Drawing.Point(224, 15)
        Me.ft_expediente.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_expediente.Name = "ft_expediente"
        Me.ft_expediente.Size = New System.Drawing.Size(76, 24)
        Me.ft_expediente.TabIndex = 2
        Me.ft_expediente.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(138, 17)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(76, 14)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "EXPEDIENTE"
        '
        'ft_rol
        '
        Me.ft_rol.FormattingEnabled = True
        Me.ft_rol.Items.AddRange(New Object() {"moct", "ebl", "edcs"})
        Me.ft_rol.Location = New System.Drawing.Point(38, 50)
        Me.ft_rol.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_rol.Name = "ft_rol"
        Me.ft_rol.Size = New System.Drawing.Size(76, 21)
        Me.ft_rol.TabIndex = 3
        '
        'ft_spo
        '
        Me.ft_spo.BulletIndent = 2
        Me.ft_spo.Location = New System.Drawing.Point(38, 15)
        Me.ft_spo.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_spo.Name = "ft_spo"
        Me.ft_spo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ft_spo.Size = New System.Drawing.Size(76, 24)
        Me.ft_spo.TabIndex = 1
        Me.ft_spo.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(4, 50)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(37, 14)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "ROL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ft_distrito_de_envio)
        Me.GroupBox2.Controls.Add(Me.ft_direccion_de_envio)
        Me.GroupBox2.Controls.Add(Me.ft_empresa_solicitante)
        Me.GroupBox2.Controls.Add(Me.ft_dirigido_a)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 103)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(349, 146)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DEL SOLICITANTE"
        '
        'ft_distrito_de_envio
        '
        Me.ft_distrito_de_envio.Location = New System.Drawing.Point(146, 112)
        Me.ft_distrito_de_envio.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_distrito_de_envio.Name = "ft_distrito_de_envio"
        Me.ft_distrito_de_envio.Size = New System.Drawing.Size(188, 20)
        Me.ft_distrito_de_envio.TabIndex = 7
        Me.ft_distrito_de_envio.Text = ""
        '
        'ft_direccion_de_envio
        '
        Me.ft_direccion_de_envio.Location = New System.Drawing.Point(146, 84)
        Me.ft_direccion_de_envio.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_direccion_de_envio.Name = "ft_direccion_de_envio"
        Me.ft_direccion_de_envio.Size = New System.Drawing.Size(188, 20)
        Me.ft_direccion_de_envio.TabIndex = 6
        Me.ft_direccion_de_envio.Text = ""
        '
        'ft_empresa_solicitante
        '
        Me.ft_empresa_solicitante.FormattingEnabled = True
        Me.ft_empresa_solicitante.Location = New System.Drawing.Point(146, 55)
        Me.ft_empresa_solicitante.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_empresa_solicitante.Name = "ft_empresa_solicitante"
        Me.ft_empresa_solicitante.Size = New System.Drawing.Size(188, 21)
        Me.ft_empresa_solicitante.TabIndex = 5
        '
        'ft_dirigido_a
        '
        Me.ft_dirigido_a.FormattingEnabled = True
        Me.ft_dirigido_a.Items.AddRange(New Object() {"Señor", "Señora", "Señores"})
        Me.ft_dirigido_a.Location = New System.Drawing.Point(146, 25)
        Me.ft_dirigido_a.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_dirigido_a.Name = "ft_dirigido_a"
        Me.ft_dirigido_a.Size = New System.Drawing.Size(188, 21)
        Me.ft_dirigido_a.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(4, 112)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(136, 14)
        Me.TextBox7.TabIndex = 13
        Me.TextBox7.Text = "DISTRITO DE ENVÍO"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(4, 84)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(136, 14)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = "DIRECCIÓN DE ENVÍO"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(4, 55)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(136, 14)
        Me.TextBox5.TabIndex = 11
        Me.TextBox5.Text = "EMPRESA SOLICITANTE"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(4, 26)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(136, 14)
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.Text = "DIRIGIDO A:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.ft_provincia_de_obra)
        Me.GroupBox3.Controls.Add(Me.ft_direccion_de_obra)
        Me.GroupBox3.Controls.Add(Me.ft_cliente)
        Me.GroupBox3.Controls.Add(Me.ft_distrito_de_obra)
        Me.GroupBox3.Controls.Add(Me.TextBox11)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Location = New System.Drawing.Point(374, 103)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(430, 146)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS DEL CLIENTE"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(353, 84)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 21)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "COPIAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(353, 54)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 21)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "COPIAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(353, 26)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 21)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "COPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ft_provincia_de_obra
        '
        Me.ft_provincia_de_obra.FormattingEnabled = True
        Me.ft_provincia_de_obra.Items.AddRange(New Object() {"Lima", "Cañete", "Huarochirí"})
        Me.ft_provincia_de_obra.Location = New System.Drawing.Point(145, 112)
        Me.ft_provincia_de_obra.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_provincia_de_obra.Name = "ft_provincia_de_obra"
        Me.ft_provincia_de_obra.Size = New System.Drawing.Size(188, 21)
        Me.ft_provincia_de_obra.TabIndex = 11
        '
        'ft_direccion_de_obra
        '
        Me.ft_direccion_de_obra.Location = New System.Drawing.Point(145, 54)
        Me.ft_direccion_de_obra.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_direccion_de_obra.Name = "ft_direccion_de_obra"
        Me.ft_direccion_de_obra.Size = New System.Drawing.Size(188, 20)
        Me.ft_direccion_de_obra.TabIndex = 9
        Me.ft_direccion_de_obra.Text = ""
        '
        'ft_cliente
        '
        Me.ft_cliente.Location = New System.Drawing.Point(145, 26)
        Me.ft_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_cliente.Name = "ft_cliente"
        Me.ft_cliente.Size = New System.Drawing.Size(188, 20)
        Me.ft_cliente.TabIndex = 8
        Me.ft_cliente.Text = ""
        '
        'ft_distrito_de_obra
        '
        Me.ft_distrito_de_obra.Location = New System.Drawing.Point(145, 84)
        Me.ft_distrito_de_obra.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_distrito_de_obra.Name = "ft_distrito_de_obra"
        Me.ft_distrito_de_obra.Size = New System.Drawing.Size(188, 20)
        Me.ft_distrito_de_obra.TabIndex = 10
        Me.ft_distrito_de_obra.Text = ""
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(4, 26)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(136, 14)
        Me.TextBox11.TabIndex = 18
        Me.TextBox11.Text = "CLIENTE"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(4, 55)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(136, 14)
        Me.TextBox10.TabIndex = 19
        Me.TextBox10.Text = "DIRECCIÓN DE OBRA"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(4, 84)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(136, 14)
        Me.TextBox9.TabIndex = 20
        Me.TextBox9.Text = "DISTRITO DE OBRA"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(4, 112)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(136, 14)
        Me.TextBox8.TabIndex = 21
        Me.TextBox8.Text = "PROVINCIA DE OBRA"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ft_pot_soli_bt)
        Me.GroupBox4.Controls.Add(Me.ft_pot_soli_mt)
        Me.GroupBox4.Controls.Add(Me.TextBox13)
        Me.GroupBox4.Controls.Add(Me.TextBox12)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 270)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(292, 91)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATOS DEL SUMINSITRO SOLICITADO"
        '
        'ft_pot_soli_bt
        '
        Me.ft_pot_soli_bt.Location = New System.Drawing.Point(202, 52)
        Me.ft_pot_soli_bt.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_pot_soli_bt.Name = "ft_pot_soli_bt"
        Me.ft_pot_soli_bt.Size = New System.Drawing.Size(76, 24)
        Me.ft_pot_soli_bt.TabIndex = 13
        Me.ft_pot_soli_bt.Text = ""
        '
        'ft_pot_soli_mt
        '
        Me.ft_pot_soli_mt.Location = New System.Drawing.Point(202, 17)
        Me.ft_pot_soli_mt.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_pot_soli_mt.Name = "ft_pot_soli_mt"
        Me.ft_pot_soli_mt.Size = New System.Drawing.Size(76, 24)
        Me.ft_pot_soli_mt.TabIndex = 12
        Me.ft_pot_soli_mt.Text = ""
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(4, 53)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(184, 14)
        Me.TextBox13.TabIndex = 18
        Me.TextBox13.Text = "POTENCIA SOLICITADA - BT (KW)"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(4, 24)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(184, 14)
        Me.TextBox12.TabIndex = 17
        Me.TextBox12.Text = "POTENCIA SOLICITADA - MT (KW)"
        '
        'frame_memo_planeamiento
        '
        Me.frame_memo_planeamiento.Controls.Add(Me.ft_correlativo)
        Me.frame_memo_planeamiento.Controls.Add(Me.TextBox15)
        Me.frame_memo_planeamiento.Location = New System.Drawing.Point(320, 270)
        Me.frame_memo_planeamiento.Margin = New System.Windows.Forms.Padding(2)
        Me.frame_memo_planeamiento.Name = "frame_memo_planeamiento"
        Me.frame_memo_planeamiento.Padding = New System.Windows.Forms.Padding(2)
        Me.frame_memo_planeamiento.Size = New System.Drawing.Size(292, 91)
        Me.frame_memo_planeamiento.TabIndex = 19
        Me.frame_memo_planeamiento.TabStop = False
        Me.frame_memo_planeamiento.Text = "DATO MEMO PLANEAMIENTO"
        '
        'ft_correlativo
        '
        Me.ft_correlativo.Location = New System.Drawing.Point(199, 35)
        Me.ft_correlativo.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_correlativo.Name = "ft_correlativo"
        Me.ft_correlativo.Size = New System.Drawing.Size(76, 24)
        Me.ft_correlativo.TabIndex = 14
        Me.ft_correlativo.Text = ""
        '
        'TextBox15
        '
        Me.TextBox15.AcceptsReturn = True
        Me.TextBox15.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(4, 36)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(190, 31)
        Me.TextBox15.TabIndex = 17
        Me.TextBox15.Text = "CORRELATIVO DEPARTAMENTO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DE PLANIFICACIÓN"
        '
        'frame_servidumbre
        '
        Me.frame_servidumbre.Controls.Add(Me.ft_area_servidumbre)
        Me.frame_servidumbre.Controls.Add(Me.TextBox14)
        Me.frame_servidumbre.Location = New System.Drawing.Point(622, 270)
        Me.frame_servidumbre.Margin = New System.Windows.Forms.Padding(2)
        Me.frame_servidumbre.Name = "frame_servidumbre"
        Me.frame_servidumbre.Padding = New System.Windows.Forms.Padding(2)
        Me.frame_servidumbre.Size = New System.Drawing.Size(203, 91)
        Me.frame_servidumbre.TabIndex = 20
        Me.frame_servidumbre.TabStop = False
        Me.frame_servidumbre.Text = "SERVIDUMBRE"
        '
        'ft_area_servidumbre
        '
        Me.ft_area_servidumbre.FormattingEnabled = True
        Me.ft_area_servidumbre.Items.AddRange(New Object() {"SI", "NO"})
        Me.ft_area_servidumbre.Location = New System.Drawing.Point(140, 24)
        Me.ft_area_servidumbre.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_area_servidumbre.Name = "ft_area_servidumbre"
        Me.ft_area_servidumbre.Size = New System.Drawing.Size(52, 21)
        Me.ft_area_servidumbre.TabIndex = 15
        '
        'TextBox14
        '
        Me.TextBox14.AcceptsReturn = True
        Me.TextBox14.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(4, 24)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(118, 31)
        Me.TextBox14.TabIndex = 17
        Me.TextBox14.Text = "¿REQUIERE ÁREA DE SERVIDUMBRE?"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(352, 27)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(161, 46)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "BUSCAR FILTRO"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(544, 28)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(161, 46)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "BUSCAR EN BASE DE CLIENTES"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ft_button_generar_carta
        '
        Me.ft_button_generar_carta.Location = New System.Drawing.Point(338, 381)
        Me.ft_button_generar_carta.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_button_generar_carta.Name = "ft_button_generar_carta"
        Me.ft_button_generar_carta.Size = New System.Drawing.Size(161, 46)
        Me.ft_button_generar_carta.TabIndex = 24
        Me.ft_button_generar_carta.Text = "GENERAR CARTA"
        Me.ft_button_generar_carta.UseVisualStyleBackColor = True
        '
        'ft_button_registrar
        '
        Me.ft_button_registrar.Location = New System.Drawing.Point(146, 380)
        Me.ft_button_registrar.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_button_registrar.Name = "ft_button_registrar"
        Me.ft_button_registrar.Size = New System.Drawing.Size(161, 46)
        Me.ft_button_registrar.TabIndex = 23
        Me.ft_button_registrar.Text = "REGISTRAR_BASE_CLIENTES"
        Me.ft_button_registrar.UseVisualStyleBackColor = True
        '
        'ft_button_limpiar
        '
        Me.ft_button_limpiar.Location = New System.Drawing.Point(532, 381)
        Me.ft_button_limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.ft_button_limpiar.Name = "ft_button_limpiar"
        Me.ft_button_limpiar.Size = New System.Drawing.Size(161, 46)
        Me.ft_button_limpiar.TabIndex = 25
        Me.ft_button_limpiar.Text = "LIMPIAR"
        Me.ft_button_limpiar.UseVisualStyleBackColor = True
        '
        'form_factibilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(850, 444)
        Me.Controls.Add(Me.ft_button_limpiar)
        Me.Controls.Add(Me.ft_button_generar_carta)
        Me.Controls.Add(Me.ft_button_registrar)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.frame_servidumbre)
        Me.Controls.Add(Me.frame_memo_planeamiento)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form_factibilidad"
        Me.Text = "FACTIBILIDAD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.frame_memo_planeamiento.ResumeLayout(False)
        Me.frame_memo_planeamiento.PerformLayout()
        Me.frame_servidumbre.ResumeLayout(False)
        Me.frame_servidumbre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ft_spo As RichTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ft_rol As ComboBox
    Friend WithEvents ft_expediente As RichTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ft_distrito_de_envio As RichTextBox
    Friend WithEvents ft_direccion_de_envio As RichTextBox
    Friend WithEvents ft_empresa_solicitante As ComboBox
    Friend WithEvents ft_dirigido_a As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ft_distrito_de_obra As RichTextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents ft_direccion_de_obra As RichTextBox
    Friend WithEvents ft_cliente As RichTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ft_provincia_de_obra As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ft_pot_soli_bt As RichTextBox
    Friend WithEvents ft_pot_soli_mt As RichTextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents frame_memo_planeamiento As GroupBox
    Friend WithEvents ft_correlativo As RichTextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents frame_servidumbre As GroupBox
    Friend WithEvents ft_area_servidumbre As ComboBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ft_button_generar_carta As Button
    Friend WithEvents ft_button_registrar As Button
    Friend WithEvents ft_button_limpiar As Button
    Friend WithEvents TextBox1 As TextBox
End Class
