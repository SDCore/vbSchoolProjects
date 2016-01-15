﻿' Michael Voell
' Aluminum Recycling Campaign
' 1/14/2016
' Purpose: Use subprocedures to calculate different types of equations.

Option Strict On

Public Class frmAluminumRecycling

    ' Class variables
    Private _strCansNum As String = "0,000"
    Private _strCansText As String = "cans need to be collected to reach your goal"
    Private _strAmountNum As String = "$0,000"
    Private _strAmountText As String = "will be earned by collecting cans for recycling"
    Private _strGoalAmount As String = "Target Goal Amount: "
    Private _strCansCollected As String = "Cans Collected: "

    Private Sub frmAluminumRecycling_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        cboRecyclingNeed.Text = "Select an Item"
        txtAmount.Text = ""
        lblOutput.Text = _strCansNum
        lblOutputText.Text = _strCansText
        lblGoalAndCans.Text = _strGoalAmount
    End Sub

    Private Sub cboRecyclingNeed_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboRecyclingNeed.SelectedIndexChanged
        ' Variables
        Dim intRecyclingNeed As Integer

        ' Getting case information
        intRecyclingNeed = cboRecyclingNeed.SelectedIndex
        Select Case intRecyclingNeed
            Case 0
                CansNeeded()
            Case 1
                AmountEarned()
        End Select

    End Sub

    Private Sub CansNeeded()
        ' Setting the output labels to the number and description respectively.
        lblOutput.Text = _strCansNum
        lblOutputText.Text = _strCansText
        lblGoalAndCans.Text = _strGoalAmount
        txtAmount.Focus()
    End Sub

    Private Sub AmountEarned()
        ' Setting the output labels to the number and description respectively.
        lblOutput.Text = _strAmountNum
        lblOutputText.Text = _strAmountText
        lblGoalAndCans.Text = _strCansCollected
        txtAmount.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        ' Variables
        Dim intAmountWanted As Integer
        Dim intRecyclingNeed As Integer
        Dim intTargetTotal As Integer

        ' Getting case information
        intRecyclingNeed = cboRecyclingNeed.SelectedIndex
        Select Case intRecyclingNeed
            Case 0
                intTargetTotal = CInt(FindTargetAmount(intAmountWanted))
                lblOutput.Text = intTargetTotal.ToString()
            Case 1
                AmountEarned()
        End Select

    End Sub

    Private Function FindTargetAmount(ByVal intCanAmount As Integer) As Decimal
        ' Equation will be: 24 * (Amount Wanted ($) / 0.75)

        ' Variables
        Dim intAmountWanted As Integer
        Dim strAmountWanted As String
        Dim intTargetTotal As Integer

        ' Getting information from text box
        strAmountWanted = txtAmount.Text.ToString()

        ' Conversions
        intAmountWanted = Convert.ToInt32(strAmountWanted)

        ' Calculations
        intTargetTotal = CInt(24 * (intAmountWanted / 0.75))

        ' Return intTargetTotal to main sub
        Return intTargetTotal

    End Function

    Private Function FindAmountEarned(ByVal intCashEarned As Integer) As Decimal
        ' Equation will be: 0.75 * (Cans Collected / 24)
    End Function

End Class
