using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        property prop = new property();
        private void Form1_Load(object sender, EventArgs e)
        {
           // prop.PublicProp = aynı projenın ıcerısınde veya farklı projenın ıcerısınde olunca da add referance yapıp publıc ı gozterebılıyoruz

              // prop.İnternalProp =  aynı projenın ıcerısındeyken gozukuyor 
           
            // prop.PrivateProp = kendı atandıgı sayfa dıısnda hıcbır yerde gozukmuyor
        }
    }
}
