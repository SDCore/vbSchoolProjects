﻿' Michael Voell
' Compute Depreciation
' 1/29/2016
' Purpose: To calculate the depreciation of inventory items over time using information from a text file.

' --TODO--
' On open, the app reads the values from the song list names songs.txt
'  songs.txt includes song titles, genre, and length of each song
' A drop down list of the genres is available to select a music genre and dispaly songs of that type
' The user can select the Display Song List menu item to open a second form
'  The second form displays the choice of displaying the playlist in the present play order or a sorted song order
' Clear Button
' Exit Button

Option Strict On

Public Class frmDJPlayList

    Private Sub frmDJPlayList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Variables
        Dim strFilePath As String = "E:\Advanced VB\DJPlayList\DJPlayasdList\songs.txt"
        Dim strFileError As String = "File not found. Please try again."
        Dim strFileErrorTitle As String = "File Error"

        ' Finding file error
        If IO.File.Exists(strFilePath) Then

        Else
            MsgBox(strFileError, , strFileErrorTitle)
            Close()
        End If
    End Sub

    Private Sub btnShowList_Click(sender As System.Object, e As System.EventArgs) Handles btnShowList.Click
        
    End Sub

End Class
