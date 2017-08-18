using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageThis {
    // http://help.eclipse.org/luna/index.jsp?topic=%2Forg.eclipse.platform.doc.isv%2Freference%2Fapi%2Forg%2Feclipse%2Fcore%2Fruntime%2FIProgressMonitor.html
    public interface IProgressMonitor {
        void beginTask(String name, int totalWork);
        void done();
        void internalWorked(double work);
        bool isCanceled();
        void setCanceled(bool value);
        void setTaskName(String name);
        void subTask(String name);
        void worked(int work);
    }
}
