using System;
using System.Net.Http;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public class UpdateChecker
    {
        // URL a tu repositorio en GitHub (ajusta usuario/repositorio)
        private static readonly string repoUrl = "https://api.github.com/repos/BrazanXL/CST/releases/latest";

        // Obtener versión actual desde AssemblyInfo
        private static readonly string currentVersion = Assembly
            .GetExecutingAssembly()
            .GetName()
            .Version
            .ToString();

        public static async Task CheckForUpdatesAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "MiAplicativo");

                    string json = await client.GetStringAsync(repoUrl);

                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        string latestVersion = doc.RootElement.GetProperty("tag_name").GetString();

                        if (latestVersion != null && latestVersion != "v" + currentVersion)
                        {
                            DialogResult result = MessageBox.Show(
                                $"Nueva versión disponible: {latestVersion}\n¿Desea descargarla?",
                                "Actualización disponible",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                string downloadUrl = doc.RootElement
                                    .GetProperty("assets")[0]
                                    .GetProperty("browser_download_url")
                                    .GetString();

                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = downloadUrl,
                                    UseShellExecute = true
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verificando actualizaciones: " + ex.Message);
            }
        }
    }
}
