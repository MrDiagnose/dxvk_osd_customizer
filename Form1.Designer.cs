
namespace dxvk_osd_customizer
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
            this.checkBoxDevinfo = new System.Windows.Forms.CheckBox();
            this.checkBoxfps = new System.Windows.Forms.CheckBox();
            this.checkBoxGpuload = new System.Windows.Forms.CheckBox();
            this.checkBoxVersion = new System.Windows.Forms.CheckBox();
            this.checkBoxframetime = new System.Windows.Forms.CheckBox();
            this.checkBoxCompiler = new System.Windows.Forms.CheckBox();
            this.checkBoxSubmissions = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawcalls = new System.Windows.Forms.CheckBox();
            this.checkBoxPipelines = new System.Windows.Forms.CheckBox();
            this.checkBoxDescriptors = new System.Windows.Forms.CheckBox();
            this.checkBoxMemory = new System.Windows.Forms.CheckBox();
            this.checkBoxApi = new System.Windows.Forms.CheckBox();
            this.checkBoxCS = new System.Windows.Forms.CheckBox();
            this.checkBoxSamplers = new System.Windows.Forms.CheckBox();
            this.checkBoxScaleX = new System.Windows.Forms.CheckBox();
            this.checkBoxOpacityY = new System.Windows.Forms.CheckBox();
            this.toolTipDxvk = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCreate = new System.Windows.Forms.Button();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.numericUpDownFrameLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFrameLimit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrameLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxDevinfo
            // 
            this.checkBoxDevinfo.AutoSize = true;
            this.checkBoxDevinfo.Location = new System.Drawing.Point(46, 44);
            this.checkBoxDevinfo.Name = "checkBoxDevinfo";
            this.checkBoxDevinfo.Size = new System.Drawing.Size(61, 17);
            this.checkBoxDevinfo.TabIndex = 0;
            this.checkBoxDevinfo.Text = "devinfo";
            this.toolTipDxvk.SetToolTip(this.checkBoxDevinfo, "Displays the name of the GPU and the driver version");
            this.checkBoxDevinfo.UseVisualStyleBackColor = true;
            // 
            // checkBoxfps
            // 
            this.checkBoxfps.AutoSize = true;
            this.checkBoxfps.Location = new System.Drawing.Point(46, 67);
            this.checkBoxfps.Name = "checkBoxfps";
            this.checkBoxfps.Size = new System.Drawing.Size(40, 17);
            this.checkBoxfps.TabIndex = 1;
            this.checkBoxfps.Text = "fps";
            this.toolTipDxvk.SetToolTip(this.checkBoxfps, "Shows the current frame rate.");
            this.checkBoxfps.UseVisualStyleBackColor = true;
            // 
            // checkBoxGpuload
            // 
            this.checkBoxGpuload.AutoSize = true;
            this.checkBoxGpuload.Location = new System.Drawing.Point(46, 90);
            this.checkBoxGpuload.Name = "checkBoxGpuload";
            this.checkBoxGpuload.Size = new System.Drawing.Size(64, 17);
            this.checkBoxGpuload.TabIndex = 2;
            this.checkBoxGpuload.Text = "gpuload";
            this.toolTipDxvk.SetToolTip(this.checkBoxGpuload, "Shows estimated GPU load. May be inaccurate.");
            this.checkBoxGpuload.UseVisualStyleBackColor = true;
            // 
            // checkBoxVersion
            // 
            this.checkBoxVersion.AutoSize = true;
            this.checkBoxVersion.Location = new System.Drawing.Point(46, 113);
            this.checkBoxVersion.Name = "checkBoxVersion";
            this.checkBoxVersion.Size = new System.Drawing.Size(60, 17);
            this.checkBoxVersion.TabIndex = 3;
            this.checkBoxVersion.Text = "version";
            this.toolTipDxvk.SetToolTip(this.checkBoxVersion, "Shows DXVK version.");
            this.checkBoxVersion.UseVisualStyleBackColor = true;
            // 
            // checkBoxframetime
            // 
            this.checkBoxframetime.AutoSize = true;
            this.checkBoxframetime.Location = new System.Drawing.Point(46, 136);
            this.checkBoxframetime.Name = "checkBoxframetime";
            this.checkBoxframetime.Size = new System.Drawing.Size(71, 17);
            this.checkBoxframetime.TabIndex = 4;
            this.checkBoxframetime.Text = "frametime";
            this.toolTipDxvk.SetToolTip(this.checkBoxframetime, "Shows a frame time graph.");
            this.checkBoxframetime.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompiler
            // 
            this.checkBoxCompiler.AutoSize = true;
            this.checkBoxCompiler.Location = new System.Drawing.Point(46, 159);
            this.checkBoxCompiler.Name = "checkBoxCompiler";
            this.checkBoxCompiler.Size = new System.Drawing.Size(65, 17);
            this.checkBoxCompiler.TabIndex = 5;
            this.checkBoxCompiler.Text = "compiler";
            this.toolTipDxvk.SetToolTip(this.checkBoxCompiler, "Shows shader compiler activity");
            this.checkBoxCompiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubmissions
            // 
            this.checkBoxSubmissions.AutoSize = true;
            this.checkBoxSubmissions.Location = new System.Drawing.Point(46, 182);
            this.checkBoxSubmissions.Name = "checkBoxSubmissions";
            this.checkBoxSubmissions.Size = new System.Drawing.Size(82, 17);
            this.checkBoxSubmissions.TabIndex = 6;
            this.checkBoxSubmissions.Text = "submissions";
            this.toolTipDxvk.SetToolTip(this.checkBoxSubmissions, "Shows the number of command buffers submitted per frame.");
            this.checkBoxSubmissions.UseVisualStyleBackColor = true;
            // 
            // checkBoxDrawcalls
            // 
            this.checkBoxDrawcalls.AutoSize = true;
            this.checkBoxDrawcalls.Location = new System.Drawing.Point(46, 205);
            this.checkBoxDrawcalls.Name = "checkBoxDrawcalls";
            this.checkBoxDrawcalls.Size = new System.Drawing.Size(70, 17);
            this.checkBoxDrawcalls.TabIndex = 7;
            this.checkBoxDrawcalls.Text = "drawcalls";
            this.toolTipDxvk.SetToolTip(this.checkBoxDrawcalls, "Shows the number of draw calls and render passes per frame.");
            this.checkBoxDrawcalls.UseVisualStyleBackColor = true;
            // 
            // checkBoxPipelines
            // 
            this.checkBoxPipelines.AutoSize = true;
            this.checkBoxPipelines.Location = new System.Drawing.Point(46, 228);
            this.checkBoxPipelines.Name = "checkBoxPipelines";
            this.checkBoxPipelines.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPipelines.TabIndex = 8;
            this.checkBoxPipelines.Text = "pipelines";
            this.toolTipDxvk.SetToolTip(this.checkBoxPipelines, "Shows the total number of graphics and compute pipelines.");
            this.checkBoxPipelines.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescriptors
            // 
            this.checkBoxDescriptors.AutoSize = true;
            this.checkBoxDescriptors.Location = new System.Drawing.Point(46, 251);
            this.checkBoxDescriptors.Name = "checkBoxDescriptors";
            this.checkBoxDescriptors.Size = new System.Drawing.Size(77, 17);
            this.checkBoxDescriptors.TabIndex = 9;
            this.checkBoxDescriptors.Text = "descriptors";
            this.toolTipDxvk.SetToolTip(this.checkBoxDescriptors, "Shows the number of descriptor pools and descriptor sets.");
            this.checkBoxDescriptors.UseVisualStyleBackColor = true;
            // 
            // checkBoxMemory
            // 
            this.checkBoxMemory.AutoSize = true;
            this.checkBoxMemory.Location = new System.Drawing.Point(46, 274);
            this.checkBoxMemory.Name = "checkBoxMemory";
            this.checkBoxMemory.Size = new System.Drawing.Size(62, 17);
            this.checkBoxMemory.TabIndex = 10;
            this.checkBoxMemory.Text = "memory";
            this.toolTipDxvk.SetToolTip(this.checkBoxMemory, "Shows the amount of device memory allocated and used.");
            this.checkBoxMemory.UseVisualStyleBackColor = true;
            // 
            // checkBoxApi
            // 
            this.checkBoxApi.AutoSize = true;
            this.checkBoxApi.Location = new System.Drawing.Point(46, 297);
            this.checkBoxApi.Name = "checkBoxApi";
            this.checkBoxApi.Size = new System.Drawing.Size(40, 17);
            this.checkBoxApi.TabIndex = 11;
            this.checkBoxApi.Text = "api";
            this.toolTipDxvk.SetToolTip(this.checkBoxApi, "Shows the D3D feature level used by the application.");
            this.checkBoxApi.UseVisualStyleBackColor = true;
            // 
            // checkBoxCS
            // 
            this.checkBoxCS.AutoSize = true;
            this.checkBoxCS.Location = new System.Drawing.Point(46, 321);
            this.checkBoxCS.Name = "checkBoxCS";
            this.checkBoxCS.Size = new System.Drawing.Size(37, 17);
            this.checkBoxCS.TabIndex = 12;
            this.checkBoxCS.Text = "cs";
            this.toolTipDxvk.SetToolTip(this.checkBoxCS, "Shows worker thread statistics.");
            this.checkBoxCS.UseVisualStyleBackColor = true;
            // 
            // checkBoxSamplers
            // 
            this.checkBoxSamplers.AutoSize = true;
            this.checkBoxSamplers.Location = new System.Drawing.Point(46, 344);
            this.checkBoxSamplers.Name = "checkBoxSamplers";
            this.checkBoxSamplers.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSamplers.TabIndex = 13;
            this.checkBoxSamplers.Text = "samplers";
            this.toolTipDxvk.SetToolTip(this.checkBoxSamplers, "Shows the current number of sampler pairs used [D3D9 Only]");
            this.checkBoxSamplers.UseVisualStyleBackColor = true;
            // 
            // checkBoxScaleX
            // 
            this.checkBoxScaleX.AutoSize = true;
            this.checkBoxScaleX.Location = new System.Drawing.Point(46, 367);
            this.checkBoxScaleX.Name = "checkBoxScaleX";
            this.checkBoxScaleX.Size = new System.Drawing.Size(62, 17);
            this.checkBoxScaleX.TabIndex = 14;
            this.checkBoxScaleX.Text = "scale=x";
            this.toolTipDxvk.SetToolTip(this.checkBoxScaleX, "Scales the HUD by a factor of x (e.g. 1.5)");
            this.checkBoxScaleX.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpacityY
            // 
            this.checkBoxOpacityY.AutoSize = true;
            this.checkBoxOpacityY.Location = new System.Drawing.Point(46, 390);
            this.checkBoxOpacityY.Name = "checkBoxOpacityY";
            this.checkBoxOpacityY.Size = new System.Drawing.Size(71, 17);
            this.checkBoxOpacityY.TabIndex = 15;
            this.checkBoxOpacityY.Text = "opacity=y";
            this.toolTipDxvk.SetToolTip(this.checkBoxOpacityY, "Adjusts the HUD opacity by a factor of y (e.g. 0.5, 1.0 being fully opaque).");
            this.checkBoxOpacityY.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(272, 415);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(220, 55);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.checkBoxSelectAll.TabIndex = 17;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFrameLimit
            // 
            this.numericUpDownFrameLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFrameLimit.Location = new System.Drawing.Point(292, 106);
            this.numericUpDownFrameLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFrameLimit.Name = "numericUpDownFrameLimit";
            this.numericUpDownFrameLimit.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFrameLimit.TabIndex = 20;
            // 
            // checkBoxFrameLimit
            // 
            this.checkBoxFrameLimit.AutoSize = true;
            this.checkBoxFrameLimit.Location = new System.Drawing.Point(210, 106);
            this.checkBoxFrameLimit.Name = "checkBoxFrameLimit";
            this.checkBoxFrameLimit.Size = new System.Drawing.Size(76, 17);
            this.checkBoxFrameLimit.TabIndex = 21;
            this.checkBoxFrameLimit.Text = "FrameLimit";
            this.toolTipDxvk.SetToolTip(this.checkBoxFrameLimit, "Set Frame Limit 0 means uncapped");
            this.checkBoxFrameLimit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.checkBoxFrameLimit);
            this.Controls.Add(this.numericUpDownFrameLimit);
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.checkBoxOpacityY);
            this.Controls.Add(this.checkBoxScaleX);
            this.Controls.Add(this.checkBoxSamplers);
            this.Controls.Add(this.checkBoxCS);
            this.Controls.Add(this.checkBoxApi);
            this.Controls.Add(this.checkBoxMemory);
            this.Controls.Add(this.checkBoxDescriptors);
            this.Controls.Add(this.checkBoxPipelines);
            this.Controls.Add(this.checkBoxDrawcalls);
            this.Controls.Add(this.checkBoxSubmissions);
            this.Controls.Add(this.checkBoxCompiler);
            this.Controls.Add(this.checkBoxframetime);
            this.Controls.Add(this.checkBoxVersion);
            this.Controls.Add(this.checkBoxGpuload);
            this.Controls.Add(this.checkBoxfps);
            this.Controls.Add(this.checkBoxDevinfo);
            this.Name = "Form1";
            this.Text = "dxvk OSD customizer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrameLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDevinfo;
        private System.Windows.Forms.CheckBox checkBoxfps;
        private System.Windows.Forms.CheckBox checkBoxGpuload;
        private System.Windows.Forms.CheckBox checkBoxVersion;
        private System.Windows.Forms.CheckBox checkBoxframetime;
        private System.Windows.Forms.CheckBox checkBoxCompiler;
        private System.Windows.Forms.CheckBox checkBoxSubmissions;
        private System.Windows.Forms.CheckBox checkBoxDrawcalls;
        private System.Windows.Forms.CheckBox checkBoxPipelines;
        private System.Windows.Forms.CheckBox checkBoxDescriptors;
        private System.Windows.Forms.CheckBox checkBoxMemory;
        private System.Windows.Forms.CheckBox checkBoxApi;
        private System.Windows.Forms.CheckBox checkBoxCS;
        private System.Windows.Forms.CheckBox checkBoxSamplers;
        private System.Windows.Forms.CheckBox checkBoxScaleX;
        private System.Windows.Forms.CheckBox checkBoxOpacityY;
        private System.Windows.Forms.ToolTip toolTipDxvk;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.NumericUpDown numericUpDownFrameLimit;
        private System.Windows.Forms.CheckBox checkBoxFrameLimit;
    }
}

