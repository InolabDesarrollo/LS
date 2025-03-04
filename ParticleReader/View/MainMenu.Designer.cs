namespace ParticleReader
{
    partial class MainMenu
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
            Main_Menu_Control = new TabControl();
            Page_Data = new TabPage();
            Btn_Go_Mesh_Selection = new Button();
            Btn_Load_Data = new Button();
            Pnl_Load_Data = new Panel();
            Page_Mesh_Selection = new TabPage();
            Btn_Return_To_Data_Page = new Button();
            Btn_Go_To_Accumulated_Differential = new Button();
            Pnl_Mesh_Selection = new Panel();
            Page_Accumulated_Differentials = new TabPage();
            Btn_Return_To_Mesh_Selection = new Button();
            Pnl_Accumulated_Differential = new Panel();
            Main_Menu_Control.SuspendLayout();
            Page_Data.SuspendLayout();
            Page_Mesh_Selection.SuspendLayout();
            Page_Accumulated_Differentials.SuspendLayout();
            SuspendLayout();
            // 
            // Main_Menu_Control
            // 
            Main_Menu_Control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Main_Menu_Control.Controls.Add(Page_Data);
            Main_Menu_Control.Controls.Add(Page_Mesh_Selection);
            Main_Menu_Control.Controls.Add(Page_Accumulated_Differentials);
            Main_Menu_Control.Location = new Point(14, 92);
            Main_Menu_Control.Margin = new Padding(3, 4, 3, 4);
            Main_Menu_Control.Name = "Main_Menu_Control";
            Main_Menu_Control.SelectedIndex = 0;
            Main_Menu_Control.Size = new Size(1065, 761);
            Main_Menu_Control.TabIndex = 0;
            Main_Menu_Control.Selecting += Main_Menu_Control_Selecting;
            // 
            // Page_Data
            // 
            Page_Data.Controls.Add(Btn_Go_Mesh_Selection);
            Page_Data.Controls.Add(Btn_Load_Data);
            Page_Data.Controls.Add(Pnl_Load_Data);
            Page_Data.Location = new Point(4, 29);
            Page_Data.Margin = new Padding(3, 4, 3, 4);
            Page_Data.Name = "Page_Data";
            Page_Data.Padding = new Padding(3, 4, 3, 4);
            Page_Data.Size = new Size(1057, 728);
            Page_Data.TabIndex = 0;
            Page_Data.Text = "Datos Cargados";
            Page_Data.UseVisualStyleBackColor = true;
            // 
            // Btn_Go_Mesh_Selection
            // 
            Btn_Go_Mesh_Selection.BackColor = Color.FromArgb(0, 112, 192);
            Btn_Go_Mesh_Selection.FlatStyle = FlatStyle.Flat;
            Btn_Go_Mesh_Selection.ForeColor = Color.White;
            Btn_Go_Mesh_Selection.Location = new Point(149, 668);
            Btn_Go_Mesh_Selection.Margin = new Padding(3, 4, 3, 4);
            Btn_Go_Mesh_Selection.Name = "Btn_Go_Mesh_Selection";
            Btn_Go_Mesh_Selection.Size = new Size(171, 52);
            Btn_Go_Mesh_Selection.TabIndex = 2;
            Btn_Go_Mesh_Selection.Text = "Ir a seleccion de mayas";
            Btn_Go_Mesh_Selection.UseVisualStyleBackColor = false;
            Btn_Go_Mesh_Selection.Click += Btn_Go_Mesh_Selection_Click;
            // 
            // Btn_Load_Data
            // 
            Btn_Load_Data.BackColor = Color.FromArgb(0, 112, 192);
            Btn_Load_Data.FlatStyle = FlatStyle.Flat;
            Btn_Load_Data.ForeColor = Color.White;
            Btn_Load_Data.Location = new Point(17, 668);
            Btn_Load_Data.Margin = new Padding(3, 4, 3, 4);
            Btn_Load_Data.Name = "Btn_Load_Data";
            Btn_Load_Data.Size = new Size(110, 48);
            Btn_Load_Data.TabIndex = 1;
            Btn_Load_Data.Text = "Cargar Datos";
            Btn_Load_Data.UseVisualStyleBackColor = false;
            Btn_Load_Data.Click += Btn_Load_Data_Click;
            // 
            // Pnl_Load_Data
            // 
            Pnl_Load_Data.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pnl_Load_Data.Location = new Point(3, 0);
            Pnl_Load_Data.Margin = new Padding(3, 4, 3, 4);
            Pnl_Load_Data.Name = "Pnl_Load_Data";
            Pnl_Load_Data.Size = new Size(1049, 660);
            Pnl_Load_Data.TabIndex = 0;
            Pnl_Load_Data.Resize += Pnl_Load_Data_Resize;
            // 
            // Page_Mesh_Selection
            // 
            Page_Mesh_Selection.Controls.Add(Btn_Return_To_Data_Page);
            Page_Mesh_Selection.Controls.Add(Btn_Go_To_Accumulated_Differential);
            Page_Mesh_Selection.Controls.Add(Pnl_Mesh_Selection);
            Page_Mesh_Selection.Location = new Point(4, 29);
            Page_Mesh_Selection.Margin = new Padding(3, 4, 3, 4);
            Page_Mesh_Selection.Name = "Page_Mesh_Selection";
            Page_Mesh_Selection.Padding = new Padding(3, 4, 3, 4);
            Page_Mesh_Selection.Size = new Size(1057, 728);
            Page_Mesh_Selection.TabIndex = 1;
            Page_Mesh_Selection.Text = "Seleccion de mallas";
            Page_Mesh_Selection.UseVisualStyleBackColor = true;
            // 
            // Btn_Return_To_Data_Page
            // 
            Btn_Return_To_Data_Page.BackColor = Color.FromArgb(0, 112, 192);
            Btn_Return_To_Data_Page.FlatStyle = FlatStyle.Flat;
            Btn_Return_To_Data_Page.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Return_To_Data_Page.ForeColor = SystemColors.Control;
            Btn_Return_To_Data_Page.Location = new Point(618, 671);
            Btn_Return_To_Data_Page.Margin = new Padding(3, 4, 3, 4);
            Btn_Return_To_Data_Page.Name = "Btn_Return_To_Data_Page";
            Btn_Return_To_Data_Page.Size = new Size(160, 45);
            Btn_Return_To_Data_Page.TabIndex = 3;
            Btn_Return_To_Data_Page.Text = "Return to data";
            Btn_Return_To_Data_Page.UseVisualStyleBackColor = false;
            Btn_Return_To_Data_Page.Click += Btn_Return_To_Data_Page_Click;
            // 
            // Btn_Go_To_Accumulated_Differential
            // 
            Btn_Go_To_Accumulated_Differential.BackColor = Color.FromArgb(0, 112, 192);
            Btn_Go_To_Accumulated_Differential.FlatStyle = FlatStyle.Flat;
            Btn_Go_To_Accumulated_Differential.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Go_To_Accumulated_Differential.ForeColor = SystemColors.Control;
            Btn_Go_To_Accumulated_Differential.Location = new Point(785, 671);
            Btn_Go_To_Accumulated_Differential.Margin = new Padding(3, 4, 3, 4);
            Btn_Go_To_Accumulated_Differential.Name = "Btn_Go_To_Accumulated_Differential";
            Btn_Go_To_Accumulated_Differential.Size = new Size(264, 45);
            Btn_Go_To_Accumulated_Differential.TabIndex = 2;
            Btn_Go_To_Accumulated_Differential.Text = "Go to Accumulated and Differentials";
            Btn_Go_To_Accumulated_Differential.UseVisualStyleBackColor = false;
            Btn_Go_To_Accumulated_Differential.Click += Btn_Go_To_Accumulated_Differential_Click;
            // 
            // Pnl_Mesh_Selection
            // 
            Pnl_Mesh_Selection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pnl_Mesh_Selection.Location = new Point(0, 4);
            Pnl_Mesh_Selection.Margin = new Padding(3, 4, 3, 4);
            Pnl_Mesh_Selection.Name = "Pnl_Mesh_Selection";
            Pnl_Mesh_Selection.Size = new Size(1053, 663);
            Pnl_Mesh_Selection.TabIndex = 0;
            Pnl_Mesh_Selection.Resize += Pnl_Mesh_Selection_Resize;
            // 
            // Page_Accumulated_Differentials
            // 
            Page_Accumulated_Differentials.Controls.Add(Btn_Return_To_Mesh_Selection);
            Page_Accumulated_Differentials.Controls.Add(Pnl_Accumulated_Differential);
            Page_Accumulated_Differentials.Location = new Point(4, 29);
            Page_Accumulated_Differentials.Margin = new Padding(3, 4, 3, 4);
            Page_Accumulated_Differentials.Name = "Page_Accumulated_Differentials";
            Page_Accumulated_Differentials.Padding = new Padding(3, 4, 3, 4);
            Page_Accumulated_Differentials.Size = new Size(1057, 728);
            Page_Accumulated_Differentials.TabIndex = 2;
            Page_Accumulated_Differentials.Text = "Acumulativos y Diferenciales";
            Page_Accumulated_Differentials.UseVisualStyleBackColor = true;
            // 
            // Btn_Return_To_Mesh_Selection
            // 
            Btn_Return_To_Mesh_Selection.BackColor = Color.FromArgb(0, 112, 192);
            Btn_Return_To_Mesh_Selection.FlatStyle = FlatStyle.Flat;
            Btn_Return_To_Mesh_Selection.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Return_To_Mesh_Selection.ForeColor = SystemColors.Control;
            Btn_Return_To_Mesh_Selection.Location = new Point(858, 671);
            Btn_Return_To_Mesh_Selection.Margin = new Padding(3, 4, 3, 4);
            Btn_Return_To_Mesh_Selection.Name = "Btn_Return_To_Mesh_Selection";
            Btn_Return_To_Mesh_Selection.Size = new Size(191, 45);
            Btn_Return_To_Mesh_Selection.TabIndex = 1;
            Btn_Return_To_Mesh_Selection.Text = "Return_To_Mesh_Selection";
            Btn_Return_To_Mesh_Selection.UseVisualStyleBackColor = false;
            Btn_Return_To_Mesh_Selection.Click += Btn_Return_To_Mesh_Selection_Click;
            // 
            // Pnl_Accumulated_Differential
            // 
            Pnl_Accumulated_Differential.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pnl_Accumulated_Differential.BackColor = Color.Transparent;
            Pnl_Accumulated_Differential.Location = new Point(0, 0);
            Pnl_Accumulated_Differential.Margin = new Padding(3, 4, 3, 4);
            Pnl_Accumulated_Differential.Name = "Pnl_Accumulated_Differential";
            Pnl_Accumulated_Differential.Size = new Size(1053, 663);
            Pnl_Accumulated_Differential.TabIndex = 0;
            Pnl_Accumulated_Differential.Resize += Pnl_Accumulated_Differential_Resize;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 869);
            Controls.Add(Main_Menu_Control);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "Menu Principal";
            Main_Menu_Control.ResumeLayout(false);
            Page_Data.ResumeLayout(false);
            Page_Mesh_Selection.ResumeLayout(false);
            Page_Accumulated_Differentials.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl Main_Menu_Control;
        private TabPage Page_Data;
        private Panel Pnl_Load_Data;
        private TabPage Page_Mesh_Selection;
        private Button Btn_Load_Data;
        private Button Btn_Go_Mesh_Selection;
        private Panel Pnl_Mesh_Selection;
        private TabPage Page_Accumulated_Differentials;
        private Panel Pnl_Accumulated_Differential;
        private Button Btn_Return_To_Mesh_Selection;
        private Button Btn_Go_To_Accumulated_Differential;
        private Button Btn_Return_To_Data_Page;
    }
}