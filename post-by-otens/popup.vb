Module popup
    Function MessageTimeOut(sMessage As String, sTitle As String, iSeconds As Integer) As Boolean
        Dim Shell
        Shell = CreateObject("WScript.Shell")
        Shell.Run
        MessageTimeOut = True
    End Function
End Module
