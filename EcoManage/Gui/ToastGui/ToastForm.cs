﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoManage.Gui.ToastGui
{
    public partial class ToastForm : Form
    {
        private static ToastForm? toastForm;
        public static string Title;
        public static string Description;
        //public static bool TimerState;

        public ToastForm()
        {
            InitializeComponent();
            
        }
        public static ToastForm Instance(string title, string description)
        {
            Title = title;
            Description = description;
            //TimerState = true;
            return toastForm ?? (toastForm = new ToastForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerToast_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timerToast.Enabled = false;
        }
        private void ToastForm_Activated(object sender, EventArgs e)
        {
            labelTitle.Text = Title;
            labelDescription.Text = Description;
            
            timerToast.Interval = Properties.Settings.Default.ToastDuration;
            timerToast.Enabled = true;
        }
    }
}
