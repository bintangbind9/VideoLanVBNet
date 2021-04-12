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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cam1 = New AxAXVLC.AxVLCPlugin2()
        Me.img1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btOn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.img2 = New System.Windows.Forms.PictureBox()
        Me.btCapture = New System.Windows.Forms.Button()
        CType(Me.cam1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cam1
        '
        Me.cam1.Enabled = True
        Me.cam1.Location = New System.Drawing.Point(12, 12)
        Me.cam1.Name = "cam1"
        Me.cam1.OcxState = CType(resources.GetObject("cam1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cam1.Size = New System.Drawing.Size(320, 240)
        Me.cam1.TabIndex = 0
        '
        'img1
        '
        Me.img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img1.Location = New System.Drawing.Point(372, 12)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(315, 240)
        Me.img1.TabIndex = 1
        Me.img1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 270)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "http://192.168.1.18:4747/video"
        '
        'btOn
        '
        Me.btOn.Location = New System.Drawing.Point(255, 267)
        Me.btOn.Name = "btOn"
        Me.btOn.Size = New System.Drawing.Size(77, 25)
        Me.btOn.TabIndex = 3
        Me.btOn.Text = "ON"
        Me.btOn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 296)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(320, 238)
        Me.ListBox1.TabIndex = 4
        '
        'img2
        '
        Me.img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img2.Location = New System.Drawing.Point(375, 296)
        Me.img2.Name = "img2"
        Me.img2.Size = New System.Drawing.Size(315, 240)
        Me.img2.TabIndex = 5
        Me.img2.TabStop = False
        '
        'btCapture
        '
        Me.btCapture.Location = New System.Drawing.Point(613, 262)
        Me.btCapture.Name = "btCapture"
        Me.btCapture.Size = New System.Drawing.Size(77, 25)
        Me.btCapture.TabIndex = 6
        Me.btCapture.Text = "Capture"
        Me.btCapture.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 548)
        Me.Controls.Add(Me.btCapture)
        Me.Controls.Add(Me.img2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btOn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.img1)
        Me.Controls.Add(Me.cam1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyCam"
        CType(Me.cam1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cam1 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents img1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btOn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents img2 As PictureBox
    Friend WithEvents btCapture As Button
End Class
