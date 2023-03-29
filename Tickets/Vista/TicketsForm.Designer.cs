namespace Vista
{
    partial class TicketsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtTipoSoporte = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionRespuesta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcionSolicitud = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(95, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitud Del Mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(83, 11);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(219, 22);
            this.txtEmpleado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(396, 11);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(184, 22);
            this.FechaDateTimePicker.TabIndex = 4;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Silver;
            this.groupBox.Controls.Add(this.txtTipoSoporte);
            this.groupBox.Controls.Add(this.txtIdentidad);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.btnBuscarCliente);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.txtCliente);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Location = new System.Drawing.Point(3, 104);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(646, 76);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            // 
            // txtTipoSoporte
            // 
            this.txtTipoSoporte.Location = new System.Drawing.Point(437, 14);
            this.txtTipoSoporte.Name = "txtTipoSoporte";
            this.txtTipoSoporte.Size = new System.Drawing.Size(178, 22);
            this.txtTipoSoporte.TabIndex = 20;
            this.txtTipoSoporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoSoporte_KeyPress);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(82, 14);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(193, 22);
            this.txtIdentidad.TabIndex = 19;
            this.txtIdentidad.TextChanged += new System.EventHandler(this.txtIdentidad_TextChanged);
            this.txtIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentidad_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Identidad:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::Vista.Properties.Resources.buscar__1_;
            this.btnBuscarCliente.Location = new System.Drawing.Point(281, 13);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(34, 25);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo Soporte:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(82, 42);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(193, 22);
            this.txtCliente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripcion Solicitud: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.txtDescripcionRespuesta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDescripcionSolicitud);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txtDescripcionRespuesta
            // 
            this.txtDescripcionRespuesta.Location = new System.Drawing.Point(174, 52);
            this.txtDescripcionRespuesta.Name = "txtDescripcionRespuesta";
            this.txtDescripcionRespuesta.Size = new System.Drawing.Size(428, 22);
            this.txtDescripcionRespuesta.TabIndex = 10;
            this.txtDescripcionRespuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionRespuesta_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Descripcion Respuesta: ";
            // 
            // txtDescripcionSolicitud
            // 
            this.txtDescripcionSolicitud.Location = new System.Drawing.Point(174, 15);
            this.txtDescripcionSolicitud.Name = "txtDescripcionSolicitud";
            this.txtDescripcionSolicitud.ReadOnly = true;
            this.txtDescripcionSolicitud.Size = new System.Drawing.Size(428, 22);
            this.txtDescripcionSolicitud.TabIndex = 8;
            this.txtDescripcionSolicitud.TextChanged += new System.EventHandler(this.txtDescripcionSolicitud_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(507, 287);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(141, 22);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Impuesto:";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(507, 348);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(141, 22);
            this.txtImpuesto.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(506, 376);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(141, 22);
            this.txtDescuento.TabIndex = 14;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total A Pagar:";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Location = new System.Drawing.Point(508, 413);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(141, 22);
            this.txtTotalAPagar.TabIndex = 16;
            this.txtTotalAPagar.TextChanged += new System.EventHandler(this.txtTotalAPagar_TextChanged);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.DetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(3, 287);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(418, 91);
            this.DetalleDataGridView.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(506, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Image = global::Vista.Properties.Resources.cancelar__1_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(122, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 38);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardar.Image = global::Vista.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(14, 395);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 38);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(652, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketsForm";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescripcionRespuesta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcionSolicitud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTipoSoporte;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Button button1;
    }
}