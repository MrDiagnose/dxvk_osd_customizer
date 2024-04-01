
namespace dxvk_osd_customizer
{
    partial class FormDxvk
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
            this.checkBoxFrameLimit = new System.Windows.Forms.CheckBox();
            this.checkBoxAsync = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.numericUpDownFrameLimit = new System.Windows.Forms.NumericUpDown();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.comboBoxDxvk = new System.Windows.Forms.ComboBox();
            this.comboBoxBit = new System.Windows.Forms.ComboBox();
            this.openFileDialogGame = new System.Windows.Forms.OpenFileDialog();
            this.listBoxGame = new System.Windows.Forms.ListBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrameLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxDevinfo
            // 
            this.checkBoxDevinfo.AutoSize = true;
            this.checkBoxDevinfo.Location = new System.Drawing.Point(139, 51);
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
            this.checkBoxfps.Location = new System.Drawing.Point(30, 76);
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
            this.checkBoxGpuload.Location = new System.Drawing.Point(76, 99);
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
            this.checkBoxVersion.Location = new System.Drawing.Point(138, 74);
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
            this.checkBoxframetime.Location = new System.Drawing.Point(285, 72);
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
            this.checkBoxCompiler.Location = new System.Drawing.Point(367, 73);
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
            this.checkBoxSubmissions.Location = new System.Drawing.Point(445, 73);
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
            this.checkBoxDrawcalls.Location = new System.Drawing.Point(445, 99);
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
            this.checkBoxPipelines.Location = new System.Drawing.Point(203, 73);
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
            this.checkBoxDescriptors.Location = new System.Drawing.Point(533, 73);
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
            this.checkBoxMemory.Location = new System.Drawing.Point(138, 99);
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
            this.checkBoxApi.Location = new System.Drawing.Point(30, 99);
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
            this.checkBoxCS.Location = new System.Drawing.Point(76, 74);
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
            this.checkBoxSamplers.Location = new System.Drawing.Point(367, 99);
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
            this.checkBoxScaleX.Location = new System.Drawing.Point(208, 99);
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
            this.checkBoxOpacityY.Location = new System.Drawing.Point(285, 99);
            this.checkBoxOpacityY.Name = "checkBoxOpacityY";
            this.checkBoxOpacityY.Size = new System.Drawing.Size(71, 17);
            this.checkBoxOpacityY.TabIndex = 15;
            this.checkBoxOpacityY.Text = "opacity=y";
            this.toolTipDxvk.SetToolTip(this.checkBoxOpacityY, "Adjusts the HUD opacity by a factor of y (e.g. 0.5, 1.0 being fully opaque).");
            this.checkBoxOpacityY.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrameLimit
            // 
            this.checkBoxFrameLimit.AutoSize = true;
            this.checkBoxFrameLimit.Location = new System.Drawing.Point(206, 50);
            this.checkBoxFrameLimit.Name = "checkBoxFrameLimit";
            this.checkBoxFrameLimit.Size = new System.Drawing.Size(76, 17);
            this.checkBoxFrameLimit.TabIndex = 21;
            this.checkBoxFrameLimit.Text = "FrameLimit";
            this.toolTipDxvk.SetToolTip(this.checkBoxFrameLimit, "Set Frame Limit 0 means uncapped");
            this.checkBoxFrameLimit.UseVisualStyleBackColor = true;
            // 
            // checkBoxAsync
            // 
            this.checkBoxAsync.AutoSize = true;
            this.checkBoxAsync.Checked = true;
            this.checkBoxAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAsync.Location = new System.Drawing.Point(30, 51);
            this.checkBoxAsync.Name = "checkBoxAsync";
            this.checkBoxAsync.Size = new System.Drawing.Size(54, 17);
            this.checkBoxAsync.TabIndex = 22;
            this.checkBoxAsync.Text = "async";
            this.toolTipDxvk.SetToolTip(this.checkBoxAsync, "disable async");
            this.checkBoxAsync.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(535, 122);
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
            this.checkBoxSelectAll.Location = new System.Drawing.Point(533, 99);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.checkBoxSelectAll.TabIndex = 17;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // numericUpDownFrameLimit
            // 
            this.numericUpDownFrameLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFrameLimit.Location = new System.Drawing.Point(288, 46);
            this.numericUpDownFrameLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFrameLimit.Name = "numericUpDownFrameLimit";
            this.numericUpDownFrameLimit.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFrameLimit.TabIndex = 20;
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(323, 349);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(75, 23);
            this.buttonInstall.TabIndex = 24;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // comboBoxDxvk
            // 
            this.comboBoxDxvk.FormattingEnabled = true;
            this.comboBoxDxvk.Items.AddRange(new object[] {
            "dxvk",
            "dxvk-async"});
            this.comboBoxDxvk.Location = new System.Drawing.Point(35, 349);
            this.comboBoxDxvk.Name = "comboBoxDxvk";
            this.comboBoxDxvk.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDxvk.TabIndex = 25;
            this.comboBoxDxvk.Text = "Dxvk version";
            // 
            // comboBoxBit
            // 
            this.comboBoxBit.FormattingEnabled = true;
            this.comboBoxBit.Items.AddRange(new object[] {
            "32 bit",
            "64 bit"});
            this.comboBoxBit.Location = new System.Drawing.Point(177, 349);
            this.comboBoxBit.Name = "comboBoxBit";
            this.comboBoxBit.Size = new System.Drawing.Size(52, 21);
            this.comboBoxBit.TabIndex = 26;
            this.comboBoxBit.Text = "Bit";
            // 
            // openFileDialogGame
            // 
            this.openFileDialogGame.FileName = "openFileDialog1";
            // 
            // listBoxGame
            // 
            this.listBoxGame.AllowDrop = true;
            this.listBoxGame.FormattingEnabled = true;
            this.listBoxGame.Location = new System.Drawing.Point(35, 231);
            this.listBoxGame.Name = "listBoxGame";
            this.listBoxGame.Size = new System.Drawing.Size(444, 95);
            this.listBoxGame.TabIndex = 27;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(485, 303);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(47, 23);
            this.buttonRun.TabIndex = 28;
            this.buttonRun.Text = "run";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Location = new System.Drawing.Point(404, 349);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(75, 23);
            this.buttonUninstall.TabIndex = 29;
            this.buttonUninstall.Text = "Uninstall";
            this.buttonUninstall.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(501, 265);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(30, 29);
            this.buttonRemove.TabIndex = 30;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(501, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(30, 23);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FormDxvk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonUninstall);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.listBoxGame);
            this.Controls.Add(this.comboBoxBit);
            this.Controls.Add(this.comboBoxDxvk);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.checkBoxAsync);
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
            this.Name = "FormDxvk";
            this.Text = "dxvk OSD customizer 1.0";
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
        private System.Windows.Forms.CheckBox checkBoxAsync;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.ComboBox comboBoxDxvk;
        private System.Windows.Forms.ComboBox comboBoxBit;
        private System.Windows.Forms.OpenFileDialog openFileDialogGame;
        private System.Windows.Forms.ListBox listBoxGame;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonUninstall;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
    }
}

