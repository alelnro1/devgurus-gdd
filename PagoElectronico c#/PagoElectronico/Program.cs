﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PagoElectronico
{
    static class Program
    {
        public static String Cliente_id_seleccionado;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
          //  Application.Run(new PagoElectronico.ABM_Cliente.MenuABMClientes(new MenuPrincipal()));
     //       Application.Run(new PagoElectronico.ABM_Cuenta.AltaCuentas());
          
        }
    }
}

