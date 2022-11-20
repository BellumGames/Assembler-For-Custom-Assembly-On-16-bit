namespace Asamblor
{
    partial class Emulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emulator));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.goBackToAssemblerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMicrocodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrBox = new System.Windows.Forms.TextBox();
            this.microBox = new System.Windows.Forms.TextBox();
            this.MDR_T = new System.Windows.Forms.Label();
            this.ADR_T = new System.Windows.Forms.Label();
            this.IR_T = new System.Windows.Forms.Label();
            this.R0_T = new System.Windows.Forms.Label();
            this.R1_T = new System.Windows.Forms.Label();
            this.R2_T = new System.Windows.Forms.Label();
            this.R3_T = new System.Windows.Forms.Label();
            this.R4_T = new System.Windows.Forms.Label();
            this.R5_T = new System.Windows.Forms.Label();
            this.R6_T = new System.Windows.Forms.Label();
            this.R7_T = new System.Windows.Forms.Label();
            this.R8_T = new System.Windows.Forms.Label();
            this.R9_T = new System.Windows.Forms.Label();
            this.R10_T = new System.Windows.Forms.Label();
            this.R11_T = new System.Windows.Forms.Label();
            this.R12_T = new System.Windows.Forms.Label();
            this.R13_T = new System.Windows.Forms.Label();
            this.R14_T = new System.Windows.Forms.Label();
            this.R15_T = new System.Windows.Forms.Label();
            this.FLAG_T = new System.Windows.Forms.Label();
            this.SP_T = new System.Windows.Forms.Label();
            this.T_T = new System.Windows.Forms.Label();
            this.IVR_T = new System.Windows.Forms.Label();
            this.PC_T = new System.Windows.Forms.Label();
            this.MDR_R = new System.Windows.Forms.Label();
            this.ADR_R = new System.Windows.Forms.Label();
            this.IR_R = new System.Windows.Forms.Label();
            this.R0_R = new System.Windows.Forms.Label();
            this.R1_R = new System.Windows.Forms.Label();
            this.R2_R = new System.Windows.Forms.Label();
            this.R3_R = new System.Windows.Forms.Label();
            this.R4_R = new System.Windows.Forms.Label();
            this.R5_R = new System.Windows.Forms.Label();
            this.R6_R = new System.Windows.Forms.Label();
            this.R7_R = new System.Windows.Forms.Label();
            this.R8_R = new System.Windows.Forms.Label();
            this.R9_R = new System.Windows.Forms.Label();
            this.R10_R = new System.Windows.Forms.Label();
            this.R11_R = new System.Windows.Forms.Label();
            this.R12_R = new System.Windows.Forms.Label();
            this.R13_R = new System.Windows.Forms.Label();
            this.R14_R = new System.Windows.Forms.Label();
            this.R15_R = new System.Windows.Forms.Label();
            this.PC_R = new System.Windows.Forms.Label();
            this.IVR_R = new System.Windows.Forms.Label();
            this.T_R = new System.Windows.Forms.Label();
            this.SP_R = new System.Windows.Forms.Label();
            this.FLAG_R = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ALU_T = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToAssemblerToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.runToEndToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.showMemToolStripMenuItem,
            this.openMicrocodeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1308, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // goBackToAssemblerToolStripMenuItem
            // 
            this.goBackToAssemblerToolStripMenuItem.Name = "goBackToAssemblerToolStripMenuItem";
            this.goBackToAssemblerToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.goBackToAssemblerToolStripMenuItem.Text = "Go Back To Assembler...";
            this.goBackToAssemblerToolStripMenuItem.Click += new System.EventHandler(this.goBackToAssemblerToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filesToolStripMenuItem.Text = "Files...";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.stepToolStripMenuItem.Text = "Step...";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // runToEndToolStripMenuItem
            // 
            this.runToEndToolStripMenuItem.Name = "runToEndToolStripMenuItem";
            this.runToEndToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.runToEndToolStripMenuItem.Text = "Run To End...";
            this.runToEndToolStripMenuItem.Click += new System.EventHandler(this.runToEndToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.resetToolStripMenuItem.Text = "Reset...";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // showMemToolStripMenuItem
            // 
            this.showMemToolStripMenuItem.Name = "showMemToolStripMenuItem";
            this.showMemToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.showMemToolStripMenuItem.Text = "Show Mem...";
            this.showMemToolStripMenuItem.Click += new System.EventHandler(this.showMemToolStripMenuItem_Click);
            // 
            // openMicrocodeToolStripMenuItem
            // 
            this.openMicrocodeToolStripMenuItem.Name = "openMicrocodeToolStripMenuItem";
            this.openMicrocodeToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.openMicrocodeToolStripMenuItem.Text = "Open Microcode...";
            this.openMicrocodeToolStripMenuItem.Click += new System.EventHandler(this.openMicrocodeToolStripMenuItem_Click);
            // 
            // instrBox
            // 
            this.instrBox.Location = new System.Drawing.Point(12, 27);
            this.instrBox.Multiline = true;
            this.instrBox.Name = "instrBox";
            this.instrBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.instrBox.Size = new System.Drawing.Size(209, 558);
            this.instrBox.TabIndex = 1;
            this.instrBox.Text = "instrBox";
            // 
            // microBox
            // 
            this.microBox.Location = new System.Drawing.Point(227, 27);
            this.microBox.Multiline = true;
            this.microBox.Name = "microBox";
            this.microBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.microBox.Size = new System.Drawing.Size(1067, 92);
            this.microBox.TabIndex = 2;
            this.microBox.Text = "microBox";
            // 
            // MDR_T
            // 
            this.MDR_T.AutoSize = true;
            this.MDR_T.Location = new System.Drawing.Point(1261, 133);
            this.MDR_T.Name = "MDR_T";
            this.MDR_T.Size = new System.Drawing.Size(33, 15);
            this.MDR_T.TabIndex = 3;
            this.MDR_T.Text = "MDR";
            // 
            // ADR_T
            // 
            this.ADR_T.AutoSize = true;
            this.ADR_T.Location = new System.Drawing.Point(1261, 158);
            this.ADR_T.Name = "ADR_T";
            this.ADR_T.Size = new System.Drawing.Size(30, 15);
            this.ADR_T.TabIndex = 4;
            this.ADR_T.Text = "ADR";
            // 
            // IR_T
            // 
            this.IR_T.AutoSize = true;
            this.IR_T.Location = new System.Drawing.Point(1261, 186);
            this.IR_T.Name = "IR_T";
            this.IR_T.Size = new System.Drawing.Size(17, 15);
            this.IR_T.TabIndex = 5;
            this.IR_T.Text = "IR";
            // 
            // R0_T
            // 
            this.R0_T.AutoSize = true;
            this.R0_T.Location = new System.Drawing.Point(1261, 218);
            this.R0_T.Name = "R0_T";
            this.R0_T.Size = new System.Drawing.Size(20, 15);
            this.R0_T.TabIndex = 6;
            this.R0_T.Text = "R0";
            // 
            // R1_T
            // 
            this.R1_T.AutoSize = true;
            this.R1_T.Location = new System.Drawing.Point(1261, 233);
            this.R1_T.Name = "R1_T";
            this.R1_T.Size = new System.Drawing.Size(20, 15);
            this.R1_T.TabIndex = 7;
            this.R1_T.Text = "R1";
            // 
            // R2_T
            // 
            this.R2_T.AutoSize = true;
            this.R2_T.Location = new System.Drawing.Point(1261, 248);
            this.R2_T.Name = "R2_T";
            this.R2_T.Size = new System.Drawing.Size(20, 15);
            this.R2_T.TabIndex = 8;
            this.R2_T.Text = "R2";
            // 
            // R3_T
            // 
            this.R3_T.AutoSize = true;
            this.R3_T.Location = new System.Drawing.Point(1261, 263);
            this.R3_T.Name = "R3_T";
            this.R3_T.Size = new System.Drawing.Size(20, 15);
            this.R3_T.TabIndex = 9;
            this.R3_T.Text = "R3";
            // 
            // R4_T
            // 
            this.R4_T.AutoSize = true;
            this.R4_T.Location = new System.Drawing.Point(1261, 278);
            this.R4_T.Name = "R4_T";
            this.R4_T.Size = new System.Drawing.Size(20, 15);
            this.R4_T.TabIndex = 10;
            this.R4_T.Text = "R4";
            // 
            // R5_T
            // 
            this.R5_T.AutoSize = true;
            this.R5_T.Location = new System.Drawing.Point(1261, 293);
            this.R5_T.Name = "R5_T";
            this.R5_T.Size = new System.Drawing.Size(20, 15);
            this.R5_T.TabIndex = 11;
            this.R5_T.Text = "R5";
            // 
            // R6_T
            // 
            this.R6_T.AutoSize = true;
            this.R6_T.Location = new System.Drawing.Point(1261, 308);
            this.R6_T.Name = "R6_T";
            this.R6_T.Size = new System.Drawing.Size(20, 15);
            this.R6_T.TabIndex = 12;
            this.R6_T.Text = "R6";
            // 
            // R7_T
            // 
            this.R7_T.AutoSize = true;
            this.R7_T.Location = new System.Drawing.Point(1261, 323);
            this.R7_T.Name = "R7_T";
            this.R7_T.Size = new System.Drawing.Size(20, 15);
            this.R7_T.TabIndex = 13;
            this.R7_T.Text = "R7";
            // 
            // R8_T
            // 
            this.R8_T.AutoSize = true;
            this.R8_T.Location = new System.Drawing.Point(1261, 338);
            this.R8_T.Name = "R8_T";
            this.R8_T.Size = new System.Drawing.Size(20, 15);
            this.R8_T.TabIndex = 14;
            this.R8_T.Text = "R8";
            // 
            // R9_T
            // 
            this.R9_T.AutoSize = true;
            this.R9_T.Location = new System.Drawing.Point(1261, 353);
            this.R9_T.Name = "R9_T";
            this.R9_T.Size = new System.Drawing.Size(20, 15);
            this.R9_T.TabIndex = 15;
            this.R9_T.Text = "R9";
            // 
            // R10_T
            // 
            this.R10_T.AutoSize = true;
            this.R10_T.Location = new System.Drawing.Point(1261, 368);
            this.R10_T.Name = "R10_T";
            this.R10_T.Size = new System.Drawing.Size(26, 15);
            this.R10_T.TabIndex = 16;
            this.R10_T.Text = "R10";
            // 
            // R11_T
            // 
            this.R11_T.AutoSize = true;
            this.R11_T.Location = new System.Drawing.Point(1261, 383);
            this.R11_T.Name = "R11_T";
            this.R11_T.Size = new System.Drawing.Size(26, 15);
            this.R11_T.TabIndex = 17;
            this.R11_T.Text = "R11";
            // 
            // R12_T
            // 
            this.R12_T.AutoSize = true;
            this.R12_T.Location = new System.Drawing.Point(1261, 398);
            this.R12_T.Name = "R12_T";
            this.R12_T.Size = new System.Drawing.Size(26, 15);
            this.R12_T.TabIndex = 18;
            this.R12_T.Text = "R12";
            // 
            // R13_T
            // 
            this.R13_T.AutoSize = true;
            this.R13_T.Location = new System.Drawing.Point(1261, 413);
            this.R13_T.Name = "R13_T";
            this.R13_T.Size = new System.Drawing.Size(26, 15);
            this.R13_T.TabIndex = 19;
            this.R13_T.Text = "R13";
            // 
            // R14_T
            // 
            this.R14_T.AutoSize = true;
            this.R14_T.Location = new System.Drawing.Point(1261, 428);
            this.R14_T.Name = "R14_T";
            this.R14_T.Size = new System.Drawing.Size(26, 15);
            this.R14_T.TabIndex = 20;
            this.R14_T.Text = "R14";
            // 
            // R15_T
            // 
            this.R15_T.AutoSize = true;
            this.R15_T.Location = new System.Drawing.Point(1261, 443);
            this.R15_T.Name = "R15_T";
            this.R15_T.Size = new System.Drawing.Size(26, 15);
            this.R15_T.TabIndex = 21;
            this.R15_T.Text = "R15";
            // 
            // FLAG_T
            // 
            this.FLAG_T.AutoSize = true;
            this.FLAG_T.Location = new System.Drawing.Point(1111, 248);
            this.FLAG_T.Name = "FLAG_T";
            this.FLAG_T.Size = new System.Drawing.Size(35, 15);
            this.FLAG_T.TabIndex = 26;
            this.FLAG_T.Text = "FLAG";
            // 
            // SP_T
            // 
            this.SP_T.AutoSize = true;
            this.SP_T.Location = new System.Drawing.Point(1111, 218);
            this.SP_T.Name = "SP_T";
            this.SP_T.Size = new System.Drawing.Size(20, 15);
            this.SP_T.TabIndex = 25;
            this.SP_T.Text = "SP";
            // 
            // T_T
            // 
            this.T_T.AutoSize = true;
            this.T_T.Location = new System.Drawing.Point(1111, 186);
            this.T_T.Name = "T_T";
            this.T_T.Size = new System.Drawing.Size(13, 15);
            this.T_T.TabIndex = 24;
            this.T_T.Text = "T";
            // 
            // IVR_T
            // 
            this.IVR_T.AutoSize = true;
            this.IVR_T.Location = new System.Drawing.Point(1111, 158);
            this.IVR_T.Name = "IVR_T";
            this.IVR_T.Size = new System.Drawing.Size(24, 15);
            this.IVR_T.TabIndex = 23;
            this.IVR_T.Text = "IVR";
            // 
            // PC_T
            // 
            this.PC_T.AutoSize = true;
            this.PC_T.Location = new System.Drawing.Point(1111, 133);
            this.PC_T.Name = "PC_T";
            this.PC_T.Size = new System.Drawing.Size(22, 15);
            this.PC_T.TabIndex = 22;
            this.PC_T.Text = "PC";
            // 
            // MDR_R
            // 
            this.MDR_R.AutoSize = true;
            this.MDR_R.Location = new System.Drawing.Point(1152, 133);
            this.MDR_R.Name = "MDR_R";
            this.MDR_R.Size = new System.Drawing.Size(103, 15);
            this.MDR_R.TabIndex = 27;
            this.MDR_R.Text = "0000000000000000";
            // 
            // ADR_R
            // 
            this.ADR_R.AutoSize = true;
            this.ADR_R.Location = new System.Drawing.Point(1152, 158);
            this.ADR_R.Name = "ADR_R";
            this.ADR_R.Size = new System.Drawing.Size(103, 15);
            this.ADR_R.TabIndex = 28;
            this.ADR_R.Text = "0000000000000000";
            // 
            // IR_R
            // 
            this.IR_R.AutoSize = true;
            this.IR_R.Location = new System.Drawing.Point(1152, 186);
            this.IR_R.Name = "IR_R";
            this.IR_R.Size = new System.Drawing.Size(103, 15);
            this.IR_R.TabIndex = 29;
            this.IR_R.Text = "0000000000000000";
            // 
            // R0_R
            // 
            this.R0_R.AutoSize = true;
            this.R0_R.Location = new System.Drawing.Point(1152, 218);
            this.R0_R.Name = "R0_R";
            this.R0_R.Size = new System.Drawing.Size(103, 15);
            this.R0_R.TabIndex = 30;
            this.R0_R.Text = "0000000000000000";
            // 
            // R1_R
            // 
            this.R1_R.AutoSize = true;
            this.R1_R.Location = new System.Drawing.Point(1152, 233);
            this.R1_R.Name = "R1_R";
            this.R1_R.Size = new System.Drawing.Size(103, 15);
            this.R1_R.TabIndex = 31;
            this.R1_R.Text = "0000000000000000";
            // 
            // R2_R
            // 
            this.R2_R.AutoSize = true;
            this.R2_R.Location = new System.Drawing.Point(1152, 248);
            this.R2_R.Name = "R2_R";
            this.R2_R.Size = new System.Drawing.Size(103, 15);
            this.R2_R.TabIndex = 32;
            this.R2_R.Text = "0000000000000000";
            // 
            // R3_R
            // 
            this.R3_R.AutoSize = true;
            this.R3_R.Location = new System.Drawing.Point(1152, 263);
            this.R3_R.Name = "R3_R";
            this.R3_R.Size = new System.Drawing.Size(103, 15);
            this.R3_R.TabIndex = 33;
            this.R3_R.Text = "0000000000000000";
            // 
            // R4_R
            // 
            this.R4_R.AutoSize = true;
            this.R4_R.Location = new System.Drawing.Point(1152, 278);
            this.R4_R.Name = "R4_R";
            this.R4_R.Size = new System.Drawing.Size(103, 15);
            this.R4_R.TabIndex = 34;
            this.R4_R.Text = "0000000000000000";
            // 
            // R5_R
            // 
            this.R5_R.AutoSize = true;
            this.R5_R.Location = new System.Drawing.Point(1152, 293);
            this.R5_R.Name = "R5_R";
            this.R5_R.Size = new System.Drawing.Size(103, 15);
            this.R5_R.TabIndex = 35;
            this.R5_R.Text = "0000000000000000";
            // 
            // R6_R
            // 
            this.R6_R.AutoSize = true;
            this.R6_R.Location = new System.Drawing.Point(1152, 308);
            this.R6_R.Name = "R6_R";
            this.R6_R.Size = new System.Drawing.Size(103, 15);
            this.R6_R.TabIndex = 36;
            this.R6_R.Text = "0000000000000000";
            // 
            // R7_R
            // 
            this.R7_R.AutoSize = true;
            this.R7_R.Location = new System.Drawing.Point(1152, 323);
            this.R7_R.Name = "R7_R";
            this.R7_R.Size = new System.Drawing.Size(103, 15);
            this.R7_R.TabIndex = 37;
            this.R7_R.Text = "0000000000000000";
            // 
            // R8_R
            // 
            this.R8_R.AutoSize = true;
            this.R8_R.Location = new System.Drawing.Point(1152, 338);
            this.R8_R.Name = "R8_R";
            this.R8_R.Size = new System.Drawing.Size(103, 15);
            this.R8_R.TabIndex = 38;
            this.R8_R.Text = "0000000000000000";
            // 
            // R9_R
            // 
            this.R9_R.AutoSize = true;
            this.R9_R.Location = new System.Drawing.Point(1152, 353);
            this.R9_R.Name = "R9_R";
            this.R9_R.Size = new System.Drawing.Size(103, 15);
            this.R9_R.TabIndex = 39;
            this.R9_R.Text = "0000000000000000";
            // 
            // R10_R
            // 
            this.R10_R.AutoSize = true;
            this.R10_R.Location = new System.Drawing.Point(1152, 368);
            this.R10_R.Name = "R10_R";
            this.R10_R.Size = new System.Drawing.Size(103, 15);
            this.R10_R.TabIndex = 40;
            this.R10_R.Text = "0000000000000000";
            // 
            // R11_R
            // 
            this.R11_R.AutoSize = true;
            this.R11_R.Location = new System.Drawing.Point(1152, 383);
            this.R11_R.Name = "R11_R";
            this.R11_R.Size = new System.Drawing.Size(103, 15);
            this.R11_R.TabIndex = 41;
            this.R11_R.Text = "0000000000000000";
            // 
            // R12_R
            // 
            this.R12_R.AutoSize = true;
            this.R12_R.Location = new System.Drawing.Point(1152, 398);
            this.R12_R.Name = "R12_R";
            this.R12_R.Size = new System.Drawing.Size(103, 15);
            this.R12_R.TabIndex = 42;
            this.R12_R.Text = "0000000000000000";
            // 
            // R13_R
            // 
            this.R13_R.AutoSize = true;
            this.R13_R.Location = new System.Drawing.Point(1152, 413);
            this.R13_R.Name = "R13_R";
            this.R13_R.Size = new System.Drawing.Size(103, 15);
            this.R13_R.TabIndex = 43;
            this.R13_R.Text = "0000000000000000";
            // 
            // R14_R
            // 
            this.R14_R.AutoSize = true;
            this.R14_R.Location = new System.Drawing.Point(1152, 428);
            this.R14_R.Name = "R14_R";
            this.R14_R.Size = new System.Drawing.Size(103, 15);
            this.R14_R.TabIndex = 44;
            this.R14_R.Text = "0000000000000000";
            // 
            // R15_R
            // 
            this.R15_R.AutoSize = true;
            this.R15_R.Location = new System.Drawing.Point(1152, 443);
            this.R15_R.Name = "R15_R";
            this.R15_R.Size = new System.Drawing.Size(103, 15);
            this.R15_R.TabIndex = 45;
            this.R15_R.Text = "0000000000000000";
            // 
            // PC_R
            // 
            this.PC_R.AutoSize = true;
            this.PC_R.Location = new System.Drawing.Point(1002, 133);
            this.PC_R.Name = "PC_R";
            this.PC_R.Size = new System.Drawing.Size(103, 15);
            this.PC_R.TabIndex = 46;
            this.PC_R.Text = "0000000000000000";
            // 
            // IVR_R
            // 
            this.IVR_R.AutoSize = true;
            this.IVR_R.Location = new System.Drawing.Point(1002, 158);
            this.IVR_R.Name = "IVR_R";
            this.IVR_R.Size = new System.Drawing.Size(103, 15);
            this.IVR_R.TabIndex = 47;
            this.IVR_R.Text = "0000000000000000";
            // 
            // T_R
            // 
            this.T_R.AutoSize = true;
            this.T_R.Location = new System.Drawing.Point(1002, 186);
            this.T_R.Name = "T_R";
            this.T_R.Size = new System.Drawing.Size(103, 15);
            this.T_R.TabIndex = 48;
            this.T_R.Text = "0000000000000000";
            // 
            // SP_R
            // 
            this.SP_R.AutoSize = true;
            this.SP_R.Location = new System.Drawing.Point(1002, 218);
            this.SP_R.Name = "SP_R";
            this.SP_R.Size = new System.Drawing.Size(103, 15);
            this.SP_R.TabIndex = 49;
            this.SP_R.Text = "1111111111111111";
            // 
            // FLAG_R
            // 
            this.FLAG_R.AutoSize = true;
            this.FLAG_R.Location = new System.Drawing.Point(1002, 248);
            this.FLAG_R.Name = "FLAG_R";
            this.FLAG_R.Size = new System.Drawing.Size(103, 15);
            this.FLAG_R.TabIndex = 50;
            this.FLAG_R.Text = "0000000000000000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1038, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 93);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // ALU_T
            // 
            this.ALU_T.AutoSize = true;
            this.ALU_T.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ALU_T.Location = new System.Drawing.Point(1047, 338);
            this.ALU_T.Name = "ALU_T";
            this.ALU_T.Size = new System.Drawing.Size(29, 15);
            this.ALU_T.TabIndex = 52;
            this.ALU_T.Text = "ALU";
            // 
            // Emulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 597);
            this.Controls.Add(this.ALU_T);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FLAG_R);
            this.Controls.Add(this.SP_R);
            this.Controls.Add(this.T_R);
            this.Controls.Add(this.IVR_R);
            this.Controls.Add(this.PC_R);
            this.Controls.Add(this.R15_R);
            this.Controls.Add(this.R14_R);
            this.Controls.Add(this.R13_R);
            this.Controls.Add(this.R12_R);
            this.Controls.Add(this.R11_R);
            this.Controls.Add(this.R10_R);
            this.Controls.Add(this.R9_R);
            this.Controls.Add(this.R8_R);
            this.Controls.Add(this.R7_R);
            this.Controls.Add(this.R6_R);
            this.Controls.Add(this.R5_R);
            this.Controls.Add(this.R4_R);
            this.Controls.Add(this.R3_R);
            this.Controls.Add(this.R2_R);
            this.Controls.Add(this.R1_R);
            this.Controls.Add(this.R0_R);
            this.Controls.Add(this.IR_R);
            this.Controls.Add(this.ADR_R);
            this.Controls.Add(this.MDR_R);
            this.Controls.Add(this.FLAG_T);
            this.Controls.Add(this.SP_T);
            this.Controls.Add(this.T_T);
            this.Controls.Add(this.IVR_T);
            this.Controls.Add(this.PC_T);
            this.Controls.Add(this.R15_T);
            this.Controls.Add(this.R14_T);
            this.Controls.Add(this.R13_T);
            this.Controls.Add(this.R12_T);
            this.Controls.Add(this.R11_T);
            this.Controls.Add(this.R10_T);
            this.Controls.Add(this.R9_T);
            this.Controls.Add(this.R8_T);
            this.Controls.Add(this.R7_T);
            this.Controls.Add(this.R6_T);
            this.Controls.Add(this.R5_T);
            this.Controls.Add(this.R4_T);
            this.Controls.Add(this.R3_T);
            this.Controls.Add(this.R2_T);
            this.Controls.Add(this.R1_T);
            this.Controls.Add(this.R0_T);
            this.Controls.Add(this.IR_T);
            this.Controls.Add(this.ADR_T);
            this.Controls.Add(this.MDR_T);
            this.Controls.Add(this.microBox);
            this.Controls.Add(this.instrBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Emulator";
            this.Text = "Emulator";
            this.Load += new System.EventHandler(this.Emulator_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem goBackToAssemblerToolStripMenuItem;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private TextBox instrBox;
        private ToolStripMenuItem stepToolStripMenuItem;
        private ToolStripMenuItem runToEndToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem showMemToolStripMenuItem;
        private TextBox microBox;
        private ToolStripMenuItem openMicrocodeToolStripMenuItem;
        private Label MDR_T;
        private Label ADR_T;
        private Label IR_T;
        private Label R0_T;
        private Label R1_T;
        private Label R2_T;
        private Label R3_T;
        private Label R4_T;
        private Label R5_T;
        private Label R6_T;
        private Label R7_T;
        private Label R8_T;
        private Label R9_T;
        private Label R10_T;
        private Label R11_T;
        private Label R12_T;
        private Label R13_T;
        private Label R14_T;
        private Label R15_T;
        private Label FLAG_T;
        private Label SP_T;
        private Label T_T;
        private Label IVR_T;
        private Label PC_T;
        private Label MDR_R;
        private Label ADR_R;
        private Label IR_R;
        private Label R0_R;
        private Label R1_R;
        private Label R2_R;
        private Label R3_R;
        private Label R4_R;
        private Label R5_R;
        private Label R6_R;
        private Label R7_R;
        private Label R8_R;
        private Label R9_R;
        private Label R10_R;
        private Label R11_R;
        private Label R12_R;
        private Label R13_R;
        private Label R14_R;
        private Label R15_R;
        private Label PC_R;
        private Label IVR_R;
        private Label T_R;
        private Label SP_R;
        private Label FLAG_R;
        private PictureBox pictureBox1;
        private Label ALU_T;
    }
}