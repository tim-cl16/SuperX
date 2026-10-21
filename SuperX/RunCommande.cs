using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace superXDev
{
    public class RunCommande
    {
        public static string RunCommandWithBash(string command)
        { 
            var psi = new ProcessStartInfo();
            psi.FileName = "/bin/bash";
            psi.Arguments = $"-c \"{command}\"";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = true;

            using var process = Process.Start(psi);

            process.StandardInput.WriteLine("16554433");
            process.StandardInput.Close();

            var output = process.StandardOutput.ReadToEnd();
            var error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            if (!string.IsNullOrEmpty(error))
            {
                return $"Erreur : {error}\n{output}";
            }

            return output;
        }
       
    }
}