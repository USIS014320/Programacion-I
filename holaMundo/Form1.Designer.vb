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
        Me.SuspendLayout()
        '
        'cbo2
        '
        Me.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo2.Location = New System.Drawing.Point(317, 108)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(121, 21)
        Me.cbo2.TabIndex = 0
        '
        'cbo1
        '
        Me.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo1.Location = New System.Drawing.Point(70, 108)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(121, 21)
        Me.cbo1.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(12, 108)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(38, 23)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "De:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(247, 108)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(26, 19)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "A:"
        '
        'lbllongitud
        '
        Me.lbllongitud.AutoSize = True
        Me.lbllongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllongitud.Location = New System.Drawing.Point(12, 74)
        Me.lbllongitud.Name = "lbllongitud"
        Me.lbllongitud.Size = New System.Drawing.Size(79, 20)
        Me.lbllongitud.TabIndex = 4
        Me.lbllongitud.Text = "Longitud"
        '
        'txtentrada
        '
        Me.txtentrada.Location = New System.Drawing.Point(186, 42)
        Me.txtentrada.Name = "txtentrada"
        Me.txtentrada.Size = New System.Drawing.Size(100, 20)
        Me.txtentrada.TabIndex = 6
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(186, 212)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtrespuesta.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 350)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.txtentrada)
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
    Friend WithEvents txtentrada As TextBox
    Friend WithEvents txtrespuesta As TextBox
End Class
