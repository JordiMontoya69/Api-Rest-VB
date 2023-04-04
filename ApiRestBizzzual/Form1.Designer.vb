<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.tbLatitud = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbLongitud = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pbImagen.Location = New System.Drawing.Point(236, 12)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(487, 308)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 11
        Me.pbImagen.TabStop = False
        '
        'tbLatitud
        '
        Me.tbLatitud.Location = New System.Drawing.Point(106, 99)
        Me.tbLatitud.Name = "tbLatitud"
        Me.tbLatitud.Size = New System.Drawing.Size(100, 20)
        Me.tbLatitud.TabIndex = 10
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(36, 99)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 18)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Latitud"
        '
        'tbLongitud
        '
        Me.tbLongitud.Location = New System.Drawing.Point(106, 140)
        Me.tbLongitud.Name = "tbLongitud"
        Me.tbLongitud.Size = New System.Drawing.Size(100, 20)
        Me.tbLongitud.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(22, 140)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 18)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Longitud"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(111, 198)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(95, 82)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Get"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Visual Basic"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 329)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.tbLatitud)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbLongitud)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pbImagen As PictureBox
    Private WithEvents tbLatitud As TextBox
    Private WithEvents label2 As Label
    Private WithEvents tbLongitud As TextBox
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
    Private WithEvents Label3 As Label
End Class
