<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    Me.radBus = New System.Windows.Forms.RadioButton()
    Me.radRes = New System.Windows.Forms.RadioButton()
    Me.lblPrem = New System.Windows.Forms.Label()
    Me.lblConn = New System.Windows.Forms.Label()
    Me.lstPremium = New System.Windows.Forms.ListBox()
    Me.lstConnections = New System.Windows.Forms.ListBox()
    Me.lblTotalMsg = New System.Windows.Forms.Label()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.btnCalc = New System.Windows.Forms.Button()
    Me.btnExit = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'radBus
    '
    Me.radBus.AutoSize = True
    Me.radBus.Checked = True
    Me.radBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.radBus.Location = New System.Drawing.Point(26, 35)
    Me.radBus.Name = "radBus"
    Me.radBus.Size = New System.Drawing.Size(92, 24)
    Me.radBus.TabIndex = 0
    Me.radBus.Text = "&Business"
    Me.radBus.UseVisualStyleBackColor = True
    '
    'radRes
    '
    Me.radRes.AutoSize = True
    Me.radRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.radRes.Location = New System.Drawing.Point(26, 65)
    Me.radRes.Name = "radRes"
    Me.radRes.Size = New System.Drawing.Size(106, 24)
    Me.radRes.TabIndex = 1
    Me.radRes.Text = "&Residential"
    Me.radRes.UseVisualStyleBackColor = True
    '
    'lblPrem
    '
    Me.lblPrem.AutoSize = True
    Me.lblPrem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPrem.Location = New System.Drawing.Point(182, 37)
    Me.lblPrem.Name = "lblPrem"
    Me.lblPrem.Size = New System.Drawing.Size(143, 20)
    Me.lblPrem.TabIndex = 2
    Me.lblPrem.Text = "&Premium channels:"
    '
    'lblConn
    '
    Me.lblConn.AutoSize = True
    Me.lblConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblConn.Location = New System.Drawing.Point(360, 37)
    Me.lblConn.Name = "lblConn"
    Me.lblConn.Size = New System.Drawing.Size(102, 20)
    Me.lblConn.TabIndex = 3
    Me.lblConn.Text = "&Connections:"
    '
    'lstPremium
    '
    Me.lstPremium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstPremium.FormattingEnabled = True
    Me.lstPremium.ItemHeight = 20
    Me.lstPremium.Location = New System.Drawing.Point(186, 60)
    Me.lstPremium.Name = "lstPremium"
    Me.lstPremium.Size = New System.Drawing.Size(67, 124)
    Me.lstPremium.TabIndex = 4
    '
    'lstConnections
    '
    Me.lstConnections.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstConnections.FormattingEnabled = True
    Me.lstConnections.ItemHeight = 20
    Me.lstConnections.Location = New System.Drawing.Point(364, 60)
    Me.lstConnections.Name = "lstConnections"
    Me.lstConnections.Size = New System.Drawing.Size(67, 124)
    Me.lstConnections.TabIndex = 5
    '
    'lblTotalMsg
    '
    Me.lblTotalMsg.AutoSize = True
    Me.lblTotalMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotalMsg.Location = New System.Drawing.Point(22, 203)
    Me.lblTotalMsg.Name = "lblTotalMsg"
    Me.lblTotalMsg.Size = New System.Drawing.Size(79, 20)
    Me.lblTotalMsg.TabIndex = 6
    Me.lblTotalMsg.Text = "Total due:"
    '
    'lblTotal
    '
    Me.lblTotal.AutoSize = True
    Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(22, 232)
    Me.lblTotal.MinimumSize = New System.Drawing.Size(150, 40)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(150, 40)
    Me.lblTotal.TabIndex = 7
    '
    'btnCalc
    '
    Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCalc.Location = New System.Drawing.Point(205, 232)
    Me.btnCalc.MinimumSize = New System.Drawing.Size(130, 30)
    Me.btnCalc.Name = "btnCalc"
    Me.btnCalc.Size = New System.Drawing.Size(180, 40)
    Me.btnCalc.TabIndex = 8
    Me.btnCalc.Text = "Calculate Total &Due"
    Me.btnCalc.UseVisualStyleBackColor = True
    '
    'btnExit
    '
    Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExit.Location = New System.Drawing.Point(391, 232)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(80, 40)
    Me.btnExit.TabIndex = 9
    Me.btnExit.Text = "E&xit"
    Me.btnExit.UseVisualStyleBackColor = True
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(496, 297)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.btnCalc)
    Me.Controls.Add(Me.lblTotal)
    Me.Controls.Add(Me.lblTotalMsg)
    Me.Controls.Add(Me.lstConnections)
    Me.Controls.Add(Me.lstPremium)
    Me.Controls.Add(Me.lblConn)
    Me.Controls.Add(Me.lblPrem)
    Me.Controls.Add(Me.radRes)
    Me.Controls.Add(Me.radBus)
    Me.Name = "frmMain"
    Me.Text = "Cable Direct"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents radBus As RadioButton
  Friend WithEvents radRes As RadioButton
  Friend WithEvents lblPrem As Label
  Friend WithEvents lblConn As Label
  Friend WithEvents lstPremium As ListBox
  Friend WithEvents lstConnections As ListBox
  Friend WithEvents lblTotalMsg As Label
  Friend WithEvents lblTotal As Label
  Friend WithEvents btnCalc As Button
  Friend WithEvents btnExit As Button
End Class
