﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Okul_VT2Entities ctx = new Okul_VT2Entities();
            Notlar n1 = new Notlar();

            n1.Not1 = 16;
            n1.Not2 = 93;
            ctx.Not_Kaydet(n1.Not1, n1.Not2);
            ctx.SaveChanges();
        }
    }
}
