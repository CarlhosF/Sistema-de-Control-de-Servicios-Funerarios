using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Partidas_Contable.Services
{
    class UpdateService
    {
        public void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("La nueva version no puede descarse actualmente. \n\n Revise su conexion a internet o intente mas tarde. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("No se puede instalar la nueva version debido a que la version instalada se corrompio. Intente reinstalar su actual version. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("No se pudo aplicar la actualizacion. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("Hay una actualizacion disponible, ¿Desea aplicar la actualizacion?", "Actualizacion disponible", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("Esta aplicación ha detectado una actualización obligatoria de su" +
                            "version a la version " + info.MinimumRequiredVersion.ToString() +
                            ". La aplicación ahora instalará la actualización y se reiniciará..",
                            "Actualización disponible", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("La aplicación se ha actualizado y ahora se reiniciará ");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("No se puede instalar la última versión de la aplicación.. \n\nRevisa tu conexion o intenta mas tarde. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }
    }
}
