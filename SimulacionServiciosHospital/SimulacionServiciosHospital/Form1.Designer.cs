namespace SimulacionServiciosHospital
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnModa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPseu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.NomServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPacientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNumerosPA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtModa = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCostoOp = new System.Windows.Forms.TextBox();
            this.btnDecision = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.txtSimulados = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbldisnor2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.txtGananciaDecision = new System.Windows.Forms.TextBox();
            this.panelDecision = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.txtDecimales = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizarDecimales = new System.Windows.Forms.Button();
            this.btnDistancia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moda:";
            // 
            // btnModa
            // 
            this.btnModa.Location = new System.Drawing.Point(146, 204);
            this.btnModa.Name = "btnModa";
            this.btnModa.Size = new System.Drawing.Size(75, 23);
            this.btnModa.TabIndex = 1;
            this.btnModa.Text = "Calcular";
            this.btnModa.UseVisualStyleBackColor = true;
            this.btnModa.Click += new System.EventHandler(this.btnModa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Ri,
            this.Raciones});
            this.dataGridView1.Location = new System.Drawing.Point(11, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(206, 386);
            this.dataGridView1.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "Día";
            this.No.Name = "No";
            this.No.Width = 40;
            // 
            // Ri
            // 
            this.Ri.HeaderText = "Ri";
            this.Ri.Name = "Ri";
            this.Ri.Width = 70;
            // 
            // Raciones
            // 
            this.Raciones.HeaderText = "Pacientes que llegaron";
            this.Raciones.Name = "Raciones";
            this.Raciones.Width = 50;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoPaciente,
            this.numPseu,
            this.servicio,
            this.pr});
            this.dataGridView2.Location = new System.Drawing.Point(785, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(321, 386);
            this.dataGridView2.TabIndex = 3;
            // 
            // NoPaciente
            // 
            this.NoPaciente.HeaderText = "No. Paciente";
            this.NoPaciente.Name = "NoPaciente";
            this.NoPaciente.Width = 50;
            // 
            // numPseu
            // 
            this.numPseu.HeaderText = "Ri";
            this.numPseu.Name = "numPseu";
            this.numPseu.Width = 70;
            // 
            // servicio
            // 
            this.servicio.HeaderText = "Servicio";
            this.servicio.Name = "servicio";
            // 
            // pr
            // 
            this.pr.HeaderText = "Precio";
            this.pr.Name = "pr";
            this.pr.Width = 50;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomServicio,
            this.prob,
            this.LimInf,
            this.LimSup,
            this.precio,
            this.tPacientes,
            this.tPrecio});
            this.dataGridView3.Location = new System.Drawing.Point(223, 293);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(556, 386);
            this.dataGridView3.TabIndex = 4;
            // 
            // NomServicio
            // 
            this.NomServicio.HeaderText = "Servicio";
            this.NomServicio.Name = "NomServicio";
            // 
            // prob
            // 
            this.prob.HeaderText = "Probabilidad";
            this.prob.Name = "prob";
            this.prob.Width = 50;
            // 
            // LimInf
            // 
            this.LimInf.HeaderText = "Limite Inferior";
            this.LimInf.Name = "LimInf";
            this.LimInf.Width = 50;
            // 
            // LimSup
            // 
            this.LimSup.HeaderText = "Limite Superior";
            this.LimSup.Name = "LimSup";
            this.LimSup.Width = 50;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 50;
            // 
            // tPacientes
            // 
            this.tPacientes.HeaderText = "Total pacientes";
            this.tPacientes.Name = "tPacientes";
            // 
            // tPrecio
            // 
            this.tPrecio.HeaderText = "Total Precio";
            this.tPrecio.Name = "tPrecio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnDistancia);
            this.panel1.Controls.Add(this.btnNumerosPA);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtM);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtXo);
            this.panel1.Controls.Add(this.txtc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txta);
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 230);
            this.panel1.TabIndex = 5;
            // 
            // btnNumerosPA
            // 
            this.btnNumerosPA.Location = new System.Drawing.Point(98, 175);
            this.btnNumerosPA.Name = "btnNumerosPA";
            this.btnNumerosPA.Size = new System.Drawing.Size(139, 23);
            this.btnNumerosPA.TabIndex = 11;
            this.btnNumerosPA.Text = "Generar números";
            this.btnNumerosPA.UseVisualStyleBackColor = true;
            this.btnNumerosPA.Click += new System.EventHandler(this.btnNumerosPA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Realizar pruebas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(86, 146);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 20);
            this.txtn.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "n:";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(86, 121);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "M:";
            // 
            // txtXo
            // 
            this.txtXo.Location = new System.Drawing.Point(86, 96);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(100, 20);
            this.txtXo.TabIndex = 6;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(86, 70);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos para el generador";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(86, 45);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txtModa);
            this.panel2.Controls.Add(this.txtMaximo);
            this.panel2.Controls.Add(this.txtPromedio);
            this.panel2.Controls.Add(this.txtMinimo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnModa);
            this.panel2.Location = new System.Drawing.Point(277, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 230);
            this.panel2.TabIndex = 6;
            // 
            // txtModa
            // 
            this.txtModa.Enabled = false;
            this.txtModa.Location = new System.Drawing.Point(74, 153);
            this.txtModa.Name = "txtModa";
            this.txtModa.Size = new System.Drawing.Size(76, 20);
            this.txtModa.TabIndex = 15;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(93, 96);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMaximo.TabIndex = 14;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(93, 70);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 13;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(93, 44);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtMinimo.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Promedio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Máximo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mínimo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Datos generales de los pacientes por día";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total de servicios simulados";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtCostoOp);
            this.panel3.Controls.Add(this.btnDecision);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtGanancia);
            this.panel3.Controls.Add(this.txtSimulados);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(573, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 154);
            this.panel3.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Costo de operación";
            // 
            // txtCostoOp
            // 
            this.txtCostoOp.Location = new System.Drawing.Point(175, 76);
            this.txtCostoOp.Name = "txtCostoOp";
            this.txtCostoOp.Size = new System.Drawing.Size(100, 20);
            this.txtCostoOp.TabIndex = 16;
            // 
            // btnDecision
            // 
            this.btnDecision.Location = new System.Drawing.Point(188, 118);
            this.btnDecision.Name = "btnDecision";
            this.btnDecision.Size = new System.Drawing.Size(75, 23);
            this.btnDecision.TabIndex = 11;
            this.btnDecision.Text = "Decisión";
            this.btnDecision.UseVisualStyleBackColor = true;
            this.btnDecision.Click += new System.EventHandler(this.btnDecision_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ganancia total";
            // 
            // txtGanancia
            // 
            this.txtGanancia.Enabled = false;
            this.txtGanancia.Location = new System.Drawing.Point(175, 47);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(100, 20);
            this.txtGanancia.TabIndex = 9;
            // 
            // txtSimulados
            // 
            this.txtSimulados.Enabled = false;
            this.txtSimulados.Location = new System.Drawing.Point(175, 17);
            this.txtSimulados.Name = "txtSimulados";
            this.txtSimulados.Size = new System.Drawing.Size(100, 20);
            this.txtSimulados.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Distribución normal:";
            this.label14.Visible = false;
            // 
            // lbldisnor2
            // 
            this.lbldisnor2.AutoSize = true;
            this.lbldisnor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisnor2.Location = new System.Drawing.Point(118, 282);
            this.lbldisnor2.Name = "lbldisnor2";
            this.lbldisnor2.Size = new System.Drawing.Size(0, 13);
            this.lbldisnor2.TabIndex = 19;
            this.lbldisnor2.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Promedio de los numeros pseodoaleatorios:";
            this.label15.Visible = false;
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(234, 251);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(0, 13);
            this.lblpromedio.TabIndex = 18;
            this.lblpromedio.Visible = false;
            // 
            // txtGananciaDecision
            // 
            this.txtGananciaDecision.Enabled = false;
            this.txtGananciaDecision.Location = new System.Drawing.Point(383, 46);
            this.txtGananciaDecision.Name = "txtGananciaDecision";
            this.txtGananciaDecision.Size = new System.Drawing.Size(100, 20);
            this.txtGananciaDecision.TabIndex = 18;
            // 
            // panelDecision
            // 
            this.panelDecision.Controls.Add(this.label17);
            this.panelDecision.Controls.Add(this.lblDecision);
            this.panelDecision.Controls.Add(this.txtGananciaDecision);
            this.panelDecision.Location = new System.Drawing.Point(573, 169);
            this.panelDecision.Name = "panelDecision";
            this.panelDecision.Size = new System.Drawing.Size(500, 107);
            this.panelDecision.TabIndex = 20;
            this.panelDecision.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(267, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Ganancia actualizada:";
            // 
            // lblDecision
            // 
            this.lblDecision.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblDecision.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecision.ForeColor = System.Drawing.Color.Black;
            this.lblDecision.Location = new System.Drawing.Point(3, 0);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(245, 107);
            this.lblDecision.TabIndex = 19;
            // 
            // txtDecimales
            // 
            this.txtDecimales.Location = new System.Drawing.Point(1007, 92);
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(66, 20);
            this.txtDecimales.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(945, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Decimales";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1021, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizarDecimales
            // 
            this.btnActualizarDecimales.Location = new System.Drawing.Point(998, 128);
            this.btnActualizarDecimales.Name = "btnActualizarDecimales";
            this.btnActualizarDecimales.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarDecimales.TabIndex = 21;
            this.btnActualizarDecimales.Text = "Actualizar";
            this.btnActualizarDecimales.UseVisualStyleBackColor = true;
            this.btnActualizarDecimales.Click += new System.EventHandler(this.btnActualizarDecimales_Click);
            // 
            // btnDistancia
            // 
            this.btnDistancia.Location = new System.Drawing.Point(14, 187);
            this.btnDistancia.Name = "btnDistancia";
            this.btnDistancia.Size = new System.Drawing.Size(78, 23);
            this.btnDistancia.TabIndex = 12;
            this.btnDistancia.Text = "Realizar pruebas";
            this.btnDistancia.UseVisualStyleBackColor = true;
            this.btnDistancia.Click += new System.EventHandler(this.btnDistancia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 691);
            this.Controls.Add(this.btnActualizarDecimales);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDecimales);
            this.Controls.Add(this.panelDecision);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbldisnor2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelDecision.ResumeLayout(false);
            this.panelDecision.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.TextBox txtSimulados;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPseu;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr;
        private System.Windows.Forms.TextBox txtModa;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lbldisnor2;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Button btnNumerosPA;
        private System.Windows.Forms.Button btnDecision;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCostoOp;
        private System.Windows.Forms.TextBox txtGananciaDecision;
        private System.Windows.Forms.Panel panelDecision;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDecimales;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizarDecimales;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raciones;
        public System.Windows.Forms.TextBox txta;
        public System.Windows.Forms.TextBox txtXo;
        public System.Windows.Forms.TextBox txtc;
        public System.Windows.Forms.TextBox txtM;
        public System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btnDistancia;
    }
}

