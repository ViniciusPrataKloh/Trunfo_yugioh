namespace clientePilha
{
    partial class btEnviarCarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btEnviarCarta));
            this.btJogar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btComprarCarta = new System.Windows.Forms.Button();
            this.campoResult = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.labelVez = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btJogar
            // 
            this.btJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btJogar.Location = new System.Drawing.Point(12, 29);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(103, 23);
            this.btJogar.TabIndex = 1;
            this.btJogar.Text = "Comprar Deck";
            this.btJogar.UseVisualStyleBackColor = true;
            this.btJogar.Click += new System.EventHandler(this.btComprarDeck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(197, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 455);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(545, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 455);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(197, 29);
            this.progressBar1.Maximum = 8000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(314, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Maroon;
            this.progressBar2.Location = new System.Drawing.Point(545, 29);
            this.progressBar2.Maximum = 8000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(314, 23);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 5;
            // 
            // btComprarCarta
            // 
            this.btComprarCarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btComprarCarta.Location = new System.Drawing.Point(13, 78);
            this.btComprarCarta.Name = "btComprarCarta";
            this.btComprarCarta.Size = new System.Drawing.Size(102, 23);
            this.btComprarCarta.TabIndex = 6;
            this.btComprarCarta.Text = "Comprar Carta";
            this.btComprarCarta.UseVisualStyleBackColor = true;
            this.btComprarCarta.Click += new System.EventHandler(this.btComprarCarta_Click);
            // 
            // campoResult
            // 
            this.campoResult.Location = new System.Drawing.Point(15, 207);
            this.campoResult.Name = "campoResult";
            this.campoResult.Size = new System.Drawing.Size(102, 20);
            this.campoResult.TabIndex = 7;
            // 
            // btEnviar
            // 
            this.btEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnviar.Location = new System.Drawing.Point(13, 128);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(102, 23);
            this.btEnviar.TabIndex = 8;
            this.btEnviar.Text = "Enviar Carta";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // labelVez
            // 
            this.labelVez.AutoSize = true;
            this.labelVez.BackColor = System.Drawing.Color.Transparent;
            this.labelVez.ForeColor = System.Drawing.Color.White;
            this.labelVez.Location = new System.Drawing.Point(12, 173);
            this.labelVez.Name = "labelVez";
            this.labelVez.Size = new System.Drawing.Size(25, 13);
            this.labelVez.TabIndex = 9;
            this.labelVez.Text = "Vez";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(542, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Oponente";
            // 
            // btEnviarCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVez);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.campoResult);
            this.Controls.Add(this.btComprarCarta);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btJogar);
            this.Name = "btEnviarCarta";
            this.Text = "Cliente 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btComprarCarta;
        private System.Windows.Forms.TextBox campoResult;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Label labelVez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

