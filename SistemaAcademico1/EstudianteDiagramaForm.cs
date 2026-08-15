using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class EstudianteDiagramaForm : Form
    {
        // Variable para controlar qué pregunta se muestra (1 a 5)
        private int preguntaActual = 1;

        // Variable para controlar qué tema de teoría está consultando el estudiante
        private string temaActual = "CONCEPTO";

        public EstudianteDiagramaForm()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Algoritmo");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        // Se ejecuta automáticamente al abrir la ventana
        private void EstudianteDiagramaForm_Load(object sender, EventArgs e)
        {
            CargarPregunta();
            CargarContenidoTema("CONCEPTO"); // Carga inicial por defecto
        }

        #region MÓDULO LECTURA DE TEORÍA Y EJEMPLOS DEL DOCENTE

        /// <summary>
        /// Busca y carga en pantalla el texto e imagen publicados por el profesor
        /// </summary>
        private void CargarContenidoTema(string nombreTema)
        {
            temaActual = nombreTema;

            // 1. OBTENER Y MOSTRAR LA TEORÍA
            string rutaTexto = $"teoria_{temaActual}.txt";

            // Si el archivo existe PERO está vacío, se saltará al else y mostrará la teoría por defecto
            if (File.Exists(rutaTexto) && !string.IsNullOrWhiteSpace(File.ReadAllText(rutaTexto)))
            {
                txtTeoriaEstudiante.Text = File.ReadAllText(rutaTexto);
            }
            else if (DatosCompartidosDiagFlu.Teorias.ContainsKey(temaActual) &&
                     !string.IsNullOrWhiteSpace(DatosCompartidosDiagFlu.Teorias[temaActual]))
            {
                txtTeoriaEstudiante.Text = DatosCompartidosDiagFlu.Teorias[temaActual];
            }
            else
            {
                txtTeoriaEstudiante.Text = ObtenerTeoriaEstandar(temaActual);
            }

            // 2. OBTENER Y MOSTRAR LA IMAGEN
            string rutaImagen = $"imagen_{temaActual}.png";

            if (picSimboloEstudiante.Image != null)
            {
                picSimboloEstudiante.Image.Dispose();
                picSimboloEstudiante.Image = null;
            }

            if (File.Exists(rutaImagen))
            {
                byte[] bytesImagen = File.ReadAllBytes(rutaImagen);
                using (MemoryStream ms = new MemoryStream(bytesImagen))
                {
                    picSimboloEstudiante.Image = Image.FromStream(ms);
                }
            }
            else if (DatosCompartidosDiagFlu.Imagenes.ContainsKey(temaActual))
            {
                picSimboloEstudiante.Image = DatosCompartidosDiagFlu.Imagenes[temaActual];
            }
            else
            {
                picSimboloEstudiante.Image = ObtenerImagenEstandar(temaActual);
            }

            // Añadir al final de CargarContenidoTema(string nombreTema):
        }

        /// <summary>
        /// Devuelve la teoría fija para que el estudiante SIEMPRE vea contenido al hacer clic
        /// </summary>
        private string ObtenerTeoriaEstandar(string tema)
        {
            switch (tema)
            {
                case "CONCEPTO":
                    return "CONCEPTO DE DIAGRAMA DE FLUJO\r\n" +
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

                case "INICIO_FIN":
                    return "🟢 SÍMBOLO: INICIO / FIN (Terminal)\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Óvalo o rectángulo redondeado.\r\n" +
                                       "FUNCIÓN: Define el punto exacto de arranque o la finalización de un diagra,ma de flujo.\r\n" +
                                       "REGLA: Todo diagrama debe iniciar con [INICIO] y finalizar con [FIN].";

                case "LINEA_FLUJO":
                    return "⬇️ SÍMBOLO: LÍNEA DE FLUJO\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Flecha direccional.\r\n" +
                                       "FUNCIÓN: Conecta los componentes y marca la secuencia u orden en que debe ejecutarse el algoritmo.";

                case "PROCESO":
                    return "💻 SÍMBOLO: PROCESO\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Rectángulo.\r\n" +
                                       "FUNCIÓN: Engloba cualquier operación que modifique datos, variables o valores (como cálculos matemáticos o asignaciones).\r\n" +
                                       "EJEMPLO: suma = a + b";

                case "ENTRADA_SALIDA":
                    return "📥 SÍMBOLO: ENTRADA / SALIDA (General)\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Romboide / Paralelogramo.\r\n" +
                                       "FUNCIÓN: Señala la recepción de información hacia el sistema o la entrega de resultados generales.\r\n" +
                                       "EJEMPLO: Leer numero1 / Leer nombreUsuario";

                case "DECISIÓN":
                    return "❓ SÍMBOLO: DECISIÓN (Condicional)\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Rombo.\r\n" +
                                       "FUNCIÓN: Evalúa una condición lógica para determinar el camino que seguirá el proceso, generalmente mediante opciones como Verdadero/Falso o Sí/No. Se utiliza en estructuras condicionales y repetitivas, como if, if-else y while. \r\n" +
                                       "EJEMPLO: ¿edad >= 18?";

                case "IMPRESORA":
                    return "📄 SÍMBOLO: IMPRESORA / DOCUMENTO\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Rectángulo con base ondulada.\r\n" +
                                       "FUNCIÓN: Simboliza la emisión o reporte de datos expresados en soporte físico o formato visual impreso." +
                                       "EJEMPLO: Imprimir reporteDeVentas \r\n";

                case "PANTALLA":
                    return "🖥️ SÍMBOLO: PANTALLA\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Símbolo con el borde derecho curvo.\r\n" +
                                       "FUNCIÓN: Muestra información directamente al usuario en formato visual digital. \r\n" +
                                       "EJEMPLO: Mostrar ¡Acceso concedido, bienvenido! .";

                case "ENTRADA":
                    return "✏️ SÍMBOLO: ENTRADA DE DATOS\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Trapecio o paralelogramo.\r\n" +
                                       "FUNCIÓN: Variante utilizada específicamente para representar la captura de datos.\r\n" +
                                       "EJEMPLO: Capturar formularioRegistro";

                case "TECLADO":
                    return "⌨️ SÍMBOLO: ENTRADA POR TECLADO\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Trapecio inclinado / Cuadro con parte superior en diagonal.\r\n" +
                                       "FUNCIÓN: Representa la introducción directa de datos por parte del usuario mediante periféricos.";

                case "CONECTOR_PAGINA":
                    return "⭕ SÍMBOLO: CONECTOR EN PÁGINA\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Círculo pequeño.\r\n" +
                                       "FUNCIÓN: Enlaza partes de un diagrama extenso que continúan en el mismo pliego o pantalla.";

                case "CONECTOR_FUERA":
                    return "🔻 SÍMBOLO: CONECTOR FUERA DE PÁGINA\r\n" +
                                       "--------------------------------------------------\r\n\r\n" +
                                       "FIGURA: Pentágono apuntando hacia abajo.\r\n" +
                                       "FUNCIÓN: Indica un salto o continuidad hacia otra sección ubicada en un plano o página distinta.";

                default:
                    return $"Información del tema {tema}.";
            }
        }
        private Image ObtenerImagenEstandar(string tema)
        {
            switch (tema)
            {
                case "CONCEPTO":
                    return Properties.Resources.img_concepto;
                case "INICIO_FIN":
                    return Properties.Resources.img_inicio_fin;
                case "LINEA_FLUJO":
                    return Properties.Resources.img_linea_flujo;
                case "PROCESO":
                    return Properties.Resources.img_proceso;
                case "ENTRADA_SALIDA":
                    return Properties.Resources.img_entrada_salida;
                case "DECISIÓN":
                    return Properties.Resources.img_decision;
                case "IMPRESORA":
                    return Properties.Resources.img_impresora;
                case "PANTALLA":
                    return Properties.Resources.img_pantalla;
                case "ENTRADA":
                    return Properties.Resources.img_entrada;
                case "TECLADO":
                    return Properties.Resources.img_teclado;
                case "CONECTOR_PAGINA":
                    return Properties.Resources.img_conector_circulo;
                case "CONECTOR_FUERA":
                    return Properties.Resources.img_conector_pagina;
                default:
                    return null;
            }
        }

        // --- EVENTOS DE NAVEGACIÓN ENTRE TEMAS (BOTONES LATERALES) ---

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("CONCEPTO");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("INICIO_FIN");
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("LINEA_FLUJO");
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("PROCESO");
        }

        private void btnEntredaSalida_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("ENTRADA_SALIDA");
        }

        private void btnDecision_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("DECISIÓN");
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("IMPRESORA");
        }

        private void btnPantalla_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("PANTALLA");
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("ENTRADA");
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("TECLADO");
        }

        private void btnConectorEnPagina_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("CONECTOR_PAGINA");
        }

        private void btnConectorFuera_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("CONECTOR_FUERA");
        }

        #endregion

        #region MÓDULO CUESTIONARIO (QUIZ)

        /// <summary>
        /// Actualiza los textos del quiz según el número de pregunta actual
        /// </summary>
        private void CargarPregunta()
        {
            lblContador.Text = $"{preguntaActual}/5";

            // Desmarca las selecciones previas
            SigcheckBox1.Checked = false;
            SigcheckBox2.Checked = false;
            SigcheckBox3.Checked = false;
            SigcheckBox4.Checked = false;

            // Cambia el contenido dinámicamente
            switch (preguntaActual)
            {
                case 1:
                    lblPregunta.Text = "Selecciona los símbolos que representan una decisión:";
                    SigcheckBox1.Text = "Rombo";
                    SigcheckBox2.Text = "Rectángulo";
                    SigcheckBox3.Text = "Óvalo";
                    SigcheckBox4.Text = "Paralelogramo";
                    break;

                case 2:
                    lblPregunta.Text = "¿Qué símbolo se utiliza para indicar el INICIO o FIN?";
                    SigcheckBox1.Text = "Cuadrado";
                    SigcheckBox2.Text = "Óvalo";
                    SigcheckBox3.Text = "Círculo pequeño";
                    SigcheckBox4.Text = "Triángulo";
                    break;

                case 3:
                    lblPregunta.Text = "¿Qué figura representa un PROCESO u operación?";
                    SigcheckBox1.Text = "Rombo";
                    SigcheckBox2.Text = "Paralelogramo";
                    SigcheckBox3.Text = "Rectángulo";
                    SigcheckBox4.Text = "Óvalo";
                    break;

                case 4:
                    lblPregunta.Text = "¿Cuál símbolo representa la ENTRADA / SALIDA de datos?";
                    SigcheckBox1.Text = "Paralelogramo";
                    SigcheckBox2.Text = "Rombo";
                    SigcheckBox3.Text = "Rectángulo";
                    SigcheckBox4.Text = "Flecha";
                    break;

                case 5:
                    lblPregunta.Text = "¿Para qué sirven las líneas de flujo en un diagrama?";
                    SigcheckBox1.Text = "Para decorar el diseño";
                    SigcheckBox2.Text = "Indicar el orden de ejecución";
                    SigcheckBox3.Text = "Mostrar errores de código";
                    SigcheckBox4.Text = "Guardar datos";
                    break;
            }
        }

        /// <summary>
        /// Evalúa la respuesta según la pregunta donde esté ubicado el estudiante
        /// </summary>
        private void btnComprobar_Click_1(object sender, EventArgs e)
        {
            bool esCorrecto = false;

            switch (preguntaActual)
            {
                case 1: // Respuesta correcta: Rombo (SigcheckBox1)
                    esCorrecto = SigcheckBox1.Checked && !SigcheckBox2.Checked && !SigcheckBox3.Checked && !SigcheckBox4.Checked;
                    break;
                case 2: // Respuesta correcta: Óvalo (SigcheckBox2)
                    esCorrecto = SigcheckBox2.Checked && !SigcheckBox1.Checked && !SigcheckBox3.Checked && !SigcheckBox4.Checked;
                    break;
                case 3: // Respuesta correcta: Rectángulo (SigcheckBox3)
                    esCorrecto = SigcheckBox3.Checked && !SigcheckBox1.Checked && !SigcheckBox2.Checked && !SigcheckBox4.Checked;
                    break;
                case 4: // Respuesta correcta: Paralelogramo (SigcheckBox1)
                    esCorrecto = SigcheckBox1.Checked && !SigcheckBox2.Checked && !SigcheckBox3.Checked && !SigcheckBox4.Checked;
                    break;
                case 5: // Respuesta correcta: Indicar orden de ejecución (SigcheckBox2)
                    esCorrecto = SigcheckBox2.Checked && !SigcheckBox1.Checked && !SigcheckBox3.Checked && !SigcheckBox4.Checked;
                    break;
            }

            if (esCorrecto)
            {
                MessageBox.Show("¡Respuesta Correcta! Excelente trabajo.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. Revisa el concepto e inténtalo de nuevo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Avanza a la siguiente pregunta del quiz
        /// </summary>
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (preguntaActual < 5)
            {
                preguntaActual++;
                CargarPregunta();
            }
            else
            {
                MessageBox.Show("¡Felicidades! Has completado las 5 preguntas del cuestionario.", "Módulo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (preguntaActual > 1)
            {
                preguntaActual--;
                CargarPregunta();
            }
            else
            {
                MessageBox.Show("Esta es la primera pregunta del cuestionario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region MÉTODOS SECUNDARIOS Y EVENTOS VACÍOS

        private void btnRegresar22_Click(object sender, EventArgs e)
        {
            MenuPrinciDiagram menuPrincipal = new MenuPrinciDiagram();
            menuPrincipal.Show();
            this.Close();
        }

        private void txtTeoriaEstudiante_TextChanged(object sender, EventArgs e) { }
        private void panelQuiz_Paint(object sender, PaintEventArgs e) { }
        private void lblPregunta_Click(object sender, EventArgs e) { }
        private void lblContador_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void panelTeoria_Paint(object sender, PaintEventArgs e) { }
        private void btnConcepto01_Click(object sender, EventArgs e) 
        {    
            CargarContenidoTema("CONCEPTO");
        }

        private void txtTeoriaEstudiante_TextChanged_1(object sender, EventArgs e) { }

        #endregion

        private void btnInicio_Fin01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("INICIO_FIN");
        }

        private void btnLinea01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("LINEA_FLUJO");
        }

        private void btnProceso01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("PROCESO");
        }

        private void btnEntrada_Salida01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("ENTRADA_SALIDA");
        }

        private void btnDesición01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("DECISIÓN");
        }

        private void btnImpresora01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("IMPRESORA");
        }

        private void btnPantalla01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("PANTALLA");
        }

        private void btnEntrada01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("ENTRADA");
        }

        private void btnTeclado01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("TECLADO");
        }

        private void btnConectorEnPagina01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("CONECTOR_PAGINA");
        }

        private void btnConectorFuera01_Click(object sender, EventArgs e)
        {
            CargarContenidoTema("CONECTOR_FUERA");
        }

        private void btnVerEjemplo_Click(object sender, EventArgs e)
        {
            string[] extensiones = { ".png", ".jpg", ".jpeg", ".pdf", ".docx", ".doc" };
            string rutaEjemploEncontrado = null;

            // Buscamos si existe alguno de los archivos para el tema actual
            foreach (string ext in extensiones)
            {
                string rutaCandidata = $"ejemplo_{temaActual}{ext}";
                if (File.Exists(rutaCandidata))
                {
                    rutaEjemploEncontrado = rutaCandidata;
                    break;
                }
            }

            // Si encuentra el archivo físico en el equipo, lo abre
            if (rutaEjemploEncontrado != null)
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = rutaEjemploEncontrado,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al intentar abrir el ejemplo: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"El docente aún no ha publicado un ejemplo práctico para el tema '{temaActual}'.",
                                "Sin Ejemplo Disponible",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }


    }
}
