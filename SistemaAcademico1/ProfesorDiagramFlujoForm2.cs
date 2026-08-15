using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace SistemaAcademico1
{
    public partial class ProfesorDiagramFlujoForm2 : Form
    {
        private string rutaDiagramaCompartido = Path.Combine(Application.StartupPath, "diagrama_ejemplo.png");
        private string temaActual = "CONCEPTO";
        private string rutaArchivoSeleccionadoPorDocente = "";

        public ProfesorDiagramFlujoForm2()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Algoritmo");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
            CargarImagenDeFormaSegura();
        }

        private void CargarImagenDeFormaSegura()
        {
            try
            {
                if (File.Exists(rutaDiagramaCompartido))
                {
                    byte[] bytesImagen = File.ReadAllBytes(rutaDiagramaCompartido);

                    using (MemoryStream ms = new MemoryStream(bytesImagen))
                    {
                        if (picSimbolo.Image != null)
                        {
                            picSimbolo.Image.Dispose();
                        }

                        picSimbolo.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen de ejemplo previa: " + ex.Message,
                "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGuardarTeoria_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "teoria_diagramas_flujo.txt";
                string rutaCompleta = Path.Combine(Application.StartupPath, nombreArchivo);

                string contenidoTeoria = textTeoria.Text;

                File.WriteAllText(rutaCompleta, contenidoTeoria);

                MessageBox.Show(
                "¡La explicación ha sido guardada y publicada con éxito!\nAhora los estudiantes podrán verla en tiempo real en su panel.",
                "Publicación Exitosa ✓",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                "No se pudo guardar la teoría debido al siguiente error: " + ex.Message,
                "Error de Guardado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagen = new OpenFileDialog();
            buscarImagen.Filter = "Archivos de Imagen|*.png;*.jpg;*.jpeg;*.gif";
            buscarImagen.Title = "Seleccionar diagrama de flujo de ejemplo";

            if (buscarImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (picSimbolo.Image != null)
                    {
                        picSimbolo.Image.Dispose();
                        picSimbolo.Image = null;
                    }

                    File.Copy(buscarImagen.FileName, rutaDiagramaCompartido, true);

                    CargarImagenDeFormaSegura();

                    MessageBox.Show(
                    "¡El diagrama se ha cargado y sincronizado con éxito para los estudiantes!",
                    "Imagen Publicada ✓",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    "Error al procesar la imagen: " + ex.Message,
                    "Fallo de Sincronización",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                    CargarImagenDeFormaSegura();
                }
            }
        }

        private void CargarTeoria(string claveTema)
        {

            temaActual = claveTema;
            // Limpiamos la imagen anterior para evitar sobrecargas
            if (picSimbolo.Image != null)
            {
                picSimbolo.Image.Dispose();
                picSimbolo.Image = null;
            }

            if (DatosCompartidosDiagFlu.Teorias.ContainsKey(claveTema))
            {
                textTeoria.Text = DatosCompartidosDiagFlu.Teorias[claveTema];
                if (DatosCompartidosDiagFlu.Imagenes.ContainsKey(claveTema))
                {
                    picSimbolo.Image = DatosCompartidosDiagFlu.Imagenes[claveTema];
                }
                return;
            }

            switch (claveTema)
            {
                case "CONCEPTO":
                    textTeoria.Text =  "CONCEPTO DE DIAGRAMA DE FLUJO\r\n" +
                                       "==========================================\r\n\r\n" +
                                       "El diagrama de flujo o también llamado flujograma, es una representación gráfica " +
                                       "de un proceso o procedimiento que muestra de forma secuencial sus pasos, tareas o etapas. " +
                                       "Permitiendo organizar, evaluar y mejorar diferentes actividades y procesos de manera clara y ordenada. \r\n\r\n" +
                                       "Se utiliza en proyectos, planificaciones y procedimientos empresariales o institucionales, " +
                                       "siendo especialmente común en áreas como la programación y la informática.  \r\n\r\n" +
                                       "Los constan de dos elementos fundamentales: \r\n\r\n" +
                                       "Símbolos: Son figuras geométricas que representan cada paso o decisión." +
                                       "Por ejemplo, hay un símbolo específico para el inicio y otro para el fin del proceso. \r\n\r\n" +
                                       "Flechas o líneas: Son aquellas que conectan los símbolos de cada paso o decisión para indicar el recorrido del proceso.";


                    picSimbolo.Image = Properties.Resources.img_concepto;
                    break;

                case "INICIO_FIN":
                    textTeoria.Text =  "🟢 SÍMBOLO: INICIO / FIN (Terminal)\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Óvalo o rectángulo redondeado.\r\n" +
                                       "FUNCIÓN: Define el punto exacto de arranque o la finalización de un diagra,ma de flujo.\r\n" +
                                       "REGLA: Todo diagrama debe iniciar con [INICIO] y finalizar con [FIN].";

                    picSimbolo.Image = Properties.Resources.img_inicio_fin;
                    break;

                case "LINEA_FLUJO":
                    textTeoria.Text =  "⬇️ SÍMBOLO: LÍNEA DE FLUJO\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Flecha direccional.\r\n" +
                                       "FUNCIÓN: Conecta los componentes y marca la secuencia u orden en que debe ejecutarse el algoritmo.";

                    picSimbolo.Image = Properties.Resources.img_linea_flujo;
                    break;

                case "PROCESO":
                    textTeoria.Text =  "💻 SÍMBOLO: PROCESO\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Rectángulo.\r\n" +
                                       "FUNCIÓN: Engloba cualquier operación que modifique datos, variables o valores (como cálculos matemáticos o asignaciones).\r\n" +
                                       "EJEMPLO: suma = a + b";

                    picSimbolo.Image = Properties.Resources.img_proceso;
                    break;

                case "ENTRADA_SALIDA":
                    textTeoria.Text = "📥 SÍMBOLO: ENTRADA / SALIDA (General)\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Romboide / Paralelogramo.\r\n" +
                                       "FUNCIÓN: Señala la recepción de información hacia el sistema o la entrega de resultados generales.\r\n" +
                                       "EJEMPLO: Leer numero1 / Leer nombreUsuario";

                    picSimbolo.Image = Properties.Resources.img_entrada_salida;
                    break;

                case "DECISION":
                    textTeoria.Text =  "❓ SÍMBOLO: DECISIÓN (Condicional)\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Rombo.\r\n" +
                                       "FUNCIÓN: Evalúa una condición lógica para determinar el camino que seguirá el proceso, generalmente mediante opciones como Verdadero/Falso o Sí/No. Se utiliza en estructuras condicionales y repetitivas, como if, if-else y while. \r\n" +
                                       "EJEMPLO: ¿edad >= 18?";

                    picSimbolo.Image = Properties.Resources.img_decision;
                    break;

                case "IMPRESORA":
                    textTeoria.Text = "📄 SÍMBOLO: IMPRESORA / DOCUMENTO\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Rectángulo con base ondulada.\r\n" +
                                       "FUNCIÓN: Simboliza la emisión o reporte de datos expresados en soporte físico o formato visual impreso." +
                                       "EJEMPLO: Imprimir reporteDeVentas \r\n";

                    picSimbolo.Image = Properties.Resources.img_impresora;
                    break;

                case "PANTALLA":
                    textTeoria.Text = "🖥️ SÍMBOLO: PANTALLA\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Símbolo con el borde derecho curvo.\r\n" +
                                       "FUNCIÓN: Muestra información directamente al usuario en formato visual digital. \r\n" +
                                       "EJEMPLO: Mostrar ¡Acceso concedido, bienvenido! .";

                    picSimbolo.Image = Properties.Resources.img_pantalla;
                    break;

                case "ENTRADA":
                    textTeoria.Text = "✏️ SÍMBOLO: ENTRADA DE DATOS\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Trapecio o paralelogramo.\r\n" +
                                       "FUNCIÓN: Variante utilizada específicamente para representar la captura de datos.\r\n" +
                                       "EJEMPLO: Capturar formularioRegistro";

                    picSimbolo.Image = Properties.Resources.img_entrada;
                    break;

                case "TECLADO":
                    textTeoria.Text = "⌨️ SÍMBOLO: ENTRADA POR TECLADO\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Trapecio inclinado / Cuadro con parte superior en diagonal.\r\n" +
                                       "FUNCIÓN: Representa la introducción directa de datos por parte del usuario mediante periféricos.";

                    picSimbolo.Image = Properties.Resources.img_teclado;
                    break;

                case "CONECTOR_CIRCULO":
                    textTeoria.Text = "⭕ SÍMBOLO: CONECTOR EN PÁGINA\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Círculo pequeño.\r\n" +
                                       "FUNCIÓN: Enlaza partes de un diagrama extenso que continúan en el mismo pliego o pantalla.";

                    picSimbolo.Image = Properties.Resources.img_conector_circulo;
                    break;

                case "CONECTOR_PAGINA":
                    textTeoria.Text = "🔻 SÍMBOLO: CONECTOR FUERA DE PÁGINA\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Pentágono apuntando hacia abajo.\r\n" +
                                       "FUNCIÓN: Indica un salto o continuidad hacia otra sección ubicada en un plano o página distinta.";

                    picSimbolo.Image = Properties.Resources.img_conector_pagina;
                    break;
            }
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            CargarTeoria("INICIO_FIN");
        }

        private void btnConcepto_Click_1(object sender, EventArgs e)
        {
            CargarTeoria("CONCEPTO");
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            CargarTeoria("LINEA_FLUJO");
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            CargarTeoria("PROCESO");
        }

        private void btnEntredaSalida_Click(object sender, EventArgs e)
        {
            CargarTeoria("ENTRADA_SALIDA");
        }

        private void btnDecision_Click(object sender, EventArgs e)
        {
            CargarTeoria("DECISION");
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            CargarTeoria("IMPRESORA");
        }

        private void btnPantalla_Click(object sender, EventArgs e)
        {
            CargarTeoria("PANTALLA");
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            CargarTeoria("ENTRADA");
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            CargarTeoria("TECLADO");
        }

        private void btnConectorEnPagina_Click(object sender, EventArgs e)
        {
            CargarTeoria("CONECTOR_CIRCULO");
        }

        private void btnConectorFuera_Click(object sender, EventArgs e)
        {
            CargarTeoria("CONECTOR_PAGINA");
        }

        private void textTeoria_TextChanged(object sender, EventArgs e)
        {
            ///POR ERROR - DEJAR VACIO 
        }

        private void btnSubirImagen_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filtro para aceptar tanto imágenes como archivos PDF / Word
                openFileDialog.Filter = "Todos los archivos permitidos|*.png;*.jpg;*.jpeg;*.pdf;*.docx|Imágenes|*.png;*.jpg;*.jpeg|Documentos PDF|*.pdf|Documentos Word|*.docx";
                openFileDialog.Title = "Seleccionar ejemplo o recurso";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = openFileDialog.FileName;
                    string extension = System.IO.Path.GetExtension(rutaArchivo).ToLower();

                    // Si es una imagen, la muestra en el PictureBox
                    if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
                    {
                        picSimbolo.Image = Image.FromFile(rutaArchivo);
                        picSimbolo.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    // Si es PDF o Word, lo abre directamente en el lector de Windows
                    else if (extension == ".pdf" || extension == ".docx")
                    {
                        MessageBox.Show("Archivo cargado correctamente: " + System.IO.Path.GetFileName(rutaArchivo),
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
                    }
                }
            }
        }

        private void bGuardarTeoria_Click_1(object sender, EventArgs e)
        {

            try
            {
                // 1. Guardar en la memoria compartida
                DatosCompartidosDiagFlu.Teorias[temaActual] = textTeoria.Text;

                if (picSimbolo.Image != null)
                {
                    DatosCompartidosDiagFlu.Imagenes[temaActual] = picSimbolo.Image;
                }

                // 2. Guardar permanentemente en archivos de texto e imagen
                string rutaTexto = $"teoria_{temaActual}.txt";
                string rutaImagen = $"imagen_{temaActual}.png";

                File.WriteAllText(rutaTexto, textTeoria.Text);

                // 💡 CAMBIO AQUÍ: Guardado seguro de imagen sin bloquear archivos
                if (picSimbolo.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picSimbolo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        File.WriteAllBytes(rutaImagen, ms.ToArray());
                    }
                }

                // 3. 🆕 GUARDAR EL ARCHIVO DE EJEMPLO (PDF, Word, Imagen, etc.)
                if (!string.IsNullOrEmpty(rutaArchivoSeleccionadoPorDocente))
                {
                    // Obtiene la extensión (.pdf, .docx, .png, etc.)
                    string extension = Path.GetExtension(rutaArchivoSeleccionadoPorDocente);

                    // Genera el nombre dinámico: "ejemplo_PROCESO.pdf", "ejemplo_DECISIÓN.docx", etc.
                    string rutaDestinoEjemplo = $"ejemplo_{temaActual}{extension}";

                    // Borra cualquier archivo de ejemplo previo de este mismo tema
                    BorrarEjemplosAnteriores(temaActual);

                    // Copia el archivo físico seleccionado a la carpeta del programa
                    File.Copy(rutaArchivoSeleccionadoPorDocente, rutaDestinoEjemplo, overwrite: true);

                    // Limpiamos la variable para evitar duplicar el archivo en otro tema por error
                    rutaArchivoSeleccionadoPorDocente = "";
                }

                MessageBox.Show(
                    $"¡La explicación del tema '{temaActual}' se guardó con éxito en el sistema!",
                    "Publicación Exitosa ✓",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en datos compartidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarEjemplosAnteriores(string tema)
        {
            string[] extensiones = { ".png", ".jpg", ".jpeg", ".pdf", ".doc", ".docx" };
            foreach (string ext in extensiones)
            {
                string archivoViejo = $"ejemplo_{tema}{ext}";
                if (File.Exists(archivoViejo))
                {
                    File.Delete(archivoViejo);
                }
            }
        }

        private void btnRegresarMenu_Click_1(object sender, EventArgs e)
        {
            MenuPrinciDiagram menuPrincipal = new MenuPrinciDiagram();
            menuPrincipal.Show();
            this.Close();
        }
    }
}

