namespace TicTacToe
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.playagain = new System.Windows.Forms.Button();
            this.Free_play = new System.Windows.Forms.RadioButton();
            this.timetrail = new System.Windows.Forms.RadioButton();
            this.fixednumber = new System.Windows.Forms.RadioButton();
            this.one_min = new System.Windows.Forms.RadioButton();
            this.two_mins = new System.Windows.Forms.RadioButton();
            this.fivegames = new System.Windows.Forms.RadioButton();
            this.ten_games = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timelabel = new System.Windows.Forms.Label();
            this.sixtylbl = new System.Windows.Forms.Label();
            this.twomin = new System.Windows.Forms.Label();
            this.gcount = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(10, 44);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(90, 90);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(106, 44);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(90, 90);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A3.Location = new System.Drawing.Point(202, 44);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(90, 90);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(202, 140);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(90, 90);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(106, 140);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(90, 90);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.BackColorChanged += new System.EventHandler(this.UserControl1_Load);
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(10, 140);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(90, 90);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(202, 233);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(90, 90);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(106, 233);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(90, 90);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(10, 233);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(90, 90);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draws";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Location = new System.Drawing.Point(43, 393);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(16, 17);
            this.x_win_count.TabIndex = 13;
            this.x_win_count.Text = "0";
            this.x_win_count.Click += new System.EventHandler(this.x_win_count_Click);
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(136, 393);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(16, 17);
            this.draw_count.TabIndex = 14;
            this.draw_count.Text = "0";
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Location = new System.Drawing.Point(228, 393);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(16, 17);
            this.o_win_count.TabIndex = 15;
            this.o_win_count.Text = "0";
            this.o_win_count.Click += new System.EventHandler(this.o_win_count_Click);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(10, 363);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(82, 22);
            this.p1.TabIndex = 16;
            this.p1.Text = "Player 1";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(202, 363);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(82, 22);
            this.p2.TabIndex = 17;
            this.p2.Text = "Player 2";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "O";
            // 
            // Exit
            // 
            this.Exit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(48, 24);
            this.Exit.Text = "File ";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.aboutToolStripMenuItem.Text = "About ";
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dtp1
            // 
            this.dtp1.Enabled = false;
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(165, 6);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(127, 22);
            this.dtp1.TabIndex = 20;
            // 
            // playagain
            // 
            this.playagain.Location = new System.Drawing.Point(99, 410);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(90, 36);
            this.playagain.TabIndex = 25;
            this.playagain.Text = "Play Again!";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Click += new System.EventHandler(this.againclick);
            // 
            // Free_play
            // 
            this.Free_play.AutoSize = true;
            this.Free_play.Location = new System.Drawing.Point(309, 44);
            this.Free_play.Name = "Free_play";
            this.Free_play.Size = new System.Drawing.Size(89, 21);
            this.Free_play.TabIndex = 26;
            this.Free_play.TabStop = true;
            this.Free_play.Text = "Free Play";
            this.Free_play.UseVisualStyleBackColor = true;
            this.Free_play.Click += new System.EventHandler(this.freeplay);
            // 
            // timetrail
            // 
            this.timetrail.AutoSize = true;
            this.timetrail.Location = new System.Drawing.Point(309, 140);
            this.timetrail.Name = "timetrail";
            this.timetrail.Size = new System.Drawing.Size(92, 21);
            this.timetrail.TabIndex = 27;
            this.timetrail.TabStop = true;
            this.timetrail.Text = "Time Trial";
            this.timetrail.UseVisualStyleBackColor = true;
            this.timetrail.CheckedChanged += new System.EventHandler(this.time);
            // 
            // fixednumber
            // 
            this.fixednumber.AutoSize = true;
            this.fixednumber.Location = new System.Drawing.Point(309, 233);
            this.fixednumber.Name = "fixednumber";
            this.fixednumber.Size = new System.Drawing.Size(116, 21);
            this.fixednumber.TabIndex = 28;
            this.fixednumber.TabStop = true;
            this.fixednumber.Text = "Fixed Number";
            this.fixednumber.UseVisualStyleBackColor = true;
            this.fixednumber.CheckedChanged += new System.EventHandler(this.fixednumber_CheckedChanged);
            // 
            // one_min
            // 
            this.one_min.AutoSize = true;
            this.one_min.Location = new System.Drawing.Point(322, 167);
            this.one_min.Name = "one_min";
            this.one_min.Size = new System.Drawing.Size(63, 21);
            this.one_min.TabIndex = 29;
            this.one_min.TabStop = true;
            this.one_min.Text = "1 min";
            this.one_min.UseVisualStyleBackColor = true;
            this.one_min.Visible = false;
            this.one_min.Click += new System.EventHandler(this.oneminclick);
            // 
            // two_mins
            // 
            this.two_mins.AutoSize = true;
            this.two_mins.Location = new System.Drawing.Point(322, 194);
            this.two_mins.Name = "two_mins";
            this.two_mins.Size = new System.Drawing.Size(70, 21);
            this.two_mins.TabIndex = 30;
            this.two_mins.TabStop = true;
            this.two_mins.Text = "2 mins";
            this.two_mins.UseVisualStyleBackColor = true;
            this.two_mins.Visible = false;
            this.two_mins.Click += new System.EventHandler(this.twominclick);
            // 
            // fivegames
            // 
            this.fivegames.AutoSize = true;
            this.fivegames.Location = new System.Drawing.Point(322, 260);
            this.fivegames.Name = "fivegames";
            this.fivegames.Size = new System.Drawing.Size(83, 21);
            this.fivegames.TabIndex = 31;
            this.fivegames.TabStop = true;
            this.fivegames.Text = "5 games";
            this.fivegames.UseVisualStyleBackColor = true;
            this.fivegames.Visible = false;
            this.fivegames.Click += new System.EventHandler(this.five);
            // 
            // ten_games
            // 
            this.ten_games.AutoSize = true;
            this.ten_games.Location = new System.Drawing.Point(322, 287);
            this.ten_games.Name = "ten_games";
            this.ten_games.Size = new System.Drawing.Size(91, 21);
            this.ten_games.TabIndex = 32;
            this.ten_games.TabStop = true;
            this.ten_games.Text = "10 games";
            this.ten_games.UseVisualStyleBackColor = true;
            this.ten_games.Visible = false;
            this.ten_games.Click += new System.EventHandler(this.tenclick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timertick);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(303, 341);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(64, 69);
            this.timelabel.TabIndex = 33;
            this.timelabel.Text = "0";
            this.timelabel.Visible = false;
            // 
            // sixtylbl
            // 
            this.sixtylbl.AutoSize = true;
            this.sixtylbl.Location = new System.Drawing.Point(309, 82);
            this.sixtylbl.Name = "sixtylbl";
            this.sixtylbl.Size = new System.Drawing.Size(24, 17);
            this.sixtylbl.TabIndex = 34;
            this.sixtylbl.Text = "60";
            this.sixtylbl.Visible = false;
            // 
            // twomin
            // 
            this.twomin.AutoSize = true;
            this.twomin.Location = new System.Drawing.Point(312, 103);
            this.twomin.Name = "twomin";
            this.twomin.Size = new System.Drawing.Size(32, 17);
            this.twomin.TabIndex = 35;
            this.twomin.Text = "120";
            this.twomin.Visible = false;
            // 
            // gcount
            // 
            this.gcount.AutoSize = true;
            this.gcount.Location = new System.Drawing.Point(338, 82);
            this.gcount.Name = "gcount";
            this.gcount.Size = new System.Drawing.Size(16, 17);
            this.gcount.TabIndex = 36;
            this.gcount.Text = "0";
            this.gcount.Visible = false;
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(293, 410);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(16, 17);
            this.lblten.TabIndex = 37;
            this.lblten.Text = "9";
            this.lblten.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(355, 410);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(16, 17);
            this.lbl5.TabIndex = 38;
            this.lbl5.Text = "4";
            this.lbl5.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.gcount);
            this.Controls.Add(this.twomin);
            this.Controls.Add(this.sixtylbl);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.ten_games);
            this.Controls.Add(this.fivegames);
            this.Controls.Add(this.two_mins);
            this.Controls.Add(this.one_min);
            this.Controls.Add(this.fixednumber);
            this.Controls.Add(this.timetrail);
            this.Controls.Add(this.Free_play);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(428, 459);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        protected internal System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.Button playagain;
        private System.Windows.Forms.RadioButton Free_play;
        private System.Windows.Forms.RadioButton timetrail;
        private System.Windows.Forms.RadioButton fixednumber;
        private System.Windows.Forms.RadioButton one_min;
        private System.Windows.Forms.RadioButton two_mins;
        private System.Windows.Forms.RadioButton fivegames;
        private System.Windows.Forms.RadioButton ten_games;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label sixtylbl;
        private System.Windows.Forms.Label twomin;
        private System.Windows.Forms.Label gcount;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lbl5;
    }
}
