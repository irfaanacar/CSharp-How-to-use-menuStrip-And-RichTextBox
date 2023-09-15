using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenüStripVeRichTextBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void felektenBirGeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Felekten bir gece";
            richTextBox1.Text = "Filmde arkadaşlarının düğününden iki gün önce bekârlığa veda partisi vermek için Las Vegas'a giden dört tuhaf arkadaşın, sarhoş oldukları parti gecesinin sabahında odalarında bir kaplan, tavuklar ve dolapta ağlayan altı aylık bir bebek ile uyanmaları üzerine gelişen olağanüstü maceralar aktarılmaktadır.";
            
        }

        private void heartOfStoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Heart Of Stone";
            richTextBox1.Text = "Heart of Stone, zorlu bir görevle karşı karşıya olan bir ajanın hikayesini konu ediyor. Rachel Stone, kendini barışı korumaya adamış çok uluslu güçlü bir istihbarat teşkilatı olan The Charter'da ajan olarak çalışan bir kadındır. Rachel, zor bir görevle karşı karşıyadır.";
        }

        private void asteriksVeOburiksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Asteriks Ve Oburiks";
            richTextBox1.Text = "Asteriks ve Oburiks: Orta Krallık, imparatoriçeyi kurtarmak için zorlu bir maceraya atılan Asteriks, Oburiks ve imparatoriçenin kızı Ra-Na'nın hikayesini konu ediyor. Yıl M.Ö. 50. Kötü prens Deng Tsin Qin, Çin İmparatoriçesi'ni esir almıştır.";
        }

        private void testere7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Testere 7";
            richTextBox1.Text = "Jigsaw'un ölümcül yasası devam ederken Jigsaw'dan kurtulan bir grup insan kendilerine yardımcı olmak için destek ararlar ve ve bu destekçilerin en başında Bobby Dagen adında Jigsaw'dan kurtulmuş biri vardır. Bobby'nin gizli sırlarından yeni bir terör dalgası ortaya çıkacaktır.";
        }
    }
}
