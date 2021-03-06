﻿using Market.BLL.HazırVeri;
using System;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class MarketOtomasyon : Form
    {
        public MarketOtomasyon()
        {
            InitializeComponent();
        }

        private AzalanUrunler azalanUrunlerForm;
        private SatisForm satisForm;
        private MalKabul MalKabulForm;
        private CRUD CrudIslemleriForm;
        private Raporlar raporlarForm;
        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (satisForm == null || satisForm.IsDisposed)
            {
                satisForm = new SatisForm();
            }
            satisForm.MdiParent = this;
            satisForm.Show();
            satisForm.WindowState = FormWindowState.Maximized;
        }

        private void malGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MalKabulForm == null || MalKabulForm.IsDisposed)
            {
                MalKabulForm = new MalKabul();
            }
            MalKabulForm.MdiParent = this;
            MalKabulForm.Show();
            MalKabulForm.WindowState = FormWindowState.Maximized;
        }



        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CrudIslemleriForm == null || CrudIslemleriForm.IsDisposed)
            {
                CrudIslemleriForm = new CRUD();
            }
            CrudIslemleriForm.MdiParent = this;
            CrudIslemleriForm.Show();
            CrudIslemleriForm.WindowState = FormWindowState.Maximized;
        }

        private void azalanUrunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (azalanUrunlerForm == null || azalanUrunlerForm.IsDisposed)
            {
                azalanUrunlerForm = new AzalanUrunler();
            }
            azalanUrunlerForm.MdiParent = this;
            azalanUrunlerForm.Show();
            azalanUrunlerForm.WindowState = FormWindowState.Maximized;
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (raporlarForm == null || raporlarForm.IsDisposed)
            {
                raporlarForm = new Raporlar();
            }
            raporlarForm.MdiParent = this;
            raporlarForm.Show();
            raporlarForm.WindowState = FormWindowState.Maximized;
        }

        private void MarketOtomasyon_Load(object sender, EventArgs e)
        {
            new HazirVeri().VeriUret();
        }
    }
}
