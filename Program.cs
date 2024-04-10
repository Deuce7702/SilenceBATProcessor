using System.Diagnostics;

int ExitCode = 0;
ProcessStartInfo ProcessInfo;
Process Process;

if (string.IsNullOrEmpty(args[0]))
{
    Environment.Exit(8888);
}

ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + args[0]);
ProcessInfo.CreateNoWindow = true;
ProcessInfo.UseShellExecute = false;

Process = Process.Start(ProcessInfo);
Process.WaitForExit();

ExitCode = Process.ExitCode;
Process.Close();
if (ExitCode == 0)
{
    Environment.Exit(0);
}
else
{
    Environment.Exit(ExitCode);
}