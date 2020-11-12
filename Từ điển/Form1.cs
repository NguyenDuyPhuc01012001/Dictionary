using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace Từ_điển
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer voice = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }
    }
}
