/**************************************************************************
**			           		SAKARYA ÜNİVERSİTESİ                         **
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ           **
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                       **
**				          PROGRAMLAMAYA GİRİŞİ DERSİ                     **
**	                                                                     **
**				ÖDEV NUMARASI: 1                                         ** 
**				ÖĞRENCİ ADI : Yağmur KAFTAR                              **
**				ÖĞRENCİ NUMARASI :g211210092                             **
**				DERS GRUBU : 2C                                          **
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
