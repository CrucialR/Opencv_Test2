namespace Opencv_Test2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사각형찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xOR비교검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxArray1 = new Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(this.components);
            this.pictureBoxIpl3 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxIpl4 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxIpl5 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxIpl6 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.웹캠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.웹캠ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(12, 129);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(457, 392);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            this.pictureBoxIpl1.Click += new System.EventHandler(this.pictureBoxIpl1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.변환ToolStripMenuItem,
            this.사각형찾기ToolStripMenuItem,
            this.검출ToolStripMenuItem,
            this.웹캠ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            this.파일ToolStripMenuItem.Click += new System.EventHandler(this.파일ToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstImageToolStripMenuItem,
            this.secondImageToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click_1);
            // 
            // firstImageToolStripMenuItem
            // 
            this.firstImageToolStripMenuItem.Name = "firstImageToolStripMenuItem";
            this.firstImageToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.firstImageToolStripMenuItem.Text = "First Image";
            this.firstImageToolStripMenuItem.Click += new System.EventHandler(this.firstImageToolStripMenuItem_Click);
            // 
            // secondImageToolStripMenuItem
            // 
            this.secondImageToolStripMenuItem.Name = "secondImageToolStripMenuItem";
            this.secondImageToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.secondImageToolStripMenuItem.Text = "Second Image";
            this.secondImageToolStripMenuItem.Click += new System.EventHandler(this.secondImageToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // 변환ToolStripMenuItem
            // 
            this.변환ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayToolStripMenuItem,
            this.cannyToolStripMenuItem,
            this.adThresholdToolStripMenuItem});
            this.변환ToolStripMenuItem.Name = "변환ToolStripMenuItem";
            this.변환ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.변환ToolStripMenuItem.Text = "변환";
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            // 
            // adThresholdToolStripMenuItem
            // 
            this.adThresholdToolStripMenuItem.Name = "adThresholdToolStripMenuItem";
            this.adThresholdToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.adThresholdToolStripMenuItem.Text = "AdThreshold";
            this.adThresholdToolStripMenuItem.Click += new System.EventHandler(this.adThresholdToolStripMenuItem_Click);
            // 
            // 사각형찾기ToolStripMenuItem
            // 
            this.사각형찾기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contourToolStripMenuItem,
            this.squareToolStripMenuItem});
            this.사각형찾기ToolStripMenuItem.Name = "사각형찾기ToolStripMenuItem";
            this.사각형찾기ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.사각형찾기ToolStripMenuItem.Text = "사각형찾기";
            this.사각형찾기ToolStripMenuItem.Click += new System.EventHandler(this.사각형찾기ToolStripMenuItem_Click);
            // 
            // contourToolStripMenuItem
            // 
            this.contourToolStripMenuItem.Name = "contourToolStripMenuItem";
            this.contourToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.contourToolStripMenuItem.Text = "Contour";
            this.contourToolStripMenuItem.Click += new System.EventHandler(this.contourToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // 검출ToolStripMenuItem
            // 
            this.검출ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xOR비교검출ToolStripMenuItem});
            this.검출ToolStripMenuItem.Name = "검출ToolStripMenuItem";
            this.검출ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.검출ToolStripMenuItem.Text = "검출";
            // 
            // xOR비교검출ToolStripMenuItem
            // 
            this.xOR비교검출ToolStripMenuItem.Name = "xOR비교검출ToolStripMenuItem";
            this.xOR비교검출ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xOR비교검출ToolStripMenuItem.Text = "XOR비교 검출";
            this.xOR비교검출ToolStripMenuItem.Click += new System.EventHandler(this.xOR비교검출ToolStripMenuItem_Click);
            // 
            // pictureBoxIpl2
            // 
            this.pictureBoxIpl2.Location = new System.Drawing.Point(854, 129);
            this.pictureBoxIpl2.Name = "pictureBoxIpl2";
            this.pictureBoxIpl2.Size = new System.Drawing.Size(457, 329);
            this.pictureBoxIpl2.TabIndex = 2;
            this.pictureBoxIpl2.TabStop = false;
            this.pictureBoxIpl2.Click += new System.EventHandler(this.pictureBoxIpl2_Click);
            // 
            // pictureBoxIpl3
            // 
            this.pictureBoxIpl3.Location = new System.Drawing.Point(104, 543);
            this.pictureBoxIpl3.Name = "pictureBoxIpl3";
            this.pictureBoxIpl3.Size = new System.Drawing.Size(273, 188);
            this.pictureBoxIpl3.TabIndex = 3;
            this.pictureBoxIpl3.TabStop = false;
            this.pictureBoxIpl3.Click += new System.EventHandler(this.pictureBoxIpl3_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // pictureBoxIpl4
            // 
            this.pictureBoxIpl4.Location = new System.Drawing.Point(516, 26);
            this.pictureBoxIpl4.Name = "pictureBoxIpl4";
            this.pictureBoxIpl4.Size = new System.Drawing.Size(254, 229);
            this.pictureBoxIpl4.TabIndex = 4;
            this.pictureBoxIpl4.TabStop = false;
            this.pictureBoxIpl4.Click += new System.EventHandler(this.pictureBoxIpl4_Click);
            // 
            // pictureBoxIpl5
            // 
            this.pictureBoxIpl5.Location = new System.Drawing.Point(516, 257);
            this.pictureBoxIpl5.Name = "pictureBoxIpl5";
            this.pictureBoxIpl5.Size = new System.Drawing.Size(254, 249);
            this.pictureBoxIpl5.TabIndex = 5;
            this.pictureBoxIpl5.TabStop = false;
            this.pictureBoxIpl5.Click += new System.EventHandler(this.pictureBoxIpl5_Click);
            // 
            // pictureBoxIpl6
            // 
            this.pictureBoxIpl6.Location = new System.Drawing.Point(516, 508);
            this.pictureBoxIpl6.Name = "pictureBoxIpl6";
            this.pictureBoxIpl6.Size = new System.Drawing.Size(254, 249);
            this.pictureBoxIpl6.TabIndex = 6;
            this.pictureBoxIpl6.TabStop = false;
            this.pictureBoxIpl6.Click += new System.EventHandler(this.pictureBoxIpl6_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(907, 27);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(359, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(907, 69);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(359, 45);
            this.trackBar2.TabIndex = 8;
            // 
            // 웹캠ToolStripMenuItem
            // 
            this.웹캠ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.웹캠ToolStripMenuItem1});
            this.웹캠ToolStripMenuItem.Name = "웹캠ToolStripMenuItem";
            this.웹캠ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.웹캠ToolStripMenuItem.Text = "웹캠";
            // 
            // 웹캠ToolStripMenuItem1
            // 
            this.웹캠ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem,
            this.정지ToolStripMenuItem});
            this.웹캠ToolStripMenuItem1.Name = "웹캠ToolStripMenuItem1";
            this.웹캠ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.웹캠ToolStripMenuItem1.Text = "웹캠";
            // 
            // 시작ToolStripMenuItem
            // 
            this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
            this.시작ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.시작ToolStripMenuItem.Text = "시작";
            this.시작ToolStripMenuItem.Click += new System.EventHandler(this.시작ToolStripMenuItem_Click);
            // 
            // 정지ToolStripMenuItem
            // 
            this.정지ToolStripMenuItem.Name = "정지ToolStripMenuItem";
            this.정지ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.정지ToolStripMenuItem.Text = "정지";
            this.정지ToolStripMenuItem.Click += new System.EventHandler(this.정지ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 759);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBoxIpl6);
            this.Controls.Add(this.pictureBoxIpl5);
            this.Controls.Add(this.pictureBoxIpl4);
            this.Controls.Add(this.pictureBoxIpl3);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArray1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사각형찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contourToolStripMenuItem;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private System.Windows.Forms.ToolStripMenuItem 변환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 검출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xOR비교검출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondImageToolStripMenuItem;
        private Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray pictureBoxArray1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem adThresholdToolStripMenuItem;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl4;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl5;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.ToolStripMenuItem 웹캠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 웹캠ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정지ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

