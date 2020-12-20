using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BackUp.Winform
{
    public partial class Fm_About : Form
    {
        public Fm_About()
        {
            InitializeComponent();
        }

        private void Fm_About_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Models.Assemblys.AssemblyTitle;
            lblVersion.Text = Models.Assemblys.AssemblyVersion;
            lblAssemblyCopyright.Text = Models.Assemblys.AssemblyCopyright;
            lblCompany.Text = Models.Assemblys.AssemblyCompany;
            lblProduct.Text = Models.Assemblys.AssemblyProduct;
            lblAssemblyDescription.Text = Models.Assemblys.AssemblyDescription;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llabUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //调用系统默认的浏览器
            System.Diagnostics.Process.Start(llabUrl.Text);
        }
    }
}
