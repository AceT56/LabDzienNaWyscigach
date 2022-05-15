namespace LabDzieńNaWyścigach
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.torWyscigowy = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.betButton = new System.Windows.Forms.Button();
            this.numericBetAmout = new System.Windows.Forms.NumericUpDown();
            this.numericDog = new System.Windows.Forms.NumericUpDown();
            this.arekButton = new System.Windows.Forms.RadioButton();
            this.bartekButton = new System.Windows.Forms.RadioButton();
            this.janekButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.pictureDog1 = new System.Windows.Forms.PictureBox();
            this.pictureDog2 = new System.Windows.Forms.PictureBox();
            this.pictureDog4 = new System.Windows.Forms.PictureBox();
            this.pictureDog3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.janekBetLabel = new System.Windows.Forms.Label();
            this.bartekBetLabel = new System.Windows.Forms.Label();
            this.arekBetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.torWyscigowy)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog3)).BeginInit();
            this.SuspendLayout();
            // 
            // torWyscigowy
            // 
            this.torWyscigowy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("torWyscigowy.BackgroundImage")));
            this.torWyscigowy.Location = new System.Drawing.Point(12, 2);
            this.torWyscigowy.Name = "torWyscigowy";
            this.torWyscigowy.Size = new System.Drawing.Size(799, 229);
            this.torWyscigowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.torWyscigowy.TabIndex = 0;
            this.torWyscigowy.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(606, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 124);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arekBetLabel);
            this.groupBox1.Controls.Add(this.bartekBetLabel);
            this.groupBox1.Controls.Add(this.janekBetLabel);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.numericBetAmout);
            this.groupBox1.Controls.Add(this.numericDog);
            this.groupBox1.Controls.Add(this.arekButton);
            this.groupBox1.Controls.Add(this.bartekButton);
            this.groupBox1.Controls.Add(this.janekButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "lol";
            this.groupBox1.Text = "Dom Buchmakerski";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(95, 127);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(73, 24);
            this.betButton.TabIndex = 14;
            this.betButton.Text = "Stawia";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // numericBetAmout
            // 
            this.numericBetAmout.Location = new System.Drawing.Point(182, 127);
            this.numericBetAmout.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericBetAmout.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericBetAmout.Name = "numericBetAmout";
            this.numericBetAmout.Size = new System.Drawing.Size(66, 22);
            this.numericBetAmout.TabIndex = 10;
            this.numericBetAmout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericDog
            // 
            this.numericDog.Location = new System.Drawing.Point(375, 127);
            this.numericDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDog.Name = "numericDog";
            this.numericDog.Size = new System.Drawing.Size(37, 22);
            this.numericDog.TabIndex = 9;
            this.numericDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // arekButton
            // 
            this.arekButton.AutoSize = true;
            this.arekButton.Location = new System.Drawing.Point(41, 99);
            this.arekButton.Name = "arekButton";
            this.arekButton.Size = new System.Drawing.Size(76, 20);
            this.arekButton.TabIndex = 8;
            this.arekButton.TabStop = true;
            this.arekButton.Text = "Arek ma";
            this.arekButton.UseVisualStyleBackColor = true;
            this.arekButton.CheckedChanged += new System.EventHandler(this.arekButton_CheckedChanged);
            // 
            // bartekButton
            // 
            this.bartekButton.AutoSize = true;
            this.bartekButton.Location = new System.Drawing.Point(41, 73);
            this.bartekButton.Name = "bartekButton";
            this.bartekButton.Size = new System.Drawing.Size(87, 20);
            this.bartekButton.TabIndex = 7;
            this.bartekButton.TabStop = true;
            this.bartekButton.Text = "Bartek ma";
            this.bartekButton.UseVisualStyleBackColor = true;
            this.bartekButton.CheckedChanged += new System.EventHandler(this.bartekButton_CheckedChanged);
            // 
            // janekButton
            // 
            this.janekButton.AutoSize = true;
            this.janekButton.Checked = true;
            this.janekButton.Location = new System.Drawing.Point(41, 47);
            this.janekButton.Name = "janekButton";
            this.janekButton.Size = new System.Drawing.Size(85, 20);
            this.janekButton.TabIndex = 6;
            this.janekButton.TabStop = true;
            this.janekButton.Text = "Janek ma";
            this.janekButton.UseVisualStyleBackColor = true;
            this.janekButton.CheckedChanged += new System.EventHandler(this.janekButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "zl na charta numer";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(41, 129);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(254, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zakłady";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(38, 22);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(130, 16);
            this.minimumBetLabel.TabIndex = 2;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // pictureDog1
            // 
            this.pictureDog1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureDog1.BackgroundImage")));
            this.pictureDog1.Location = new System.Drawing.Point(12, 2);
            this.pictureDog1.Name = "pictureDog1";
            this.pictureDog1.Size = new System.Drawing.Size(91, 50);
            this.pictureDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDog1.TabIndex = 3;
            this.pictureDog1.TabStop = false;
            // 
            // pictureDog2
            // 
            this.pictureDog2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureDog2.BackgroundImage")));
            this.pictureDog2.Location = new System.Drawing.Point(12, 58);
            this.pictureDog2.Name = "pictureDog2";
            this.pictureDog2.Size = new System.Drawing.Size(91, 53);
            this.pictureDog2.TabIndex = 4;
            this.pictureDog2.TabStop = false;
            // 
            // pictureDog4
            // 
            this.pictureDog4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureDog4.BackgroundImage")));
            this.pictureDog4.Location = new System.Drawing.Point(12, 176);
            this.pictureDog4.Name = "pictureDog4";
            this.pictureDog4.Size = new System.Drawing.Size(91, 55);
            this.pictureDog4.TabIndex = 5;
            this.pictureDog4.TabStop = false;
            // 
            // pictureDog3
            // 
            this.pictureDog3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureDog3.BackgroundImage")));
            this.pictureDog3.Location = new System.Drawing.Point(12, 117);
            this.pictureDog3.Name = "pictureDog3";
            this.pictureDog3.Size = new System.Drawing.Size(91, 53);
            this.pictureDog3.TabIndex = 6;
            this.pictureDog3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // janekBetLabel
            // 
            this.janekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.janekBetLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.janekBetLabel.Location = new System.Drawing.Point(254, 47);
            this.janekBetLabel.Name = "janekBetLabel";
            this.janekBetLabel.Size = new System.Drawing.Size(306, 19);
            this.janekBetLabel.TabIndex = 15;
            this.janekBetLabel.Text = "janekBetLabel";
            // 
            // bartekBetLabel
            // 
            this.bartekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bartekBetLabel.Location = new System.Drawing.Point(254, 73);
            this.bartekBetLabel.Name = "bartekBetLabel";
            this.bartekBetLabel.Size = new System.Drawing.Size(306, 19);
            this.bartekBetLabel.TabIndex = 16;
            this.bartekBetLabel.Text = "bartekBetLabel";
            // 
            // arekBetLabel
            // 
            this.arekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arekBetLabel.Location = new System.Drawing.Point(254, 99);
            this.arekBetLabel.Name = "arekBetLabel";
            this.arekBetLabel.Size = new System.Drawing.Size(306, 19);
            this.arekBetLabel.TabIndex = 17;
            this.arekBetLabel.Text = "arekBetLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 403);
            this.Controls.Add(this.pictureDog3);
            this.Controls.Add(this.pictureDog4);
            this.Controls.Add(this.pictureDog2);
            this.Controls.Add(this.pictureDog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.torWyscigowy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dzień na wyścigach";
            ((System.ComponentModel.ISupportInitialize)(this.torWyscigowy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox torWyscigowy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureDog1;
        private System.Windows.Forms.PictureBox pictureDog2;
        private System.Windows.Forms.PictureBox pictureDog4;
        private System.Windows.Forms.PictureBox pictureDog3;
        private System.Windows.Forms.RadioButton arekButton;
        private System.Windows.Forms.RadioButton bartekButton;
        private System.Windows.Forms.RadioButton janekButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.NumericUpDown numericBetAmout;
        private System.Windows.Forms.NumericUpDown numericDog;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label arekBetLabel;
        private System.Windows.Forms.Label bartekBetLabel;
        private System.Windows.Forms.Label janekBetLabel;
    }
}

