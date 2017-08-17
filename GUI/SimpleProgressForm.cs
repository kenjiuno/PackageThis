using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageThis {
    public partial class SimpleProgressForm : Form {
        public SimpleProgressForm() {
            InitializeComponent();
        }

        public static SimpleProgressForm Display(String progress) {
            var form = new SimpleProgressForm();
            form.label1.Text = progress;
            form.Show(Form.ActiveForm);
            form.Update();
            return form;
        }
    }
}
