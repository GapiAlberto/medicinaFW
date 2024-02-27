namespace medicinaFW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroButtonCotizar = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPrecio = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabelPrecioTotal = new MetroFramework.Drawing.Html.HtmlLabel();
            this.SuspendLayout();
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.metroCheckBox1.Location = new System.Drawing.Point(185, 214);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(32, 15);
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.Text = "SI";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(209, 29);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel1.Location = new System.Drawing.Point(97, 63);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(214, 35);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "Intruduce el recio del producto";
            this.htmlLabel1.Click += new System.EventHandler(this.htmlLabel1_Click);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(180, 29);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel2.Location = new System.Drawing.Point(106, 156);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(186, 43);
            this.htmlLabel2.TabIndex = 2;
            this.htmlLabel2.Text = "¡Tu producto es Medicina?";
            // 
            // metroButtonCotizar
            // 
            this.metroButtonCotizar.Location = new System.Drawing.Point(185, 250);
            this.metroButtonCotizar.Name = "metroButtonCotizar";
            this.metroButtonCotizar.Size = new System.Drawing.Size(32, 23);
            this.metroButtonCotizar.TabIndex = 3;
            this.metroButtonCotizar.Text = "=";
            this.metroButtonCotizar.UseSelectable = true;
            this.metroButtonCotizar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBoxPrecio
            // 
            this.metroTextBoxPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.metroTextBoxPrecio.CustomButton.Image = null;
            this.metroTextBoxPrecio.CustomButton.Location = new System.Drawing.Point(27, 1);
            this.metroTextBoxPrecio.CustomButton.Name = "";
            this.metroTextBoxPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrecio.CustomButton.TabIndex = 1;
            this.metroTextBoxPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrecio.CustomButton.UseSelectable = true;
            this.metroTextBoxPrecio.CustomButton.Visible = false;
            this.metroTextBoxPrecio.Lines = new string[0];
            this.metroTextBoxPrecio.Location = new System.Drawing.Point(168, 116);
            this.metroTextBoxPrecio.MaxLength = 32767;
            this.metroTextBoxPrecio.Name = "metroTextBoxPrecio";
            this.metroTextBoxPrecio.PasswordChar = '\0';
            this.metroTextBoxPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrecio.SelectedText = "";
            this.metroTextBoxPrecio.SelectionLength = 0;
            this.metroTextBoxPrecio.SelectionStart = 0;
            this.metroTextBoxPrecio.ShortcutsEnabled = true;
            this.metroTextBoxPrecio.Size = new System.Drawing.Size(49, 23);
            this.metroTextBoxPrecio.TabIndex = 4;
            this.metroTextBoxPrecio.UseSelectable = true;
            this.metroTextBoxPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabelPrecioTotal
            // 
            this.htmlLabelPrecioTotal.AutoScroll = true;
            this.htmlLabelPrecioTotal.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.htmlLabelPrecioTotal.AutoSize = false;
            this.htmlLabelPrecioTotal.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabelPrecioTotal.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabelPrecioTotal.Location = new System.Drawing.Point(84, 292);
            this.htmlLabelPrecioTotal.Name = "htmlLabelPrecioTotal";
            this.htmlLabelPrecioTotal.Size = new System.Drawing.Size(235, 64);
            this.htmlLabelPrecioTotal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 379);
            this.Controls.Add(this.htmlLabelPrecioTotal);
            this.Controls.Add(this.metroTextBoxPrecio);
            this.Controls.Add(this.metroButtonCotizar);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.metroCheckBox1);
            this.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroButton metroButtonCotizar;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrecio;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabelPrecioTotal;
    }
}

