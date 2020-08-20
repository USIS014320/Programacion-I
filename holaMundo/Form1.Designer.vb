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
        Me.txtentrada = New System.Windows.Forms.TextBox()
        Me.txtrespuesta = New System.Windows.Forms.TextBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblIgual = New System.Windows.Forms.Label()
        Me.txtrespuestab = New System.Windows.Forms.TextBox()
        Me.txtEntradab = New System.Windows.Forms.TextBox()
        Me.lblmasa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDe = New System.Windows.Forms.ComboBox()
        Me.cboA = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbo2
        '
        Me.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo2.Location = New System.Drawing.Point(390, 129)
        Me.cbo2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(160, 24)
        Me.cbo2.TabIndex = 0
        '
        'cbo1
        '
        Me.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo1.Location = New System.Drawing.Point(146, 128)
        Me.cbo1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(160, 24)
        Me.cbo1.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(204, 96)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(48, 28)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "De:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(469, 100)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(30, 24)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "A:"
        '
        'lbllongitud
        '
        Me.lbllongitud.AutoSize = True
        Me.lbllongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllongitud.Location = New System.Drawing.Point(293, 36)
        Me.lbllongitud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllongitud.Name = "lbllongitud"
        Me.lbllongitud.Size = New System.Drawing.Size(95, 25)
        Me.lbllongitud.TabIndex = 4
        Me.lbllongitud.Text = "Longitud"
        '
        'txtentrada
        '
        Me.txtentrada.Location = New System.Drawing.Point(277, 65)
        Me.txtentrada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtentrada.Name = "txtentrada"
        Me.txtentrada.Size = New System.Drawing.Size(132, 22)
        Me.txtentrada.TabIndex = 6
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(277, 186)
        Me.txtrespuesta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(132, 22)
        Me.txtrespuesta.TabIndex = 9
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(265, 528)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(163, 45)
        Me.btnConvertir.TabIndex = 27
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblIgual
        '
        Me.lblIgual.AutoSize = True
        Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgual.Location = New System.Drawing.Point(331, 427)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(28, 29)
        Me.lblIgual.TabIndex = 26
        Me.lblIgual.Text = "="
        '
        'txtrespuestab
        '
        Me.txtrespuestab.Location = New System.Drawing.Point(277, 460)
        Me.txtrespuestab.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrespuestab.Name = "txtrespuestab"
        Me.txtrespuestab.Size = New System.Drawing.Size(132, 22)
        Me.txtrespuestab.TabIndex = 25
        '
        'txtEntradab
        '
        Me.txtEntradab.Location = New System.Drawing.Point(277, 336)
        Me.txtEntradab.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEntradab.Name = "txtEntradab"
        Me.txtEntradab.Size = New System.Drawing.Size(132, 22)
        Me.txtEntradab.TabIndex = 24
        '
        'lblmasa
        '
        Me.lblmasa.AutoSize = True
        Me.lblmasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmasa.Location = New System.Drawing.Point(313, 307)
        Me.lblmasa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmasa.Name = "lblmasa"
        Me.lblmasa.Size = New System.Drawing.Size(75, 25)
        Me.lblmasa.TabIndex = 23
        Me.lblmasa.Text = "MASA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 361)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 357)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 28)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "De:"
        '
        'cboDe
        '
        Me.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDe.FormattingEnabled = True
        Me.cboDe.Items.AddRange(New Object() {"Kilogramo", "Libra", "Onza", "Quintal", "Tonelada", "Arroba", "Gramo", "Miligramo", "Microgramo", "Quilate"})
        Me.cboDe.Location = New System.Drawing.Point(59, 389)
        Me.cboDe.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDe.Name = "cboDe"
        Me.cboDe.Size = New System.Drawing.Size(160, 24)
        Me.cboDe.TabIndex = 20
        '
        'cboA
        '
        Me.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA.FormattingEnabled = True
        Me.cboA.Items.AddRange(New Object() {"Kilogramo", "Libra", "Onza", "Quintal", "Tonelada", "Arroba", "Gramo", "Miligramo", "Microgramo", "Quilate"})
        Me.cboA.Location = New System.Drawing.Point(471, 389)
        Me.cboA.Margin = New System.Windows.Forms.Padding(4)
        Me.cboA.Name = "cboA"
        Me.cboA.Size = New System.Drawing.Size(160, 24)
        Me.cboA.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(693, 599)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblIgual)
        Me.Controls.Add(Me.txtrespuestab)
        Me.Controls.Add(Me.txtEntradab)
        Me.Controls.Add(Me.lblmasa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDe)
        Me.Controls.Add(Me.cboA)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.txtentrada)
        Me.Controls.Add(Me.lbllongitud)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.cbo2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents txtentrada As TextBox
    Friend WithEvents txtrespuesta As TextBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblIgual As Label
    Friend WithEvents txtrespuestab As TextBox
    Friend WithEvents txtEntradab As TextBox
    Friend WithEvents lblmasa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDe As ComboBox
    Friend WithEvents cboA As ComboBox
End Class
