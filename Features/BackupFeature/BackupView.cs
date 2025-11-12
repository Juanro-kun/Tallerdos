using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_2_Gestor.Features.BackupFeature
{
    public partial class BackupView : UserControl
    {
        public BackupView()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bExaminar_Click(object sender, EventArgs e)
        {
            // 1. Define el nombre sugerido
            // Puedes obtener el nombre de la BD dinámicamente o usar un prefijo fijo.
            string nombreBD = "Taller2GestorBD"; // ¡Reemplaza por la forma de obtener tu BD!
            string fechaHora = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // Formato sugerido: NombreBD_Fecha_Hora.bak
            string nombreSugerido = $"{nombreBD}_{fechaHora}.bak";

            // 2. Establece las propiedades del SaveFileDialog
            saveFileDialog1.Filter = "Archivos de Backup (*.bak)|*.bak";
            saveFileDialog1.DefaultExt = "bak";

            saveFileDialog1.FileName = nombreSugerido;

            // 3. Mostrar el diálogo
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 4. Llenar los campos de texto de la vista (¡usando las propiedades del diálogo!)
                tbRuta.Text = Path.GetDirectoryName(saveFileDialog1.FileName); // Muestra solo la carpeta
                tbNombreArchivo.Text = Path.GetFileName(saveFileDialog1.FileName);         // Muestra solo el archivo sugerido
            }
        }

        private void bRealizarBackup_Click(object sender, EventArgs e)
        {
            // 1. OBTENER INFORMACIÓN Y VALIDAR

            // Obtener la cadena de conexión de tu App.config o donde la tengas guardada
            string connectionString = "Server=.\\SQLEXPRESS;Database=Tallerdosbase;Trusted_Connection=True;TrustServerCertificate=True;";

            // Construir la ruta completa del archivo de backup
            string carpetaDestino = tbRuta.Text.Trim();
            string nombreArchivo = tbNombreArchivo.Text.Trim();

            if (string.IsNullOrEmpty(carpetaDestino) || string.IsNullOrEmpty(nombreArchivo))
            {
                MessageBox.Show("Por favor, selecciona la ubicación y asegúrate de que el nombre del archivo esté completo.",
                                "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construye la ruta final del archivo .bak
            string rutaBackupCompleta = Path.Combine(carpetaDestino, nombreArchivo);

            // 2. CONFIGURAR PARÁMETROS DE SQL

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            string serverName = ".\\SQLEXPRESS";
            string databaseName = "Tallerdosbase";

            try
            {
                // Deshabilitar el botón para evitar clics múltiples durante el proceso
                bRealizarBackup.Enabled = false;
                // Opcional: Actualizar un Label de estado
                // lblEstado.Text = "Iniciando copia de seguridad..."; 

                // 3. CONEXIÓN Y CONFIGURACIÓN SMO
                ServerConnection connection = new ServerConnection(serverName);
                Server sqlServer = new Server(connection);

                Backup backup = new Backup
                {
                    Action = BackupActionType.Database,
                    Database = databaseName,
                    Initialize = true, // Sobrescribe si el archivo existe
                    BackupSetName = Path.GetFileNameWithoutExtension(nombreArchivo),
                    BackupSetDescription = $"Copia creada el {DateTime.Now:yyyy-MM-dd HH:mm:ss}"
                };

                // Agregar la ruta del archivo de destino
                backup.Devices.AddDevice(rutaBackupCompleta, DeviceType.File);

                // 5. EJECUTAR EL BACKUP
                backup.SqlBackup(sqlServer);

                // 6. FINALIZACIÓN EXITOSA
                MessageBox.Show($"Copia de seguridad finalizada con éxito en:\n{rutaBackupCompleta}",
                                "Backup Completo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // 7. MANEJO DE ERRORES
                // lblEstado.Text = "❌ Error en el Backup.";
                MessageBox.Show($"Error al realizar el backup:\n{ex.Message}\n\nVerifica los permisos de la carpeta.",
                                "Error de Backup",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurar que el botón se habilite de nuevo
                bRealizarBackup.Enabled = true;
            }
        }
    }
}

