using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationProtect
{
    public partial class Form1 : Form
    {
        PasswordEngineer pe;

        public Form1()
        {
            InitializeComponent();
        }

        private void encryption_Click(object sender, EventArgs e)
        {

            //초기화
            pe.Init();

            string plainLine=plain.Text; //평문을 변수에 저장
            string keyword = keywordtext.Text; //키워드를 변수에 저장

            //값들 넘겨주고
            pe.SetPlain(plainLine.ToLower());
            pe.SetKeyword(keyword.ToLower());


            //암호화 메서드 실행
            pe.Encryption();
            cryptogram .Text= pe.GetCryptogram();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pe = new PasswordEngineer();
        }
    }
}
