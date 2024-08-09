<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBrowseOutput = New System.Windows.Forms.Button()
        Me.btnBrowseInput = New System.Windows.Forms.Button()
        Me.txtInputPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutputPath = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBrowseOutput
        '
        Me.btnBrowseOutput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseOutput.Location = New System.Drawing.Point(426, 59)
        Me.btnBrowseOutput.Name = "btnBrowseOutput"
        Me.btnBrowseOutput.Size = New System.Drawing.Size(90, 23)
        Me.btnBrowseOutput.TabIndex = 0
        Me.btnBrowseOutput.Text = "Browse Output"
        Me.btnBrowseOutput.UseVisualStyleBackColor = True
        '
        'btnBrowseInput
        '
        Me.btnBrowseInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseInput.Location = New System.Drawing.Point(426, 31)
        Me.btnBrowseInput.Name = "btnBrowseInput"
        Me.btnBrowseInput.Size = New System.Drawing.Size(90, 23)
        Me.btnBrowseInput.TabIndex = 1
        Me.btnBrowseInput.Text = "Browse Input"
        Me.btnBrowseInput.UseVisualStyleBackColor = True
        '
        'txtInputPath
        '
        Me.txtInputPath.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputPath.Location = New System.Drawing.Point(92, 33)
        Me.txtInputPath.Name = "txtInputPath"
        Me.txtInputPath.Size = New System.Drawing.Size(328, 23)
        Me.txtInputPath.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input Path"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Output Path"
        '
        'txtOutputPath
        '
        Me.txtOutputPath.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputPath.Location = New System.Drawing.Point(92, 61)
        Me.txtOutputPath.Name = "txtOutputPath"
        Me.txtOutputPath.Size = New System.Drawing.Size(328, 23)
        Me.txtOutputPath.TabIndex = 4
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(522, 59)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MS-EXCEL TO JSON"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 98)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOutputPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInputPath)
        Me.Controls.Add(Me.btnBrowseInput)
        Me.Controls.Add(Me.btnBrowseOutput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowseOutput As Button
    Friend WithEvents btnBrowseInput As Button
    Friend WithEvents txtInputPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOutputPath As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label3 As Label
End Class
