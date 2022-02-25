
namespace hockey_puck
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Radius = new System.Windows.Forms.NumericUpDown();
            this.Mass = new System.Windows.Forms.NumericUpDown();
            this.Friction = new System.Windows.Forms.NumericUpDown();
            this.Velocity = new System.Windows.Forms.NumericUpDown();
            this.ThrowAngle = new System.Windows.Forms.NumericUpDown();
            this.TunnelWidth = new System.Windows.Forms.NumericUpDown();
            this.TunnelHeight = new System.Windows.Forms.NumericUpDown();
            this.TunnelAngle = new System.Windows.Forms.NumericUpDown();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelMass = new System.Windows.Forms.Label();
            this.labelFriction = new System.Windows.Forms.Label();
            this.labelVelocity = new System.Windows.Forms.Label();
            this.labelThrowAngle = new System.Windows.Forms.Label();
            this.labelTunnelWidth = new System.Windows.Forms.Label();
            this.labelTunnelHeight = new System.Windows.Forms.Label();
            this.labelTunnelAngle = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.puckX = new System.Windows.Forms.NumericUpDown();
            this.puckY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Friction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Velocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TunnelWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TunnelHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TunnelAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puckX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puckY)).BeginInit();
            this.SuspendLayout();
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(158, 17);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(120, 20);
            this.Radius.TabIndex = 0;
            // 
            // Mass
            // 
            this.Mass.Location = new System.Drawing.Point(158, 43);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(120, 20);
            this.Mass.TabIndex = 1;
            // 
            // Friction
            // 
            this.Friction.DecimalPlaces = 2;
            this.Friction.Location = new System.Drawing.Point(158, 69);
            this.Friction.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Friction.Name = "Friction";
            this.Friction.Size = new System.Drawing.Size(120, 20);
            this.Friction.TabIndex = 2;
            // 
            // Velocity
            // 
            this.Velocity.Location = new System.Drawing.Point(158, 95);
            this.Velocity.Name = "Velocity";
            this.Velocity.Size = new System.Drawing.Size(120, 20);
            this.Velocity.TabIndex = 3;
            // 
            // ThrowAngle
            // 
            this.ThrowAngle.DecimalPlaces = 2;
            this.ThrowAngle.Location = new System.Drawing.Point(158, 121);
            this.ThrowAngle.Name = "ThrowAngle";
            this.ThrowAngle.Size = new System.Drawing.Size(120, 20);
            this.ThrowAngle.TabIndex = 4;
            // 
            // TunnelWidth
            // 
            this.TunnelWidth.Location = new System.Drawing.Point(456, 15);
            this.TunnelWidth.Name = "TunnelWidth";
            this.TunnelWidth.Size = new System.Drawing.Size(120, 20);
            this.TunnelWidth.TabIndex = 5;
            // 
            // TunnelHeight
            // 
            this.TunnelHeight.Location = new System.Drawing.Point(456, 41);
            this.TunnelHeight.Name = "TunnelHeight";
            this.TunnelHeight.Size = new System.Drawing.Size(120, 20);
            this.TunnelHeight.TabIndex = 6;
            // 
            // TunnelAngle
            // 
            this.TunnelAngle.Location = new System.Drawing.Point(456, 67);
            this.TunnelAngle.Name = "TunnelAngle";
            this.TunnelAngle.Size = new System.Drawing.Size(120, 20);
            this.TunnelAngle.TabIndex = 7;
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(18, 17);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(86, 13);
            this.labelRadius.TabIndex = 8;
            this.labelRadius.Text = "Радиус шайбы: ";
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Location = new System.Drawing.Point(18, 45);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(80, 13);
            this.labelMass.TabIndex = 9;
            this.labelMass.Text = "Масса шайбы:";
            // 
            // labelFriction
            // 
            this.labelFriction.AutoSize = true;
            this.labelFriction.Location = new System.Drawing.Point(15, 76);
            this.labelFriction.Name = "labelFriction";
            this.labelFriction.Size = new System.Drawing.Size(121, 13);
            this.labelFriction.TabIndex = 10;
            this.labelFriction.Text = "Коэффициент трения: ";
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Location = new System.Drawing.Point(15, 102);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(118, 13);
            this.labelVelocity.TabIndex = 11;
            this.labelVelocity.Text = "Начальная скорость: ";
            // 
            // labelThrowAngle
            // 
            this.labelThrowAngle.AutoSize = true;
            this.labelThrowAngle.Location = new System.Drawing.Point(12, 123);
            this.labelThrowAngle.Name = "labelThrowAngle";
            this.labelThrowAngle.Size = new System.Drawing.Size(140, 13);
            this.labelThrowAngle.TabIndex = 12;
            this.labelThrowAngle.Text = "Угол броска (в градусах): ";
            // 
            // labelTunnelWidth
            // 
            this.labelTunnelWidth.AutoSize = true;
            this.labelTunnelWidth.Location = new System.Drawing.Point(308, 19);
            this.labelTunnelWidth.Name = "labelTunnelWidth";
            this.labelTunnelWidth.Size = new System.Drawing.Size(95, 13);
            this.labelTunnelWidth.TabIndex = 13;
            this.labelTunnelWidth.Text = "Ширина туннеля: ";
            // 
            // labelTunnelHeight
            // 
            this.labelTunnelHeight.AutoSize = true;
            this.labelTunnelHeight.Location = new System.Drawing.Point(308, 45);
            this.labelTunnelHeight.Name = "labelTunnelHeight";
            this.labelTunnelHeight.Size = new System.Drawing.Size(88, 13);
            this.labelTunnelHeight.TabIndex = 14;
            this.labelTunnelHeight.Text = "Высота туннеля";
            // 
            // labelTunnelAngle
            // 
            this.labelTunnelAngle.AutoSize = true;
            this.labelTunnelAngle.Location = new System.Drawing.Point(308, 71);
            this.labelTunnelAngle.Name = "labelTunnelAngle";
            this.labelTunnelAngle.Size = new System.Drawing.Size(142, 13);
            this.labelTunnelAngle.TabIndex = 15;
            this.labelTunnelAngle.Text = "Угол стенок (в градусах):  ";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 318);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 16;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(296, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 260);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(15, 153);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(119, 13);
            this.labelX.TabIndex = 20;
            this.labelX.Text = "X координата шайбы: ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(18, 181);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(119, 13);
            this.labelY.TabIndex = 21;
            this.labelY.Text = "Y координата шайбы: ";
            // 
            // puckX
            // 
            this.puckX.Location = new System.Drawing.Point(158, 148);
            this.puckX.Name = "puckX";
            this.puckX.Size = new System.Drawing.Size(120, 20);
            this.puckX.TabIndex = 22;
            // 
            // puckY
            // 
            this.puckY.Location = new System.Drawing.Point(158, 174);
            this.puckY.Name = "puckY";
            this.puckY.Size = new System.Drawing.Size(120, 20);
            this.puckY.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.puckY);
            this.Controls.Add(this.puckX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTunnelAngle);
            this.Controls.Add(this.labelTunnelHeight);
            this.Controls.Add(this.labelTunnelWidth);
            this.Controls.Add(this.labelThrowAngle);
            this.Controls.Add(this.labelVelocity);
            this.Controls.Add(this.labelFriction);
            this.Controls.Add(this.labelMass);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.TunnelAngle);
            this.Controls.Add(this.TunnelHeight);
            this.Controls.Add(this.TunnelWidth);
            this.Controls.Add(this.ThrowAngle);
            this.Controls.Add(this.Velocity);
            this.Controls.Add(this.Friction);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.Radius);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Friction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Velocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TunnelWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TunnelHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TunnelAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puckX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puckY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Radius;
        private System.Windows.Forms.NumericUpDown Mass;
        private System.Windows.Forms.NumericUpDown Friction;
        private System.Windows.Forms.NumericUpDown Velocity;
        private System.Windows.Forms.NumericUpDown ThrowAngle;
        private System.Windows.Forms.NumericUpDown TunnelWidth;
        private System.Windows.Forms.NumericUpDown TunnelHeight;
        private System.Windows.Forms.NumericUpDown TunnelAngle;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.Label labelFriction;
        private System.Windows.Forms.Label labelVelocity;
        private System.Windows.Forms.Label labelThrowAngle;
        private System.Windows.Forms.Label labelTunnelWidth;
        private System.Windows.Forms.Label labelTunnelHeight;
        private System.Windows.Forms.Label labelTunnelAngle;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.NumericUpDown puckX;
        private System.Windows.Forms.NumericUpDown puckY;
    }
}

