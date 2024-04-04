
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
            this.checkBoxfps = new System.Windows.Forms.CheckBox();
            this.toolTipDxvk = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonSaveList = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxDxvk = new System.Windows.Forms.ComboBox();
            this.comboBoxBit = new System.Windows.Forms.ComboBox();
            this.openFileDialogGame = new System.Windows.Forms.OpenFileDialog();
            this.listBoxGame = new System.Windows.Forms.ListBox();
            this.checkBoxSamplers = new System.Windows.Forms.CheckBox();
            this.checkBoxCS = new System.Windows.Forms.CheckBox();
            this.checkBoxApi = new System.Windows.Forms.CheckBox();
            this.checkBoxMemory = new System.Windows.Forms.CheckBox();
            this.checkBoxDescriptors = new System.Windows.Forms.CheckBox();
            this.checkBoxPipelines = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawcalls = new System.Windows.Forms.CheckBox();
            this.checkBoxSubmissions = new System.Windows.Forms.CheckBox();
            this.checkBoxCompiler = new System.Windows.Forms.CheckBox();
            this.checkBoxVersion = new System.Windows.Forms.CheckBox();
            this.checkBoxGpuload = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxScaleX = new System.Windows.Forms.CheckBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.checkBoxOpacityY = new System.Windows.Forms.CheckBox();
            this.checkBoxframetime = new System.Windows.Forms.CheckBox();
            this.checkBoxFrameLimit = new System.Windows.Forms.CheckBox();
            this.numericUpDownFrameLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDevinfo = new System.Windows.Forms.CheckBox();
            this.checkBoxAsync = new System.Windows.Forms.CheckBox();
            this.groupBoxBasic = new System.Windows.Forms.GroupBox();
            this.groupBoxAdvanced = new System.Windows.Forms.GroupBox();
            this.groupBoxHudSize = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrameLimit)).BeginInit();
            this.groupBoxBasic.SuspendLayout();
            this.groupBoxAdvanced.SuspendLayout();
            this.groupBoxHudSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxfps
            // 
            this.checkBoxfps.AutoSize = true;
            this.checkBoxfps.Location = new System.Drawing.Point(6, 42);
            this.checkBoxfps.Name = "checkBoxfps";
            this.checkBoxfps.Size = new System.Drawing.Size(40, 17);
            this.checkBoxfps.TabIndex = 1;
            this.checkBoxfps.Text = "fps";
            this.toolTipDxvk.SetToolTip(this.checkBoxfps, "Shows the current frame rate.");
            this.checkBoxfps.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(162, 205);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(72, 23);
            this.buttonRun.TabIndex = 28;
            this.buttonRun.Text = "run";
            this.toolTipDxvk.SetToolTip(this.buttonRun, "not implemented");
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonSaveList
            // 
            this.buttonSaveList.Location = new System.Drawing.Point(6, 205);
            this.buttonSaveList.Name = "buttonSaveList";
            this.buttonSaveList.Size = new System.Drawing.Size(72, 23);
            this.buttonSaveList.TabIndex = 31;
            this.buttonSaveList.Text = "Save List";
            this.toolTipDxvk.SetToolTip(this.buttonSaveList, "Save your game list");
            this.buttonSaveList.UseVisualStyleBackColor = true;
            this.buttonSaveList.Click += new System.EventHandler(this.buttonSaveList_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(208, 196);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Apply";
            this.toolTipDxvk.SetToolTip(this.buttonCreate, "creates dxvk.config");
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(240, 205);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(75, 23);
            this.buttonInstall.TabIndex = 24;
            this.buttonInstall.Text = "Install";
            this.toolTipDxvk.SetToolTip(this.buttonInstall, "install dxvk");
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Location = new System.Drawing.Point(321, 205);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(75, 23);
            this.buttonUninstall.TabIndex = 29;
            this.buttonUninstall.Text = "Uninstall";
            this.toolTipDxvk.SetToolTip(this.buttonUninstall, "remove dxvk");
            this.buttonUninstall.UseVisualStyleBackColor = true;
            this.buttonUninstall.Click += new System.EventHandler(this.buttonUninstall_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(84, 205);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(72, 23);
            this.buttonRemove.TabIndex = 30;
            this.buttonRemove.Text = "Remove Game";
            this.toolTipDxvk.SetToolTip(this.buttonRemove, "remove selected item");
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxDxvk
            // 
            this.comboBoxDxvk.FormattingEnabled = true;
            this.comboBoxDxvk.Items.AddRange(new object[] {
            "dxvk",
            "dxvk-async"});
            this.comboBoxDxvk.Location = new System.Drawing.Point(6, 178);
            this.comboBoxDxvk.Name = "comboBoxDxvk";
            this.comboBoxDxvk.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDxvk.TabIndex = 25;
            this.comboBoxDxvk.Text = "Dxvk version";
            this.toolTipDxvk.SetToolTip(this.comboBoxDxvk, "Select dxvk / dxvk-async");
            // 
            // comboBoxBit
            // 
            this.comboBoxBit.FormattingEnabled = true;
            this.comboBoxBit.Items.AddRange(new object[] {
            "32 bit",
            "64 bit"});
            this.comboBoxBit.Location = new System.Drawing.Point(141, 178);
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
            this.listBoxGame.HorizontalScrollbar = true;
            this.listBoxGame.Location = new System.Drawing.Point(6, 12);
            this.listBoxGame.Name = "listBoxGame";
            this.listBoxGame.Size = new System.Drawing.Size(458, 160);
            this.listBoxGame.TabIndex = 27;
            this.toolTipDxvk.SetToolTip(this.listBoxGame, "Drag and Drop game exe here");
            // 
            // checkBoxSamplers
            // 
            this.checkBoxSamplers.AutoSize = true;
            this.checkBoxSamplers.Location = new System.Drawing.Point(93, 46);
            this.checkBoxSamplers.Name = "checkBoxSamplers";
            this.checkBoxSamplers.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSamplers.TabIndex = 34;
            this.checkBoxSamplers.Text = "samplers";
            this.toolTipDxvk.SetToolTip(this.checkBoxSamplers, "Shows the current number of sampler pairs used [D3D9 Only]");
            this.checkBoxSamplers.UseVisualStyleBackColor = true;
            // 
            // checkBoxCS
            // 
            this.checkBoxCS.AutoSize = true;
            this.checkBoxCS.Location = new System.Drawing.Point(93, 28);
            this.checkBoxCS.Name = "checkBoxCS";
            this.checkBoxCS.Size = new System.Drawing.Size(37, 17);
            this.checkBoxCS.TabIndex = 33;
            this.checkBoxCS.Text = "cs";
            this.toolTipDxvk.SetToolTip(this.checkBoxCS, "Shows worker thread statistics.");
            this.checkBoxCS.UseVisualStyleBackColor = true;
            // 
            // checkBoxApi
            // 
            this.checkBoxApi.AutoSize = true;
            this.checkBoxApi.Location = new System.Drawing.Point(158, 42);
            this.checkBoxApi.Name = "checkBoxApi";
            this.checkBoxApi.Size = new System.Drawing.Size(40, 17);
            this.checkBoxApi.TabIndex = 32;
            this.checkBoxApi.Text = "api";
            this.toolTipDxvk.SetToolTip(this.checkBoxApi, "Shows the D3D feature level used by the application.");
            this.checkBoxApi.UseVisualStyleBackColor = true;
            // 
            // checkBoxMemory
            // 
            this.checkBoxMemory.AutoSize = true;
            this.checkBoxMemory.Location = new System.Drawing.Point(90, 42);
            this.checkBoxMemory.Name = "checkBoxMemory";
            this.checkBoxMemory.Size = new System.Drawing.Size(62, 17);
            this.checkBoxMemory.TabIndex = 31;
            this.checkBoxMemory.Text = "memory";
            this.toolTipDxvk.SetToolTip(this.checkBoxMemory, "Shows the amount of device memory allocated and used.");
            this.checkBoxMemory.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescriptors
            // 
            this.checkBoxDescriptors.AutoSize = true;
            this.checkBoxDescriptors.Location = new System.Drawing.Point(10, 68);
            this.checkBoxDescriptors.Name = "checkBoxDescriptors";
            this.checkBoxDescriptors.Size = new System.Drawing.Size(77, 17);
            this.checkBoxDescriptors.TabIndex = 30;
            this.checkBoxDescriptors.Text = "descriptors";
            this.toolTipDxvk.SetToolTip(this.checkBoxDescriptors, "Shows the number of descriptor pools and descriptor sets.");
            this.checkBoxDescriptors.UseVisualStyleBackColor = true;
            // 
            // checkBoxPipelines
            // 
            this.checkBoxPipelines.AutoSize = true;
            this.checkBoxPipelines.Location = new System.Drawing.Point(10, 23);
            this.checkBoxPipelines.Name = "checkBoxPipelines";
            this.checkBoxPipelines.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPipelines.TabIndex = 29;
            this.checkBoxPipelines.Text = "pipelines";
            this.toolTipDxvk.SetToolTip(this.checkBoxPipelines, "Shows the total number of graphics and compute pipelines.");
            this.checkBoxPipelines.UseVisualStyleBackColor = true;
            // 
            // checkBoxDrawcalls
            // 
            this.checkBoxDrawcalls.AutoSize = true;
            this.checkBoxDrawcalls.Location = new System.Drawing.Point(11, 46);
            this.checkBoxDrawcalls.Name = "checkBoxDrawcalls";
            this.checkBoxDrawcalls.Size = new System.Drawing.Size(70, 17);
            this.checkBoxDrawcalls.TabIndex = 28;
            this.checkBoxDrawcalls.Text = "drawcalls";
            this.toolTipDxvk.SetToolTip(this.checkBoxDrawcalls, "Shows the number of draw calls and render passes per frame.");
            this.checkBoxDrawcalls.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubmissions
            // 
            this.checkBoxSubmissions.AutoSize = true;
            this.checkBoxSubmissions.Location = new System.Drawing.Point(93, 68);
            this.checkBoxSubmissions.Name = "checkBoxSubmissions";
            this.checkBoxSubmissions.Size = new System.Drawing.Size(82, 17);
            this.checkBoxSubmissions.TabIndex = 27;
            this.checkBoxSubmissions.Text = "submissions";
            this.toolTipDxvk.SetToolTip(this.checkBoxSubmissions, "Shows the number of command buffers submitted per frame.");
            this.checkBoxSubmissions.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompiler
            // 
            this.checkBoxCompiler.AutoSize = true;
            this.checkBoxCompiler.Location = new System.Drawing.Point(158, 65);
            this.checkBoxCompiler.Name = "checkBoxCompiler";
            this.checkBoxCompiler.Size = new System.Drawing.Size(65, 17);
            this.checkBoxCompiler.TabIndex = 26;
            this.checkBoxCompiler.Text = "compiler";
            this.toolTipDxvk.SetToolTip(this.checkBoxCompiler, "Shows shader compiler activity");
            this.checkBoxCompiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxVersion
            // 
            this.checkBoxVersion.AutoSize = true;
            this.checkBoxVersion.Location = new System.Drawing.Point(158, 19);
            this.checkBoxVersion.Name = "checkBoxVersion";
            this.checkBoxVersion.Size = new System.Drawing.Size(60, 17);
            this.checkBoxVersion.TabIndex = 24;
            this.checkBoxVersion.Text = "version";
            this.toolTipDxvk.SetToolTip(this.checkBoxVersion, "Shows DXVK version.");
            this.checkBoxVersion.UseVisualStyleBackColor = true;
            // 
            // checkBoxGpuload
            // 
            this.checkBoxGpuload.AutoSize = true;
            this.checkBoxGpuload.Location = new System.Drawing.Point(91, 65);
            this.checkBoxGpuload.Name = "checkBoxGpuload";
            this.checkBoxGpuload.Size = new System.Drawing.Size(64, 17);
            this.checkBoxGpuload.TabIndex = 23;
            this.checkBoxGpuload.Text = "gpuload";
            this.toolTipDxvk.SetToolTip(this.checkBoxGpuload, "Shows estimated GPU load. May be inaccurate.");
            this.checkBoxGpuload.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 263);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCreate);
            this.tabPage1.Controls.Add(this.groupBoxHudSize);
            this.tabPage1.Controls.Add(this.checkBoxSelectAll);
            this.tabPage1.Controls.Add(this.groupBoxAdvanced);
            this.tabPage1.Controls.Add(this.groupBoxBasic);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dxvk.conf";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxGame);
            this.tabPage2.Controls.Add(this.buttonSaveList);
            this.tabPage2.Controls.Add(this.buttonRemove);
            this.tabPage2.Controls.Add(this.buttonInstall);
            this.tabPage2.Controls.Add(this.buttonUninstall);
            this.tabPage2.Controls.Add(this.comboBoxDxvk);
            this.tabPage2.Controls.Add(this.buttonRun);
            this.tabPage2.Controls.Add(this.comboBoxBit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "dxvk";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxScaleX
            // 
            this.checkBoxScaleX.AutoSize = true;
            this.checkBoxScaleX.Location = new System.Drawing.Point(87, 19);
            this.checkBoxScaleX.Name = "checkBoxScaleX";
            this.checkBoxScaleX.Size = new System.Drawing.Size(62, 17);
            this.checkBoxScaleX.TabIndex = 35;
            this.checkBoxScaleX.Text = "scale=x";
            this.toolTipDxvk.SetToolTip(this.checkBoxScaleX, "Scales the HUD by a factor of x (e.g. 1.5)");
            this.checkBoxScaleX.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(132, 202);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.checkBoxSelectAll.TabIndex = 37;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged_1);
            // 
            // checkBoxOpacityY
            // 
            this.checkBoxOpacityY.AutoSize = true;
            this.checkBoxOpacityY.Location = new System.Drawing.Point(10, 19);
            this.checkBoxOpacityY.Name = "checkBoxOpacityY";
            this.checkBoxOpacityY.Size = new System.Drawing.Size(71, 17);
            this.checkBoxOpacityY.TabIndex = 36;
            this.checkBoxOpacityY.Text = "opacity=y";
            this.toolTipDxvk.SetToolTip(this.checkBoxOpacityY, "Adjusts the HUD opacity by a factor of y (e.g. 0.5, 1.0 being fully opaque).");
            this.checkBoxOpacityY.UseVisualStyleBackColor = true;
            // 
            // checkBoxframetime
            // 
            this.checkBoxframetime.AutoSize = true;
            this.checkBoxframetime.Location = new System.Drawing.Point(6, 65);
            this.checkBoxframetime.Name = "checkBoxframetime";
            this.checkBoxframetime.Size = new System.Drawing.Size(71, 17);
            this.checkBoxframetime.TabIndex = 25;
            this.checkBoxframetime.Text = "frametime";
            this.toolTipDxvk.SetToolTip(this.checkBoxframetime, "Shows a frame time graph.");
            this.checkBoxframetime.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrameLimit
            // 
            this.checkBoxFrameLimit.AutoSize = true;
            this.checkBoxFrameLimit.Location = new System.Drawing.Point(6, 88);
            this.checkBoxFrameLimit.Name = "checkBoxFrameLimit";
            this.checkBoxFrameLimit.Size = new System.Drawing.Size(76, 17);
            this.checkBoxFrameLimit.TabIndex = 21;
            this.checkBoxFrameLimit.Text = "FrameLimit";
            this.toolTipDxvk.SetToolTip(this.checkBoxFrameLimit, "Set Frame Limit 0 means uncapped");
            this.checkBoxFrameLimit.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFrameLimit
            // 
            this.numericUpDownFrameLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFrameLimit.Location = new System.Drawing.Point(91, 85);
            this.numericUpDownFrameLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFrameLimit.Name = "numericUpDownFrameLimit";
            this.numericUpDownFrameLimit.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFrameLimit.TabIndex = 38;
            // 
            // checkBoxDevinfo
            // 
            this.checkBoxDevinfo.AutoSize = true;
            this.checkBoxDevinfo.Location = new System.Drawing.Point(91, 19);
            this.checkBoxDevinfo.Name = "checkBoxDevinfo";
            this.checkBoxDevinfo.Size = new System.Drawing.Size(61, 17);
            this.checkBoxDevinfo.TabIndex = 0;
            this.checkBoxDevinfo.Text = "devinfo";
            this.toolTipDxvk.SetToolTip(this.checkBoxDevinfo, "Displays the name of the GPU and the driver version");
            this.checkBoxDevinfo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAsync
            // 
            this.checkBoxAsync.AutoSize = true;
            this.checkBoxAsync.Checked = true;
            this.checkBoxAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAsync.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAsync.Name = "checkBoxAsync";
            this.checkBoxAsync.Size = new System.Drawing.Size(54, 17);
            this.checkBoxAsync.TabIndex = 22;
            this.checkBoxAsync.Text = "async";
            this.toolTipDxvk.SetToolTip(this.checkBoxAsync, "disable async");
            this.checkBoxAsync.UseVisualStyleBackColor = true;
            // 
            // groupBoxBasic
            // 
            this.groupBoxBasic.Controls.Add(this.checkBoxAsync);
            this.groupBoxBasic.Controls.Add(this.checkBoxDevinfo);
            this.groupBoxBasic.Controls.Add(this.checkBoxMemory);
            this.groupBoxBasic.Controls.Add(this.checkBoxCompiler);
            this.groupBoxBasic.Controls.Add(this.checkBoxfps);
            this.groupBoxBasic.Controls.Add(this.checkBoxApi);
            this.groupBoxBasic.Controls.Add(this.checkBoxVersion);
            this.groupBoxBasic.Controls.Add(this.checkBoxGpuload);
            this.groupBoxBasic.Controls.Add(this.checkBoxframetime);
            this.groupBoxBasic.Controls.Add(this.numericUpDownFrameLimit);
            this.groupBoxBasic.Controls.Add(this.checkBoxFrameLimit);
            this.groupBoxBasic.Location = new System.Drawing.Point(19, 23);
            this.groupBoxBasic.Name = "groupBoxBasic";
            this.groupBoxBasic.Size = new System.Drawing.Size(233, 144);
            this.groupBoxBasic.TabIndex = 40;
            this.groupBoxBasic.TabStop = false;
            this.groupBoxBasic.Text = "Basic";
            // 
            // groupBoxAdvanced
            // 
            this.groupBoxAdvanced.Controls.Add(this.checkBoxPipelines);
            this.groupBoxAdvanced.Controls.Add(this.checkBoxDescriptors);
            this.groupBoxAdvanced.Controls.Add(this.checkBoxDrawcalls);
            this.groupBoxAdvanced.Controls.Add(this.checkBoxCS);
            this.groupBoxAdvanced.Controls.Add(this.checkBoxSubmissions);
            this.groupBoxAdvanced.Controls.Add(this.checkBoxSamplers);
            this.groupBoxAdvanced.Location = new System.Drawing.Point(258, 23);
            this.groupBoxAdvanced.Name = "groupBoxAdvanced";
            this.groupBoxAdvanced.Size = new System.Drawing.Size(184, 90);
            this.groupBoxAdvanced.TabIndex = 41;
            this.groupBoxAdvanced.TabStop = false;
            this.groupBoxAdvanced.Text = "Advanced";
            // 
            // groupBoxHudSize
            // 
            this.groupBoxHudSize.Controls.Add(this.checkBoxScaleX);
            this.groupBoxHudSize.Controls.Add(this.checkBoxOpacityY);
            this.groupBoxHudSize.Location = new System.Drawing.Point(258, 119);
            this.groupBoxHudSize.Name = "groupBoxHudSize";
            this.groupBoxHudSize.Size = new System.Drawing.Size(184, 48);
            this.groupBoxHudSize.TabIndex = 42;
            this.groupBoxHudSize.TabStop = false;
            this.groupBoxHudSize.Text = "Hud Size";
            // 
            // FormDxvk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 303);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FormDxvk";
            this.Text = "dxvk OSD customizer 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrameLimit)).EndInit();
            this.groupBoxBasic.ResumeLayout(false);
            this.groupBoxBasic.PerformLayout();
            this.groupBoxAdvanced.ResumeLayout(false);
            this.groupBoxAdvanced.PerformLayout();
            this.groupBoxHudSize.ResumeLayout(false);
            this.groupBoxHudSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxfps;
        private System.Windows.Forms.ToolTip toolTipDxvk;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.ComboBox comboBoxDxvk;
        private System.Windows.Forms.ComboBox comboBoxBit;
        private System.Windows.Forms.OpenFileDialog openFileDialogGame;
        private System.Windows.Forms.ListBox listBoxGame;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonUninstall;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSaveList;
        private System.Windows.Forms.CheckBox checkBoxSamplers;
        private System.Windows.Forms.CheckBox checkBoxCS;
        private System.Windows.Forms.CheckBox checkBoxApi;
        private System.Windows.Forms.CheckBox checkBoxMemory;
        private System.Windows.Forms.CheckBox checkBoxDescriptors;
        private System.Windows.Forms.CheckBox checkBoxPipelines;
        private System.Windows.Forms.CheckBox checkBoxDrawcalls;
        private System.Windows.Forms.CheckBox checkBoxSubmissions;
        private System.Windows.Forms.CheckBox checkBoxCompiler;
        private System.Windows.Forms.CheckBox checkBoxVersion;
        private System.Windows.Forms.CheckBox checkBoxGpuload;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxOpacityY;
        private System.Windows.Forms.CheckBox checkBoxScaleX;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.CheckBox checkBoxframetime;
        private System.Windows.Forms.NumericUpDown numericUpDownFrameLimit;
        private System.Windows.Forms.CheckBox checkBoxFrameLimit;
        private System.Windows.Forms.CheckBox checkBoxAsync;
        private System.Windows.Forms.CheckBox checkBoxDevinfo;
        private System.Windows.Forms.GroupBox groupBoxBasic;
        private System.Windows.Forms.GroupBox groupBoxAdvanced;
        private System.Windows.Forms.GroupBox groupBoxHudSize;
    }
}

