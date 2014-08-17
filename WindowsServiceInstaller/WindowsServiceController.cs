using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Collections;

/*
 * Ugur Ozkan
 * uguro@biscozum.com.tr 
 * 
 * By using this program you can install/uninstall/run/restart/stop any service and see status.
 */

namespace WindowsServiceInstaller
{

    public partial class serviceInstallerForm : Form
    {
        private const String INSTALL = "-i";
        private const String UNINSTALL = "-u";
        private const int TIMEOUT_MILLISECONDS = 15000; // 15 seconds
        private String username;
        private String password;
        private String displayName;
        private String serviceName;
        private ServiceStartMode startType;
        private String path;

        public serviceInstallerForm()
        {
            InitializeComponent();
        }

        private void serviceInstallerForm_Load(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            username = null;
            password = null;
            displayName = "User Defined Service";
            serviceName = "User Defined Service";
            startType = ServiceStartMode.Automatic;
            path = null;

            serviceDisplayNameTB.Text = "";
            serviceNameTB.Text = "";
            serviceStartTypeCB.SelectedIndex = 0;
            serviceAccountCB.Checked = false;
            usernameTB.Text = "";
            passwordTB.Text = "";
            pathTB.Text = "";
            userAccountInformationGB.Enabled = false;
            servicesListCB.Items.Clear();
            allServicesCB.Items.Clear();
            runListCB.Items.Clear();
            stopRestartListCB.Items.Clear();
            foreach (ServiceController service in ServiceController.GetServices())
            {
                service.Refresh();
                servicesListCB.Items.Add(service.ServiceName);
                allServicesCB.Items.Add(service.ServiceName);
                if (service.Status != ServiceControllerStatus.Running)
                    runListCB.Items.Add(service.ServiceName);
                else
                    stopRestartListCB.Items.Add(service.ServiceName);
            }
            allServicesCB.SelectedIndex = 0;
            servicesListCB.SelectedIndex = 0;
            runListCB.SelectedIndex = 0;
            stopRestartListCB.SelectedIndex = 0;

        }

        private String getUsername()
        {
            return usernameTB.Text == "" ? null : usernameTB.Text;
        }

        private String getPassword()
        {
            return passwordTB.Text == "" ? null : passwordTB.Text;
        }

        private String getDisplayName()
        {
            return serviceDisplayNameTB.Text == "" ? "User Defined Service" : serviceDisplayNameTB.Text;
        }

        private ServiceStartMode getStartType()
        {
            switch (serviceStartTypeCB.GetItemText(serviceStartTypeCB.SelectedItem))
            {
                case "Manual": return ServiceStartMode.Manual;
                case "Disabled": return ServiceStartMode.Disabled;
                default: return ServiceStartMode.Automatic;
            }
        }

        private String getPath()
        {
            return pathTB.Text;
        }

        private ServiceAccount getServiceAccount()
        {
            if (serviceAccountCB.Checked)
                return ServiceAccount.User;
            else
                return ServiceAccount.LocalSystem;
        }

        private String getServiceName(String action)
        {
            switch (action)
            {
                case UNINSTALL: return servicesListCB.GetItemText(servicesListCB.SelectedItem);
                case INSTALL: return serviceNameTB.Text;
                default: return "User Defined Service";
            }
        }

        private void serviceAccountCB_CheckedChanged(object sender, EventArgs e)
        {
            if (serviceAccountCB.Checked == true)
            {
                userAccountInformationGB.Enabled = true;
            }
            else
            {
                userAccountInformationGB.Enabled = false;
                usernameTB.Text = "";
                passwordTB.Text = "";
            }
        }

        private static void showInfoMessage(String message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void showErrorMessage(String message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Install Tab
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pathTB.Text = openFileDialog1.FileName;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void cancelButtonInstall_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            installService();
            resetForm();
        }

        private void installService()
        {
            try
            {
                ServiceInstaller serviceInstaller = initializeServiceInstaller(INSTALL);
                try
                {
                    serviceInstaller.Install(getState());
                    showInfoMessage("Service is installed.");
                }
                catch
                {
                    showErrorMessage("Service already exists.");
                }
            }
            catch
            {
                showErrorMessage("Invalid arguments.");
            }
        }

        private ServiceInstaller initializeServiceInstaller(String action)
        {
            ServiceInstaller serviceInstaller = new ServiceInstaller();
            serviceInstaller.Context = getContext(action);
            serviceInstaller.Description = "Description: User defined Service.";
            serviceInstaller.DisplayName = getDisplayName();
            serviceInstaller.Parent = getParent();
            serviceInstaller.ServiceName = getServiceName(action);
            serviceInstaller.StartType = getStartType();
            return serviceInstaller;
        }

        private System.Configuration.Install.InstallContext getContext(String action)
        {
            System.Configuration.Install.InstallContext context = new System.Configuration.Install.InstallContext();
            String servicePath = String.Format("/assemblypath={0}", getPath());
            String[] cmdline = { servicePath };
            context = new System.Configuration.Install.InstallContext(action, cmdline);
            return context;
        }

        private ServiceProcessInstaller getParent()
        {
            ServiceProcessInstaller processServiceInstaller = new ServiceProcessInstaller();
            processServiceInstaller.Account = getServiceAccount();
            processServiceInstaller.Username = getUsername();
            processServiceInstaller.Password = getPassword();
            return processServiceInstaller;
        }

        private System.Collections.IDictionary getState()
        {
            return new System.Collections.Specialized.ListDictionary();
        }

        // Uninstall Tab
        private void cancelButtonUninstall_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            uninstallService();
            resetForm();
        }

        private void uninstallService()
        {
            ServiceInstaller serviceInstaller = initializeServiceInstaller(UNINSTALL);
            try
            {
                serviceInstaller.Uninstall(null);
                showInfoMessage("Service is uninstalled.");
            }
            catch
            {
                showErrorMessage("Service cannot be uninstalled.");
            }
        }

        // Run Tab
        private void cancelButtonRun_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            startService();
            resetForm();
        }

        private void startService()
        {
            ServiceController service = new ServiceController(runListCB.GetItemText(runListCB.SelectedItem));
            try
            {
                if (service.Status == ServiceControllerStatus.Running)
                    showErrorMessage("Service is already running.");
                else
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMilliseconds(TIMEOUT_MILLISECONDS));
                    showInfoMessage("Service is running.");
                }
            }
            catch
            {
                showErrorMessage("Service cannot be started.");
            }
        }

        // Stop/Restart Tab
        private void cancelButtonStopRestart_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopService();
            resetForm();
        }

        private void stopService()
        {
            ServiceController service = new ServiceController(stopRestartListCB.GetItemText(stopRestartListCB.SelectedItem));
            try
            {
                if (service.Status == ServiceControllerStatus.Stopped)
                    showErrorMessage("Service is already stopped.");
                else
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMilliseconds(TIMEOUT_MILLISECONDS));
                    showInfoMessage("Service is stopped.");
                }
            }
            catch
            {
                showErrorMessage("Service cannot be stopped.");
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            restartService();
            resetForm();
        }

        private void restartService()
        {
            ServiceController service = new ServiceController(stopRestartListCB.GetItemText(stopRestartListCB.SelectedItem));
            try
            {
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMilliseconds(TIMEOUT_MILLISECONDS));
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMilliseconds(TIMEOUT_MILLISECONDS));
                showInfoMessage("Service is restarted.");
            }
            catch
            {
                showErrorMessage("Service cannot be restarted.");
            }
        }

        // Status Tab
        private void cancelButtonStatus_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void allServicesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedService = allServicesCB.GetItemText(allServicesCB.SelectedItem);
            setStatusText(ServiceController.GetServices().FirstOrDefault(service => service.ServiceName == selectedService));
        }

        private void setStatusText(ServiceController service)
        {
            statusTB.Text = getStatusMessage(service).Item1;
            statusTB.BackColor = getStatusMessage(service).Item2;
        }

        private Tuple<String, Color> getStatusMessage(ServiceController service)
        {
            if (service == null)
                return new Tuple<string, Color>("Service Is Not Installed!", Color.Black);

            switch (service.Status)
            {
                case ServiceControllerStatus.ContinuePending:
                    return new Tuple<string, Color>("Service Is In Continue Pending State!", Color.DarkViolet);
                case ServiceControllerStatus.Paused:
                    return new Tuple<string, Color>("Service Is Paused!", Color.Blue);
                case ServiceControllerStatus.PausePending:
                    return new Tuple<string, Color>("Service Is In Pause Pending State!", Color.DarkBlue);
                case ServiceControllerStatus.Running:
                    return new Tuple<string, Color>("Service Is Running!", Color.Green);
                case ServiceControllerStatus.StartPending:
                    return new Tuple<string, Color>("Service Is In StartPending State!", Color.DarkGreen);
                case ServiceControllerStatus.Stopped:
                    return new Tuple<string, Color>("Service Is Stopped!", Color.Red);
                case ServiceControllerStatus.StopPending:
                    return new Tuple<string, Color>("Service Is In Stop Pending State!", Color.DarkRed);
                default:
                    return new Tuple<string, Color>("Unknown Status!", Color.Gray);
            }
        }

        private void refreshServices(object sender, EventArgs e)
        {
            foreach (ServiceController service in ServiceController.GetServices())
            {
                service.Refresh();
            }
            resetForm();
        }

    }
}
