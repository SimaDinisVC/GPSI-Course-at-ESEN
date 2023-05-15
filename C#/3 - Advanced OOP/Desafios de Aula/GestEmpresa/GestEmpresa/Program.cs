using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestEmpresa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // A partir do .NET Framework 4.8, há um novo nível de melhorias de acessibilidade (nível 2)
            // Caso seja aplicado a seleção completa na linha, alterando a respetiva propriedade da DataGridView,
            // quando se clica numa célula é ativada a seleção da célula no cabeçalho de coluna 
            // Para resolver o problema sem desativar o estilo de visualização
            // no cabeçalho de coluna, podemos desativar as melhorias de nível 2
            // Outra alternativa seria incluir novo código na App.config
            // Nota: se desativar um nível 2 tenho de desativar os posteriores níveis também
            // https://www.vbforums.com/showthread.php?889910-RESOLVED-DataGridView-FullRowSelect-selects-column-header-too
            // https://stackoverflow.com/questions/51513396/breaking-change-in-datagridview-between-net-4-0-and-net-4-7-2-header-selection
            AppContext.SetSwitch("Switch.UseLegacyAccessibilityFeatures.3", true);
            AppContext.SetSwitch("Switch.UseLegacyAccessibilityFeatures.2", true);
            AppContext.SetSwitch("Switch.UseLegacyAccessibilityFeatures", false);
            



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
