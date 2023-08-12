namespace frmPokemon
{
    partial class frmPokemon
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
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.btnCargarPokemon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresarPokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPokemon.Location = new System.Drawing.Point(91, 186);
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.Size = new System.Drawing.Size(548, 377);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(814, 186);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(316, 377);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 1;
            this.pbxPokemon.TabStop = false;
            // 
            // btnCargarPokemon
            // 
            this.btnCargarPokemon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCargarPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPokemon.Location = new System.Drawing.Point(91, 594);
            this.btnCargarPokemon.Name = "btnCargarPokemon";
            this.btnCargarPokemon.Size = new System.Drawing.Size(252, 60);
            this.btnCargarPokemon.TabIndex = 2;
            this.btnCargarPokemon.Text = "Listar Pokemons";
            this.btnCargarPokemon.UseVisualStyleBackColor = false;
            this.btnCargarPokemon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(135, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIENVENIDO ENTRENADOR";
            // 
            // btnIngresarPokemon
            // 
            this.btnIngresarPokemon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresarPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPokemon.Location = new System.Drawing.Point(387, 594);
            this.btnIngresarPokemon.Name = "btnIngresarPokemon";
            this.btnIngresarPokemon.Size = new System.Drawing.Size(252, 60);
            this.btnIngresarPokemon.TabIndex = 4;
            this.btnIngresarPokemon.Text = "Ingresar Pokemon";
            this.btnIngresarPokemon.UseVisualStyleBackColor = false;
            this.btnIngresarPokemon.Click += new System.EventHandler(this.btnIngresarPokemon_Click);
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1239, 761);
            this.Controls.Add(this.btnIngresarPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarPokemon);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.dgvPokemon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 478);
            this.Name = "frmPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POKEMON";
            this.Load += new System.EventHandler(this.frmPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.Button btnCargarPokemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarPokemon;
    }
}

