using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5Pool
{
    public partial class Pump : UserControl
    {
        private bool active = false;
        private bool mode = false;

        private Thread thread;
        public string NamePump
        {
            get => button1.Text;
            set => this.button1.Text = value;
        }

        public int powerPump
        {
            get;
            set;
        }

        public bool Active
        {
            get;
        }

        public void Activation(ProgressBar progressBar)
        {
            this.active = !this.active;
            this.button1.BackColor = active ? Color.Aquamarine : default;
            if (active)
            {
                if (this.mode)
                {
                    this.thread = new Thread(new ParameterizedThreadStart(pumping));
                    thread.Start(progressBar);
                }
                else
                {
                    this.thread = new Thread(new ParameterizedThreadStart(pumpingOut));
                    thread.Start(progressBar);
                }
            }
            else
            {
                thread.Abort();
            }
        }

        private void pumping(object progressBar)
        {
            try
            {
                ProgressBar progress = (ProgressBar)progressBar;
                while (progress.Value != progress.Maximum)
                {
                    Thread.Sleep(10000);
                    if ((progress.Maximum - progress.Value) >= this.powerPump)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            progress.Value += this.powerPump;
                            progress.Refresh();
                        }));
                    }
                    else
                    {
                        thread.Abort();
                    }
                }
            }
            catch (Exception e)
            {
                this.thread.Abort();
            }
        }

        private void pumpingOut(object progressBar)
        {
            try
            {
                ProgressBar progress = (ProgressBar) progressBar;
                while (progress.Value > progress.Minimum)
                {
                    Thread.Sleep(10000);
                    if ((progress.Value - this.powerPump) > 0)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            progress.Value -= this.powerPump;
                            progress.Refresh();
                        }));
                    }
                    else
                    {
                        this.Activation(progress);
                    }
                }

                this.Activation(progress);
            }
            catch (Exception e)
            {
                this.thread.Abort();
            }
        }

        public Pump()
        {
            InitializeComponent();
            this.button1.Text = NamePump;
        }

        public event EventHandler Click
        {
            add
            {
                this.button1.Click += value;
            }
            remove
            {
                this.button1.Click -= value;
            }
        }

        public bool Mode
        {
            get => mode;
            set => mode = value;
        }
    }
}
