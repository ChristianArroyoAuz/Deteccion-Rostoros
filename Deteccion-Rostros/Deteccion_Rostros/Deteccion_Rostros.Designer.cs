namespace Deteccion_Rostros
{
    partial class Deteccion_Rostros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_Buscar_Camara = new System.Windows.Forms.GroupBox();
            this.botonConectar = new System.Windows.Forms.Button();
            this.botonDesconectar = new System.Windows.Forms.Button();
            this.txt_Camara_URL = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.etiquetaCamara = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.etiquetaNumero = new System.Windows.Forms.Label();
            this.etiquetaRostros = new System.Windows.Forms.Label();
            this.imageBox_Guardada = new Emgu.CV.UI.ImageBox();
            this.imageBox_Deteccion = new Emgu.CV.UI.ImageBox();
            this.botonBuscar_Imagen = new System.Windows.Forms.Button();
            this.groupBox_Buscar_Imagen = new System.Windows.Forms.GroupBox();
            this.botonCargar_Imagen = new System.Windows.Forms.Button();
            this.botonQuitar_Imagen = new System.Windows.Forms.Button();
            this.botonGuardar_Imagen = new System.Windows.Forms.Button();
            this.txt_Imagen_URL = new System.Windows.Forms.TextBox();
            this.etiquetaImagen = new System.Windows.Forms.Label();
            this.groupBox_Controles = new System.Windows.Forms.GroupBox();
            this.boton_Limpiar_Imagenes = new System.Windows.Forms.Button();
            this.etiqueta_Cuadro_Imagenes = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.etiquetaLimpiar = new System.Windows.Forms.Label();
            this.checkBox_Guardar = new System.Windows.Forms.CheckBox();
            this.checkBox_Imagen = new System.Windows.Forms.CheckBox();
            this.etiquetaHabilitar = new System.Windows.Forms.Label();
            this.groupBox_Nombres = new System.Windows.Forms.GroupBox();
            this.botonLimpiar_Nombre = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.groupBox_Controles_Imagenes = new System.Windows.Forms.GroupBox();
            this.checkBox_Azul = new System.Windows.Forms.CheckBox();
            this.checkBox_Verde = new System.Windows.Forms.CheckBox();
            this.checkBox_Rojo = new System.Windows.Forms.CheckBox();
            this.etiquetaColores_RGB = new System.Windows.Forms.Label();
            this.botonCambiar = new System.Windows.Forms.Button();
            this.etiqueta_Gris_Color = new System.Windows.Forms.Label();
            this.groupBox_Buscar_Camara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Guardada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Deteccion)).BeginInit();
            this.groupBox_Buscar_Imagen.SuspendLayout();
            this.groupBox_Controles.SuspendLayout();
            this.groupBox_Nombres.SuspendLayout();
            this.groupBox_Controles_Imagenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Buscar_Camara
            // 
            this.groupBox_Buscar_Camara.Controls.Add(this.botonConectar);
            this.groupBox_Buscar_Camara.Controls.Add(this.botonDesconectar);
            this.groupBox_Buscar_Camara.Controls.Add(this.txt_Camara_URL);
            this.groupBox_Buscar_Camara.Controls.Add(this.botonGuardar);
            this.groupBox_Buscar_Camara.Controls.Add(this.etiquetaCamara);
            this.groupBox_Buscar_Camara.Controls.Add(this.botonBuscar);
            this.groupBox_Buscar_Camara.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Buscar_Camara.Name = "groupBox_Buscar_Camara";
            this.groupBox_Buscar_Camara.Size = new System.Drawing.Size(328, 69);
            this.groupBox_Buscar_Camara.TabIndex = 0;
            this.groupBox_Buscar_Camara.TabStop = false;
            this.groupBox_Buscar_Camara.Text = "Buscar Camara";
            // 
            // botonConectar
            // 
            this.botonConectar.Enabled = false;
            this.botonConectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.botonConectar.ForeColor = System.Drawing.Color.Black;
            this.botonConectar.Location = new System.Drawing.Point(61, 39);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(81, 23);
            this.botonConectar.TabIndex = 2;
            this.botonConectar.Text = "Conectar";
            this.botonConectar.UseVisualStyleBackColor = true;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
            // 
            // botonDesconectar
            // 
            this.botonDesconectar.Enabled = false;
            this.botonDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonDesconectar.Location = new System.Drawing.Point(148, 39);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(79, 23);
            this.botonDesconectar.TabIndex = 3;
            this.botonDesconectar.Text = "Desconectar";
            this.botonDesconectar.UseVisualStyleBackColor = true;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // txt_Camara_URL
            // 
            this.txt_Camara_URL.Location = new System.Drawing.Point(61, 14);
            this.txt_Camara_URL.Name = "txt_Camara_URL";
            this.txt_Camara_URL.ReadOnly = true;
            this.txt_Camara_URL.Size = new System.Drawing.Size(166, 20);
            this.txt_Camara_URL.TabIndex = 0;
            this.txt_Camara_URL.TextChanged += new System.EventHandler(this.txt_Camera_URL_TextChanged);
            // 
            // botonGuardar
            // 
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonGuardar.Location = new System.Drawing.Point(233, 39);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(87, 23);
            this.botonGuardar.TabIndex = 4;
            this.botonGuardar.Text = "Guardar Imagen";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // etiquetaCamara
            // 
            this.etiquetaCamara.AutoSize = true;
            this.etiquetaCamara.Location = new System.Drawing.Point(6, 16);
            this.etiquetaCamara.Name = "etiquetaCamara";
            this.etiquetaCamara.Size = new System.Drawing.Size(49, 13);
            this.etiquetaCamara.TabIndex = 5;
            this.etiquetaCamara.Text = "Camera: ";
            // 
            // botonBuscar
            // 
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonBuscar.Location = new System.Drawing.Point(233, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(87, 23);
            this.botonBuscar.TabIndex = 1;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // etiquetaNumero
            // 
            this.etiquetaNumero.AutoSize = true;
            this.etiquetaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaNumero.ForeColor = System.Drawing.Color.Red;
            this.etiquetaNumero.Location = new System.Drawing.Point(223, 507);
            this.etiquetaNumero.Name = "etiquetaNumero";
            this.etiquetaNumero.Size = new System.Drawing.Size(16, 16);
            this.etiquetaNumero.TabIndex = 4;
            this.etiquetaNumero.Text = "0";
            // 
            // etiquetaRostros
            // 
            this.etiquetaRostros.AutoSize = true;
            this.etiquetaRostros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaRostros.Location = new System.Drawing.Point(12, 507);
            this.etiquetaRostros.Name = "etiquetaRostros";
            this.etiquetaRostros.Size = new System.Drawing.Size(211, 15);
            this.etiquetaRostros.TabIndex = 3;
            this.etiquetaRostros.Text = "Numero de Rostros Detectados:";
            // 
            // imageBox_Guardada
            // 
            this.imageBox_Guardada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_Guardada.Location = new System.Drawing.Point(346, 264);
            this.imageBox_Guardada.Name = "imageBox_Guardada";
            this.imageBox_Guardada.Size = new System.Drawing.Size(328, 240);
            this.imageBox_Guardada.TabIndex = 5;
            this.imageBox_Guardada.TabStop = false;
            // 
            // imageBox_Deteccion
            // 
            this.imageBox_Deteccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_Deteccion.Location = new System.Drawing.Point(12, 264);
            this.imageBox_Deteccion.Name = "imageBox_Deteccion";
            this.imageBox_Deteccion.Size = new System.Drawing.Size(328, 240);
            this.imageBox_Deteccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox_Deteccion.TabIndex = 24;
            this.imageBox_Deteccion.TabStop = false;
            // 
            // botonBuscar_Imagen
            // 
            this.botonBuscar_Imagen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonBuscar_Imagen.Location = new System.Drawing.Point(233, 12);
            this.botonBuscar_Imagen.Name = "botonBuscar_Imagen";
            this.botonBuscar_Imagen.Size = new System.Drawing.Size(87, 23);
            this.botonBuscar_Imagen.TabIndex = 1;
            this.botonBuscar_Imagen.Text = "Buscar";
            this.botonBuscar_Imagen.UseVisualStyleBackColor = true;
            this.botonBuscar_Imagen.Click += new System.EventHandler(this.botonBuscar_Imagen_Click);
            // 
            // groupBox_Buscar_Imagen
            // 
            this.groupBox_Buscar_Imagen.Controls.Add(this.botonCargar_Imagen);
            this.groupBox_Buscar_Imagen.Controls.Add(this.botonQuitar_Imagen);
            this.groupBox_Buscar_Imagen.Controls.Add(this.botonGuardar_Imagen);
            this.groupBox_Buscar_Imagen.Controls.Add(this.txt_Imagen_URL);
            this.groupBox_Buscar_Imagen.Controls.Add(this.botonBuscar_Imagen);
            this.groupBox_Buscar_Imagen.Controls.Add(this.etiquetaImagen);
            this.groupBox_Buscar_Imagen.Location = new System.Drawing.Point(346, 12);
            this.groupBox_Buscar_Imagen.Name = "groupBox_Buscar_Imagen";
            this.groupBox_Buscar_Imagen.Size = new System.Drawing.Size(328, 69);
            this.groupBox_Buscar_Imagen.TabIndex = 1;
            this.groupBox_Buscar_Imagen.TabStop = false;
            this.groupBox_Buscar_Imagen.Text = "Buscar Imagen";
            // 
            // botonCargar_Imagen
            // 
            this.botonCargar_Imagen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonCargar_Imagen.Location = new System.Drawing.Point(61, 39);
            this.botonCargar_Imagen.Name = "botonCargar_Imagen";
            this.botonCargar_Imagen.Size = new System.Drawing.Size(81, 23);
            this.botonCargar_Imagen.TabIndex = 5;
            this.botonCargar_Imagen.Text = "Cargar Imagen";
            this.botonCargar_Imagen.UseVisualStyleBackColor = true;
            this.botonCargar_Imagen.Click += new System.EventHandler(this.botonCargar_Imagen_Click);
            // 
            // botonQuitar_Imagen
            // 
            this.botonQuitar_Imagen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonQuitar_Imagen.Location = new System.Drawing.Point(148, 39);
            this.botonQuitar_Imagen.Name = "botonQuitar_Imagen";
            this.botonQuitar_Imagen.Size = new System.Drawing.Size(79, 23);
            this.botonQuitar_Imagen.TabIndex = 2;
            this.botonQuitar_Imagen.Text = "Quitar Imagen";
            this.botonQuitar_Imagen.UseVisualStyleBackColor = true;
            this.botonQuitar_Imagen.Click += new System.EventHandler(this.botonQuitar_Imagen_Click);
            // 
            // botonGuardar_Imagen
            // 
            this.botonGuardar_Imagen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonGuardar_Imagen.Location = new System.Drawing.Point(233, 39);
            this.botonGuardar_Imagen.Name = "botonGuardar_Imagen";
            this.botonGuardar_Imagen.Size = new System.Drawing.Size(87, 23);
            this.botonGuardar_Imagen.TabIndex = 3;
            this.botonGuardar_Imagen.Text = "Guardar Imagen";
            this.botonGuardar_Imagen.UseVisualStyleBackColor = true;
            this.botonGuardar_Imagen.Click += new System.EventHandler(this.botonGuardar_Imagen_Click);
            // 
            // txt_Imagen_URL
            // 
            this.txt_Imagen_URL.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Imagen_URL.Location = new System.Drawing.Point(61, 14);
            this.txt_Imagen_URL.Name = "txt_Imagen_URL";
            this.txt_Imagen_URL.ReadOnly = true;
            this.txt_Imagen_URL.Size = new System.Drawing.Size(166, 20);
            this.txt_Imagen_URL.TabIndex = 0;
            this.txt_Imagen_URL.TextChanged += new System.EventHandler(this.txt_Imagen_URL_TextChanged);
            // 
            // etiquetaImagen
            // 
            this.etiquetaImagen.AutoSize = true;
            this.etiquetaImagen.Location = new System.Drawing.Point(6, 16);
            this.etiquetaImagen.Name = "etiquetaImagen";
            this.etiquetaImagen.Size = new System.Drawing.Size(45, 13);
            this.etiquetaImagen.TabIndex = 4;
            this.etiquetaImagen.Text = "Imagen:";
            // 
            // groupBox_Controles
            // 
            this.groupBox_Controles.Controls.Add(this.boton_Limpiar_Imagenes);
            this.groupBox_Controles.Controls.Add(this.etiqueta_Cuadro_Imagenes);
            this.groupBox_Controles.Controls.Add(this.botonLimpiar);
            this.groupBox_Controles.Controls.Add(this.etiquetaLimpiar);
            this.groupBox_Controles.Controls.Add(this.checkBox_Guardar);
            this.groupBox_Controles.Controls.Add(this.checkBox_Imagen);
            this.groupBox_Controles.Controls.Add(this.etiquetaHabilitar);
            this.groupBox_Controles.Location = new System.Drawing.Point(12, 87);
            this.groupBox_Controles.Name = "groupBox_Controles";
            this.groupBox_Controles.Size = new System.Drawing.Size(460, 97);
            this.groupBox_Controles.TabIndex = 2;
            this.groupBox_Controles.TabStop = false;
            this.groupBox_Controles.Text = "Controles";
            // 
            // boton_Limpiar_Imagenes
            // 
            this.boton_Limpiar_Imagenes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boton_Limpiar_Imagenes.Location = new System.Drawing.Point(166, 67);
            this.boton_Limpiar_Imagenes.Name = "boton_Limpiar_Imagenes";
            this.boton_Limpiar_Imagenes.Size = new System.Drawing.Size(283, 23);
            this.boton_Limpiar_Imagenes.TabIndex = 6;
            this.boton_Limpiar_Imagenes.Text = "Limpiar Cuadros de Imagenes";
            this.boton_Limpiar_Imagenes.UseVisualStyleBackColor = true;
            this.boton_Limpiar_Imagenes.Click += new System.EventHandler(this.boton_Limpiar_Imagenes_Click);
            // 
            // etiqueta_Cuadro_Imagenes
            // 
            this.etiqueta_Cuadro_Imagenes.AutoSize = true;
            this.etiqueta_Cuadro_Imagenes.Location = new System.Drawing.Point(6, 72);
            this.etiqueta_Cuadro_Imagenes.Name = "etiqueta_Cuadro_Imagenes";
            this.etiqueta_Cuadro_Imagenes.Size = new System.Drawing.Size(144, 13);
            this.etiqueta_Cuadro_Imagenes.TabIndex = 5;
            this.etiqueta_Cuadro_Imagenes.Text = "Limpiar Cuadro de Imagenes:";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(166, 38);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(283, 23);
            this.botonLimpiar.TabIndex = 2;
            this.botonLimpiar.Text = "Limpiar Cuadros de Texto URL";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // etiquetaLimpiar
            // 
            this.etiquetaLimpiar.AutoSize = true;
            this.etiquetaLimpiar.Location = new System.Drawing.Point(6, 43);
            this.etiquetaLimpiar.Name = "etiquetaLimpiar";
            this.etiquetaLimpiar.Size = new System.Drawing.Size(133, 13);
            this.etiquetaLimpiar.TabIndex = 4;
            this.etiquetaLimpiar.Text = "Limpiar Cuadros de Texto: ";
            // 
            // checkBox_Guardar
            // 
            this.checkBox_Guardar.AutoSize = true;
            this.checkBox_Guardar.Location = new System.Drawing.Point(297, 15);
            this.checkBox_Guardar.Name = "checkBox_Guardar";
            this.checkBox_Guardar.Size = new System.Drawing.Size(152, 17);
            this.checkBox_Guardar.TabIndex = 1;
            this.checkBox_Guardar.Text = "Recuadro Guardar Imagen";
            this.checkBox_Guardar.UseVisualStyleBackColor = true;
            this.checkBox_Guardar.CheckedChanged += new System.EventHandler(this.checkBox_Guardar_CheckedChanged);
            // 
            // checkBox_Imagen
            // 
            this.checkBox_Imagen.AutoSize = true;
            this.checkBox_Imagen.Location = new System.Drawing.Point(166, 15);
            this.checkBox_Imagen.Name = "checkBox_Imagen";
            this.checkBox_Imagen.Size = new System.Drawing.Size(125, 17);
            this.checkBox_Imagen.TabIndex = 0;
            this.checkBox_Imagen.Text = "Recuadro Detección";
            this.checkBox_Imagen.UseVisualStyleBackColor = true;
            this.checkBox_Imagen.CheckedChanged += new System.EventHandler(this.checkBox_Imagen_CheckedChanged);
            // 
            // etiquetaHabilitar
            // 
            this.etiquetaHabilitar.AutoSize = true;
            this.etiquetaHabilitar.Location = new System.Drawing.Point(6, 16);
            this.etiquetaHabilitar.Name = "etiquetaHabilitar";
            this.etiquetaHabilitar.Size = new System.Drawing.Size(154, 13);
            this.etiquetaHabilitar.TabIndex = 3;
            this.etiquetaHabilitar.Text = "Habilitar Cuadros de Imagenes:";
            // 
            // groupBox_Nombres
            // 
            this.groupBox_Nombres.Controls.Add(this.botonLimpiar_Nombre);
            this.groupBox_Nombres.Controls.Add(this.txt_Nombre);
            this.groupBox_Nombres.Controls.Add(this.etiquetaNombre);
            this.groupBox_Nombres.Location = new System.Drawing.Point(12, 190);
            this.groupBox_Nombres.Name = "groupBox_Nombres";
            this.groupBox_Nombres.Size = new System.Drawing.Size(460, 68);
            this.groupBox_Nombres.TabIndex = 25;
            this.groupBox_Nombres.TabStop = false;
            this.groupBox_Nombres.Text = "Nombre";
            // 
            // botonLimpiar_Nombre
            // 
            this.botonLimpiar_Nombre.Location = new System.Drawing.Point(166, 35);
            this.botonLimpiar_Nombre.Name = "botonLimpiar_Nombre";
            this.botonLimpiar_Nombre.Size = new System.Drawing.Size(283, 23);
            this.botonLimpiar_Nombre.TabIndex = 2;
            this.botonLimpiar_Nombre.Text = "Limpiar Cuadro de Texto Nombre";
            this.botonLimpiar_Nombre.UseVisualStyleBackColor = true;
            this.botonLimpiar_Nombre.Click += new System.EventHandler(this.botonLimpiar_Nombre_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(166, 9);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(283, 20);
            this.txt_Nombre.TabIndex = 1;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Location = new System.Drawing.Point(6, 16);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(160, 13);
            this.etiquetaNombre.TabIndex = 0;
            this.etiquetaNombre.Text = "Ingrese el Nombre de la Imagen:";
            // 
            // groupBox_Controles_Imagenes
            // 
            this.groupBox_Controles_Imagenes.Controls.Add(this.checkBox_Azul);
            this.groupBox_Controles_Imagenes.Controls.Add(this.checkBox_Verde);
            this.groupBox_Controles_Imagenes.Controls.Add(this.checkBox_Rojo);
            this.groupBox_Controles_Imagenes.Controls.Add(this.etiquetaColores_RGB);
            this.groupBox_Controles_Imagenes.Controls.Add(this.botonCambiar);
            this.groupBox_Controles_Imagenes.Controls.Add(this.etiqueta_Gris_Color);
            this.groupBox_Controles_Imagenes.Location = new System.Drawing.Point(478, 87);
            this.groupBox_Controles_Imagenes.Name = "groupBox_Controles_Imagenes";
            this.groupBox_Controles_Imagenes.Size = new System.Drawing.Size(196, 171);
            this.groupBox_Controles_Imagenes.TabIndex = 26;
            this.groupBox_Controles_Imagenes.TabStop = false;
            this.groupBox_Controles_Imagenes.Text = "Controles de Imagenes";
            // 
            // checkBox_Azul
            // 
            this.checkBox_Azul.AutoSize = true;
            this.checkBox_Azul.Location = new System.Drawing.Point(102, 125);
            this.checkBox_Azul.Name = "checkBox_Azul";
            this.checkBox_Azul.Size = new System.Drawing.Size(81, 17);
            this.checkBox_Azul.TabIndex = 27;
            this.checkBox_Azul.Text = "Mostar Azul";
            this.checkBox_Azul.UseVisualStyleBackColor = true;
            this.checkBox_Azul.CheckedChanged += new System.EventHandler(this.checkBox_Azul_CheckedChanged);
            // 
            // checkBox_Verde
            // 
            this.checkBox_Verde.AutoSize = true;
            this.checkBox_Verde.Location = new System.Drawing.Point(102, 103);
            this.checkBox_Verde.Name = "checkBox_Verde";
            this.checkBox_Verde.Size = new System.Drawing.Size(89, 17);
            this.checkBox_Verde.TabIndex = 4;
            this.checkBox_Verde.Text = "Mostar Verde";
            this.checkBox_Verde.UseVisualStyleBackColor = true;
            this.checkBox_Verde.CheckedChanged += new System.EventHandler(this.checkBox_Verde_CheckedChanged);
            // 
            // checkBox_Rojo
            // 
            this.checkBox_Rojo.AutoSize = true;
            this.checkBox_Rojo.Location = new System.Drawing.Point(102, 80);
            this.checkBox_Rojo.Name = "checkBox_Rojo";
            this.checkBox_Rojo.Size = new System.Drawing.Size(86, 17);
            this.checkBox_Rojo.TabIndex = 3;
            this.checkBox_Rojo.Text = "Mostrar Rojo";
            this.checkBox_Rojo.UseVisualStyleBackColor = true;
            this.checkBox_Rojo.CheckedChanged += new System.EventHandler(this.checkBox_Rojo_CheckedChanged);
            // 
            // etiquetaColores_RGB
            // 
            this.etiquetaColores_RGB.AutoSize = true;
            this.etiquetaColores_RGB.Location = new System.Drawing.Point(6, 64);
            this.etiquetaColores_RGB.Name = "etiquetaColores_RGB";
            this.etiquetaColores_RGB.Size = new System.Drawing.Size(98, 13);
            this.etiquetaColores_RGB.TabIndex = 2;
            this.etiquetaColores_RGB.Text = "Mostrar Color RGB:";
            // 
            // botonCambiar
            // 
            this.botonCambiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonCambiar.Location = new System.Drawing.Point(9, 38);
            this.botonCambiar.Name = "botonCambiar";
            this.botonCambiar.Size = new System.Drawing.Size(179, 23);
            this.botonCambiar.TabIndex = 1;
            this.botonCambiar.Text = "Cambiar a Gris";
            this.botonCambiar.UseVisualStyleBackColor = true;
            this.botonCambiar.Click += new System.EventHandler(this.botonCambiar_Click);
            // 
            // etiqueta_Gris_Color
            // 
            this.etiqueta_Gris_Color.AutoSize = true;
            this.etiqueta_Gris_Color.Location = new System.Drawing.Point(6, 19);
            this.etiqueta_Gris_Color.Name = "etiqueta_Gris_Color";
            this.etiqueta_Gris_Color.Size = new System.Drawing.Size(113, 13);
            this.etiqueta_Gris_Color.TabIndex = 0;
            this.etiqueta_Gris_Color.Text = "Cambiar Color Imagen:";
            // 
            // Deteccion_Rostros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 532);
            this.Controls.Add(this.groupBox_Controles_Imagenes);
            this.Controls.Add(this.groupBox_Nombres);
            this.Controls.Add(this.groupBox_Controles);
            this.Controls.Add(this.groupBox_Buscar_Imagen);
            this.Controls.Add(this.imageBox_Guardada);
            this.Controls.Add(this.etiquetaNumero);
            this.Controls.Add(this.imageBox_Deteccion);
            this.Controls.Add(this.etiquetaRostros);
            this.Controls.Add(this.groupBox_Buscar_Camara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Deteccion_Rostros";
            this.Text = "Deteccion de Rostros";
            this.Load += new System.EventHandler(this.Deteccion_Rostros_Load);
            this.groupBox_Buscar_Camara.ResumeLayout(false);
            this.groupBox_Buscar_Camara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Guardada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Deteccion)).EndInit();
            this.groupBox_Buscar_Imagen.ResumeLayout(false);
            this.groupBox_Buscar_Imagen.PerformLayout();
            this.groupBox_Controles.ResumeLayout(false);
            this.groupBox_Controles.PerformLayout();
            this.groupBox_Nombres.ResumeLayout(false);
            this.groupBox_Nombres.PerformLayout();
            this.groupBox_Controles_Imagenes.ResumeLayout(false);
            this.groupBox_Controles_Imagenes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Buscar_Camara;
        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.Button botonDesconectar;
        private System.Windows.Forms.TextBox txt_Camara_URL;
        private System.Windows.Forms.Label etiquetaCamara;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label etiquetaNumero;
        private System.Windows.Forms.Label etiquetaRostros;
        private Emgu.CV.UI.ImageBox imageBox_Guardada;
        private System.Windows.Forms.Button botonGuardar;
        private Emgu.CV.UI.ImageBox imageBox_Deteccion;
        private System.Windows.Forms.Button botonBuscar_Imagen;
        private System.Windows.Forms.GroupBox groupBox_Buscar_Imagen;
        private System.Windows.Forms.Label etiquetaImagen;
        private System.Windows.Forms.TextBox txt_Imagen_URL;
        private System.Windows.Forms.Button botonGuardar_Imagen;
        private System.Windows.Forms.GroupBox groupBox_Controles;
        private System.Windows.Forms.CheckBox checkBox_Guardar;
        private System.Windows.Forms.CheckBox checkBox_Imagen;
        private System.Windows.Forms.Label etiquetaHabilitar;
        private System.Windows.Forms.Button botonQuitar_Imagen;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label etiquetaLimpiar;
        private System.Windows.Forms.Button botonCargar_Imagen;
        private System.Windows.Forms.GroupBox groupBox_Nombres;
        private System.Windows.Forms.Button botonLimpiar_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.GroupBox groupBox_Controles_Imagenes;
        private System.Windows.Forms.CheckBox checkBox_Verde;
        private System.Windows.Forms.CheckBox checkBox_Rojo;
        private System.Windows.Forms.Label etiquetaColores_RGB;
        private System.Windows.Forms.Button botonCambiar;
        private System.Windows.Forms.Label etiqueta_Gris_Color;
        private System.Windows.Forms.CheckBox checkBox_Azul;
        private System.Windows.Forms.Button boton_Limpiar_Imagenes;
        private System.Windows.Forms.Label etiqueta_Cuadro_Imagenes;
    }
}

