using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageThis {
    public partial class SimpleProgressForm : Form, IProgressMonitor {
        private Action<IProgressMonitor> fork;
        private bool cancelStatus;
        SynchronizationContext mainThread;
        private double totalWork;
        private double worked;
        bool isBusy;

        public SimpleProgressForm() {
            InitializeComponent();
        }

        public static bool ShowDialogAndWait(Action<IProgressMonitor> fork) {
            var form = new SimpleProgressForm() {
                fork = fork
            };
            form.ShowDialog();
            return !form.cancelStatus;
        }

        void IProgressMonitor.beginTask(string name, int totalWork) {
            mainThread.Send(delegate {
                this.Text = name;
                this.totalWork = totalWork;
                worked = 0;
                progressBar1.Value = 0;
                label1.Text = "";
            }, null);
        }

        void IProgressMonitor.done() {
            mainThread.Send(delegate {
                this.Text = "Done";
                label1.Text = "";
                cancelStatus = false;
                isBusy = false;
                Close();
            }, null);
        }

        void IProgressMonitor.internalWorked(double work) {
            mainThread.Send(delegate {
                worked += work;
                progressBar1.Value = (int)((worked / totalWork) * 10000);
            }, null);
        }

        bool IProgressMonitor.isCanceled() {
            return cancelStatus;
        }

        void IProgressMonitor.setCanceled(bool value) {
            cancelStatus = value;
        }

        void IProgressMonitor.setTaskName(string name) {
            mainThread.Send(delegate {
                this.Text = name;
            }, null);
        }

        void IProgressMonitor.subTask(string name) {
            mainThread.Send(delegate {
                label1.Text = name;
            }, null);
        }

        void IProgressMonitor.worked(int work) {
            mainThread.Send(delegate {
                worked += work;
                progressBar1.Value = (int)((worked / totalWork) * 10000);
            }, null);
        }

        private void SimpleProgressForm_Load(object sender, EventArgs e) {
            cancelStatus = false;
            mainThread = SynchronizationContext.Current;
            totalWork = 0;
            worked = 0;
            isBusy = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            fork(this);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            isBusy = false;
            Close();
            if (e.Error != null) {
                throw new TargetInvocationException(e.Error);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {

        }

        private void SimpleProgressForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (isBusy) {
                e.Cancel = true;
                cancelStatus = true;
            }
        }
    }
}
