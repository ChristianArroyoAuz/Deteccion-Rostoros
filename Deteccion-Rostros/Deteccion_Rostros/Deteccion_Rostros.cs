using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System;
//Librerias Ozeki 
using Ozeki.Media;
//Librerias Emgu
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;


namespace Deteccion_Rostros
{
    public partial class Deteccion_Rostros : Form
    {
        //Declaracion de todas las variables, vectors y haarcascades con COLOR
        List<Image<Bgr, byte>> trainingImages = new List<Image<Bgr, byte>>();
        List<string> NamePersons = new List<string>();
        OpenFileDialog open = new OpenFileDialog();
        List<string> labels = new List<string>();
        Image<Bgr, byte> result, TrainedFace;
        Image<Bgr, byte> gray = null;
        Image<Bgr, Byte> currentFrame;
        int ContTrain, NumLabels;
        HaarCascade rostros;
        Capture grabber;
        //Variables Ozeki
        private CameraURLBuilderWF _myCameraUrlBuilder;
        //Varibles para modificar el color
        Image<Bgr, Byte> My_Image;
        Image<Gray, Byte> gray_image;
        Image<Bgr, Byte> My_image_copy;
        bool gray_in_use = false;

        public Deteccion_Rostros()
        {
            InitializeComponent();
            rostros = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/Imagenes_Guardadas/Nombre_Imagenes.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Bgr, byte>(Application.StartupPath + "/Imagenes_Guardadas/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
            }
            catch
            {
            }
        }

        private void Deteccion_Rostros_Load(object sender, EventArgs e)
        {
            botonBuscar.Enabled = true;
            botonBuscar_Imagen.Enabled = true;
            botonGuardar_Imagen.Enabled = false;
            botonConectar.Enabled = false;
            botonDesconectar.Enabled = false;
            botonGuardar.Enabled = false;
            botonQuitar_Imagen.Enabled = false;
            botonCargar_Imagen.Enabled = false;
            Habilitar();
        }

        public void FrameGrabber(object sender, EventArgs e)
        {
            etiquetaNumero.Text = "0";
            NamePersons.Add("");
            //Captura el Frame actual del dispositivo
            currentFrame = grabber.QueryFrame().Resize(328, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convirtiendo a escala de grisis
            gray = currentFrame;
            //Detector de Rostrosr
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(rostros, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            //Accion para cad elemento detectado
            foreach (MCvAvgComp f in facesDetected[0])
            {
                result = currentFrame.Copy(f.rect).Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //Recuadro de rostro color amarillo
                currentFrame.Draw(f.rect, new Bgr(Color.Yellow), 2);
                NamePersons.Add("");
                //Setiando el numero de rostros
                etiquetaNumero.Text = facesDetected[0].Length.ToString();
            }
            //Mostrando los rostros reconocidos
            imageBox_Deteccion.Image = currentFrame;
            //Limpiando la lista de nombres
            NamePersons.Clear();
        }

        public void Habilitar()
        {
            checkBox_Guardar.Checked = true;
            checkBox_Imagen.Checked = true;
            checkBox_Rojo.Checked = false;
            checkBox_Verde.Checked = false;
            checkBox_Azul.Checked = false;
            groupBox_Nombres.Enabled = false;
            groupBox_Controles_Imagenes.Enabled = false;
            botonLimpiar.Enabled = false;
            etiquetaLimpiar.Enabled = false;
            etiqueta_Cuadro_Imagenes.Enabled = false;
            boton_Limpiar_Imagenes.Enabled = false;
        }

        private void Suppress(int spectrum)
        {
            for (int i = 0; i < My_Image.Height; i++)
            {
                for (int j = 0; j < My_Image.Width; j++)
                {
                    My_image_copy.Data[i, j, spectrum] = 0;
                }
            }
        }

        private void Un_Suppress(int spectrum)
        {
            for (int i = 0; i < My_Image.Height; i++)
            {
                for (int j = 0; j < My_Image.Width; j++)
                {
                    My_image_copy.Data[i, j, spectrum] = My_Image.Data[i, j, spectrum];
                }
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            //Limpiando Imagenes
            boton_Limpiar_Imagenes_Click(sender, e);
            //Buscando lista de camaras conectadas
            var result = _myCameraUrlBuilder.ShowDialog();
            if (result != DialogResult.OK)
            {
                //Habilitando boton buscar
                botonBuscar.Enabled = true;
                return;
            }
            else
            {
                //Seteando URL de la Camara en el textbox
                txt_Camara_URL.Text = _myCameraUrlBuilder.CameraURL;
                //Habilitando el boton conectar
                botonConectar.Enabled = true;
            }
        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            //Deshabilitando serie de botones
            botonBuscar.Enabled = false;
            botonConectar.Enabled = false;
            botonDesconectar.Enabled = true;
            botonGuardar.Enabled = true;
            botonLimpiar.Enabled = false;
            etiquetaLimpiar.Enabled = false;
            botonLimpiar_Nombre.Enabled = false;
            //Habilitando Nombre
            groupBox_Nombres.Enabled = true;
            //Iniciando Camara
            if (txt_Camara_URL.Text == "usb://DeviceId=0;Name=HD WebCam;")
            {
                //Iniciando la captura de Frames
                grabber = new Capture(0);
                grabber.QueryFrame();
                //Iniciando el Metodo FrameGraber
                Application.Idle += new EventHandler(FrameGrabber);
            }
            else
            {
                //Iniciando la captura de Frames
                grabber = new Capture(1);
                grabber.QueryFrame();
                //Iniciando el Metodo FrameGraber
                Application.Idle += new EventHandler(FrameGrabber);
            }
        }

        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            //Deshabilitando y Reseteando Todo
            txt_Camara_URL.Text = "";
            botonBuscar.Enabled = true;
            botonConectar.Enabled = false;
            botonDesconectar.Enabled = false;
            botonGuardar.Enabled = false;
            botonLimpiar.Enabled = false;
            etiquetaLimpiar.Enabled = false;
            Application.Idle -= new EventHandler(FrameGrabber);
            imageBox_Deteccion.Image = null;
            grabber.Dispose();
            etiquetaNumero.Text = "0";
            groupBox_Nombres.Enabled = false;
            txt_Nombre.Text = "";
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (etiquetaNumero.Text == "0")
                {
                    MessageBox.Show("No hay Rostros Detectados.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Cambiando el tamaño de la Imagen para guardar
                    TrainedFace = result.Resize(328, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    trainingImages.Add(TrainedFace);
                    labels.Add(txt_Nombre.Text);
                    //Mostrando la imagen en escala de colores
                    imageBox_Guardada.Image = TrainedFace;
                    My_Image = TrainedFace;
                    My_image_copy = My_Image;
                    checkBox_Rojo.Checked = true;
                    checkBox_Verde.Checked = true;
                    checkBox_Azul.Checked = true;
                    //Escribiendo el texto de la imagen
                    trainingImages.ToArray()[0].Save(Application.StartupPath + "/Imagenes_Guardadas/" + txt_Nombre.Text + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/Imagenes_Guardadas/Nombre_Imagenes.txt", labels.ToArray()[0] + "%");
                    txt_Nombre.Text = "";
                    etiqueta_Cuadro_Imagenes.Enabled = true;
                    boton_Limpiar_Imagenes.Enabled = true;
                    groupBox_Controles_Imagenes.Enabled = true;
                }
            }
        }

        private void botonBuscar_Imagen_Click(object sender, EventArgs e)
        {
            //Limpiando Imagenes
            boton_Limpiar_Imagenes_Click(sender, e);
            //Abriendo Cuadro de Dialogo
            if (open.ShowDialog() == DialogResult.OK)
            {
                txt_Imagen_URL.Text = open.FileName.ToString();
            }
        }

        private void checkBox_Imagen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Imagen.Checked == true)
            {
                imageBox_Deteccion.Enabled = false;
            }
            else
            {
                imageBox_Deteccion.Enabled = true;
            }
        }

        private void checkBox_Guardar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Guardar.Checked == true)
            {
                imageBox_Guardada.Enabled = false;
            }
            else
            {
                imageBox_Guardada.Enabled = true;
            }
        }

        private void txt_Camera_URL_TextChanged(object sender, EventArgs e)
        {
            if (txt_Camara_URL.Text != "")
            {
                groupBox_Buscar_Imagen.Enabled = false;
                botonLimpiar.Enabled = true;
                etiquetaLimpiar.Enabled = true;
            }
            else
            {
                groupBox_Buscar_Imagen.Enabled = true;
                botonConectar.Enabled = false;
                botonLimpiar.Enabled = false;
                etiquetaLimpiar.Enabled = false;
            }
        }

        private void txt_Imagen_URL_TextChanged(object sender, EventArgs e)
        {
            if (txt_Imagen_URL.Text != "")
            {
                groupBox_Buscar_Camara.Enabled = false;
                botonCargar_Imagen.Enabled = true;
                botonLimpiar.Enabled = true;
                etiquetaLimpiar.Enabled = true;
            }
            else
            {
                groupBox_Buscar_Camara.Enabled = true;
                botonLimpiar.Enabled = false;
                etiquetaLimpiar.Enabled = false;
                botonQuitar_Imagen.Enabled = false;
                botonGuardar_Imagen.Enabled = false;
                botonCargar_Imagen.Enabled = false;
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            txt_Camara_URL.Text = "";
            txt_Imagen_URL.Text = "";
        }

        private void botonCargar_Imagen_Click(object sender, EventArgs e)
        {
            //Habilitando Botones y Nombre
            botonQuitar_Imagen.Enabled = true;
            botonGuardar_Imagen.Enabled = true;
            botonCargar_Imagen.Enabled = false;
            botonBuscar_Imagen.Enabled = false;
            botonLimpiar.Enabled = false;
            etiquetaLimpiar.Enabled = false;
            groupBox_Nombres.Enabled = true;
            botonLimpiar_Nombre.Enabled = false;
            //Cargando la Imagen
            Image InputImg = Image.FromFile(open.FileName);
            currentFrame = new Image<Bgr, byte>(new Bitmap(InputImg));
            imageBox_Deteccion.Image = currentFrame;
            //Detectando numero de rostros
            var faces = currentFrame.DetectHaarCascade(rostros, 1.1, 2,
                                        HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                        new Size(200, 200))[0];
            etiquetaNumero.Text = faces.Length.ToString();
            //Dibujando un recuadro rojo alrededor de los rostros detectados
            foreach (var face in faces)
            {
                //Posicionando recuadro rojo
                currentFrame.Draw(face.rect, new Bgr(Color.Red), 2);
                imageBox_Deteccion.Image = currentFrame;
            }
        }

        private void botonQuitar_Imagen_Click(object sender, EventArgs e)
        {
            botonLimpiar.Enabled = false;
            etiquetaLimpiar.Enabled = false;
            txt_Imagen_URL.Text = "";
            imageBox_Deteccion.Image = null;
            etiquetaNumero.Text = "0";
            groupBox_Nombres.Enabled = false;
            botonBuscar_Imagen.Enabled = true;
            botonCargar_Imagen.Enabled = false;
            botonQuitar_Imagen.Enabled = false;
            botonGuardar_Imagen.Enabled = false;
            txt_Nombre.Text = "";
        }

        private void botonGuardar_Imagen_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (etiquetaNumero.Text == "0")
                {
                    MessageBox.Show("No Hay Rostros Detetados.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var faces = currentFrame.DetectHaarCascade(rostros, 1.1, 2,
                                        HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                        new Size(200, 200))[0];
                    foreach (var face in faces)
                    {
                        TrainedFace = currentFrame.Copy(face.rect).Resize(328, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        trainingImages.Add(TrainedFace);
                        labels.Add(txt_Nombre.Text);
                        //Mostrando la imagen en escala de colores
                        imageBox_Guardada.Image = TrainedFace;
                        My_Image = TrainedFace;
                        My_image_copy = My_Image;
                        checkBox_Rojo.Checked = true;
                        checkBox_Verde.Checked = true;
                        checkBox_Azul.Checked = true;
                        trainingImages.ToArray()[0].Save(Application.StartupPath + "/Imagenes_Guardadas/" + txt_Nombre.Text + ".bmp");
                        File.AppendAllText(Application.StartupPath + "/Imagenes_Guardadas/Nombre_Imagenes.txt", labels.ToArray()[0] + "%");
                    }
                    txt_Nombre.Text = "";
                    etiqueta_Cuadro_Imagenes.Enabled = true;
                    boton_Limpiar_Imagenes.Enabled = true;
                    groupBox_Controles_Imagenes.Enabled = true;
                }
            }
        }

        private void botonLimpiar_Nombre_Click(object sender, EventArgs e)
        {
            txt_Nombre.Text = "";
        }

        private void boton_Limpiar_Imagenes_Click(object sender, EventArgs e)
        {
            if (txt_Camara_URL.Text != "" && txt_Imagen_URL.Text == "")
            {
                imageBox_Deteccion.Image = null;
                imageBox_Guardada.Image = null;
                groupBox_Controles_Imagenes.Enabled = false;
                botonCambiar.Text = "Cambiar a Gris";
                checkBox_Azul.Checked = true;
                checkBox_Rojo.Checked = true;
                checkBox_Verde.Checked = true;
                etiqueta_Cuadro_Imagenes.Enabled = false;
                boton_Limpiar_Imagenes.Enabled = false;
                groupBox_Nombres.Enabled = false;
                txt_Camara_URL.Text = "";
                txt_Imagen_URL.Text = "";
                botonLimpiar.Enabled = false;
                etiquetaLimpiar.Enabled = false;
                etiquetaNumero.Text = "0";
                botonBuscar_Imagen.Enabled = true;
                botonCargar_Imagen.Enabled = false;
                botonQuitar_Imagen.Enabled = false;
                botonGuardar_Imagen.Enabled = false;
                botonDesconectar_Click(sender, e);
            }
            if (txt_Camara_URL.Text == "" && txt_Imagen_URL.Text != "")
            {
                imageBox_Deteccion.Image = null;
                imageBox_Guardada.Image = null;
                groupBox_Controles_Imagenes.Enabled = false;
                botonCambiar.Text = "Cambiar a Gris";
                checkBox_Azul.Checked = true;
                checkBox_Rojo.Checked = true;
                checkBox_Verde.Checked = true;
                etiqueta_Cuadro_Imagenes.Enabled = false;
                boton_Limpiar_Imagenes.Enabled = false;
                groupBox_Nombres.Enabled = false;
                txt_Camara_URL.Text = "";
                txt_Imagen_URL.Text = "";
                botonLimpiar.Enabled = false;
                etiquetaLimpiar.Enabled = false;
                etiquetaNumero.Text = "0";
                botonBuscar_Imagen.Enabled = true;
                botonCargar_Imagen.Enabled = false;
                botonQuitar_Imagen.Enabled = false;
                botonGuardar_Imagen.Enabled = false;
            }
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                botonLimpiar_Nombre.Enabled = false;
            }
            else
            {
                botonLimpiar_Nombre.Enabled = true;
            }
        }

        private void botonCambiar_Click(object sender, EventArgs e)
        {
            if (My_Image != null)
            {
                if (gray_in_use)
                {
                    gray_in_use = false;
                    imageBox_Guardada.Image = My_Image;
                    botonCambiar.Text = "Cambiar a Gris";
                    checkBox_Azul.Enabled = true;
                    checkBox_Rojo.Enabled = true;
                    checkBox_Verde.Enabled = true;
                    checkBox_Azul.Checked = true;
                    checkBox_Rojo.Checked = true;
                    checkBox_Verde.Checked = true;
                }
                else
                {
                    gray_image = My_Image.Convert<Gray, Byte>();
                    gray_in_use = true;
                    imageBox_Guardada.Image = gray_image;
                    botonCambiar.Text = "Cambiar a Color";
                    checkBox_Azul.Enabled = false;
                    checkBox_Rojo.Enabled = false;
                    checkBox_Verde.Enabled = false;
                }
            }
        }

        private void checkBox_Rojo_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Rojo.Checked)
            {
                Suppress(2);
            }
            else
            {
                Un_Suppress(2);
            }
            imageBox_Guardada.Image = My_image_copy;
        }

        private void checkBox_Verde_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Verde.Checked)
            {
                Suppress(1);
            }
            else
            {
                Un_Suppress(1);
            }
            imageBox_Guardada.Image = My_image_copy;
        }

        private void checkBox_Azul_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Azul.Checked)
            {
                Suppress(0);
            }
            else
            {
                Un_Suppress(0);
            }
            imageBox_Guardada.Image = My_image_copy;
        }
    }
}