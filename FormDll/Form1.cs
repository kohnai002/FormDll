using System;
using System.Runtime.InteropServices;

namespace FormDll
{
    public partial class Form1 : Form
    {
        [DllImport("CppDll.dll")]
        public static extern IntPtr seqGen_Create();

        [DllImport("CppDll.dll")]
        public static extern void seqGen_Delete(IntPtr seqPtr);

        [DllImport("CppDll.dll")]
        public static extern void seqGen_Load(IntPtr seqPtr, int num);

        [DllImport("CppDll.dll")]
        public static extern int seqGen_GetNum(IntPtr seqPtr);

        [DllImport("CppDll.dll")]
        public static extern int seqGen_countSeq(IntPtr seqPtr);

        [DllImport("CppDll.dll")]
        public static extern int seqGen_fibSeq(IntPtr seqPtr);

        [DllImport("CppDll.dll")]
        public static extern int seqGen_factSeq(IntPtr seqPtr);

        IntPtr seqPtr = seqGen_Create();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numIn = int.Parse(textBox1.Text);
            int numOut, count, fib, fact;

            seqGen_Load(seqPtr, numIn);

            numOut = seqGen_GetNum(seqPtr);
            seqNumLabel.Text = numOut.ToString();

            count = seqGen_countSeq(seqPtr);
            CountSeqLabel.Text = count.ToString();

            fib = seqGen_fibSeq(seqPtr);
            FibSeqLabel.Text = fib.ToString();

            fact = seqGen_factSeq(seqPtr);
            FactorialSeqLabel.Text = fact.ToString(); 
        }
    }
}
