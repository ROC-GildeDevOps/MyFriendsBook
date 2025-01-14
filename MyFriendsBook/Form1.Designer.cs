namespace MyFriendsBook
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.TextBox();
            this.input_firstName = new System.Windows.Forms.TextBox();
            this.input_lastName = new System.Windows.Forms.TextBox();
            this.input_birthPlace = new System.Windows.Forms.TextBox();
            this.input_adress = new System.Windows.Forms.TextBox();
            this.input_phone = new System.Windows.Forms.TextBox();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_dob = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_birthPlace = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.input_male = new System.Windows.Forms.RadioButton();
            this.input_female = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(98, 126);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(242, 37);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Friend ID";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(597, 77);
            this.label10.TabIndex = 9;
            this.label10.Text = "My Friends Book";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(398, 126);
            this.input_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_id.Multiline = true;
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(242, 35);
            this.input_id.TabIndex = 10;
            // 
            // input_firstName
            // 
            this.input_firstName.Location = new System.Drawing.Point(398, 177);
            this.input_firstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_firstName.Multiline = true;
            this.input_firstName.Name = "input_firstName";
            this.input_firstName.Size = new System.Drawing.Size(418, 35);
            this.input_firstName.TabIndex = 11;
            // 
            // input_lastName
            // 
            this.input_lastName.Location = new System.Drawing.Point(398, 232);
            this.input_lastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_lastName.Multiline = true;
            this.input_lastName.Name = "input_lastName";
            this.input_lastName.Size = new System.Drawing.Size(418, 35);
            this.input_lastName.TabIndex = 12;
            // 
            // input_birthPlace
            // 
            this.input_birthPlace.Location = new System.Drawing.Point(398, 335);
            this.input_birthPlace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_birthPlace.Multiline = true;
            this.input_birthPlace.Name = "input_birthPlace";
            this.input_birthPlace.Size = new System.Drawing.Size(418, 35);
            this.input_birthPlace.TabIndex = 14;
            // 
            // input_adress
            // 
            this.input_adress.Location = new System.Drawing.Point(398, 437);
            this.input_adress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_adress.Multiline = true;
            this.input_adress.Name = "input_adress";
            this.input_adress.Size = new System.Drawing.Size(418, 35);
            this.input_adress.TabIndex = 15;
            // 
            // input_phone
            // 
            this.input_phone.Location = new System.Drawing.Point(398, 494);
            this.input_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_phone.Multiline = true;
            this.input_phone.Name = "input_phone";
            this.input_phone.Size = new System.Drawing.Size(418, 35);
            this.input_phone.TabIndex = 16;
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(398, 549);
            this.input_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_email.Multiline = true;
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(418, 35);
            this.input_email.TabIndex = 17;
            // 
            // input_dob
            // 
            this.input_dob.Location = new System.Drawing.Point(398, 289);
            this.input_dob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_dob.Name = "input_dob";
            this.input_dob.Size = new System.Drawing.Size(418, 26);
            this.input_dob.TabIndex = 21;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_save.Location = new System.Drawing.Point(855, 126);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(174, 68);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_search.Location = new System.Drawing.Point(855, 209);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(174, 68);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_show.Location = new System.Drawing.Point(855, 286);
            this.btn_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(174, 68);
            this.btn_show.TabIndex = 24;
            this.btn_show.Text = "Show Data";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_update.Location = new System.Drawing.Point(1038, 126);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(174, 68);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_delete.Location = new System.Drawing.Point(1038, 209);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(174, 68);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_clean.Location = new System.Drawing.Point(1038, 289);
            this.btn_clean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(174, 68);
            this.btn_clean.TabIndex = 27;
            this.btn_clean.Text = "Clean";
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_exit.Location = new System.Drawing.Point(1038, 368);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(174, 68);
            this.btn_exit.TabIndex = 28;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(98, 177);
            this.lbl_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(242, 37);
            this.lbl_firstName.TabIndex = 29;
            this.lbl_firstName.Text = "First Name";
            this.lbl_firstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(98, 228);
            this.lbl_lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(242, 37);
            this.lbl_lastName.TabIndex = 30;
            this.lbl_lastName.Text = "Last Name";
            this.lbl_lastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dob
            // 
            this.lbl_dob.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(98, 283);
            this.lbl_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(242, 37);
            this.lbl_dob.TabIndex = 31;
            this.lbl_dob.Text = "Birthday";
            this.lbl_dob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_birthPlace
            // 
            this.lbl_birthPlace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_birthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthPlace.Location = new System.Drawing.Point(98, 335);
            this.lbl_birthPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_birthPlace.Name = "lbl_birthPlace";
            this.lbl_birthPlace.Size = new System.Drawing.Size(242, 37);
            this.lbl_birthPlace.TabIndex = 32;
            this.lbl_birthPlace.Text = "Birthplace";
            this.lbl_birthPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(98, 386);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(242, 37);
            this.lbl_gender.TabIndex = 33;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adress
            // 
            this.lbl_adress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adress.Location = new System.Drawing.Point(98, 437);
            this.lbl_adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(242, 37);
            this.lbl_adress.TabIndex = 34;
            this.lbl_adress.Text = "Address";
            this.lbl_adress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_phone
            // 
            this.lbl_phone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(98, 494);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(242, 37);
            this.lbl_phone.TabIndex = 35;
            this.lbl_phone.Text = "Telephone";
            this.lbl_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(98, 549);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(242, 37);
            this.lbl_email.TabIndex = 36;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_male
            // 
            this.input_male.AutoSize = true;
            this.input_male.Location = new System.Drawing.Point(398, 392);
            this.input_male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_male.Name = "input_male";
            this.input_male.Size = new System.Drawing.Size(68, 24);
            this.input_male.TabIndex = 37;
            this.input_male.TabStop = true;
            this.input_male.Text = "Male";
            this.input_male.UseVisualStyleBackColor = true;
            // 
            // input_female
            // 
            this.input_female.AutoSize = true;
            this.input_female.Location = new System.Drawing.Point(478, 392);
            this.input_female.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_female.Name = "input_female";
            this.input_female.Size = new System.Drawing.Size(87, 24);
            this.input_female.TabIndex = 38;
            this.input_female.TabStop = true;
            this.input_female.Text = "Female";
            this.input_female.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output.Location = new System.Drawing.Point(102, 623);
            this.output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output.Name = "output";
            this.output.RowHeadersWidth = 62;
            this.output.Size = new System.Drawing.Size(1182, 380);
            this.output.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 1043);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input_female);
            this.Controls.Add(this.input_male);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_adress);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_birthPlace);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.input_dob);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.input_phone);
            this.Controls.Add(this.input_adress);
            this.Controls.Add(this.input_birthPlace);
            this.Controls.Add(this.input_lastName);
            this.Controls.Add(this.input_firstName);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_id);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.TextBox input_firstName;
        private System.Windows.Forms.TextBox input_lastName;
        private System.Windows.Forms.TextBox input_birthPlace;
        private System.Windows.Forms.TextBox input_adress;
        private System.Windows.Forms.TextBox input_phone;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.DateTimePicker input_dob;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_birthPlace;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.RadioButton input_male;
        private System.Windows.Forms.RadioButton input_female;
        private System.Windows.Forms.DataGridView output;
    }
}

