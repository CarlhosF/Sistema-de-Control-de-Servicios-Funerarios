using Exequie.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exequie.CLS
{
    class AppManager: ApplicationContext
    {
        private Boolean SplashScreen()
        {
            Boolean Resultado = true;
            Splash f = new Splash();//->using Exequie.GUI;
            f.ShowDialog();//se muestra el formulario Orion
            return Resultado;
        }

        private Boolean LoginScreen()
        {
            Boolean Resultado = true;
            Login f = new Login();
            f.ShowDialog();

            Resultado = f.Validado;

            return Resultado;
        }

        //constructor
        public AppManager()
        {
            if (SplashScreen())
            {
                if (LoginScreen())
                {
                    GUI.Interfaz f = new GUI.Interfaz();
                    f.ShowDialog();
                    Environment.Exit(0);
                }
            }
        }

    }
}
