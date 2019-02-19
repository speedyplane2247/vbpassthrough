Module Main1

    Sub Main()
    
        Dim EXEArgs = My.Application.CommandLineArgs.ToString()
        Dim EXEName = "failed"
        Dim EXERen = "C:\Windows\System32\cmd.exe /k"
        EXEName = Process.GetCurrentProcess().MainModule.ToString()
        If EXEName = "failed" Then
            MsgBox("Failed to find required DLL.", vbCritical)
        Else
            EXERen = "C:\Windows\System32\cmd.exe /k rename " + EXEName + " temp.exe"
            Process.Start(EXERen)
            Process.Start("C:\Windows\temp.exe " + EXEArgs(1) + EXEArgs(2) + EXEArgs(3) + EXEArgs(4) + EXEArgs(5) + EXEArgs(6))

            Process.Start("C:\Windows\System32\cmd.exe /k echo y | del C:\Windows\temp.exe")
        End If
    End Sub

End Module
' not written in an IDE, might not work
