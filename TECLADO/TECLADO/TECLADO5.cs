using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Management;

namespace TECLADO
{
    public partial class TECLADO5 : MaterialSkin.Controls.MaterialForm
    {
        public string ValidaTeclado;

        public TECLADO5()
        {
            InitializeComponent();
            DesabiltarTab();
            //TimeStart();
            //Se já houver arquivo texto não vai gerar outro
            GerarTxt();
            timerCheck.Start();
        }

        public void GerarTxt()
        {
            try
            {
                //Data e hora para registro:
                DateTime data = DateTime.Now;

                //Vai verificar se o arquivo existe, se não houver, vai adicionar.
                String path = @"C:\TESTES_AVELL_VIRTUO\logs_teclado\teclado.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao gerar log Teclado" + ex);
            }
        }

        public void TimeStart()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 30;

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();

                    //Condição para acionar as falhas, somente se o teclado não for aprovado e não gerar a variável pública
                    if (ValidaTeclado != "OK")
                    {
                        var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL_VIRTUO\logs_teclado", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
                        int valor = int.Parse(quantidadeLog);
                        if (valor == 1)
                        {
                            ENVIAREPARO formEnviaReparo = new ENVIAREPARO();
                            this.Hide();
                            formEnviaReparo.ShowDialog();
                        }
                        else
                        {
                            REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                            this.Hide();
                            formReprovaFalha.ShowDialog();
                        }
                    }
                }
            };
            relogio.Start();
        }

        public void DesabiltarTab()
        {
            //Desabilta o TAB Index dos Botões, senão não funciona
            btnEsc.TabStop = false;
            btnF1.TabStop = false;
            btnF2.TabStop = false;
            btnF3.TabStop = false;
            btnF4.TabStop = false;
            btnF5.TabStop = false;
            btnF6.TabStop = false;
            btnF7.TabStop = false;
            btnF8.TabStop = false;
            btnF9.TabStop = false;
            btnF10.TabStop = false;
            btnF11.TabStop = false;
            btnF12.TabStop = false;
            btnPause.TabStop = false;
            btnBreak.TabStop = false;
            btnPrint.TabStop = false;
            btnScrl.TabStop = false;
            btnDel.TabStop = false;
            btnApos.TabStop = false;
            btnExc.TabStop = false;
            btnArrob.TabStop = false;
            btnCerc.TabStop = false;
            btnSifr.TabStop = false;
            btnPercent.TabStop = false;
            btnTrema.TabStop = false;
            btnComer.TabStop = false;
            btnAster.TabStop = false;
            btnParD.TabStop = false;
            btnParEsc.TabStop = false;
            btnIfen.TabStop = false;
            btnIgual.TabStop = false;
            btnBackspace.TabStop = false;
            btnChavDir.TabStop = false;
            btnChavEsq.TabStop = false;
            btnAcent.TabStop = false;
            btnP.TabStop = false;
            btnO.TabStop = false;
            btnI.TabStop = false;
            btnU.TabStop = false;
            btnY.TabStop = false;
            btnT.TabStop = false;
            btnR.TabStop = false;
            btnE.TabStop = false;
            btnW.TabStop = false;
            btnQ.TabStop = false;
            btnTab.TabStop = false;
            btnEnter.TabStop = false;
            btnTio.TabStop = false;
            btnÇ.TabStop = false;
            btnL.TabStop = false;
            btnK.TabStop = false;
            btnJ.TabStop = false;
            btnH.TabStop = false;
            btnH.TabStop = false;
            btnG.TabStop = false;
            btnF.TabStop = false;
            btnD.TabStop = false;
            btnS.TabStop = false;
            btnA.TabStop = false;
            btnCapsl.TabStop = false;
            btnShift.TabStop = false;
            btnZ.TabStop = false;
            btnX.TabStop = false;
            btnC.TabStop = false;
            btnV.TabStop = false;
            btnB.TabStop = false;
            btnN.TabStop = false;
            btnM.TabStop = false;
            btnMenor.TabStop = false;
            btnMaior.TabStop = false;
            btnDoisP.TabStop = false;
            btnShift2.TabStop = false;
            btnCima.TabStop = false;
            btnBaixo.TabStop = false;
            btnEsq.TabStop = false;
            btnInt.TabStop = false;
            btnList.TabStop = false;
            btnAlt2.TabStop = false;
            btnSpace.TabStop = false;
            btnAlt.TabStop = false;
            btnWindow.TabStop = false;
            btnFN.TabStop = false;
            btnEnter2.TabStop = false;
            btnCtrl.TabStop = false;
            btnSub.TabStop = false;
            btnSom.TabStop = false;
            btnHome.TabStop = false;
            btnEnd.TabStop = false;
            btnNuml.TabStop = false;
            btnDir.TabStop = false;
            btn0.TabStop = false;
            btnDel2.TabStop = false;
            btn1.TabStop = false;
            btn2.TabStop = false;
            btn3.TabStop = false;
            btn4.TabStop = false;
            btn5.TabStop = false;
            btn6.TabStop = false;
            btn7.TabStop = false;
            btn8.TabStop = false;
            btn9.TabStop = false;
            btnDiv.TabStop = false;
            btnMult.TabStop = false;
        }

        private void TECLADO5_KeyDown(object sender, KeyEventArgs e)
        {
            int tecla = (e.KeyValue);
            //lblTecla.Text = Convert.ToString(e.KeyValue);

            try
            {
                //Persistir dados também dentro da plasta de logs
                String path2 = @"C:\TESTES_AVELL_VIRTUO\logs_teclado\teclado.txt";
                int texto = (e.KeyValue);
                StreamWriter s = File.AppendText(path2);
                s.WriteLine(texto);
                s.Close();
            }
            catch (Exception E)
            {
                //MessageBox.Show("Falha");
            }


            if (tecla == 27)
            {
                btnEsc.BackColor = Color.DarkGreen;
            }
            if (tecla == 112)
            {
                btnF1.BackColor = Color.DarkGreen;
            }
            if (tecla == 113)
            {
                btnF2.BackColor = Color.DarkGreen;
            }
            if (tecla == 114)
            {
                btnF3.BackColor = Color.DarkGreen;
            }
            if (tecla == 115)
            {
                btnF4.BackColor = Color.DarkGreen;
            }
            if (tecla == 116)
            {
                btnF5.BackColor = Color.DarkGreen;
            }
            if (tecla == 117)
            {
                btnF6.BackColor = Color.DarkGreen;
            }
            if (tecla == 118)
            {

                btnF7.BackColor = Color.DarkGreen;
            }
            if (tecla == 119)
            {
                btnF8.BackColor = Color.DarkGreen;
            }
            if (tecla == 120)
            {
                btnF9.BackColor = Color.DarkGreen;
            }
            if (tecla == 121)
            {
                btnF10.BackColor = Color.DarkGreen;
            }
            if (tecla == 122)
            {
                btnF11.BackColor = Color.DarkGreen;
            }
            if (tecla == 123)
            {
                btnF12.BackColor = Color.DarkGreen;
            }
            if (tecla == 45)
            {
                btnScrl.BackColor = Color.DarkGreen;
                btnPrint.BackColor = Color.DarkOliveGreen;//Tratativa Diferente
            }
            if (tecla == 33)
            {
                btnPause.BackColor = Color.DarkGreen;
            }

            if (tecla == 34)
            {
                btnBreak.BackColor = Color.DarkGreen;
            }
            if (tecla == 36)
            {
                btnHome.BackColor = Color.DarkGreen;
            }
            if (tecla == 46)
            {
                btnDel.BackColor = Color.DarkGreen;
            }
            if (tecla == 192)
            {
                btnApos.BackColor = Color.DarkGreen;
            }
            if (tecla == 49)
            {
                btnExc.BackColor = Color.DarkGreen;
            }
            if (tecla == 50)
            {
                btnArrob.BackColor = Color.DarkGreen;
            }
            if (tecla == 51)
            {
                btnCerc.BackColor = Color.DarkGreen;
            }
            if (tecla == 52)
            {
                btnSifr.BackColor = Color.DarkGreen;
            }
            if (tecla == 53)
            {
                btnPercent.BackColor = Color.DarkGreen;
            }
            if (tecla == 54)
            {
                btnTrema.BackColor = Color.DarkGreen;
            }
            if (tecla == 55)
            {
                btnComer.BackColor = Color.DarkGreen;
            }
            if (tecla == 56)
            {
                btnAster.BackColor = Color.DarkGreen;
            }
            if (tecla == 57)
            {
                btnParD.BackColor = Color.DarkGreen;
            }
            if (tecla == 48)
            {
                btnParEsc.BackColor = Color.DarkGreen;
            }
            if (tecla == 189)
            {
                btnIfen.BackColor = Color.DarkGreen;
            }
            if (tecla == 187)
            {
                btnIgual.BackColor = Color.DarkGreen;
            }
            if (tecla == 8)
            {
                btnBackspace.BackColor = Color.DarkGreen;
            }
            if (tecla == 9)
            {
                btnTab.BackColor = Color.DarkGreen;
            }
            if (tecla == 81)
            {
                btnQ.BackColor = Color.DarkGreen;
            }
            if (tecla == 87)
            {
                btnW.BackColor = Color.DarkGreen;
            }
            if (tecla == 69)
            {
                btnE.BackColor = Color.DarkGreen;
            }
            if (tecla == 82)
            {
                btnR.BackColor = Color.DarkGreen;
            }
            if (tecla == 84)
            {
                btnT.BackColor = Color.DarkGreen;
            }
            if (tecla == 89)
            {
                btnY.BackColor = Color.DarkGreen;
            }
            if (tecla == 85)
            {
                btnU.BackColor = Color.DarkGreen;
            }
            if (tecla == 73)
            {
                btnI.BackColor = Color.DarkGreen;
            }
            if (tecla == 79)
            {
                btnO.BackColor = Color.DarkGreen;
            }
            if (tecla == 80)
            {
                btnP.BackColor = Color.DarkGreen;
            }
            if (tecla == 219)
            {
                btnAcent.BackColor = Color.DarkGreen;
            }
            if (tecla == 221)
            {
                btnChavEsq.BackColor = Color.DarkGreen;
            }
            if (tecla == 220)
            {
                btnChavDir.BackColor = Color.DarkGreen;
            }
            if (tecla == 20)
            {
                btnCapsl.BackColor = Color.DarkGreen;
            }
            if (tecla == 65)
            {
                btnA.BackColor = Color.DarkGreen;
            }
            if (tecla == 83)
            {
                btnS.BackColor = Color.DarkGreen;
            }
            if (tecla == 68)
            {
                btnD.BackColor = Color.DarkGreen;
            }
            if (tecla == 70)
            {
                btnF.BackColor = Color.DarkGreen;
            }
            if (tecla == 71)
            {
                btnG.BackColor = Color.DarkGreen;
            }
            if (tecla == 72)
            {
                btnH.BackColor = Color.DarkGreen;
            }
            if (tecla == 74)
            {
                btnJ.BackColor = Color.DarkGreen;
            }
            if (tecla == 75)
            {
                btnK.BackColor = Color.DarkGreen;
            }
            if (tecla == 76)
            {
                btnL.BackColor = Color.DarkGreen;
            }
            if (tecla == 186)
            {
                btnÇ.BackColor = Color.DarkGreen;
            }
            if (tecla == 222)
            {
                btnTio.BackColor = Color.DarkGreen;
            }
            if (tecla == 13)
            {
                btnEnter.BackColor = Color.DarkGreen;
                btnEnter2.BackColor = Color.DarkOliveGreen;
            }
            if (tecla == 16)
            {
                btnShift.BackColor = Color.DarkGreen;
            }
            if (tecla == 90)
            {
                btnZ.BackColor = Color.DarkGreen;
            }
            if (tecla == 88)
            {
                btnX.BackColor = Color.DarkGreen;
            }
            if (tecla == 67)
            {
                btnC.BackColor = Color.DarkGreen;
            }
            if (tecla == 86)
            {
                btnV.BackColor = Color.DarkGreen;
            }
            if (tecla == 66)
            {
                btnB.BackColor = Color.DarkGreen;
            }
            if (tecla == 78)
            {
                btnN.BackColor = Color.DarkGreen;
            }
            if (tecla == 77)
            {
                btnM.BackColor = Color.DarkGreen;
            }
            if (tecla == 188)
            {
                btnMenor.BackColor = Color.DarkGreen;
            }
            if (tecla == 190)
            {
                btnMaior.BackColor = Color.DarkGreen;
            }
            if (tecla == 191)
            {
                btnDoisP.BackColor = Color.DarkGreen;
            }
            if (tecla == 16)
            {
                btnShift2.BackColor = Color.DarkOliveGreen;
            }
            if (tecla == 38)
            {
                btnCima.BackColor = Color.DarkGreen;
            }
            if (tecla == 17)
            {
                btnCtrl.BackColor = Color.DarkGreen;
            }
            if (tecla == 255)
            {
                btnFN.BackColor = Color.DarkGreen;
            }
            if (tecla == 91)
            {
                btnWindow.BackColor = Color.DarkGreen;
            }
            if (tecla == 18)
            {
                btnAlt.BackColor = Color.DarkGreen;
                btnAlt2.BackColor = Color.DarkOliveGreen;
            }
            if (tecla == 32)
            {
                btnSpace.BackColor = Color.DarkGreen;
            }
            if (tecla == 93)
            {
                btnList.BackColor = Color.DarkGreen;
            }
            if (tecla == 193)
            {
                btnInt.BackColor = Color.DarkGreen;
            }
            if (tecla == 37)
            {
                btnEsq.BackColor = Color.DarkGreen;
            }
            if (tecla == 40)
            {
                btnBaixo.BackColor = Color.DarkGreen;
            }
            if (tecla == 39)
            {
                btnDir.BackColor = Color.DarkGreen;
            }
            if (tecla == 109)
            {
                btnSub.BackColor = Color.DarkGreen;
            }
            if (tecla == 107)
            {
                btnSom.BackColor = Color.DarkGreen;
            }
            if (tecla == 35)
            {
                btnEnd.BackColor = Color.DarkGreen;
            }
            if (tecla == 144)
            {
                btnNuml.BackColor = Color.DarkOliveGreen;
            }
            if (tecla == 111)
            {
                btnDiv.BackColor = Color.DarkGreen;
            }
            if (tecla == 106)
            {
                btnMult.BackColor = Color.DarkGreen;
            }
            if (tecla == 103)
            {
                btn7.BackColor = Color.DarkGreen;
            }
            if (tecla == 104)
            {
                btn8.BackColor = Color.DarkGreen;
            }
            if (tecla == 105)
            {
                btn9.BackColor = Color.DarkGreen;
            }
            if (tecla == 100)
            {
                btn4.BackColor = Color.DarkGreen;
            }
            if (tecla == 101)
            {
                btn5.BackColor = Color.DarkGreen;
            }
            if (tecla == 102)
            {
                btn6.BackColor = Color.DarkGreen;
            }
            if (tecla == 97)
            {
                btn1.BackColor = Color.DarkGreen;
            }
            if (tecla == 98)
            {
                btn2.BackColor = Color.DarkGreen;
            }
            if (tecla == 99)
            {
                btn3.BackColor = Color.DarkGreen;
            }
            if (tecla == 96)
            {
                btn0.BackColor = Color.DarkGreen;
            }
            if (tecla == 110)
            {
                btnDel2.BackColor = Color.DarkGreen;
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                if (btnEsc.BackColor == Color.DarkGreen && btnF1.BackColor == Color.DarkGreen && btnF2.BackColor == Color.DarkGreen && btnF3.BackColor == Color.DarkGreen
                && btnF4.BackColor == Color.DarkGreen && btnF5.BackColor == Color.DarkGreen && btnF6.BackColor == Color.DarkGreen && btnF7.BackColor == Color.DarkGreen
                && btnF8.BackColor == Color.DarkGreen && btnF9.BackColor == Color.DarkGreen && btnF10.BackColor == Color.DarkGreen && btnF11.BackColor == Color.DarkGreen
                && btnF12.BackColor == Color.DarkGreen && btnScrl.BackColor == Color.DarkGreen && btnPrint.BackColor == Color.DarkOliveGreen
                && btnPause.BackColor == Color.DarkGreen && btnPause.BackColor == Color.DarkGreen && btnBreak.BackColor == Color.DarkGreen && btnHome.BackColor == Color.DarkGreen
                && btnDel.BackColor == Color.DarkGreen && btnApos.BackColor == Color.DarkGreen && btnExc.BackColor == Color.DarkGreen && btnArrob.BackColor == Color.DarkGreen
                && btnCerc.BackColor == Color.DarkGreen && btnSifr.BackColor == Color.DarkGreen && btnPercent.BackColor == Color.DarkGreen && btnTrema.BackColor == Color.DarkGreen
                && btnComer.BackColor == Color.DarkGreen && btnAster.BackColor == Color.DarkGreen && btnParD.BackColor == Color.DarkGreen && btnParEsc.BackColor == Color.DarkGreen
                && btnIfen.BackColor == Color.DarkGreen && btnIgual.BackColor == Color.DarkGreen && btnBackspace.BackColor == Color.DarkGreen && btnTab.BackColor == Color.DarkGreen
                && btnQ.BackColor == Color.DarkGreen && btnW.BackColor == Color.DarkGreen && btnE.BackColor == Color.DarkGreen && btnR.BackColor == Color.DarkGreen
                && btnT.BackColor == Color.DarkGreen && btnY.BackColor == Color.DarkGreen && btnU.BackColor == Color.DarkGreen && btnI.BackColor == Color.DarkGreen
                && btnO.BackColor == Color.DarkGreen && btnP.BackColor == Color.DarkGreen && btnAcent.BackColor == Color.DarkGreen && btnChavEsq.BackColor == Color.DarkGreen
                && btnChavDir.BackColor == Color.DarkGreen && btnCapsl.BackColor == Color.DarkGreen && btnA.BackColor == Color.DarkGreen && btnS.BackColor == Color.DarkGreen
                && btnD.BackColor == Color.DarkGreen && btnF.BackColor == Color.DarkGreen && btnG.BackColor == Color.DarkGreen && btnH.BackColor == Color.DarkGreen
                && btnJ.BackColor == Color.DarkGreen && btnK.BackColor == Color.DarkGreen && btnL.BackColor == Color.DarkGreen && btnÇ.BackColor == Color.DarkGreen
                && btnTio.BackColor == Color.DarkGreen && btnEnter.BackColor == Color.DarkGreen && btnEnter2.BackColor == Color.DarkOliveGreen && btnShift.BackColor == Color.DarkGreen
                && btnShift.BackColor == Color.DarkGreen && btnZ.BackColor == Color.DarkGreen && btnX.BackColor == Color.DarkGreen && btnC.BackColor == Color.DarkGreen
                && btnV.BackColor == Color.DarkGreen && btnB.BackColor == Color.DarkGreen && btnN.BackColor == Color.DarkGreen
                && btnM.BackColor == Color.DarkGreen && btnMenor.BackColor == Color.DarkGreen && btnMaior.BackColor == Color.DarkGreen && btnDoisP.BackColor == Color.DarkGreen
                && btnShift2.BackColor == Color.DarkOliveGreen && btnCima.BackColor == Color.DarkGreen && btnCtrl.BackColor == Color.DarkGreen && btnFN.BackColor == Color.DarkGreen
                && btnFN.BackColor == Color.DarkGreen && btnWindow.BackColor == Color.DarkGreen && btnAlt.BackColor == Color.DarkGreen && btnAlt2.BackColor == Color.DarkOliveGreen
                && btnSpace.BackColor == Color.DarkGreen && btnList.BackColor == Color.DarkGreen && btnInt.BackColor == Color.DarkGreen && btnEsq.BackColor == Color.DarkGreen
                && btnBaixo.BackColor == Color.DarkGreen && btnDir.BackColor == Color.DarkGreen && btnSub.BackColor == Color.DarkGreen && btnSom.BackColor == Color.DarkGreen
                && btnEnd.BackColor == Color.DarkGreen && btnNuml.BackColor == Color.DarkOliveGreen && btnDiv.BackColor == Color.DarkGreen && btnMult.BackColor == Color.DarkGreen
                && btn7.BackColor == Color.DarkGreen && btn8.BackColor == Color.DarkGreen && btn9.BackColor == Color.DarkGreen && btn4.BackColor == Color.DarkGreen
                && btn5.BackColor == Color.DarkGreen && btn6.BackColor == Color.DarkGreen && btn1.BackColor == Color.DarkGreen && btn2.BackColor == Color.DarkGreen
                && btn3.BackColor == Color.DarkGreen && btn0.BackColor == Color.DarkGreen && btnDel2.BackColor == Color.DarkGreen
                )
                {
                    ValidaTeclado = "OK";

                    timerCheck.Stop();
                    VALIDAOK formValidaOK = new VALIDAOK();
                    this.Hide();
                    formValidaOK.ShowDialog();
                }
            }
            catch (Exception E)
            {

            }
        }

        private void pictureBoxFalha_Click(object sender, EventArgs e)
        {
            //RelatorioReprovado();
            CriarLog_MySQLFalha();

            //Enviar para reparo
            ENVIAREPARO formEnviaReparo = new ENVIAREPARO();
            this.Hide();
            formEnviaReparo.ShowDialog();
        }

        public void CriarLog_MySQLFalha()
        {
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                //Dll: System.Management.dll - Para conseguir informações da BIOS
                string NomeArquivo = (string)obj["SerialNumber"];

                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                string Furmark = "C:\\TESTES_AVELL_VIRTUO\\MySqlData\\" + NomeArquivo + "\\Teclado_FALHA.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("TECLADO FALHA!: " + dataHoraMinutoOK);
                Arquivo.Close();
            }
        }

        private void btnF2_Click(object sender, EventArgs e)
        {

        }
    }
}
