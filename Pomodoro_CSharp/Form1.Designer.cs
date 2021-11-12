﻿
namespace Pomodoro_CSharp
{
    partial class Pomodoro
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
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.btn35 = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(12, 12);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(140, 121);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5 Minutes";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(158, 12);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(140, 121);
            this.btn10.TabIndex = 1;
            this.btn10.Text = "10 Minutes";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Location = new System.Drawing.Point(304, 12);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(140, 121);
            this.btn15.TabIndex = 2;
            this.btn15.Text = "15 Minutes";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn30
            // 
            this.btn30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30.Location = new System.Drawing.Point(304, 139);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(140, 121);
            this.btn30.TabIndex = 5;
            this.btn30.Text = "30 Minutes";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn25
            // 
            this.btn25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn25.Location = new System.Drawing.Point(158, 139);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(140, 121);
            this.btn25.TabIndex = 4;
            this.btn25.Text = "25 Minutes";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(12, 139);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(140, 121);
            this.btn20.TabIndex = 3;
            this.btn20.Text = "20 Minutes";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn45
            // 
            this.btn45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn45.Location = new System.Drawing.Point(304, 266);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(140, 121);
            this.btn45.TabIndex = 8;
            this.btn45.Text = "45 Minutes";
            this.btn45.UseVisualStyleBackColor = true;
            this.btn45.Click += new System.EventHandler(this.btn45_Click);
            // 
            // btn40
            // 
            this.btn40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn40.Location = new System.Drawing.Point(158, 266);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(140, 121);
            this.btn40.TabIndex = 7;
            this.btn40.Text = "40 Minutes";
            this.btn40.UseVisualStyleBackColor = true;
            this.btn40.Click += new System.EventHandler(this.btn40_Click);
            // 
            // btn35
            // 
            this.btn35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn35.Location = new System.Drawing.Point(12, 266);
            this.btn35.Name = "btn35";
            this.btn35.Size = new System.Drawing.Size(140, 121);
            this.btn35.TabIndex = 6;
            this.btn35.Text = "35 Minutes";
            this.btn35.UseVisualStyleBackColor = true;
            this.btn35.Click += new System.EventHandler(this.btn35_Click);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(200, 406);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 24);
            this.lblTimeLeft.TabIndex = 9;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 439);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.btn45);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btn35);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.Name = "Pomodoro";
            this.Text = "Pomodoro Technique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer countdownTimer;
    }
}

