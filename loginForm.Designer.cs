namespace MovieHub
{
    partial class loginForm
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label16;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel_login = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_passwordLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usernameLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_signup = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_usernameSignup = new System.Windows.Forms.TextBox();
            this.txt_passwordSignup = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_mobileNum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_signup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.panel_login.Controls.Add(this.pictureBox1);
            this.panel_login.Controls.Add(this.linkSignUp);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.txt_passwordLogin);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.txt_usernameLogin);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Location = new System.Drawing.Point(296, 101);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(360, 437);
            this.panel_login.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieHub.Properties.Resources.movie_hub_logo___white;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.LinkColor = System.Drawing.Color.Red;
            this.linkSignUp.Location = new System.Drawing.Point(193, 353);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(59, 17);
            this.linkSignUp.TabIndex = 4;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Sign Up";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Red;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(69, 298);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(227, 37);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // txt_passwordLogin
            // 
            this.txt_passwordLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_passwordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_passwordLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordLogin.ForeColor = System.Drawing.Color.White;
            this.txt_passwordLogin.Location = new System.Drawing.Point(69, 248);
            this.txt_passwordLogin.Name = "txt_passwordLogin";
            this.txt_passwordLogin.Size = new System.Drawing.Size(227, 25);
            this.txt_passwordLogin.TabIndex = 2;
            this.txt_passwordLogin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "New to MovieHub?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txt_usernameLogin
            // 
            this.txt_usernameLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_usernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usernameLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usernameLogin.ForeColor = System.Drawing.Color.White;
            this.txt_usernameLogin.Location = new System.Drawing.Point(69, 188);
            this.txt_usernameLogin.Name = "txt_usernameLogin";
            this.txt_usernameLogin.Size = new System.Drawing.Size(227, 25);
            this.txt_usernameLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panel_signup
            // 
            this.panel_signup.Controls.Add(this.button1);
            this.panel_signup.Controls.Add(this.label13);
            this.panel_signup.Controls.Add(this.label15);
            this.panel_signup.Controls.Add(this.label10);
            this.panel_signup.Controls.Add(this.label14);
            this.panel_signup.Controls.Add(this.label12);
            this.panel_signup.Controls.Add(this.label11);
            this.panel_signup.Controls.Add(this.groupBox3);
            this.panel_signup.Controls.Add(this.groupBox1);
            this.panel_signup.Controls.Add(label9);
            this.panel_signup.Controls.Add(label16);
            this.panel_signup.Controls.Add(label8);
            this.panel_signup.Controls.Add(label7);
            this.panel_signup.Controls.Add(label6);
            this.panel_signup.Controls.Add(this.label4);
            this.panel_signup.Controls.Add(this.label5);
            this.panel_signup.Controls.Add(this.txt_passwordSignup);
            this.panel_signup.Controls.Add(this.txt_mobileNum);
            this.panel_signup.Controls.Add(this.txt_usernameSignup);
            this.panel_signup.Controls.Add(this.txt_lastName);
            this.panel_signup.Controls.Add(this.txt_firstName);
            this.panel_signup.Location = new System.Drawing.Point(0, 0);
            this.panel_signup.Name = "panel_signup";
            this.panel_signup.Size = new System.Drawing.Size(960, 637);
            this.panel_signup.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(61, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sign Up";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Create your MovieHub account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(64, 284);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(80, 17);
            label6.TabIndex = 3;
            label6.Text = "First Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_firstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.ForeColor = System.Drawing.Color.White;
            this.txt_firstName.Location = new System.Drawing.Point(67, 313);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(178, 25);
            this.txt_firstName.TabIndex = 4;
            // 
            // txt_lastName
            // 
            this.txt_lastName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lastName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.ForeColor = System.Drawing.Color.White;
            this.txt_lastName.Location = new System.Drawing.Point(263, 313);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(178, 25);
            this.txt_lastName.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(260, 284);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 17);
            label7.TabIndex = 3;
            label7.Text = "Last Name";
            // 
            // txt_usernameSignup
            // 
            this.txt_usernameSignup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_usernameSignup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usernameSignup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usernameSignup.ForeColor = System.Drawing.Color.White;
            this.txt_usernameSignup.Location = new System.Drawing.Point(67, 385);
            this.txt_usernameSignup.Name = "txt_usernameSignup";
            this.txt_usernameSignup.Size = new System.Drawing.Size(178, 25);
            this.txt_usernameSignup.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(64, 357);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 17);
            label8.TabIndex = 3;
            label8.Text = "Username";
            // 
            // txt_passwordSignup
            // 
            this.txt_passwordSignup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_passwordSignup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_passwordSignup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordSignup.ForeColor = System.Drawing.Color.White;
            this.txt_passwordSignup.Location = new System.Drawing.Point(263, 385);
            this.txt_passwordSignup.Name = "txt_passwordSignup";
            this.txt_passwordSignup.Size = new System.Drawing.Size(178, 25);
            this.txt_passwordSignup.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(260, 357);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(74, 17);
            label9.TabIndex = 3;
            label9.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(512, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(35, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Basic";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(135, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Standard";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(255, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 21);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Premium";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(62, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "Basic Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(509, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Payment Method";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(510, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Setup your payment method";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(63, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Let us know you!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(508, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 24);
            this.label14.TabIndex = 6;
            this.label14.Text = "Subscription Plan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(510, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Choose your plan";
            // 
            // txt_mobileNum
            // 
            this.txt_mobileNum.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_mobileNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mobileNum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobileNum.ForeColor = System.Drawing.Color.White;
            this.txt_mobileNum.Location = new System.Drawing.Point(67, 457);
            this.txt_mobileNum.Name = "txt_mobileNum";
            this.txt_mobileNum.Size = new System.Drawing.Size(374, 25);
            this.txt_mobileNum.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ForeColor = System.Drawing.Color.White;
            label16.Location = new System.Drawing.Point(64, 429);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(105, 17);
            label16.TabIndex = 3;
            label16.Text = "Mobile Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(512, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 71);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(206, 26);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(102, 21);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "MasterCard";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(84, 26);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(54, 21);
            this.radioButton8.TabIndex = 6;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Visa";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(66, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(820, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "CREATE ACCOUNT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel_signup);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieHub";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_signup.ResumeLayout(false);
            this.panel_signup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_passwordLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usernameLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_signup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_passwordSignup;
        private System.Windows.Forms.TextBox txt_usernameSignup;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_mobileNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button button1;
    }
}

