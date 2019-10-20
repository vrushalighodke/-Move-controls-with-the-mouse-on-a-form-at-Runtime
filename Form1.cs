using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveContols
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            // Move your controls
            MoveContols.helperClassforControlMover.Init(this.button1);
			MoveContols.helperClassforControlMover.Init(this.groupBox1);
            MoveContols.helperClassforControlMover.Init(this.label1);
            }
        }
    }
