// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("CICD on AWS programme");
Process process = new Process();
process.StartInfo.UseShellExecute = true;
process.StartInfo.FileName = "chrome";
//process.StartInfo.Arguments = @"http://www.stackoverflow.net/";
//process.StartInfo.Arguments = @"https://web.whatsapp.com/";
//process.StartInfo.Arguments = @"https://web.whatsapp.com/";
//process.StartInfo.Arguments = @"https://outlook.office.com/mail/";
//process.StartInfo.Arguments = @"https://www.flipkart.com/";
process.StartInfo.Arguments = @"https://sastraonline.com/online-mca-degree-course?utm_source=Google-Search&utm_medium=cpc&utm_campaign=Sastra-MCA-Brand-Phrase&utm_term=Brand&gclid=EAIaIQobChMI3sH2jqbn_wIV-5hmAh39YgVIEAAYASAAEgKu8_D_BwE/";
//process.StartInfo.Arguments = @"https://web.whatsapp.com/";
process.Start();
