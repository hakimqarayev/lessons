﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{

    /*
     Homework 1:
     Ev tapşırığı olaraq FormControls formunu davam etdirməyinizi istəyirəm. Əlavə Et button'una klik edəndə tələbə məlumatlarını virtual database'ə əlavə edin
     və bir dənə əlavə button atın form'a hansı ki, o buttona basanda yeni açılan bir View'da əlavə olunan insanların məlumatları olacaq. Həmin yeni açılan
     məlumatların göstərildiyi siyahı olan pəncərə bağlanmadığı müddətcə əlavə etmə səhifəsində heçnəyə klik edilə bilməsin. İstəsəz mənim yazdığımı davam
     etdirin istəsəz də yeni bir proyekt açıb sıfırdan özünüz yazın.
     */ 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormControls());
        }
    }
}
