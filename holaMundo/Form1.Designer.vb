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
        Me.lblalamacenamientoa = New System.Windows.Forms.Label()
        Me.lblalmacenamientode = New System.Windows.Forms.Label()
        Me.cboalmacenamientosalida = New System.Windows.Forms.ComboBox()
        Me.cboalmacenamientoentrada = New System.Windows.Forms.ComboBox()
        Me.lblalmacenamiento = New System.Windows.Forms.Label()
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.txtEntradab = New System.Windows.Forms.TextBox()
        Me.lbllongitud = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.cbo2 = New System.Windows.Forms.ComboBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblIgual = New System.Windows.Forms.Label()
        Me.txtrespuesta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblalamacenamientoa
        '
        Me.lblalamacenamientoa.AutoSize = True
        Me.lblalamacenamientoa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalamacenamientoa.Location = New System.Drawing.Point(383, 122)
        Me.lblalamacenamientoa.Name = "lblalamacenamientoa"
        Me.lblalamacenamientoa.Size = New System.Drawing.Size(21, 16)
        Me.lblalamacenamientoa.TabIndex = 52
        Me.lblalamacenamientoa.Text = "A:"
        '
        'lblalmacenamientode
        '
        Me.lblalmacenamientode.AutoSize = True
        Me.lblalmacenamientode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalmacenamientode.Location = New System.Drawing.Point(51, 131)
        Me.lblalmacenamientode.Name = "lblalmacenamientode"
        Me.lblalmacenamientode.Size = New System.Drawing.Size(29, 16)
        Me.lblalmacenamientode.TabIndex = 51
        Me.lblalmacenamientode.Text = "De:"
        '
        'cboalmacenamientosalida
        '
        Me.cboalmacenamientosalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacenamientosalida.FormattingEnabled = True
        Me.cboalmacenamientosalida.Items.AddRange(New Object() {"Bit", "Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Petabyte"})
        Me.cboalmacenamientosalida.Location = New System.Drawing.Point(332, 158)
        Me.cboalmacenamientosalida.Name = "cboalmacenamientosalida"
        Me.cboalmacenamientosalida.Size = New System.Drawing.Size(121, 21)
        Me.cboalmacenamientosalida.TabIndex = 50
        '
        'cboalmacenamientoentrada
        '
        Me.cboalmacenamientoentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacenamientoentrada.FormattingEnabled = True
        Me.cboalmacenamientoentrada.Items.AddRange(New Object() {"Bit", "Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Petabyte"})
        Me.cboalmacenamientoentrada.Location = New System.Drawing.Point(10, 158)
        Me.cboalmacenamientoentrada.Name = "cboalmacenamientoentrada"
        Me.cboalmacenamientoentrada.Size = New System.Drawing.Size(121, 21)
        Me.cboalmacenamientoentrada.TabIndex = 49
        '
        'lblalmacenamiento
        '
        Me.lblalmacenamiento.AutoSize = True
        Me.lblalmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalmacenamiento.Location = New System.Drawing.Point(15, 105)
        Me.lblalmacenamiento.Name = "lblalmacenamiento"
        Me.lblalmacenamiento.Size = New System.Drawing.Size(102, 16)
        Me.lblalmacenamiento.TabIndex = 48
        Me.lblalmacenamiento.Text = "Alcemaniento"
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalor.Location = New System.Drawing.Point(198, 3)
        Me.lblvalor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(79, 24)
        Me.lblvalor.TabIndex = 47
        Me.lblvalor.Text = "VALOR"
        '
        'txtEntradab
        '
        Me.txtEntradab.Location = New System.Drawing.Point(186, 30)
        Me.txtEntradab.Name = "txtEntradab"
        Me.txtEntradab.Size = New System.Drawing.Size(100, 20)
        Me.txtEntradab.TabIndex = 46
        '
        'lbllongitud
        '
        Me.lbllongitud.AutoSize = True
        Me.lbllongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllongitud.Location = New System.Drawing.Point(38, 26)
        Me.lbllongitud.Name = "lbllongitud"
        Me.lbllongitud.Size = New System.Drawing.Size(79, 20)
        Me.lbllongitud.TabIndex = 45
        Me.lbllongitud.Text = "Longitud"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(382, 49)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(26, 19)
        Me.lbl2.TabIndex = 44
        Me.lbl2.Text = "A:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(55, 47)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(38, 23)
        Me.lbl1.TabIndex = 43
        Me.lbl1.Text = "De:"
        '
        'cbo1
        '
        Me.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo1.Location = New System.Drawing.Point(10, 73)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(121, 21)
        Me.cbo1.TabIndex = 42
        '
        'cbo2
        '
        Me.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo2.Location = New System.Drawing.Point(332, 73)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(121, 21)
        Me.cbo2.TabIndex = 41
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(168, 428)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(134, 46)
        Me.btnConvertir.TabIndex = 55
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblIgual
        '
        Me.lblIgual.AutoSize = True
        Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgual.Location = New System.Drawing.Point(230, 361)
        Me.lblIgual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(22, 24)
        Me.lblIgual.TabIndex = 54
        Me.lblIgual.Text = "="
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(186, 388)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtrespuesta.TabIndex = 53
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(500, 497)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblIgual)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.lblalamacenamientoa)
        Me.Controls.Add(Me.lblalmacenamientode)
        Me.Controls.Add(Me.cboalmacenamientosalida)
        Me.Controls.Add(Me.cboalmacenamientoentrada)
        Me.Controls.Add(Me.lblalmacenamiento)
        Me.Controls.Add(Me.lblvalor)
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
        Me.Text = "conversor de unidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblalamacenamientoa As Label
    Friend WithEvents lblalmacenamientode As Label
    Friend WithEvents cboalmacenamientosalida As ComboBox
    Friend WithEvents cboalmacenamientoentrada As ComboBox
    Friend WithEvents lblalmacenamiento As Label
    Friend WithEvents lblvalor As Label
    Friend WithEvents txtEntradab As TextBox
    Friend WithEvents lbllongitud As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents cbo1 As ComboBox
    Friend WithEvents cbo2 As ComboBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblIgual As Label
    Friend WithEvents txtrespuesta As TextBox
End Class
