namespace Task4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.crosswalk_pictureBox = new System.Windows.Forms.PictureBox();
            this.car_pictureBox = new System.Windows.Forms.PictureBox();
            this.StartFilm_btn = new System.Windows.Forms.Button();
            this.frontPedestrian_pb = new System.Windows.Forms.PictureBox();
            this.ambulance_pb = new System.Windows.Forms.PictureBox();
            this.fireman_pb = new System.Windows.Forms.PictureBox();
            this.police_pb = new System.Windows.Forms.PictureBox();
            this.trafficLight_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crosswalk_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontPedestrian_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulance_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireman_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLight_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // crosswalk_pictureBox
            // 
            this.crosswalk_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crosswalk_pictureBox.BackgroundImage")));
            this.crosswalk_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crosswalk_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.crosswalk_pictureBox.Name = "crosswalk_pictureBox";
            this.crosswalk_pictureBox.Size = new System.Drawing.Size(1372, 934);
            this.crosswalk_pictureBox.TabIndex = 0;
            this.crosswalk_pictureBox.TabStop = false;
            // 
            // car_pictureBox
            // 
            this.car_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.car_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car_pictureBox.BackgroundImage")));
            this.car_pictureBox.Location = new System.Drawing.Point(1329, 595);
            this.car_pictureBox.Name = "car_pictureBox";
            this.car_pictureBox.Size = new System.Drawing.Size(522, 151);
            this.car_pictureBox.TabIndex = 1;
            this.car_pictureBox.TabStop = false;
            // 
            // StartFilm_btn
            // 
            this.StartFilm_btn.Location = new System.Drawing.Point(1153, 12);
            this.StartFilm_btn.Name = "StartFilm_btn";
            this.StartFilm_btn.Size = new System.Drawing.Size(186, 109);
            this.StartFilm_btn.TabIndex = 2;
            this.StartFilm_btn.Text = "Старт";
            this.StartFilm_btn.UseVisualStyleBackColor = true;
            this.StartFilm_btn.Click += new System.EventHandler(this.StartFilm_btn_Click);
            // 
            // frontPedestrian_pb
            // 
            this.frontPedestrian_pb.BackColor = System.Drawing.Color.Transparent;
            this.frontPedestrian_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frontPedestrian_pb.BackgroundImage")));
            this.frontPedestrian_pb.Location = new System.Drawing.Point(379, 266);
            this.frontPedestrian_pb.Name = "frontPedestrian_pb";
            this.frontPedestrian_pb.Size = new System.Drawing.Size(169, 225);
            this.frontPedestrian_pb.TabIndex = 3;
            this.frontPedestrian_pb.TabStop = false;
            // 
            // ambulance_pb
            // 
            this.ambulance_pb.BackColor = System.Drawing.Color.Transparent;
            this.ambulance_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ambulance_pb.BackgroundImage")));
            this.ambulance_pb.Location = new System.Drawing.Point(-470, 256);
            this.ambulance_pb.Name = "ambulance_pb";
            this.ambulance_pb.Size = new System.Drawing.Size(685, 329);
            this.ambulance_pb.TabIndex = 4;
            this.ambulance_pb.TabStop = false;
            // 
            // fireman_pb
            // 
            this.fireman_pb.BackColor = System.Drawing.Color.Transparent;
            this.fireman_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fireman_pb.BackgroundImage")));
            this.fireman_pb.Location = new System.Drawing.Point(1302, 145);
            this.fireman_pb.Name = "fireman_pb";
            this.fireman_pb.Size = new System.Drawing.Size(645, 357);
            this.fireman_pb.TabIndex = 5;
            this.fireman_pb.TabStop = false;
            // 
            // police_pb
            // 
            this.police_pb.BackColor = System.Drawing.Color.Transparent;
            this.police_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("police_pb.BackgroundImage")));
            this.police_pb.Location = new System.Drawing.Point(1302, 299);
            this.police_pb.Name = "police_pb";
            this.police_pb.Size = new System.Drawing.Size(710, 296);
            this.police_pb.TabIndex = 6;
            this.police_pb.TabStop = false;
            // 
            // trafficLight_pb
            // 
            this.trafficLight_pb.Location = new System.Drawing.Point(0, 0);
            this.trafficLight_pb.Name = "trafficLight_pb";
            this.trafficLight_pb.Size = new System.Drawing.Size(148, 250);
            this.trafficLight_pb.TabIndex = 7;
            this.trafficLight_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 934);
            this.Controls.Add(this.trafficLight_pb);
            this.Controls.Add(this.police_pb);
            this.Controls.Add(this.fireman_pb);
            this.Controls.Add(this.ambulance_pb);
            this.Controls.Add(this.frontPedestrian_pb);
            this.Controls.Add(this.StartFilm_btn);
            this.Controls.Add(this.car_pictureBox);
            this.Controls.Add(this.crosswalk_pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.crosswalk_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontPedestrian_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulance_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireman_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLight_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox crosswalk_pictureBox;
        private System.Windows.Forms.PictureBox car_pictureBox;
        private System.Windows.Forms.Button StartFilm_btn;
        private System.Windows.Forms.PictureBox frontPedestrian_pb;
        private System.Windows.Forms.PictureBox ambulance_pb;
        private System.Windows.Forms.PictureBox fireman_pb;
        private System.Windows.Forms.PictureBox police_pb;
        private System.Windows.Forms.PictureBox trafficLight_pb;
    }
}

