<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComic))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.lblCostTickets = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radSuperhero = New System.Windows.Forms.RadioButton()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(194, 528)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(156, 40)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'picComic
        '
        Me.picComic.Image = CType(resources.GetObject("picComic.Image"), System.Drawing.Image)
        Me.picComic.Location = New System.Drawing.Point(-1, 0)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(801, 215)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 1
        Me.picComic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(124, 226)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(552, 51)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Comic Convention Registration"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSize.ForeColor = System.Drawing.Color.Red
        Me.lblSize.Location = New System.Drawing.Point(304, 291)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(109, 20)
        Me.lblSize.TabIndex = 3
        Me.lblSize.Text = "Group Size:"
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Cooper Black", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRegistration.ForeColor = System.Drawing.Color.Red
        Me.lblRegistration.Location = New System.Drawing.Point(233, 482)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(175, 21)
        Me.lblRegistration.TabIndex = 4
        Me.lblRegistration.Text = "Registration Cost:"
        '
        'lblCostTickets
        '
        Me.lblCostTickets.AutoSize = True
        Me.lblCostTickets.Font = New System.Drawing.Font("Cooper Black", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCostTickets.ForeColor = System.Drawing.Color.Red
        Me.lblCostTickets.Location = New System.Drawing.Point(461, 482)
        Me.lblCostTickets.Name = "lblCostTickets"
        Me.lblCostTickets.Size = New System.Drawing.Size(68, 21)
        Me.lblCostTickets.TabIndex = 5
        Me.lblCostTickets.Text = "$X.XX"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(450, 528)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(156, 40)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtGroup
        '
        Me.txtGroup.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGroup.ForeColor = System.Drawing.Color.Red
        Me.txtGroup.Location = New System.Drawing.Point(437, 288)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(60, 27)
        Me.txtGroup.TabIndex = 7
        '
        'grpType
        '
        Me.grpType.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grpType.Controls.Add(Me.radConvention)
        Me.grpType.Controls.Add(Me.radAutographs)
        Me.grpType.Controls.Add(Me.radSuperhero)
        Me.grpType.Font = New System.Drawing.Font("Broadway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpType.ForeColor = System.Drawing.Color.Red
        Me.grpType.Location = New System.Drawing.Point(184, 333)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(433, 121)
        Me.grpType.TabIndex = 8
        Me.grpType.TabStop = False
        Me.grpType.Text = "Select Badge Type:"
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(32, 86)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(145, 24)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Location = New System.Drawing.Point(32, 56)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(284, 24)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radSuperhero
        '
        Me.radSuperhero.AutoSize = True
        Me.radSuperhero.Location = New System.Drawing.Point(32, 26)
        Me.radSuperhero.Name = "radSuperhero"
        Me.radSuperhero.Size = New System.Drawing.Size(390, 24)
        Me.radSuperhero.TabIndex = 0
        Me.radSuperhero.TabStop = True
        Me.radSuperhero.Text = "Convention + Superhero Experience"
        Me.radSuperhero.UseVisualStyleBackColor = True
        '
        'frmComic
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 589)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCostTickets)
        Me.Controls.Add(Me.lblRegistration)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picComic)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmComic"
        Me.Text = "Comic Convention Registration"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblRegistration As Label
    Friend WithEvents lblCostTickets As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtGroup As TextBox
    Friend WithEvents grpType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radSuperhero As RadioButton
End Class
