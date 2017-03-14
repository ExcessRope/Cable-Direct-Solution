Option Explicit On
Option Strict On
Option Infer Off
' Name:         Cable Direct Project
' Purpose:      Calculates cable bill
' Programmer:   Nate Johnson on 9 Feb 2017

Imports System.ComponentModel

Public Class frmMain
  Private Function GetBusinessTotal() As Double
    Const dblPROC_FEE As Double = 16.5
    Const dblADD_CONN_FEE As Double = 4.0
    Const dblSERVICE_FEE As Double = 80.0
    Const dblPREM_FEE As Double = 50.0
    Dim dblNumCon As Double
    Dim dblNumPrem As Double
    Dim dblTotal As Double

    dblNumCon = Convert.ToDouble(lstConnections.SelectedItem.ToString)
    dblNumPrem = Convert.ToDouble(lstPremium.SelectedItem.ToString)

    If dblNumCon > 10 Then
      dblTotal = dblSERVICE_FEE + ((dblNumCon - 10) * dblADD_CONN_FEE)
    Else
      dblTotal = dblSERVICE_FEE
    End If

    If dblNumPrem > 0 Then
      dblTotal += dblPREM_FEE * dblNumPrem * dblNumCon
    End If

    dblTotal += dblPROC_FEE

    Return dblTotal
  End Function

  Private Function GetResTotal() As Double
    Const dblPROC_FEE As Double = 4.5
    Const dblSERVICE_FEE As Double = 30
    Const dblPREM_FEE As Double = 5.0

    Dim dblNumPrem As Double
    Dim dblTotal As Double

    dblNumPrem = Convert.ToDouble(lstPremium.SelectedItem.ToString)

    dblTotal = dblPROC_FEE + dblSERVICE_FEE + (dblNumPrem * dblPREM_FEE)

    Return dblTotal
  End Function

  Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
    Dim dblTotalDue As Double

    If radBus.Checked Then
      If lstConnections.SelectedIndex > 0 Then
        dblTotalDue = GetBusinessTotal()
        lblTotal.Text = dblTotalDue.ToString("C2")
      Else
        MessageBox.Show("Business customers are required to have at least one connection.",
                        "Cable Direct", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation)
        lblTotal.Text = String.Empty
      End If
    ElseIf radRes.Checked Then
      dblTotalDue = GetResTotal()
      lblTotal.Text = dblTotalDue.ToString("C2")
    End If
  End Sub

  Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
    ' fill lists with values
    For intChannels As Integer = 0 To 20
      lstPremium.Items.Add(intChannels.ToString)
    Next intChannels
    lstPremium.SelectedIndex = 0

    For intConn As Integer = 0 To 100
      lstConnections.Items.Add(intConn.ToString)
    Next intConn
    lstConnections.SelectedIndex = 0
  End Sub

  Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    ' verify that the user wants to exit the application

    Dim dlgButton As DialogResult

    dlgButton =
      MessageBox.Show("Do you want to exit?",
                      "Cable Direct", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Exclamation)

    ' if the No button was selected, don't close the form
    If dlgButton = System.Windows.Forms.DialogResult.No Then
      e.Cancel = True
    End If
  End Sub

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Me.Close()
  End Sub
End Class
