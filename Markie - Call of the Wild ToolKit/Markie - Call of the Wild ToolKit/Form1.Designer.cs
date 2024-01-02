namespace Markie___Call_of_the_Wild_ToolKit
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
            discord = new Label();
            Featues1 = new GroupBox();
            xptext = new TextBox();
            InfXp = new CheckBox();
            InfPerk = new CheckBox();
            InfSkill = new CheckBox();
            InfMoney = new CheckBox();
            Featues2 = new GroupBox();
            label1 = new Label();
            Featues1.SuspendLayout();
            Featues2.SuspendLayout();
            SuspendLayout();
            // 
            // discord
            // 
            discord.AutoSize = true;
            discord.Location = new Point(34, 98);
            discord.Name = "discord";
            discord.Size = new Size(138, 15);
            discord.TabIndex = 0;
            discord.Text = "Discord: markiewastaken";
            // 
            // Featues1
            // 
            Featues1.Controls.Add(xptext);
            Featues1.Controls.Add(InfXp);
            Featues1.Controls.Add(InfPerk);
            Featues1.Controls.Add(InfSkill);
            Featues1.Controls.Add(InfMoney);
            Featues1.Location = new Point(12, 12);
            Featues1.Name = "Featues1";
            Featues1.Size = new Size(200, 160);
            Featues1.TabIndex = 2;
            Featues1.TabStop = false;
            Featues1.Text = "Main Featues";
            // 
            // xptext
            // 
            xptext.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xptext.Location = new Point(55, 117);
            xptext.Name = "xptext";
            xptext.Size = new Size(107, 19);
            xptext.TabIndex = 4;
            // 
            // InfXp
            // 
            InfXp.AutoSize = true;
            InfXp.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfXp.Location = new Point(6, 115);
            InfXp.Name = "InfXp";
            InfXp.Size = new Size(43, 22);
            InfXp.TabIndex = 3;
            InfXp.Text = "XP";
            InfXp.UseVisualStyleBackColor = true;
            // 
            // InfPerk
            // 
            InfPerk.AutoSize = true;
            InfPerk.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfPerk.Location = new Point(6, 87);
            InfPerk.Name = "InfPerk";
            InfPerk.Size = new Size(82, 22);
            InfPerk.TabIndex = 2;
            InfPerk.Text = "INF PERK";
            InfPerk.UseVisualStyleBackColor = true;
            // 
            // InfSkill
            // 
            InfSkill.AutoSize = true;
            InfSkill.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfSkill.Location = new Point(6, 59);
            InfSkill.Name = "InfSkill";
            InfSkill.Size = new Size(82, 22);
            InfSkill.TabIndex = 1;
            InfSkill.Text = "INF SKILL";
            InfSkill.UseVisualStyleBackColor = true;
            // 
            // InfMoney
            // 
            InfMoney.AutoSize = true;
            InfMoney.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfMoney.Location = new Point(6, 31);
            InfMoney.Name = "InfMoney";
            InfMoney.Size = new Size(97, 22);
            InfMoney.TabIndex = 0;
            InfMoney.Text = "INF MONEY";
            InfMoney.UseVisualStyleBackColor = true;
            // 
            // Featues2
            // 
            Featues2.Controls.Add(label1);
            Featues2.Controls.Add(discord);
            Featues2.Location = new Point(218, 12);
            Featues2.Name = "Featues2";
            Featues2.Size = new Size(200, 160);
            Featues2.TabIndex = 3;
            Featues2.TabStop = false;
            Featues2.Text = "Misc Meatues";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 75);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Give me some ideas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 191);
            Controls.Add(Featues2);
            Controls.Add(Featues1);
            Name = "Form1";
            Text = "Makie - Call of the Wild ToolKit";
            Load += Form1_Load;
            Featues1.ResumeLayout(false);
            Featues1.PerformLayout();
            Featues2.ResumeLayout(false);
            Featues2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label discord;
        private GroupBox Featues1;
        private GroupBox Featues2;
        private Label label1;
        private CheckBox InfXp;
        private CheckBox InfPerk;
        private CheckBox InfSkill;
        private CheckBox InfMoney;
        private TextBox xptext;
    }
}
