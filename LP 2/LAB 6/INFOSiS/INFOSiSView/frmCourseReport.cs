﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiSView
{
    public partial class frmCourseReport : Form
    {
        public frmCourseReport()
        {
            InitializeComponent();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            String openFile;
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFile = folderBrowser.SelectedPath;  //En openFile se guarda la ruta donde quiero guardar el reporte
            }
        }
    }
}