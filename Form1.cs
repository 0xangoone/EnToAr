using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnToAr
{
    public partial class EnToAr : Form
    {
        Trans data = new Trans();
        public EnToAr()
        {
            InitializeComponent();
            string keys = "qwertyuiop[]asdfghjkl;'zxcvbnm,./";
            string values = "ضصثقفغعهخحجدشسيبلاتنمكطئءؤرلاىةوزظ";
            for(int i = 0; i < keys.Length; i++)
            {
                data.add(keys[i], values[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (toar.Checked){
                foreach (char c in input.Text) {
                    result.Text += data.getValueFromKey(c);
                }
            }else if(toen.Checked){
                foreach (char c in input.Text)
                {
                    result.Text += data.getKeyFromValue(c);
                }
            }   
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "result: ";
        }
    }
}
