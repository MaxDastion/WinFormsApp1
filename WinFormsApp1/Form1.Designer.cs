namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            MoveTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 25;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 25;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.Size = new Size(684, 661);
            tableLayoutPanel1.TabIndex = 0;
            

            // 
            // MoveTimer
            // 
            MoveTimer.Enabled = true;
            MoveTimer.Interval = 512;
            MoveTimer.Tick += TickMoveSn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 661);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += MoveSnArr_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer MoveTimer;
        private enum _MoveArrow
        {
            None,
            Up,
            Down,
            Right,
            Left
        }
        private _MoveArrow _TempArrow;
        private Point _TempPoin;
    }
}
        enum Status
        {
            HEAD, BODY, APPLE, BORDDER, TAIL
        }
