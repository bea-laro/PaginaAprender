using System;
using System.Drawing;
using System.Windows.Forms;


namespace TelaInicial
{
    partial class TelaInicial
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.ContainerInicial = new System.Windows.Forms.TableLayoutPanel();
            this.ContainerCentro = new System.Windows.Forms.TableLayoutPanel();
            this.ContainerBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTaPronto = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelDesafio = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPlaca = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContainerMensagem = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ContainerMascote = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ContainerTexto = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSobre = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            this.ContainerInicial.SuspendLayout();
            this.ContainerCentro.SuspendLayout();
            this.ContainerBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTaPronto.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelDesafio.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelPlaca.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ContainerMensagem.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.ContainerMascote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.ContainerTexto.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Name = "label2";
            // 
            // ContainerInicial
            // 
            resources.ApplyResources(this.ContainerInicial, "ContainerInicial");
            this.ContainerInicial.Controls.Add(this.ContainerCentro, 0, 1);
            this.ContainerInicial.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.ContainerInicial.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.ContainerInicial.Name = "ContainerInicial";
            // 
            // ContainerCentro
            // 
            resources.ApplyResources(this.ContainerCentro, "ContainerCentro");
            this.ContainerCentro.Controls.Add(this.ContainerBotoes, 1, 0);
            this.ContainerCentro.Controls.Add(this.ContainerMensagem, 0, 0);
            this.ContainerCentro.Name = "ContainerCentro";
            // 
            // ContainerBotoes
            // 
            resources.ApplyResources(this.ContainerBotoes, "ContainerBotoes");
            this.ContainerBotoes.Controls.Add(this.panel1, 0, 0);
            this.ContainerBotoes.Controls.Add(this.panelTaPronto, 1, 1);
            this.ContainerBotoes.Controls.Add(this.panelDesafio, 0, 1);
            this.ContainerBotoes.Controls.Add(this.panelPlaca, 1, 0);
            this.ContainerBotoes.Name = "ContainerBotoes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(84)))), ((int)(((byte)(147)))));
            this.label5.Name = "label5";
            // 
            // panelTaPronto
            // 
            this.panelTaPronto.BackColor = System.Drawing.Color.White;
            this.panelTaPronto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTaPronto.Controls.Add(this.tableLayoutPanel5);
            this.panelTaPronto.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panelTaPronto, "panelTaPronto");
            this.panelTaPronto.Name = "panelTaPronto";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(84)))), ((int)(((byte)(147)))));
            this.label8.Name = "label8";
            // 
            // panelDesafio
            // 
            this.panelDesafio.BackColor = System.Drawing.Color.White;
            this.panelDesafio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesafio.Controls.Add(this.tableLayoutPanel4);
            this.panelDesafio.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panelDesafio, "panelDesafio");
            this.panelDesafio.Name = "panelDesafio";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(84)))), ((int)(((byte)(147)))));
            this.label6.Name = "label6";
            // 
            // panelPlaca
            // 
            this.panelPlaca.BackColor = System.Drawing.Color.White;
            this.panelPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlaca.Controls.Add(this.tableLayoutPanel6);
            this.panelPlaca.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panelPlaca, "panelPlaca");
            this.panelPlaca.Name = "panelPlaca";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(84)))), ((int)(((byte)(147)))));
            this.label4.Name = "label4";
            // 
            // ContainerMensagem
            // 
            resources.ApplyResources(this.ContainerMensagem, "ContainerMensagem");
            this.ContainerMensagem.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.ContainerMensagem.Controls.Add(this.ContainerMascote, 0, 0);
            this.ContainerMensagem.Name = "ContainerMensagem";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(84)))), ((int)(((byte)(147)))));
            this.label7.Name = "label7";
            // 
            // ContainerMascote
            // 
            resources.ApplyResources(this.ContainerMascote, "ContainerMascote");
            this.ContainerMascote.Controls.Add(this.pictureBox5, 0, 0);
            this.ContainerMascote.Controls.Add(this.ContainerTexto, 1, 0);
            this.ContainerMascote.Name = "ContainerMascote";
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // ContainerTexto
            // 
            resources.ApplyResources(this.ContainerTexto, "ContainerTexto");
            this.ContainerTexto.Controls.Add(this.panel5, 0, 1);
            this.ContainerTexto.Controls.Add(this.panel4, 0, 0);
            this.ContainerTexto.Name = "ContainerTexto";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.panel5.Controls.Add(this.label3);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(label2);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(84)))), ((int)(((byte)(147)))));
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.pictureBox7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.pictureBox6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.buttonSobre, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.buttonSair, 1, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // buttonSobre
            // 
            resources.ApplyResources(this.buttonSobre, "buttonSobre");
            this.buttonSobre.BackColor = System.Drawing.Color.White;
            this.buttonSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.UseVisualStyleBackColor = false;
            // 
            // buttonSair
            // 
            resources.ApplyResources(this.buttonSair, "buttonSair");
            this.buttonSair.BackColor = System.Drawing.Color.Red;
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.pictureBox9, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.pictureBox8, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // pictureBox9
            // 
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // TelaInicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ContainerInicial);
            this.Name = "TelaInicial";
            this.ContainerInicial.ResumeLayout(false);
            this.ContainerCentro.ResumeLayout(false);
            this.ContainerBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTaPronto.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelDesafio.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelPlaca.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ContainerMensagem.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ContainerMascote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ContainerTexto.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel ContainerInicial;
        private TableLayoutPanel ContainerCentro;
        private TableLayoutPanel ContainerBotoes;
        private Panel panelTaPronto;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panelDesafio;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panelPlaca;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel ContainerMensagem;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label7;
        private Label label1;
        private TableLayoutPanel ContainerMascote;
        private PictureBox pictureBox5;
        private TableLayoutPanel ContainerTexto;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private Label label8;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox6;
        private TableLayoutPanel tableLayoutPanel7;
        private Button buttonSobre;
        private Button buttonSair;
        private PictureBox pictureBox7;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
    }
}
