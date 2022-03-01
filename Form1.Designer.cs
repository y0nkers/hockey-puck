
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTrace = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.bounceCount = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Label();
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
            this.Radius.DecimalPlaces = 2;
            this.Radius.Location = new System.Drawing.Point(211, 7);
            this.Radius.Margin = new System.Windows.Forms.Padding(4);
            this.Radius.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Radius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(180, 26);
            this.Radius.TabIndex = 0;
            this.Radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Mass
            // 
            this.Mass.DecimalPlaces = 2;
            this.Mass.Location = new System.Drawing.Point(211, 41);
            this.Mass.Margin = new System.Windows.Forms.Padding(4);
            this.Mass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(180, 26);
            this.Mass.TabIndex = 1;
            this.Mass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Friction
            // 
            this.Friction.DecimalPlaces = 2;
            this.Friction.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Friction.Location = new System.Drawing.Point(211, 75);
            this.Friction.Margin = new System.Windows.Forms.Padding(4);
            this.Friction.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Friction.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Friction.Name = "Friction";
            this.Friction.Size = new System.Drawing.Size(180, 26);
            this.Friction.TabIndex = 2;
            this.Friction.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // Velocity
            // 
            this.Velocity.DecimalPlaces = 2;
            this.Velocity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Velocity.Location = new System.Drawing.Point(211, 109);
            this.Velocity.Margin = new System.Windows.Forms.Padding(4);
            this.Velocity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Velocity.Name = "Velocity";
            this.Velocity.Size = new System.Drawing.Size(180, 26);
            this.Velocity.TabIndex = 3;
            this.Velocity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ThrowAngle
            // 
            this.ThrowAngle.DecimalPlaces = 2;
            this.ThrowAngle.Location = new System.Drawing.Point(211, 143);
            this.ThrowAngle.Margin = new System.Windows.Forms.Padding(4);
            this.ThrowAngle.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThrowAngle.Name = "ThrowAngle";
            this.ThrowAngle.Size = new System.Drawing.Size(180, 26);
            this.ThrowAngle.TabIndex = 4;
            this.ThrowAngle.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TunnelWidth
            // 
            this.TunnelWidth.Location = new System.Drawing.Point(210, 269);
            this.TunnelWidth.Margin = new System.Windows.Forms.Padding(4);
            this.TunnelWidth.Name = "TunnelWidth";
            this.TunnelWidth.Size = new System.Drawing.Size(180, 26);
            this.TunnelWidth.TabIndex = 7;
            this.TunnelWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TunnelHeight
            // 
            this.TunnelHeight.Location = new System.Drawing.Point(209, 304);
            this.TunnelHeight.Margin = new System.Windows.Forms.Padding(4);
            this.TunnelHeight.Name = "TunnelHeight";
            this.TunnelHeight.Size = new System.Drawing.Size(180, 26);
            this.TunnelHeight.TabIndex = 8;
            this.TunnelHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TunnelAngle
            // 
            this.TunnelAngle.Location = new System.Drawing.Point(209, 337);
            this.TunnelAngle.Margin = new System.Windows.Forms.Padding(4);
            this.TunnelAngle.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this.TunnelAngle.Name = "TunnelAngle";
            this.TunnelAngle.Size = new System.Drawing.Size(180, 26);
            this.TunnelAngle.TabIndex = 9;
            this.TunnelAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadius.Location = new System.Drawing.Point(9, 9);
            this.labelRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(121, 19);
            this.labelRadius.TabIndex = 8;
            this.labelRadius.Text = "Радиус шайбы: ";
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMass.Location = new System.Drawing.Point(9, 48);
            this.labelMass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(114, 19);
            this.labelMass.TabIndex = 9;
            this.labelMass.Text = "Масса шайбы:";
            // 
            // labelFriction
            // 
            this.labelFriction.AutoSize = true;
            this.labelFriction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFriction.Location = new System.Drawing.Point(9, 82);
            this.labelFriction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriction.Name = "labelFriction";
            this.labelFriction.Size = new System.Drawing.Size(175, 19);
            this.labelFriction.TabIndex = 10;
            this.labelFriction.Text = "Коэффициент трения: ";
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVelocity.Location = new System.Drawing.Point(9, 116);
            this.labelVelocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(164, 19);
            this.labelVelocity.TabIndex = 11;
            this.labelVelocity.Text = "Начальная скорость: ";
            // 
            // labelThrowAngle
            // 
            this.labelThrowAngle.AutoSize = true;
            this.labelThrowAngle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThrowAngle.Location = new System.Drawing.Point(7, 145);
            this.labelThrowAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThrowAngle.Name = "labelThrowAngle";
            this.labelThrowAngle.Size = new System.Drawing.Size(194, 19);
            this.labelThrowAngle.TabIndex = 12;
            this.labelThrowAngle.Text = "Угол броска (в градусах): ";
            // 
            // labelTunnelWidth
            // 
            this.labelTunnelWidth.AutoSize = true;
            this.labelTunnelWidth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTunnelWidth.Location = new System.Drawing.Point(7, 271);
            this.labelTunnelWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTunnelWidth.Name = "labelTunnelWidth";
            this.labelTunnelWidth.Size = new System.Drawing.Size(143, 19);
            this.labelTunnelWidth.TabIndex = 13;
            this.labelTunnelWidth.Text = "Ширина туннеля: ";
            // 
            // labelTunnelHeight
            // 
            this.labelTunnelHeight.AutoSize = true;
            this.labelTunnelHeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTunnelHeight.Location = new System.Drawing.Point(7, 306);
            this.labelTunnelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTunnelHeight.Name = "labelTunnelHeight";
            this.labelTunnelHeight.Size = new System.Drawing.Size(133, 19);
            this.labelTunnelHeight.TabIndex = 14;
            this.labelTunnelHeight.Text = "Высота туннеля:";
            // 
            // labelTunnelAngle
            // 
            this.labelTunnelAngle.AutoSize = true;
            this.labelTunnelAngle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTunnelAngle.Location = new System.Drawing.Point(7, 339);
            this.labelTunnelAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTunnelAngle.Name = "labelTunnelAngle";
            this.labelTunnelAngle.Size = new System.Drawing.Size(199, 19);
            this.labelTunnelAngle.TabIndex = 15;
            this.labelTunnelAngle.Text = "Угол стенок (в градусах):  ";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Location = new System.Drawing.Point(13, 394);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(146, 62);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(427, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 355);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(7, 179);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(170, 19);
            this.labelX.TabIndex = 20;
            this.labelX.Text = "X координата шайбы: ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(9, 213);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(168, 19);
            this.labelY.TabIndex = 21;
            this.labelY.Text = "Y координата шайбы: ";
            // 
            // puckX
            // 
            this.puckX.Location = new System.Drawing.Point(211, 177);
            this.puckX.Margin = new System.Windows.Forms.Padding(4);
            this.puckX.Name = "puckX";
            this.puckX.Size = new System.Drawing.Size(180, 26);
            this.puckX.TabIndex = 5;
            // 
            // puckY
            // 
            this.puckY.Location = new System.Drawing.Point(211, 211);
            this.puckY.Margin = new System.Windows.Forms.Padding(4);
            this.puckY.Name = "puckY";
            this.puckY.Size = new System.Drawing.Size(180, 26);
            this.puckY.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(209, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTrace
            // 
            this.textBoxTrace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTrace.Location = new System.Drawing.Point(427, 394);
            this.textBoxTrace.Multiline = true;
            this.textBoxTrace.Name = "textBoxTrace";
            this.textBoxTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTrace.Size = new System.Drawing.Size(521, 260);
            this.textBoxTrace.TabIndex = 25;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(15, 485);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(186, 19);
            this.labelDistance.TabIndex = 26;
            this.labelDistance.Text = "Пройденная дистанция: ";
            // 
            // bounceCount
            // 
            this.bounceCount.AutoSize = true;
            this.bounceCount.Location = new System.Drawing.Point(15, 524);
            this.bounceCount.Name = "bounceCount";
            this.bounceCount.Size = new System.Drawing.Size(206, 19);
            this.bounceCount.TabIndex = 27;
            this.bounceCount.Text = "Количество столкновений:";
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Location = new System.Drawing.Point(15, 558);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(157, 19);
            this.elapsedTime.TabIndex = 28;
            this.elapsedTime.Text = "Затраченное время: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(974, 658);
            this.Controls.Add(this.elapsedTime);
            this.Controls.Add(this.bounceCount);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.textBoxTrace);
            this.Controls.Add(this.button1);
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
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Hockey Puck Modeling";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTrace;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label bounceCount;
        private System.Windows.Forms.Label elapsedTime;
    }
}

