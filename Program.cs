﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortniteAutoclicker
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.Priority = ThreadPriority.Lowest;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
