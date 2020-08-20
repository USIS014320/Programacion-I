<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbo2 = New System.Windows.Forms.ComboBox()
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbllongitud = New System.Windows.Forms.Label()
        Me.txtEntradab = New System.Windows.Forms.TextBox()
        Me.txtrespuesta = New System.Windows.Forms.TextBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblIgual = New System.Windows.Forms.Label()
        Me.lblmasa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDe = New System.Windows.Forms.ComboBox()
        Me.cboA = New System.Windows.Forms.ComboBox()
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.lblalamacenamientoa = New System.Windows.Forms.Label()
        Me.lblalmacenamientode = New System.Windows.Forms.Label()
        Me.cboalmacenamientosalida = New System.Windows.Forms.ComboBox()
        Me.cboalmacenamientoentrada = New System.Windows.Forms.ComboBox()
        Me.lblalmacenamiento = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbo2
        '
        Me.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo2.Location = New System.Drawing.Point(368, 105)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(121, 21)
        Me.cbo2.TabIndex = 0
        '
        'cbo1
        '
        Me.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo1.Location = New System.Drawing.Point(46, 105)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(121, 21)
        Me.cbo1.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(91, 79)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(38, 23)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "De:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(418, 81)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(26, 19)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "A:"
        '
        'lbllongitud
        '
        Me.lbllongitud.AutoSize = True
        Me.lbllongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllongitud.Location = New System.Drawing.Point(74, 58)
        Me.lbllongitud.Name = "lbllongitud"
        Me.lbllongitud.Size = New System.Drawing.Size(79, 20)
        Me.lbllongitud.TabIndex = 4
        Me.lbllongitud.Text = "Longitud"
        '
        'txtEntradab
        '
        Me.txtEntradab.Location = New System.Drawing.Point(222, 62)
        Me.txtEntradab.Name = "txtEntradab"
        Me.txtEntradab.Size = New System.Drawing.Size(100, 20)
        Me.txtEntradab.TabIndex = 6
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(222, 353)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtrespuesta.TabIndex = 9
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(202, 394)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(134, 46)
        Me.btnConvertir.TabIndex = 27
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblIgual
        '
        Me.lblIgual.AutoSize = True
        Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgual.Location = New System.Drawing.Point(262, 326)
        Me.lblIgual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(22, 24)
        Me.lblIgual.TabIndex = 26
        Me.lblIgual.Text = "="
        '
        'lblmasa
        '
        Me.lblmasa.AutoSize = True
        Me.lblmasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmasa.Location = New System.Drawing.Point(74, 129)
        Me.lblmasa.Name = "lblmasa"
        Me.lblmasa.Size = New System.Drawing.Size(59, 20)
        Me.lblmasa.TabIndex = 23
        Me.lblmasa.Text = "MASA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(418, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "De:"
        '
        'cboDe
        '
        Me.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDe.FormattingEnabled = True
        Me.cboDe.Items.AddRange(New Object() {"Kilogramo", "Libra", "Onza", "Quintal", "Tonelada", "Arroba", "Gramo", "Miligramo", "Microgramo", "Quilate"})
        Me.cboDe.Location = New System.Drawing.Point(46, 179)
        Me.cboDe.Name = "cboDe"
        Me.cboDe.Size = New System.Drawing.Size(121, 21)
        Me.cboDe.TabIndex = 20
        '
        'cboA
        '
        Me.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA.FormattingEnabled = True
        Me.cboA.Items.AddRange(New Object() {"Kilogramo", "Libra", "Onza", "Quintal", "Tonelada", "Arroba", "Gramo", "Miligramo", "Microgramo", "Quilate"})
        Me.cboA.Location = New System.Drawing.Point(368, 179)
        Me.cboA.Name = "cboA"
        Me.cboA.Size = New System.Drawing.Size(121, 21)
        Me.cboA.TabIndex = 19
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalor.Location = New System.Drawing.Point(234, 35)
        Me.lblvalor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(79, 24)
        Me.lblvalor.TabIndex = 28
        Me.lblvalor.Text = "VALOR"
        '
        'lblalamacenamientoa
        '
        Me.lblalamacenamientoa.AutoSize = True
        Me.lblalamacenamientoa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalamacenamientoa.Location = New System.Drawing.Point(419, 220)
        Me.lblalamacenamientoa.Name = "lblalamacenamientoa"
        Me.lblalamacenamientoa.Size = New System.Drawing.Size(21, 16)
        Me.lblalamacenamientoa.TabIndex = 33
        Me.lblalamacenamientoa.Text = "A:"
        '
        'lblalmacenamientode
        '
        Me.lblalmacenamientode.AutoSize = True
        Me.lblalmacenamientode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalmacenamientode.Location = New System.Drawing.Point(87, 229)
        Me.lblalmacenamientode.Name = "lblalmacenamientode"
        Me.lblalmacenamientode.Size = New System.Drawing.Size(29, 16)
        Me.lblalmacenamientode.TabIndex = 32
        Me.lblalmacenamientode.Text = "De:"
        '
        'cboalmacenamientosalida
        '
        Me.cboalmacenamientosalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacenamientosalida.FormattingEnabled = True
        Me.cboalmacenamientosalida.Items.AddRange(New Object() {"Bit", "Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Petabyte"})
        Me.cboalmacenamientosalida.Location = New System.Drawing.Point(368, 256)
        Me.cboalmacenamientosalida.Name = "cboalmacenamientosalida"
        Me.cboalmacenamientosalida.Size = New System.Drawing.Size(121, 21)
        Me.cboalmacenamientosalida.TabIndex = 31
        '
        'cboalmacenamientoentrada
        '
        Me.cboalmacenamientoentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacenamientoentrada.FormattingEnabled = True
        Me.cboalmacenamientoentrada.Items.AddRange(New Object() {"Bit", "Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Petabyte"})
        Me.cboalmacenamientoentrada.Location = New System.Drawing.Point(46, 256)
        Me.cboalmacenamientoentrada.Name = "cboalmacenamientoentrada"
        Me.cboalmacenamientoentrada.Size = New System.Drawing.Size(121, 21)
        Me.cboalmacenamientoentrada.TabIndex = 30
        '
        'lblalmacenamiento
        '
        Me.lblalmacenamiento.AutoSize = True
        Me.lblalmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalmacenamiento.Location = New System.Drawing.Point(51, 203)
        Me.lblalmacenamiento.Name = "lblalmacenamiento"
        Me.lblalmacenamiento.Size = New System.Drawing.Size(102, 16)
        Me.lblalmacenamiento.TabIndex = 29
        Me.lblalmacenamiento.Text = "Alcemaniento"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(542, 487)
        Me.Controls.Add(Me.lblalamacenamientoa)
        Me.Controls.Add(Me.lblalmacenamientode)
        Me.Controls.Add(Me.cboalmacenamientosalida)
        Me.Controls.Add(Me.cboalmacenamientoentrada)
        Me.Controls.Add(Me.lblalmacenamiento)
        Me.Controls.Add(Me.lblvalor)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblIgual)
        Me.Controls.Add(Me.lblmasa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDe)
        Me.Controls.Add(Me.cboA)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.txtEntradab)
        Me.Controls.Add(Me.lbllongitud)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.cbo2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Conversor de unidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbo2 As ComboBox
    Friend WithEvents cbo1 As ComboBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbllongitud As Label
    Friend WithEvents txtrespuesta As TextBox
    Friend WithEvents txtEntradab As TextBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblIgual As Label
    Friend WithEvents lblmasa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDe As ComboBox
    Friend WithEvents cboA As ComboBox
    Friend WithEvents lblvalor As Label
    Friend WithEvents lblalamacenamientoa As Label
    Friend WithEvents lblalmacenamientode As Label
    Friend WithEvents cboalmacenamientosalida As ComboBox
    Friend WithEvents cboalmacenamientoentrada As ComboBox
    Friend WithEvents lblalmacenamiento As Label
End Class
