namespace IDS
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuWhiteListAPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuActivateIDS = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.defaultCameraMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTrain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btntrain = new System.Windows.Forms.Button();
            this.btnactivate = new System.Windows.Forms.Button();
            this.btn_Students = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAddPerson,
            this.MnuEditPerson,
            this.toolStripMenuItem1,
            this.MnuWhiteListAPerson,
            this.toolStripMenuItem2,
            this.MnuActivateIDS,
            this.MnuMinimize,
            this.toolStripMenuItem3,
            this.defaultCameraMenu,
            this.MnuTrain,
            this.toolStripMenuItem4,
            this.MnuExit});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(200, 204);
            // 
            // MnuAddPerson
            // 
            this.MnuAddPerson.Name = "MnuAddPerson";
            this.MnuAddPerson.Size = new System.Drawing.Size(199, 22);
            this.MnuAddPerson.Text = "Add Student";
            this.MnuAddPerson.Click += new System.EventHandler(this.MnuAddPerson_Click);
            // 
            // MnuEditPerson
            // 
            this.MnuEditPerson.Name = "MnuEditPerson";
            this.MnuEditPerson.Size = new System.Drawing.Size(199, 22);
            this.MnuEditPerson.Text = "Edit Student Details";
            this.MnuEditPerson.Click += new System.EventHandler(this.MnuEditPerson_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
            // 
            // MnuWhiteListAPerson
            // 
            this.MnuWhiteListAPerson.Name = "MnuWhiteListAPerson";
            this.MnuWhiteListAPerson.Size = new System.Drawing.Size(199, 22);
            this.MnuWhiteListAPerson.Text = "White Or Black List";
            this.MnuWhiteListAPerson.Click += new System.EventHandler(this.MnuWhiteListAPerson_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
            // 
            // MnuActivateIDS
            // 
            this.MnuActivateIDS.Name = "MnuActivateIDS";
            this.MnuActivateIDS.Size = new System.Drawing.Size(199, 22);
            this.MnuActivateIDS.Text = "Activate Camera";
            this.MnuActivateIDS.Click += new System.EventHandler(this.MnuActivateIDS_Click);
            // 
            // MnuMinimize
            // 
            this.MnuMinimize.Name = "MnuMinimize";
            this.MnuMinimize.Size = new System.Drawing.Size(199, 22);
            this.MnuMinimize.Text = "Minimize Camera";
            this.MnuMinimize.Click += new System.EventHandler(this.MnuMinimize_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(196, 6);
            // 
            // defaultCameraMenu
            // 
            this.defaultCameraMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiToolStripMenuItem,
            this.helloToolStripMenuItem});
            this.defaultCameraMenu.Name = "defaultCameraMenu";
            this.defaultCameraMenu.Size = new System.Drawing.Size(199, 22);
            this.defaultCameraMenu.Text = "Choose Default Camera";
            // 
            // hiToolStripMenuItem
            // 
            this.hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            this.hiToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.hiToolStripMenuItem.Text = "Hi";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.helloToolStripMenuItem.Text = "Hello";
            // 
            // MnuTrain
            // 
            this.MnuTrain.Name = "MnuTrain";
            this.MnuTrain.Size = new System.Drawing.Size(199, 22);
            this.MnuTrain.Text = "Capture Image";
            this.MnuTrain.Click += new System.EventHandler(this.MnuTrain_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(196, 6);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(199, 22);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Intrusion Detection System";
            this.notifyIcon.BalloonTipTitle = "Intrusion Detection System";
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.BalloonTipClosed += new System.EventHandler(this.notifyIcon_BalloonTipClosed);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // btnmenu
            // 
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.Location = new System.Drawing.Point(21, 325);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(6);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(348, 50);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(21, 426);
            this.btnedit.Margin = new System.Windows.Forms.Padding(6);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(348, 50);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit Student Details";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Visible = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(21, 15);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(348, 50);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Register Student";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btntrain
            // 
            this.btntrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrain.Location = new System.Drawing.Point(21, 77);
            this.btntrain.Margin = new System.Windows.Forms.Padding(6);
            this.btntrain.Name = "btntrain";
            this.btntrain.Size = new System.Drawing.Size(348, 50);
            this.btntrain.TabIndex = 5;
            this.btntrain.Text = "Capture image";
            this.btntrain.UseVisualStyleBackColor = true;
            this.btntrain.Click += new System.EventHandler(this.btntrain_Click);
            // 
            // btnactivate
            // 
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.Location = new System.Drawing.Point(21, 139);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(6);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(348, 50);
            this.btnactivate.TabIndex = 6;
            this.btnactivate.Text = "Activate Camera";
            this.btnactivate.UseVisualStyleBackColor = true;
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // btn_Students
            // 
            this.btn_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Students.Location = new System.Drawing.Point(21, 201);
            this.btn_Students.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Size = new System.Drawing.Size(348, 50);
            this.btn_Students.TabIndex = 7;
            this.btn_Students.Text = "Registered Students";
            this.btn_Students.UseVisualStyleBackColor = true;
            this.btn_Students.Click += new System.EventHandler(this.btn_Students_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Attendance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::IDS.Properties.Resources.face3;
            this.groupBox1.Location = new System.Drawing.Point(381, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1280, 798);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1034, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Students);
            this.Controls.Add(this.btnactivate);
            this.Controls.Add(this.btntrain);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnmenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainFrm";
            this.ShowInTaskbar = false;
            this.Text = "MainFrm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainFrm_MouseClick);
            this.MouseEnter += new System.EventHandler(this.MainFrm_MouseEnter);
            this.MouseHover += new System.EventHandler(this.MainFrm_MouseHover);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuAddPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuEditPerson;
        private System.Windows.Forms.ToolStripMenuItem MnuWhiteListAPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MnuActivateIDS;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem MnuMinimize;
        private System.Windows.Forms.ToolStripMenuItem MnuTrain;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem defaultCameraMenu;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btntrain;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button btn_Students;
        private System.Windows.Forms.Button button1;
    }
}