
namespace Carrera_Algoritmos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtNumBuscar = new System.Windows.Forms.TextBox();
            this.lblNumBuscar = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbSecuencial = new System.Windows.Forms.GroupBox();
            this.rtxtSecuencial = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRamSecuencial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTiempoSecuencial = new System.Windows.Forms.Label();
            this.pbSecuencial = new System.Windows.Forms.ProgressBar();
            this.gbBinaria = new System.Windows.Forms.GroupBox();
            this.rtxtBinaria = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRamBinaria = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTiempoBinaria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbBinaria = new System.Windows.Forms.ProgressBar();
            this.gbBurbuja = new System.Windows.Forms.GroupBox();
            this.rtxtBurbuja = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRamBurbuja = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTiempoBurbuja = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbBurbuja = new System.Windows.Forms.ProgressBar();
            this.gbQuicksort = new System.Windows.Forms.GroupBox();
            this.rtxtQuicksort = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblRamQuicksort = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTiempoQuicksort = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbQuicksort = new System.Windows.Forms.ProgressBar();
            this.gbInsercion = new System.Windows.Forms.GroupBox();
            this.rtxtInsercion = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRamInsercion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTiempoInsercion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbInsercion = new System.Windows.Forms.ProgressBar();
            this.niErrorLetra = new System.Windows.Forms.NotifyIcon(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblRamApp = new System.Windows.Forms.Label();
            this.gbSecuencial.SuspendLayout();
            this.gbBinaria.SuspendLayout();
            this.gbBurbuja.SuspendLayout();
            this.gbQuicksort.SuspendLayout();
            this.gbInsercion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(579, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(148, 50);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtNumBuscar
            // 
            this.txtNumBuscar.Location = new System.Drawing.Point(182, 27);
            this.txtNumBuscar.Name = "txtNumBuscar";
            this.txtNumBuscar.Size = new System.Drawing.Size(219, 23);
            this.txtNumBuscar.TabIndex = 1;
            this.txtNumBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumBuscar_KeyPress);
            // 
            // lblNumBuscar
            // 
            this.lblNumBuscar.AutoSize = true;
            this.lblNumBuscar.Location = new System.Drawing.Point(12, 30);
            this.lblNumBuscar.Name = "lblNumBuscar";
            this.lblNumBuscar.Size = new System.Drawing.Size(167, 15);
            this.lblNumBuscar.TabIndex = 2;
            this.lblNumBuscar.Text = "Digite un número para buscar:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(733, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 50);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbSecuencial
            // 
            this.gbSecuencial.Controls.Add(this.rtxtSecuencial);
            this.gbSecuencial.Controls.Add(this.label11);
            this.gbSecuencial.Controls.Add(this.label1);
            this.gbSecuencial.Controls.Add(this.lblRamSecuencial);
            this.gbSecuencial.Controls.Add(this.label6);
            this.gbSecuencial.Controls.Add(this.lblTiempoSecuencial);
            this.gbSecuencial.Controls.Add(this.pbSecuencial);
            this.gbSecuencial.Location = new System.Drawing.Point(12, 130);
            this.gbSecuencial.Name = "gbSecuencial";
            this.gbSecuencial.Size = new System.Drawing.Size(238, 353);
            this.gbSecuencial.TabIndex = 4;
            this.gbSecuencial.TabStop = false;
            this.gbSecuencial.Text = "Busqueda Secuencial";
            // 
            // rtxtSecuencial
            // 
            this.rtxtSecuencial.Location = new System.Drawing.Point(6, 51);
            this.rtxtSecuencial.Name = "rtxtSecuencial";
            this.rtxtSecuencial.ReadOnly = true;
            this.rtxtSecuencial.Size = new System.Drawing.Size(226, 192);
            this.rtxtSecuencial.TabIndex = 8;
            this.rtxtSecuencial.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(7, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiempo:";
            // 
            // lblRamSecuencial
            // 
            this.lblRamSecuencial.AutoSize = true;
            this.lblRamSecuencial.Location = new System.Drawing.Point(63, 290);
            this.lblRamSecuencial.Name = "lblRamSecuencial";
            this.lblRamSecuencial.Size = new System.Drawing.Size(0, 15);
            this.lblRamSecuencial.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ram:";
            // 
            // lblTiempoSecuencial
            // 
            this.lblTiempoSecuencial.AutoSize = true;
            this.lblTiempoSecuencial.Location = new System.Drawing.Point(63, 257);
            this.lblTiempoSecuencial.Name = "lblTiempoSecuencial";
            this.lblTiempoSecuencial.Size = new System.Drawing.Size(0, 15);
            this.lblTiempoSecuencial.TabIndex = 2;
            // 
            // pbSecuencial
            // 
            this.pbSecuencial.Location = new System.Drawing.Point(6, 324);
            this.pbSecuencial.Name = "pbSecuencial";
            this.pbSecuencial.Size = new System.Drawing.Size(226, 23);
            this.pbSecuencial.TabIndex = 0;
            // 
            // gbBinaria
            // 
            this.gbBinaria.Controls.Add(this.rtxtBinaria);
            this.gbBinaria.Controls.Add(this.label12);
            this.gbBinaria.Controls.Add(this.lblRamBinaria);
            this.gbBinaria.Controls.Add(this.label7);
            this.gbBinaria.Controls.Add(this.lblTiempoBinaria);
            this.gbBinaria.Controls.Add(this.label2);
            this.gbBinaria.Controls.Add(this.pbBinaria);
            this.gbBinaria.Location = new System.Drawing.Point(265, 130);
            this.gbBinaria.Name = "gbBinaria";
            this.gbBinaria.Size = new System.Drawing.Size(238, 353);
            this.gbBinaria.TabIndex = 5;
            this.gbBinaria.TabStop = false;
            this.gbBinaria.Text = "Busqueda Binaria";
            // 
            // rtxtBinaria
            // 
            this.rtxtBinaria.Location = new System.Drawing.Point(6, 51);
            this.rtxtBinaria.Name = "rtxtBinaria";
            this.rtxtBinaria.ReadOnly = true;
            this.rtxtBinaria.Size = new System.Drawing.Size(226, 192);
            this.rtxtBinaria.TabIndex = 9;
            this.rtxtBinaria.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Resultado";
            // 
            // lblRamBinaria
            // 
            this.lblRamBinaria.AutoSize = true;
            this.lblRamBinaria.Location = new System.Drawing.Point(62, 290);
            this.lblRamBinaria.Name = "lblRamBinaria";
            this.lblRamBinaria.Size = new System.Drawing.Size(0, 15);
            this.lblRamBinaria.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ram:";
            // 
            // lblTiempoBinaria
            // 
            this.lblTiempoBinaria.AutoSize = true;
            this.lblTiempoBinaria.Location = new System.Drawing.Point(62, 257);
            this.lblTiempoBinaria.Name = "lblTiempoBinaria";
            this.lblTiempoBinaria.Size = new System.Drawing.Size(0, 15);
            this.lblTiempoBinaria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo:";
            // 
            // pbBinaria
            // 
            this.pbBinaria.Location = new System.Drawing.Point(6, 324);
            this.pbBinaria.Name = "pbBinaria";
            this.pbBinaria.Size = new System.Drawing.Size(226, 23);
            this.pbBinaria.TabIndex = 1;
            // 
            // gbBurbuja
            // 
            this.gbBurbuja.Controls.Add(this.rtxtBurbuja);
            this.gbBurbuja.Controls.Add(this.label13);
            this.gbBurbuja.Controls.Add(this.lblRamBurbuja);
            this.gbBurbuja.Controls.Add(this.label8);
            this.gbBurbuja.Controls.Add(this.lblTiempoBurbuja);
            this.gbBurbuja.Controls.Add(this.label3);
            this.gbBurbuja.Controls.Add(this.pbBurbuja);
            this.gbBurbuja.Location = new System.Drawing.Point(509, 130);
            this.gbBurbuja.Name = "gbBurbuja";
            this.gbBurbuja.Size = new System.Drawing.Size(238, 353);
            this.gbBurbuja.TabIndex = 6;
            this.gbBurbuja.TabStop = false;
            this.gbBurbuja.Text = "Ordenamiento Burbuja";
            // 
            // rtxtBurbuja
            // 
            this.rtxtBurbuja.Location = new System.Drawing.Point(6, 51);
            this.rtxtBurbuja.Name = "rtxtBurbuja";
            this.rtxtBurbuja.ReadOnly = true;
            this.rtxtBurbuja.Size = new System.Drawing.Size(226, 192);
            this.rtxtBurbuja.TabIndex = 10;
            this.rtxtBurbuja.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Resultado";
            // 
            // lblRamBurbuja
            // 
            this.lblRamBurbuja.AutoSize = true;
            this.lblRamBurbuja.Location = new System.Drawing.Point(62, 290);
            this.lblRamBurbuja.Name = "lblRamBurbuja";
            this.lblRamBurbuja.Size = new System.Drawing.Size(0, 15);
            this.lblRamBurbuja.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ram:";
            // 
            // lblTiempoBurbuja
            // 
            this.lblTiempoBurbuja.AutoSize = true;
            this.lblTiempoBurbuja.Location = new System.Drawing.Point(62, 257);
            this.lblTiempoBurbuja.Name = "lblTiempoBurbuja";
            this.lblTiempoBurbuja.Size = new System.Drawing.Size(0, 15);
            this.lblTiempoBurbuja.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiempo:";
            // 
            // pbBurbuja
            // 
            this.pbBurbuja.Location = new System.Drawing.Point(6, 324);
            this.pbBurbuja.Name = "pbBurbuja";
            this.pbBurbuja.Size = new System.Drawing.Size(226, 23);
            this.pbBurbuja.TabIndex = 1;
            // 
            // gbQuicksort
            // 
            this.gbQuicksort.Controls.Add(this.rtxtQuicksort);
            this.gbQuicksort.Controls.Add(this.label14);
            this.gbQuicksort.Controls.Add(this.lblRamQuicksort);
            this.gbQuicksort.Controls.Add(this.label9);
            this.gbQuicksort.Controls.Add(this.lblTiempoQuicksort);
            this.gbQuicksort.Controls.Add(this.label4);
            this.gbQuicksort.Controls.Add(this.pbQuicksort);
            this.gbQuicksort.Location = new System.Drawing.Point(753, 130);
            this.gbQuicksort.Name = "gbQuicksort";
            this.gbQuicksort.Size = new System.Drawing.Size(238, 353);
            this.gbQuicksort.TabIndex = 6;
            this.gbQuicksort.TabStop = false;
            this.gbQuicksort.Text = "Quicksort";
            // 
            // rtxtQuicksort
            // 
            this.rtxtQuicksort.Location = new System.Drawing.Point(6, 51);
            this.rtxtQuicksort.Name = "rtxtQuicksort";
            this.rtxtQuicksort.ReadOnly = true;
            this.rtxtQuicksort.Size = new System.Drawing.Size(226, 192);
            this.rtxtQuicksort.TabIndex = 10;
            this.rtxtQuicksort.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Resultado";
            // 
            // lblRamQuicksort
            // 
            this.lblRamQuicksort.AutoSize = true;
            this.lblRamQuicksort.Location = new System.Drawing.Point(62, 290);
            this.lblRamQuicksort.Name = "lblRamQuicksort";
            this.lblRamQuicksort.Size = new System.Drawing.Size(0, 15);
            this.lblRamQuicksort.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ram:";
            // 
            // lblTiempoQuicksort
            // 
            this.lblTiempoQuicksort.AutoSize = true;
            this.lblTiempoQuicksort.Location = new System.Drawing.Point(62, 257);
            this.lblTiempoQuicksort.Name = "lblTiempoQuicksort";
            this.lblTiempoQuicksort.Size = new System.Drawing.Size(0, 15);
            this.lblTiempoQuicksort.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiempo:";
            // 
            // pbQuicksort
            // 
            this.pbQuicksort.Location = new System.Drawing.Point(6, 324);
            this.pbQuicksort.Name = "pbQuicksort";
            this.pbQuicksort.Size = new System.Drawing.Size(226, 23);
            this.pbQuicksort.TabIndex = 2;
            // 
            // gbInsercion
            // 
            this.gbInsercion.Controls.Add(this.rtxtInsercion);
            this.gbInsercion.Controls.Add(this.label15);
            this.gbInsercion.Controls.Add(this.lblRamInsercion);
            this.gbInsercion.Controls.Add(this.label10);
            this.gbInsercion.Controls.Add(this.lblTiempoInsercion);
            this.gbInsercion.Controls.Add(this.label5);
            this.gbInsercion.Controls.Add(this.pbInsercion);
            this.gbInsercion.Location = new System.Drawing.Point(997, 130);
            this.gbInsercion.Name = "gbInsercion";
            this.gbInsercion.Size = new System.Drawing.Size(238, 353);
            this.gbInsercion.TabIndex = 6;
            this.gbInsercion.TabStop = false;
            this.gbInsercion.Text = "Metodo inserción";
            this.gbInsercion.Enter += new System.EventHandler(this.gbInsercion_Enter);
            // 
            // rtxtInsercion
            // 
            this.rtxtInsercion.Location = new System.Drawing.Point(6, 51);
            this.rtxtInsercion.Name = "rtxtInsercion";
            this.rtxtInsercion.ReadOnly = true;
            this.rtxtInsercion.Size = new System.Drawing.Size(226, 192);
            this.rtxtInsercion.TabIndex = 10;
            this.rtxtInsercion.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Resultado";
            // 
            // lblRamInsercion
            // 
            this.lblRamInsercion.AutoSize = true;
            this.lblRamInsercion.Location = new System.Drawing.Point(62, 290);
            this.lblRamInsercion.Name = "lblRamInsercion";
            this.lblRamInsercion.Size = new System.Drawing.Size(0, 15);
            this.lblRamInsercion.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ram:";
            // 
            // lblTiempoInsercion
            // 
            this.lblTiempoInsercion.AutoSize = true;
            this.lblTiempoInsercion.Location = new System.Drawing.Point(62, 257);
            this.lblTiempoInsercion.Name = "lblTiempoInsercion";
            this.lblTiempoInsercion.Size = new System.Drawing.Size(0, 15);
            this.lblTiempoInsercion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiempo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pbInsercion
            // 
            this.pbInsercion.Location = new System.Drawing.Point(6, 324);
            this.pbInsercion.Name = "pbInsercion";
            this.pbInsercion.Size = new System.Drawing.Size(226, 23);
            this.pbInsercion.TabIndex = 2;
            // 
            // niErrorLetra
            // 
            this.niErrorLetra.Text = "notifyIcon1";
            this.niErrorLetra.Visible = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1092, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "Maxibanex Rodriguez Garcia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1092, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 15);
            this.label17.TabIndex = 8;
            this.label17.Text = "Matr. 1-19-1876";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 506);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "Ram consumida en la prueba:";
            // 
            // lblRamApp
            // 
            this.lblRamApp.AutoSize = true;
            this.lblRamApp.Location = new System.Drawing.Point(182, 506);
            this.lblRamApp.Name = "lblRamApp";
            this.lblRamApp.Size = new System.Drawing.Size(44, 15);
            this.lblRamApp.TabIndex = 10;
            this.lblRamApp.Text = "label19";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 546);
            this.Controls.Add(this.lblRamApp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gbInsercion);
            this.Controls.Add(this.gbQuicksort);
            this.Controls.Add(this.gbBurbuja);
            this.Controls.Add(this.gbBinaria);
            this.Controls.Add(this.gbSecuencial);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblNumBuscar);
            this.Controls.Add(this.txtNumBuscar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSecuencial.ResumeLayout(false);
            this.gbSecuencial.PerformLayout();
            this.gbBinaria.ResumeLayout(false);
            this.gbBinaria.PerformLayout();
            this.gbBurbuja.ResumeLayout(false);
            this.gbBurbuja.PerformLayout();
            this.gbQuicksort.ResumeLayout(false);
            this.gbQuicksort.PerformLayout();
            this.gbInsercion.ResumeLayout(false);
            this.gbInsercion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtNumBuscar;
        private System.Windows.Forms.Label lblNumBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbSecuencial;
        private System.Windows.Forms.ProgressBar pbSecuencial;
        private System.Windows.Forms.GroupBox gbBinaria;
        private System.Windows.Forms.ProgressBar pbBinaria;
        private System.Windows.Forms.GroupBox gbBurbuja;
        private System.Windows.Forms.ProgressBar pbBurbuja;
        private System.Windows.Forms.GroupBox gbQuicksort;
        private System.Windows.Forms.ProgressBar pbQuicksort;
        private System.Windows.Forms.GroupBox gbInsercion;
        private System.Windows.Forms.ProgressBar pbInsercion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRamSecuencial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTiempoSecuencial;
        private System.Windows.Forms.Label lblRamBinaria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTiempoBinaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRamBurbuja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTiempoBurbuja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRamQuicksort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTiempoQuicksort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRamInsercion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTiempoInsercion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtSecuencial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtxtBinaria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtxtBurbuja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtxtQuicksort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtxtInsercion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NotifyIcon niErrorLetra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblRamApp;
    }
}

