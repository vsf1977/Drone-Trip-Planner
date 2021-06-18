
namespace Drone_trip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_drone_max_weight = new System.Windows.Forms.TextBox();
            this.txt_drone_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_site_pack_weight = new System.Windows.Forms.TextBox();
            this.txt_site_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_new_drone = new System.Windows.Forms.Button();
            this.txt_new_site = new System.Windows.Forms.Button();
            this.lb_site_list = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_drone_list = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_drone_max_weight);
            this.groupBox1.Controls.Add(this.txt_drone_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drone Information";
            // 
            // txt_drone_max_weight
            // 
            this.txt_drone_max_weight.Location = new System.Drawing.Point(295, 92);
            this.txt_drone_max_weight.Name = "txt_drone_max_weight";
            this.txt_drone_max_weight.Size = new System.Drawing.Size(150, 31);
            this.txt_drone_max_weight.TabIndex = 7;
            this.txt_drone_max_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_drone_max_weight_KeyPress);
            // 
            // txt_drone_name
            // 
            this.txt_drone_name.Location = new System.Drawing.Point(295, 49);
            this.txt_drone_name.Name = "txt_drone_name";
            this.txt_drone_name.Size = new System.Drawing.Size(150, 31);
            this.txt_drone_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maximum Weight Supported";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_site_pack_weight);
            this.groupBox2.Controls.Add(this.txt_site_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 161);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Site Information";
            // 
            // txt_site_pack_weight
            // 
            this.txt_site_pack_weight.Location = new System.Drawing.Point(295, 92);
            this.txt_site_pack_weight.Name = "txt_site_pack_weight";
            this.txt_site_pack_weight.Size = new System.Drawing.Size(150, 31);
            this.txt_site_pack_weight.TabIndex = 7;
            this.txt_site_pack_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_site_pack_weight_KeyPress);
            // 
            // txt_site_name
            // 
            this.txt_site_name.Location = new System.Drawing.Point(295, 49);
            this.txt_site_name.Name = "txt_site_name";
            this.txt_site_name.Size = new System.Drawing.Size(150, 31);
            this.txt_site_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Package Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // btn_new_drone
            // 
            this.btn_new_drone.Location = new System.Drawing.Point(12, 202);
            this.btn_new_drone.Name = "btn_new_drone";
            this.btn_new_drone.Size = new System.Drawing.Size(166, 34);
            this.btn_new_drone.TabIndex = 9;
            this.btn_new_drone.Text = "Enter new drone";
            this.btn_new_drone.UseVisualStyleBackColor = true;
            this.btn_new_drone.Click += new System.EventHandler(this.btn_new_drone_Click);
            // 
            // txt_new_site
            // 
            this.txt_new_site.Location = new System.Drawing.Point(174, 501);
            this.txt_new_site.Name = "txt_new_site";
            this.txt_new_site.Size = new System.Drawing.Size(166, 34);
            this.txt_new_site.TabIndex = 10;
            this.txt_new_site.Text = "Enter new site";
            this.txt_new_site.UseVisualStyleBackColor = true;
            this.txt_new_site.Click += new System.EventHandler(this.txt_new_site_Click);
            // 
            // lb_site_list
            // 
            this.lb_site_list.FormattingEnabled = true;
            this.lb_site_list.ItemHeight = 25;
            this.lb_site_list.Location = new System.Drawing.Point(74, 616);
            this.lb_site_list.Name = "lb_site_list";
            this.lb_site_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_site_list.Size = new System.Drawing.Size(368, 304);
            this.lb_site_list.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Site list";
            // 
            // cmb_drone_list
            // 
            this.cmb_drone_list.FormattingEnabled = true;
            this.cmb_drone_list.Location = new System.Drawing.Point(324, 202);
            this.cmb_drone_list.Name = "cmb_drone_list";
            this.cmb_drone_list.Size = new System.Drawing.Size(182, 33);
            this.cmb_drone_list.TabIndex = 14;
            this.cmb_drone_list.SelectedIndexChanged += new System.EventHandler(this.cmb_drone_list_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 953);
            this.Controls.Add(this.cmb_drone_list);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_site_list);
            this.Controls.Add(this.txt_new_site);
            this.Controls.Add(this.btn_new_drone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Drone Delivery Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_drone_max_weight;
        private System.Windows.Forms.TextBox txt_drone_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_site_pack_weight;
        private System.Windows.Forms.TextBox txt_site_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_new_drone;
        private System.Windows.Forms.Button txt_new_site;
        private System.Windows.Forms.ListBox lb_site_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_drone_list;
    }
}

